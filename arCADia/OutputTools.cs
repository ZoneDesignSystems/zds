using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZoneDesignSystems.arCADia {
   class OutputTools {
    public OutputTools() {

    }
    /// <summary>
    /// ExportContiguitiesDict2TXT
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="exportFileName"></param>
    /// <param name="enumVal"></param>
    public void ExportContiguitiesDict2TXT(Dictionary<string, string> dictionary,
                                           string exportFileName, 
                                           Engine.AppEngine.ExportMode enumVal ) 
    {
      
      System.IO.TextWriter textWriter = new System.IO.StreamWriter(exportFileName);

      if (enumVal == Engine.AppEngine.ExportMode.Pairs)
      {
        textWriter.WriteLine("AreaId,NeigId");
      } // End if
      
      foreach (var dictItem in dictionary) {
        textWriter.WriteLine(dictItem.Value);
      } //End Foreach

      textWriter.Close();
      textWriter.Dispose();

    }
    
    /// <summary>
    /// ExportCentroidsDict2TXT
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="exportFileName"></param>
    public void ExportCentroidsDict2TXT(Dictionary<string, string> dictionary, 
                                        string exportFileName, 
                                        Engine.AppEngine.ProjectionUnits projUnits,
                                        Boolean includeAreaPerimeter)
    {

      System.IO.TextWriter textWriter = new System.IO.StreamWriter(exportFileName);

      if (projUnits == Engine.AppEngine.ProjectionUnits.Geometric){
        if (includeAreaPerimeter == true)
        {
          textWriter.WriteLine("AreaId,CoordX,CoordY,Area,Perimeter");
        }
        else
        {
          textWriter.WriteLine("AreaId,CoordX,CoordY");
        }
      }
      else {
        if (includeAreaPerimeter == true)
        {
          textWriter.WriteLine("AreaId,Lat,Lon,Area,Perimeter");
        }
        else
        {
          textWriter.WriteLine("AreaId,Lat,Lon");
        }
      } // End if

      foreach (var dictItem in dictionary)
      {
        textWriter.WriteLine(dictItem.Value);
      } //End Foreach

      textWriter.Close();

    }
  }
}
