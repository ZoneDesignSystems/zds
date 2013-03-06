using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ZoneDesignSystems.arCADia.Engine 
{  
  [Serializable()]
  static class AppEngine
  {
    private static SharpMap.Data.FeatureDataSet _featureData;
    private static SharpMap.Layers.VectorLayer _cLayer;
   

    public enum ExportMode
    {
      Pairs = 1,
      Matrix = 2
    }

    public enum ProjectionUnits 
    {
      Geometric = 0,
      Geodetic =1
    }

       public static SharpMap.Data.FeatureDataSet FeatureData {
      get {
        return _featureData;
      }
    }

    public static SharpMap.Layers.VectorLayer ShpLayer {
      get {
        return _cLayer;
      }
    }

    static AppEngine() {

      _featureData = new SharpMap.Data.FeatureDataSet();

    }

    /// <summary>
    /// Create SharpMap Layer
    /// </summary>
    /// <param name="ShapeFilePath"></param>
    /// <param name="ShapeName"></param>
    /// <returns></returns>
    public static SharpMap.Layers.VectorLayer CreateShpLayer(string shapeFilePath, 
                                                             string shapeName)
    {
      _cLayer = new SharpMap.Layers.VectorLayer(shapeName);
      _cLayer.DataSource = new SharpMap.Data.Providers.ShapeFile(shapeFilePath,true);
      _cLayer.Style.Fill = Brushes.LightGoldenrodYellow;
      _cLayer.Style.EnableOutline = true;
      _cLayer.Style.Outline = Pens.DarkBlue;

      return _cLayer;
    }

    /// <summary>
    /// Get FeatureDataSet
    /// </summary>
    /// <param name="ShapeLayer"></param>
    /// <returns></returns>
    public static SharpMap.Data.FeatureDataSet GetFeatureDataSet(SharpMap.Geometries.BoundingBox envelope, 
                                                                 SharpMap.Layers.VectorLayer shapeLayer) 
    {
            
      shapeLayer.DataSource.Open();
      shapeLayer.DataSource.ExecuteIntersectionQuery(envelope, _featureData);

      return _featureData;
    }
  }
}
