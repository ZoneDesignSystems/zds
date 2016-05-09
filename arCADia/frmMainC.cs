using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SharpMap.Data;
using GisSharpBlog.NetTopologySuite;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ZoneDesignSystems.arCADia {
  public partial class frmMainC : Form {
    
    //--> Define the SharpMap object
    SharpMap.Map _sharpMap;

    //--> Set the zoom factor percentage
    const float ZOOM_FACTOR = 0.3f;

    //--> Define the data name and source
    const string DATA_NAME = "Boundaries";

    /// <summary>
    /// frmMain 
    /// </summary>
    public frmMainC() {
      InitializeComponent();

      //--> Initialize the map
      _sharpMap = new SharpMap.Map(new Size(picMap.Width, picMap.Height));
      _sharpMap.BackColor = Color.LightGray;

    }

    /// <summary>
    ///  RefreshMap
    /// </summary>
    private void RefreshMap() {
      //--> Use SharpMap to generate the map image
      picMap.Image = _sharpMap.GetMap();
    }

    /// <summary>
    /// frmMain_SizeChanged
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmMain_SizeChanged(object sender, EventArgs e) {
      _sharpMap.Size = new Size(picMap.Width, picMap.Height);
      RefreshMap();
    }

    /// <summary>
    /// btnLoad_Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnLoad_Click(object sender, EventArgs e) {

      //--> Load Shapefile window
      string Chosen_File = "";

      openFD.InitialDirectory = "C:";
      openFD.Title = "Insert a Shapefile";
      openFD.FileName = "";
      openFD.Filter = "SHP Shapefile|*.shp";

      if (openFD.ShowDialog() == DialogResult.Cancel) {
        MessageBox.Show("Operation Cancelled");
      }
      else {
        lblStatus.Text = "Loading Shapefile ...";
        txtStatusInfoContiguities.AppendText("Loading Shapefile ...");

        Chosen_File = openFD.FileName;
        string fName = openFD.SafeFileName;
        fName = fName.Remove(fName.Length - 4, 4);
        
        //--> Add the countries shapefile to the map
        SharpMap.Layers.VectorLayer NewLayer = Engine.AppEngine.CreateShpLayer(Chosen_File, fName);
        _sharpMap.BackColor = Color.Gray;
        _sharpMap.Layers.Add(NewLayer);

         //--> Zoom the map to the entire extent
        _sharpMap.ZoomToExtents();
        RefreshMap();

        //--> Identify if the coordinates are planar or geodetic
        // TODO: Need of a better and more accurate way to retrive this information
        if ((_sharpMap.Layers[0].Envelope.Min.X > 360) | (_sharpMap.Layers[0].Envelope.Max.Y > 360)) {
          cmbSelectProjection.Text = cmbSelectProjection.Items[0].ToString();
         }
        else {
          cmbSelectProjection.Text = cmbSelectProjection.Items[1].ToString();
 
        }
        
        //--> Enable selection fields
        cmbSelectProjection.Enabled = true;
        chkLBoxContiguities.Enabled = true;
        cmbFieldId.Enabled = true;
        txtFileName.Enabled = true;
        txtFileName.Text = fName;
        btnSave.Enabled = true;


        //--> Load field names in the cmbFieldId and cmbFieldPopulation
        SharpMap.Data.FeatureDataSet featureData = new SharpMap.Data.FeatureDataSet();
        featureData = Engine.AppEngine.GetFeatureDataSet(NewLayer.Envelope,NewLayer);
        cmbFieldId.Items.Clear();
        
        foreach (DataColumn i in featureData.Tables[0].Columns) {
          cmbFieldId.Items.Add(i.ColumnName);
          cmbFieldPopulation.Items.Add(i.ColumnName);
        } // End Foreach

        cmbFieldId.Text = cmbFieldId.Items[0].ToString();
        cmbFieldPopulation.Text = cmbFieldPopulation.Items[0].ToString();
        lblStatus.Text = "Loaded";
        txtStatusInfoContiguities.AppendText(" Loaded.");
        SharpMap.Data.FeatureDataSet test =  Engine.AppEngine.FeatureData;
        
      } // End If_Else

    }

    /// <summary>
    /// frmMain_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmMain_Load(object sender, EventArgs e) {
      chkLBoxContiguities.SetItemChecked(0, true);
      txtBoxInfo.Text = Properties.Resources.ListInfo_1;
    }

    /// <summary>
    /// btnSave_click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSave_Click(object sender, EventArgs e) {
      
      //--> Select Directory for output files
      string Chosen_Dir = "";

      selectFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;

      if (selectFolder.ShowDialog() == DialogResult.Cancel) {
        MessageBox.Show("Operation Cancelled");
      }
      else {
        Chosen_Dir = selectFolder.SelectedPath;
        tabMap.SelectedTab = tabMap.TabPages[1];
        if (chkLBoxContiguities.GetItemChecked(0))
        {
          #region Item 0
          Dictionary<string, string> contPairs = new Dictionary<string, string>();
          ContiguityTools contLibs = new ContiguityTools();
          lblStatus.Text = "Creating Contiguities ...";
          txtStatusInfoContiguities.AppendText("\r\nCreating Contiguities ...");
          contPairs = contLibs.CreateContiguities(Engine.AppEngine.ShpLayer, cmbFieldId.Text, Engine.AppEngine.ExportMode.Pairs);
          txtStatusInfoContiguities.AppendText(" Done.");
          OutputTools expLib0 = new OutputTools();
          lblStatus.Text = "Saving Contiguities to file ...";
          txtStatusInfoContiguities.AppendText("\r\nSaving Contiguities to file ...");
          string exportFile = openFD.SafeFileName;
          exportFile = Chosen_Dir + @"\" + exportFile.Remove(exportFile.Length - 4, 4) + "_pairs.con";
          expLib0.ExportContiguitiesDict2TXT(contPairs, exportFile, Engine.AppEngine.ExportMode.Pairs);
          txtStatusInfoContiguities.AppendText(" Done.");
          txtStatusInfoContiguities.AppendText("\r\n-----");
          lblStatus.Text = "Done!!!";
          #endregion
        }
        if (chkLBoxContiguities.GetItemChecked(3)) {
          if (cmbSelectProjection.SelectedIndex == 0) {
            #region Item 4 - Planar
            Dictionary<string, string> centPairs = new Dictionary<string, string>();
            ContiguityTools centLibs = new ContiguityTools();
            lblStatus.Text = "Creating Centroids ...";
            txtStatusInfoContiguities.AppendText("\r\nCreating Centroids ...");
            centPairs = centLibs.CreateCentroids (Engine.AppEngine.ShpLayer, 
                                                  cmbFieldId.Text);
            txtStatusInfoContiguities.AppendText(" Done.");
            OutputTools expLib3 = new OutputTools();
            lblStatus.Text = "Saving Centroids to file ...";
            txtStatusInfoContiguities.AppendText("\r\nSaving Centroids to file ...");
            string exportFile = openFD.SafeFileName;
            exportFile = Chosen_Dir + @"\" + exportFile.Remove(exportFile.Length - 4, 4) + "_xy.cen";
            expLib3.ExportCentroidsDict2TXT(centPairs, exportFile, Engine.AppEngine.ProjectionUnits.Geometric, false );
            txtStatusInfoContiguities.AppendText(" Done.");
            txtStatusInfoContiguities.AppendText("\r\n-----");
            lblStatus.Text = "Done!!!";
            #endregion
          }
          else {
            #region Item 4 - Geodetic
            Dictionary<string, string> centPairs = new Dictionary<string, string>();
            ContiguityTools centLibs = new ContiguityTools();
            lblStatus.Text = "Creating Centroids ...";
            txtStatusInfoContiguities.AppendText("\r\nCreating Centroids ...");
            centPairs = centLibs.CreateCentroids(Engine.AppEngine.ShpLayer, 
                                                 cmbFieldId.Text);
            txtStatusInfoContiguities.AppendText(" Done.");
            OutputTools expLib3 = new OutputTools();
            lblStatus.Text = "Saving Centroids to file ...";
            txtStatusInfoContiguities.AppendText("\r\nSaving Centroids to file ...");
            string exportFile = openFD.SafeFileName;
            exportFile = Chosen_Dir + @"\" + exportFile.Remove(exportFile.Length - 4, 4) + "_LatLon.cen";
            expLib3.ExportCentroidsDict2TXT(centPairs, exportFile, Engine.AppEngine.ProjectionUnits.Geodetic, false );
            txtStatusInfoContiguities.AppendText(" Done.");
            txtStatusInfoContiguities.AppendText("\r\n-----");
            lblStatus.Text = "Done!!!";
            #endregion
          }
        }
        if (chkLBoxContiguities.GetItemChecked(4)) {
          if (cmbSelectProjection.SelectedIndex == 0) {
            #region Item 5 - Planar
            Dictionary<string, string> centPairs = new Dictionary<string, string>();
            ContiguityTools centLibs = new ContiguityTools();
            lblStatus.Text = "Creating Centroids ...";
            txtStatusInfoContiguities.AppendText("\r\nCreating Centroids ...");
            centPairs = centLibs.CreateCentroidsArea (Engine.AppEngine.ShpLayer, cmbFieldId.Text,Engine.AppEngine.ProjectionUnits.Geometric);
            txtStatusInfoContiguities.AppendText(" Done.");
            OutputTools expLib3 = new OutputTools();
            lblStatus.Text = "Saving Centroids to file ...";
            txtStatusInfoContiguities.AppendText("\r\nSaving Centroids to file ...");
            string exportFile = openFD.SafeFileName;
            exportFile = Chosen_Dir + @"\" + exportFile.Remove(exportFile.Length - 4, 4) + "_xyAreaPer.cen";
            expLib3.ExportCentroidsDict2TXT(centPairs, exportFile, Engine.AppEngine.ProjectionUnits.Geometric, true);
            txtStatusInfoContiguities.AppendText(" Done.");
            txtStatusInfoContiguities.AppendText("\r\n-----");
            lblStatus.Text = "Done!!!";
            #endregion
          }
          else {
            #region Item 5 - Geodetic
            Dictionary<string, string> centPairs = new Dictionary<string, string>();
            ContiguityTools centLibs = new ContiguityTools();
            lblStatus.Text = "Creating Centroids ...";
            txtStatusInfoContiguities.AppendText("\r\nCreating Centroids ...");
            centPairs = centLibs.CreateCentroidsArea (Engine.AppEngine.ShpLayer, cmbFieldId.Text,Engine.AppEngine.ProjectionUnits.Geodetic);
            txtStatusInfoContiguities.AppendText(" Done.");
            OutputTools expLib3 = new OutputTools();
            lblStatus.Text = "Saving Centroids to file ...";
            txtStatusInfoContiguities.AppendText("\r\nSaving Centroids to file ...");
            string exportFile = openFD.SafeFileName;
            exportFile = Chosen_Dir + @"\" + exportFile.Remove(exportFile.Length - 4, 4) + "_LatLonAreaPer.cen";
            expLib3.ExportCentroidsDict2TXT(centPairs, exportFile,Engine.AppEngine.ProjectionUnits.Geodetic, true);
            txtStatusInfoContiguities.AppendText(" Done.");
            txtStatusInfoContiguities.AppendText("\r\n-----");
            lblStatus.Text = "Done!!!";
            #endregion
          }
        }
      } //End If_Else
      tabMap.SelectedTab = tabMap.TabPages[0];

    }

    /// <summary>
    /// chkLBoxContiguities_ItemCheck
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void chkLBoxContiguities_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.Index == 0) {
        txtBoxInfo.Text = Properties.Resources.ListInfo_1;
      }
      if (e.Index == 1) {
		    txtBoxInfo.Text=Properties.Resources.ListInfo_2;
	    }
      if (e.Index == 2)
      {
        txtBoxInfo.Text = Properties.Resources.ListInfo_3;
      }
      if (e.Index == 3) {
        if (cmbSelectProjection.SelectedIndex == 0) 
        {
          txtBoxInfo.Text = Properties.Resources.ListInfo_4;
        }
        else 
        {
          txtBoxInfo.Text = Properties.Resources.ListInfo_4a;
        }
      }
      if (e.Index == 4)
      {
        if (cmbSelectProjection.SelectedIndex == 0)
        {
          txtBoxInfo.Text = Properties.Resources.ListInfo_5;
        }
        else
        {
          txtBoxInfo.Text = Properties.Resources.ListInfo_5a;
        }
      }
      
      if (e.Index == 5) {
        txtBoxInfo.Text = Properties.Resources.ListInfo_6;
      }
      if (e.Index == 6) {
        txtBoxInfo.Text = Properties.Resources.ListInfo_7;
      }
      if (e.Index == 7) 
      {
        txtBoxInfo.Text = Properties.Resources.ListInfo_8;
        if (e.CurrentValue == CheckState.Unchecked) 
        {
          btnLoadFlows.Enabled = true;
        }
        else 
        {
          btnLoadFlows.Enabled = false;
        }
      }

      if (e.Index == 8) 
      {
        txtBoxInfo.Text = Properties.Resources.ListInfo_9;
        if (e.CurrentValue == CheckState.Unchecked) 
        {
          cmbFieldPopulation.Enabled = true;
        }
        else 
        {
          cmbFieldPopulation.Enabled = false;
        }
      }
    }

    /// <summary>
    /// cmbSelectProjection_SelectedIndexChanged
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cmbSelectProjection_SelectedIndexChanged(object sender, EventArgs e) {
      if (cmbSelectProjection.SelectedIndex == 0) {
        chkLBoxContiguities.Items[3] = "Centroids (AreaId, X, Y)";
        chkLBoxContiguities.Items[4] = "Centroids (AreaId, X, Y, Area, Perimeter)";
      }
      else {
        chkLBoxContiguities.Items[3] = "Centroids (AreaId, Lat, Lon)";
        chkLBoxContiguities.Items[4] = "Centroids (AreaId, Lat, Lon, Area, Perimeter)";      
      }
    }



    

    }

  }

