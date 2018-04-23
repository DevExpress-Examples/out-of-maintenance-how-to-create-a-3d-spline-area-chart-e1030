using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_3DSplineAreaChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl SplineAreaChart3D = new ChartControl();

            // Add a spline area series to it.
            Series series1 = new Series("Series 1", ViewType.SplineArea3D);

            // Add points to the series.
            series1.Points.Add(new SeriesPoint("A", 12));
            series1.Points.Add(new SeriesPoint("B", 4));
            series1.Points.Add(new SeriesPoint("C", 17));
            series1.Points.Add(new SeriesPoint("D", 7));
            series1.Points.Add(new SeriesPoint("E", 12));
            series1.Points.Add(new SeriesPoint("F", 4));
            series1.Points.Add(new SeriesPoint("G", 17));
            series1.Points.Add(new SeriesPoint("H", 7));

            // Add both series to the chart.
            SplineAreaChart3D.Series.Add(series1);

            // Access labels of the series.
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((Area3DSeriesLabel)series1.Label).ResolveOverlappingMode =
                ResolveOverlappingMode.Default;

            // Access another series options.
            series1.Label.TextPattern = "{A}: {V}";

            // Customize the view-type-specific properties of the series.
            SplineArea3DSeriesView myView = (SplineArea3DSeriesView)series1.View;
            myView.AreaWidth = 4;
            myView.LineTensionPercent = 50;

            // Access the diagram's options.
            ((XYDiagram3D)SplineAreaChart3D.Diagram).ZoomPercent = 110;
            ((XYDiagram3D)SplineAreaChart3D.Diagram).VerticalScrollPercent = 10;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Spline Area Chart";
            SplineAreaChart3D.Titles.Add(chartTitle1);
            SplineAreaChart3D.Legend.Visible = false;

            // Add the chart to the form.
            SplineAreaChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(SplineAreaChart3D);
        }

    }
}