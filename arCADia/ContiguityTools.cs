using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpMap;


namespace ZoneDesignSystems.arCADia {
  class ContiguityTools {
    /// <summary>
    /// _dctContPairs
    /// </summary>
    private Dictionary<string,string> _dctContPairs;
    
    /// <summary>
    /// ContiguityTools
    /// </summary>
    public ContiguityTools() {
      _dctContPairs = new Dictionary<string, string>();
    }

    /// <summary>
    /// DegreeToRadian
    /// </summary>
    /// <param name="degreeVal"></param>
    /// <returns></returns>
    public double DegreeToRadian(double degreeVal) {
      return Math.PI * degreeVal / 180.0;
    }

    /// <summary>
    /// Creates Contiguities as Dictionary where the [KEY] and the [VALUE] are the pairs of area Ids.  
    /// </summary>
    /// <param name="featureData"></param>
    /// <returns></returns>
    public Dictionary<string, string> CreateContiguities(SharpMap.Layers.VectorLayer shapeLayer, string fieldIDName, Engine.AppEngine.ExportMode enumVal) {

      SharpMap.Data.FeatureDataSet _fDataSet = new SharpMap.Data.FeatureDataSet();
      SharpMap.Data.FeatureDataTable _fdTable = new SharpMap.Data.FeatureDataTable();
      
      shapeLayer.DataSource.ExecuteIntersectionQuery(shapeLayer.Envelope, _fDataSet);
      _fdTable = _fDataSet.Tables[0];

      if (enumVal == Engine.AppEngine.ExportMode.Pairs)
      {
        #region Create Contiguities as Pairs (AreaId, NeigId)
        for (int i = 0; i < _fdTable.Count; i++)
        {
          SharpMap.Data.FeatureDataRow dRowFROM = _fdTable[i];

          //Select geometries using a given geometry 
          SharpMap.Data.FeatureDataSet _selFDataSet = new SharpMap.Data.FeatureDataSet();
          SharpMap.Data.FeatureDataTable _selFDTable = new SharpMap.Data.FeatureDataTable();

          shapeLayer.DataSource.ExecuteIntersectionQuery(dRowFROM.Geometry.GetBoundingBox(), _selFDataSet);
          _selFDTable = _selFDataSet.Tables[0];

          // Convert SharpMap FROM geometry to NTS geometry
          GisSharpBlog.NetTopologySuite.Geometries.Geometry polyFROM =
            SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowFROM.Geometry,
                       new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
          string fldIdFROM = dRowFROM[fieldIDName].ToString();

          for (int x = 0; x < _selFDTable.Count; x++)
          {
            SharpMap.Data.FeatureDataRow dRowTO = _selFDTable[x];
            // Convert SharpMap TO geometry to NTS geometry
            GisSharpBlog.NetTopologySuite.Geometries.Geometry polyTO =
              SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowTO.Geometry,
                         new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
            string fldIdTO = dRowTO[fieldIDName].ToString();

            // Check checks if there is a touch topology condition between polyFROM and polyTO. 

            Boolean adjCondition = polyFROM.Touches(polyTO);
            // Adds Pair to the dictionary when a "Touches" topology condition is valid
            if (adjCondition == true)
            {
              _dctContPairs.Add((dRowFROM[fieldIDName].ToString() + "_" + dRowTO[fieldIDName].ToString()),
                               (dRowFROM[fieldIDName].ToString() + "," + dRowTO[fieldIDName].ToString()));
            } // End If
          } // End For
          _selFDataSet = null;
          _selFDTable = null;
        } // End For
        #endregion
      }
      else
      {
        //TODO:Write the code !!!
        #region Create Contiguities as Matrix (AreaId, Neig1,...NeigN)
        
        for (int i = 0; i < _fdTable.Count; i++)
        {
          SharpMap.Data.FeatureDataRow dRowFROM = _fdTable[i];

          //Select geometries using a given geometry 
          SharpMap.Data.FeatureDataSet _selFDataSet = new SharpMap.Data.FeatureDataSet();
          SharpMap.Data.FeatureDataTable _selFDTable = new SharpMap.Data.FeatureDataTable();

          shapeLayer.DataSource.ExecuteIntersectionQuery(dRowFROM.Geometry.GetBoundingBox(), _selFDataSet);
          _selFDTable = _selFDataSet.Tables[0];

          // Convert SharpMap FROM geometry to NTS geometry
          GisSharpBlog.NetTopologySuite.Geometries.Geometry polyFROM =
            SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowFROM.Geometry,
                       new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
          string fldIdFROM = dRowFROM[fieldIDName].ToString();

          for (int x = 0; x < _selFDTable.Count; x++)
          {
            SharpMap.Data.FeatureDataRow dRowTO = _selFDTable[x];
            // Convert SharpMap TO geometry to NTS geometry
            GisSharpBlog.NetTopologySuite.Geometries.Geometry polyTO =
              SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowTO.Geometry,
                         new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
            string fldIdTO = dRowTO[fieldIDName].ToString();

            // Check checks if there is a touch topology condition between polyFROM and polyTO. 

            Boolean adjCondition = polyFROM.Touches(polyTO);
            // Adds Pair to the dictionary when a "Touches" topology condition is valid
            if (adjCondition == true)
            {
              _dctContPairs.Add((dRowFROM[fieldIDName].ToString() + "_" + dRowTO[fieldIDName].ToString()),
                               (dRowFROM[fieldIDName].ToString() + "," + dRowTO[fieldIDName].ToString()));
            } // End If
          } // End For
          _selFDataSet = null;
          _selFDTable = null;
        } // End For
        #endregion
      
      } // End if_Else
      
      
      return _dctContPairs; 
    }

    /// <summary>
    /// Create X,Y coordinates
    /// </summary>
    /// <param name="shapeLayer"></param>
    /// <param name="fieldIDName"></param>
    /// <returns></returns>
    public Dictionary<string, string> CreateCentroids(SharpMap.Layers.VectorLayer shapeLayer, 
                                                      string fieldIDName) {
      Dictionary<string,string> _dictCentroids = new Dictionary<string,string>();

      SharpMap.Data.FeatureDataSet _fDataSet = new SharpMap.Data.FeatureDataSet();
      SharpMap.Data.FeatureDataTable _fdTable = new SharpMap.Data.FeatureDataTable();

      shapeLayer.DataSource.ExecuteIntersectionQuery(shapeLayer.Envelope, 
                                                     _fDataSet);
      _fdTable = _fDataSet.Tables[0];

      for (int i = 0; i < _fdTable.Count; i++) {
        SharpMap.Data.FeatureDataRow dRowCent = _fdTable[i];
    
        // Convert SharpMap FROM geometry to NTS geometry
        GisSharpBlog.NetTopologySuite.Geometries.Geometry polyCent =
          SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowCent.Geometry,
                     new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
        string fldIdFROM = dRowCent[fieldIDName].ToString();
        
        string fullStr = fldIdFROM + "," + polyCent.InteriorPoint.X.ToString() + "," + polyCent.InteriorPoint.Y.ToString();

        _dictCentroids.Add(i.ToString(), fullStr);
      }

      return _dictCentroids;
    }

    /// <summary>
    /// CreateCentroidsArea
    /// </summary>
    /// <param name="shapeLayer"></param>
    /// <param name="fieldIDName"></param>
    /// <param name="projUnits"></param>
    /// <returns></returns>
    public Dictionary<string, string> CreateCentroidsArea(SharpMap.Layers.VectorLayer shapeLayer, 
                                                          string fieldIDName, 
                                                          Engine.AppEngine.ProjectionUnits projUnits) {
      
      Dictionary<string, string> _dictCentroids = new Dictionary<string, string>();

      SharpMap.Data.FeatureDataSet _fDataSet = new SharpMap.Data.FeatureDataSet();
      SharpMap.Data.FeatureDataTable _fdTable = new SharpMap.Data.FeatureDataTable();

      shapeLayer.DataSource.ExecuteIntersectionQuery(shapeLayer.Envelope, 
                                                     _fDataSet);
      _fdTable = _fDataSet.Tables[0];

      if (projUnits == Engine.AppEngine.ProjectionUnits.Geometric) {
        for (int i = 0; i < _fdTable.Count; i++) {
          SharpMap.Data.FeatureDataRow dRowCent = _fdTable[i];

          // Convert SharpMap FROM geometry to NTS geometry
          GisSharpBlog.NetTopologySuite.Geometries.Geometry polyCent =
            SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowCent.Geometry,
                       new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
          string fldIdFROM = dRowCent[fieldIDName].ToString();
          double polyArea = Math.Sqrt(polyCent.Area / Math.PI);
          double polyPerimeter = polyCent.Length / (2 * Math.PI);
          string fullStr = fldIdFROM + ","
                         + polyCent.InteriorPoint.X.ToString() + ","
                         + polyCent.InteriorPoint.Y.ToString() + ","
                         + polyArea.ToString() + ","
                         + polyPerimeter.ToString();
          _dictCentroids.Add(i.ToString(), fullStr);
        } // End For
      } 
      else {
        for (int i = 0; i < _fdTable.Count; i++) {
          SharpMap.Data.FeatureDataRow dRowCent = _fdTable[i];
          
          // Convert SharpMap FROM geometry to NTS geometry
          GisSharpBlog.NetTopologySuite.Geometries.Geometry polyCent =
            SharpMap.Converters.NTS.GeometryConverter.ToNTSGeometry(dRowCent.Geometry,
                       new GisSharpBlog.NetTopologySuite.Geometries.GeometryFactory());
          string fldIdFROM = dRowCent[fieldIDName].ToString();
          double polyArea = GeodeticArea(polyCent);
          double polyPerimeter = GeodeticPerimeter(polyCent);
          string fullStr = fldIdFROM + ","
                         + polyCent.InteriorPoint.X.ToString() + ","
                         + polyCent.InteriorPoint.Y.ToString() + ","
                         + polyArea.ToString() + ","
                         + polyPerimeter.ToString();
          _dictCentroids.Add(i.ToString(), fullStr);
        } // End For
      } //End if_Else
      

      return _dictCentroids;
    }

    /// <summary>
    /// Calculate the approximate area of the polygon were it projected onto the earth.  
    /// The spatial reference system is the Geographic/WGS84 for the geometry coordinates.  
    /// </summary>
    /// <param name="geometry"></param>
    /// <returns>The approximate signed geodesic area of the polygon in square kilometers.</returns>
    public double GeodeticArea(GisSharpBlog.NetTopologySuite.Geometries.Geometry geometry) {
      double _geodeticArea = 0;
      double _delArea = 0;
      double _finGeodeticArea =0;

      // Calculate geodetic area for simple polygons with/without holes
      if (geometry.GetType().Name == "Polygon") {
        GisSharpBlog.NetTopologySuite.Geometries.Polygon _chkPoly = (GisSharpBlog.NetTopologySuite.Geometries.Polygon)geometry;
        if (_chkPoly.Holes.Length == 0) { // Simple Polygon
          for (int i = 0; i < _chkPoly.Shell.Coordinates.Length - 1; i++) {
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkPoly.Shell.Coordinates[i];
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkPoly.Shell.Coordinates[i + 1];
            _geodeticArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
          }
          _geodeticArea = _geodeticArea * 6378.137 * 6378.137 / 2;
        }
        else { // Polygon with holes
          for (int i = 0; i < _chkPoly.Shell.Coordinates.Length - 1; i++) {
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkPoly.Shell.Coordinates[i];
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkPoly.Shell.Coordinates[i + 1];
            _geodeticArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
          }
          foreach (var interRing in _chkPoly.Holes) {
            for (int i = interRing.Coordinates.Length - 2; i >= 0; i--) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = interRing.Coordinates[i + 1];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = interRing.Coordinates[i];
              _delArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
            }
          }
          _geodeticArea = _geodeticArea * 6378.137 * 6378.137 / 2;
          _delArea = _delArea * 6378.137 * 6378.137 / 2;
          _geodeticArea -= _delArea;

        } // End if_Else
      } // End if

        _finGeodeticArea = _geodeticArea;

        // Calculate geodetic area for multipolygons with/without holes
      if (geometry.GetType().Name == "MultiPolygon") {
        GisSharpBlog.NetTopologySuite.Geometries.MultiPolygon _chkMGeoms = (GisSharpBlog.NetTopologySuite.Geometries.MultiPolygon)geometry;
        foreach (var geometryM in _chkMGeoms.Geometries) {
          _geodeticArea = 0;
          _delArea = 0;
          GisSharpBlog.NetTopologySuite.Geometries.Polygon _chkMPoly = (GisSharpBlog.NetTopologySuite.Geometries.Polygon)geometryM;
          if (_chkMPoly.Holes.Length == 0) { // Simple Polygon
            for (int i = 0; i < _chkMPoly.Shell.Coordinates.Length - 1; i++) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkMPoly.Shell.Coordinates[i];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkMPoly.Shell.Coordinates[i + 1];
              _geodeticArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
            }
            _geodeticArea = _geodeticArea * 6378.137 * 6378.137 / 2;
          }
          else { // MultiPolygon with holes
            for (int i = 0; i < _chkMPoly.Shell.Coordinates.Length - 1; i++) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkMPoly.Shell.Coordinates[i ];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkMPoly.Shell.Coordinates[i + 1];
              _geodeticArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
            }
            foreach (var interRing in _chkMPoly.Holes) {
              for (int i = interRing.Coordinates.Length - 2; i >= 0; i--) {
                GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = interRing.Coordinates[i + 1];
                GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = interRing.Coordinates[i ];
                _delArea += DegreeToRadian(p2.X - p1.X) * (2 + Math.Sin(DegreeToRadian(p1.Y)) + Math.Sin(DegreeToRadian(p2.Y)));
              }
            }
            _geodeticArea = _geodeticArea * 6378.137 * 6378.137 / 2;
            _delArea = _delArea * 6378.137 * 6378.137 / 2;
            _geodeticArea -= _delArea;

          } // End if_Else
          _finGeodeticArea += _geodeticArea;
        } // End Foreach
      } // End if

      return _finGeodeticArea;
    }

    /// <summary>
    /// Calculate the perimeter of the polygon were it projected onto the earth using the Haversine formula.  
    /// The spatial reference system is the Geographic/WGS84 for the geometry coordinates.  
    /// </summary>
    /// <param name="geometry"></param>
    /// <returns>The geodetic perimeter of the polygon in kilometers.</returns>
    public double GeodeticPerimeter(GisSharpBlog.NetTopologySuite.Geometries.Geometry geometry) {
      double _geodeticPerimeter = 0;
      double _delPerimeter = 0;
      double _finGeodeticPerimeter = 0;

      // Calculate geodetic Perimeter for simple polygons with/without holes
      if (geometry.GetType().Name == "Polygon") {
        GisSharpBlog.NetTopologySuite.Geometries.Polygon _chkPoly = (GisSharpBlog.NetTopologySuite.Geometries.Polygon)geometry;
        if (_chkPoly.Holes.Length == 0) { // Simple Polygon
          for (int i = 0; i < _chkPoly.Shell.Coordinates.Length - 1; i++) {
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkPoly.Shell.Coordinates[i];
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkPoly.Shell.Coordinates[i + 1];
            _geodeticPerimeter += HaversineDistance(p1,p2);
          }
         }
        else { // Polygon with holes
          for (int i = 0; i < _chkPoly.Shell.Coordinates.Length - 1; i++) {
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkPoly.Shell.Coordinates[i];
            GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkPoly.Shell.Coordinates[i + 1];
            _geodeticPerimeter += HaversineDistance(p1, p2);
          }
          foreach (var interRing in _chkPoly.Holes) {
            for (int i = interRing.Coordinates.Length - 2; i >= 0; i--) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = interRing.Coordinates[i + 1];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = interRing.Coordinates[i];
              _delPerimeter += HaversineDistance(p1, p2);
            }
          }
          _geodeticPerimeter += _delPerimeter;

        } // End if_Else
      } // End if

      _finGeodeticPerimeter = _geodeticPerimeter;

      // Calculate geodetic Perimeter for multipolygons with/without holes
      if (geometry.GetType().Name == "MultiPolygon") {
        GisSharpBlog.NetTopologySuite.Geometries.MultiPolygon _chkMGeoms = (GisSharpBlog.NetTopologySuite.Geometries.MultiPolygon)geometry;
        foreach (var geometryM in _chkMGeoms.Geometries) {
          _geodeticPerimeter = 0;
          _delPerimeter = 0;
          GisSharpBlog.NetTopologySuite.Geometries.Polygon _chkMPoly = (GisSharpBlog.NetTopologySuite.Geometries.Polygon)geometryM;
          if (_chkMPoly.Holes.Length == 0) { // Simple Polygon
            for (int i = 0; i < _chkMPoly.Shell.Coordinates.Length - 1; i++) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkMPoly.Shell.Coordinates[i];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkMPoly.Shell.Coordinates[i + 1];
              _geodeticPerimeter += HaversineDistance(p1, p2);
            }
          }
          else { // MultiPolygon with holes
            for (int i = 0; i < _chkMPoly.Shell.Coordinates.Length - 1; i++) {
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = _chkMPoly.Shell.Coordinates[i];
              GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = _chkMPoly.Shell.Coordinates[i + 1];
              _geodeticPerimeter += HaversineDistance(p1, p2);
            }
            foreach (var interRing in _chkMPoly.Holes) {
              for (int i = interRing.Coordinates.Length - 2; i >= 0; i--) {
                GisSharpBlog.NetTopologySuite.Geometries.Coordinate p1 = interRing.Coordinates[i + 1];
                GisSharpBlog.NetTopologySuite.Geometries.Coordinate p2 = interRing.Coordinates[i];
                _delPerimeter += HaversineDistance(p1, p2);
              }
            }
            _geodeticPerimeter += _delPerimeter;

          } // End if_Else
          _finGeodeticPerimeter += _geodeticPerimeter;
        } // End Foreach
      } // End if

      return _finGeodeticPerimeter;
    }

    /// <summary>
    /// Calculates the great-circle distance between two geodetic points using the Haversine formula. 
    /// </summary>
    /// <param name="fromPoint"></param>
    /// <param name="toPoint"></param>
    /// <returns>The distance between the two points in Kilometers.</returns>
    public double HaversineDistance(GisSharpBlog.NetTopologySuite.Geometries.Coordinate fromPoint, GisSharpBlog.NetTopologySuite.Geometries.Coordinate toPoint) {

      double rEarth = 6378.137;
      
      double fromLat = DegreeToRadian(fromPoint.X);
      double fromLon = DegreeToRadian(fromPoint.Y);
      double toLat = DegreeToRadian(toPoint.X);
      double toLon = DegreeToRadian(toPoint.Y);

      double dLat = toLat - fromLat;
      double dLon = toLon - fromLon;

      double a = (Math.Sin(dLat/2) * Math.Sin(dLat/2)) + 
                 ((Math.Sin(dLon/2) * Math.Sin(dLon/2)) * Math.Cos(fromLat) * Math.Cos(toLat));
      double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

      double _distance = rEarth * c;

      return _distance;
    }

    /// <summary>
    /// Clean
    /// </summary>
    public void Clean() {
      _dctContPairs = null;
      _dctContPairs = new Dictionary<string, string>();
    }

  }
}
