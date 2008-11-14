using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class OverlayBMP: PFSMapper
  {


    internal OverlayBMP(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public int Touched
    {
      get
      {
        return _pfsHandle.GetKeyword("Touched", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Touched", 1).GetParameter(1).Value = value;
      }
    }

    public int IsDataUsedInSetup
    {
      get
      {
        return _pfsHandle.GetKeyword("IsDataUsedInSetup", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("IsDataUsedInSetup", 1).GetParameter(1).Value = value;
      }
    }

    public string Filename
    {
      get
      {
        return _pfsHandle.GetKeyword("Filename", 1).GetParameter(1).ToString();
      }
      set
      {
        _pfsHandle.GetKeyword("Filename", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_X0
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_X0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_X0", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_X1
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_X1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_X1", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_Y0
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_Y0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_Y0", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_Y1
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_Y1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_Y1", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_TransparentColor
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_TransparentColor", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_TransparentColor", 1).GetParameter(1).Value = value;
      }
    }

    public int BMP_DisplayStyle
    {
      get
      {
        return _pfsHandle.GetKeyword("BMP_DisplayStyle", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("BMP_DisplayStyle", 1).GetParameter(1).Value = value;
      }
    }

    public int Display
    {
      get
      {
        return _pfsHandle.GetKeyword("Display", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Display", 1).GetParameter(1).Value = value;
      }
    }

  }
}