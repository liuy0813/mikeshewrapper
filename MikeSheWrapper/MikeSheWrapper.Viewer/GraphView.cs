﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MikeSheWrapper.Tools;


namespace MikeSheWrapper.Viewer
{
  public partial class GraphView : UserControl
  {
    private Dictionary<string,List<ObservationEntry>> _entries; 

    public GraphView()
    {
      InitializeComponent();
      _entries = new Dictionary<string, List<ObservationEntry>>();
    }

    public void AddTimeSeries(string name, List<ObservationEntry> entries)
    {
      _entries.Add(name, entries);

      Series n = new Series(name);
      n.Name = name;
      n.Points.DataBindXY(entries, "Time", entries, "Value");
      n.ChartType = SeriesChartType.FastPoint;
      this.chart1.Series.Add(n);
      this.dataGridView1.DataSource = entries;
     
    }

    public void ClearView()
    {
      chart1.Series.Clear();
      _entries.Clear();

    }
    
    public void Refresh()
    {
      foreach (KeyValuePair<string, List<ObservationEntry>> KVP in _entries)
      {
        chart1.Series[KVP.Key].Points.DataBindXY(KVP.Value, "Time", KVP.Value, "Value");
        chart1.Invalidate();
      }
    }

  }
}
