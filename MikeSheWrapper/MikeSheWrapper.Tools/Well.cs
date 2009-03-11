﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikeSheWrapper.Tools
{
  /// <summary>
  /// A small class holding typical data to describe a well
  /// </summary>
  public class Well
  {
    protected string _id;
    protected string _description;
    protected double _x;
    protected double _y;
    protected List<double> _screenTop = new List<double>();
    protected List<double> _screenBottom = new List<double>();
    protected double _terrain;

    #region Constructors
    public Well()
    {
    }

    public Well(string ID)
    {
      _id = ID;
    }

    public Well(string ID, double X, double Y):this(ID)
    {
      _x = X;
      _y = Y;
    }
    #endregion

    public override string ToString()
    {
      return _id;
    }

    #region Properties

    /// <summary>
    /// Gets and sets the x-coodinate
    /// </summary>
    public double X
    {
      get { return _x; }
      set { _x = value; }
    }

    /// <summary>
    /// Gets and sets the y-coodinate
    /// </summary>
    public double Y
    {
      get { return _y; }
      set { _y = value; }
    }

    /// <summary>
    /// Gets and sets the top of the screen in meters above sealevel
    /// </summary>
    public List<double> ScreenTop
    {
      get { return _screenTop; }
      set { _screenTop = value; }
    }

    /// <summary>
    /// Gets and sets the bottom of the screen in meters above mean sea level
    /// </summary>
    public List<double> ScreenBottom
    {
      get { return _screenBottom; }
      set { _screenBottom = value; }
    }

    /// <summary>
    /// Gets and sets the ID of the well
    /// </summary>
    public string ID
    {
      get { return _id; }
      set { _id = value; }
    }

    /// <summary>
    /// Gets and sets a description
    /// </summary>
    public string Description
    {
      get { return _description; }
      set { _description = value; }
    }

    /// <summary>
    /// Gets and sets the terrain in meters above mean sea level
    /// </summary>
    public double Terrain
    {
      get { return _terrain; }
      set { _terrain = value; }
    }

    #endregion
  }
}