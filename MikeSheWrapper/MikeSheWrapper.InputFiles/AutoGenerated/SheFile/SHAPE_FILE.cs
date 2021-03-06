using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class SHAPE_FILE: PFSMapper
  {


    internal SHAPE_FILE(PFSSection Section)
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

    public string FILE_NAME
    {
      get
      {
        return _pfsHandle.GetKeyword("FILE_NAME", 1).GetParameter(1).ToString();
      }
      set
      {
        _pfsHandle.GetKeyword("FILE_NAME", 1).GetParameter(1).Value = value;
      }
    }

    public int ITEM_COUNT
    {
      get
      {
        return _pfsHandle.GetKeyword("ITEM_COUNT", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("ITEM_COUNT", 1).GetParameter(1).Value = value;
      }
    }

    public string ITEM_NUMBERS
    {
      get
      {
        return _pfsHandle.GetKeyword("ITEM_NUMBERS", 1).GetParameter(1).ToString();
      }
      set
      {
        _pfsHandle.GetKeyword("ITEM_NUMBERS", 1).GetParameter(1).Value = value;
      }
    }

  }
}
