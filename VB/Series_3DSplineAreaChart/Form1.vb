Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DSplineAreaChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim SplineAreaChart3D As New ChartControl()

            ' Add a spline area series to it.
            Dim series1 As New Series("Series 1", ViewType.SplineArea3D)

            ' Add points to the series.
            series1.Points.Add(New SeriesPoint("A", 12))
            series1.Points.Add(New SeriesPoint("B", 4))
            series1.Points.Add(New SeriesPoint("C", 17))
            series1.Points.Add(New SeriesPoint("D", 7))
            series1.Points.Add(New SeriesPoint("E", 12))
            series1.Points.Add(New SeriesPoint("F", 4))
            series1.Points.Add(New SeriesPoint("G", 17))
            series1.Points.Add(New SeriesPoint("H", 7))

            ' Add both series to the chart.
            SplineAreaChart3D.Series.Add(series1)

            ' Access labels of the series.
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            CType(series1.Label, Area3DSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

            ' Access another series options.
            series1.Label.PointOptions.PointView = PointView.ArgumentAndValues

            ' Customize the view-type-specific properties of the series.
            Dim myView As SplineArea3DSeriesView = CType(series1.View, SplineArea3DSeriesView)
            myView.AreaWidth = 4
            myView.LineTensionPercent = 50

            ' Access the diagram's options.
            CType(SplineAreaChart3D.Diagram, XYDiagram3D).ZoomPercent = 110
            CType(SplineAreaChart3D.Diagram, XYDiagram3D).VerticalScrollPercent = 10

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Spline Area Chart"
            SplineAreaChart3D.Titles.Add(chartTitle1)
            SplineAreaChart3D.Legend.Visible = False

            ' Add the chart to the form.
            SplineAreaChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(SplineAreaChart3D)
        End Sub

    End Class
End Namespace