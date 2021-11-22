using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls.DataVisualization;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.Wpf;

namespace MediaBazaarApp
{
    public partial class EmployeeStatistics : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;

        public EmployeeStatistics(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();
            //this.WindowState = FormWindowState.Maximized;

            employeeManager = new EmployeeManager();

            CreateBarChart();
            CreateLineChart();
            CreatePieChart();

            //LoadCombobox();

        }

        private void LoadCombobox()
        {
            //string[] stats = new string[]{ "Employees ratio", "Overview of Employees" };
            //cbStats.Items.AddRange(stats);
            //cbStatistics.Items.Add("Employees ratio");
            //cbStatistics.Items.Add("Overview of Employees");

        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            //CreateBarChart();
        }

        private void CreateBarChart()
        {            
            //var pv = new PlotView();
            //pv.Location = new Point(0, 0);
            //pv.Size = new Size(1100, 629);
            //this.tabPage1.Controls.Add(pv);
            ////this.Controls.Add(pv);
            //pv.Model = new PlotModel();
            //pv.Model.Title = "Number of Employees Hired & Fired in the last four months.";
            //pv.Model.IsLegendVisible = true;
            //{
            //    Title = "BarSeries",
            //    LegendPlacement = LegendPlacement.Outside,
            //    LegendPosition = LegendPosition.BottomCenter,
            //    LegendOrientation = LegendOrientation.Horizontal,
            //    LegendBorderThickness = 0
            //};

            //model.Title = "BarSeries";


            //var s1 = new BarSeries { Title = "Series 1", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            //s1.Items.Add(new BarItem { Value = 57, Color = OxyColors.Green });
            //s1.Items.Add(new BarItem { Value = 16, Color = OxyColors.Green });
            //s1.Items.Add(new BarItem { Value = 33, Color = OxyColors.Green });
            //s1.Items.Add(new BarItem { Value = 21, Color = OxyColors.Green });

            //var s2 = new BarSeries { Title = "Series 2", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            //s2.Items.Add(new BarItem { Value = 31, Color = OxyColors.Red });
            //s2.Items.Add(new BarItem { Value = 15, Color = OxyColors.Red });
            //s2.Items.Add(new BarItem { Value = 21, Color = OxyColors.Red });
            //s2.Items.Add(new BarItem { Value = 8, Color = OxyColors.Red });

            //var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            //categoryAxis.Labels.Add("September");
            //categoryAxis.Labels.Add("October");
            //categoryAxis.Labels.Add("November");
            //categoryAxis.Labels.Add("December");
            //var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };
            //pv.Model.Series.Add(s1);
            //pv.Model.Series.Add(s2);
            //pv.Model.Axes.Add(categoryAxis);
            //pv.Model.Axes.Add(valueAxis);

            //return pv;
        }

        private void CreateLineChart()
        {
            //PlotView pv = new PlotView();
            //pv.Location = new Point(0, 0);
            //pv.Size = new Size(1100, 629);
            ////this.Controls.Add(pv);
            //this.tabPage2.Controls.Add(pv);


            //pv.Model = new PlotModel { Title = "Employees' number change throughout the year" };

            //FunctionSeries fs = new FunctionSeries();
            //fs.Points.Add(new OxyPlot.DataPoint(0, 57));
            //fs.Points.Add(new OxyPlot.DataPoint(1, 40));
            //fs.Points.Add(new OxyPlot.DataPoint(2, 51));
            //fs.Points.Add(new OxyPlot.DataPoint(3, 64));
            //fs.Points.Add(new OxyPlot.DataPoint(4, 50));
            //fs.Points.Add(new OxyPlot.DataPoint(5, 45));
            //fs.Points.Add(new OxyPlot.DataPoint(6, 52));
            //fs.Points.Add(new OxyPlot.DataPoint(7, 58));
            //fs.Points.Add(new OxyPlot.DataPoint(8, 62));
            //fs.Points.Add(new OxyPlot.DataPoint(9, 55));
            //fs.Points.Add(new OxyPlot.DataPoint(10, 49));
            //fs.Points.Add(new OxyPlot.DataPoint(11, 53));
            //pv.Model.Series.Add(fs);

            // pv.Model.Series.Add(getFunction());
            //pv.Model.Series.Add(getLine());

            //pv.Model.Series.Add(new FunctionSeries(Math.Exp, 0, 1, 0.1, "e(x)"));
            //pv.Model.Series.Add(new FunctionSeries(Math.Log, 0.1, 1, 0.1, "log(x)"));
            //pv.Model.Series.Add(new FunctionSeries(Math.Tan, -1, 1, 0.1, "tan(x)"));

            //return pv;
        }

        private void CreatePieChart()
        {
            //PlotView pv = new PlotView();
            //pv.Location = new Point(0, 0);
            //pv.Size = new Size(1100, 629);
            //this.tabPage3.Controls.Add(pv);

            //pv.Model = new PlotModel { Title = "Number of employees per department" };

            //var s1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            //s1.Slices.Add(new PieSlice("HR", 7));
            //s1.Slices.Add(new PieSlice("Logistics", 10));
            //s1.Slices.Add(new PieSlice("Sales", 15));
            //s1.Slices.Add(new PieSlice("Depot Workers", 25));

            //pv.Model.Series.Add(s1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void btnLoadStats_Click(object sender, EventArgs e)
        {
            //if(cbStats.SelectedIndex == 0)
            //{
            //    this.Controls.Remove(LineChart());
            //    this.Controls.Add(BarChart());                
            //}


            //if(cbStats.SelectedIndex == 1)
            //{
            //    this.Controls.Remove(BarChart());
            //    this.Controls.Add(LineChart());
            //}

            //switch (cbStats.SelectedIndex)
            //{
            //    case 0:
            //        CreateBarChart();
            //        break;
            //    case 1:
            //        CreateLineChart();
            //        break;
            //}
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //private FunctionSeries getFunction()
        //{
        //    FunctionSeries fs = new FunctionSeries();
        //    for(double i=0.0; i<1.0; i += 0.01)
        //    {
        //        OxyPlot.DataPoint dp = new OxyPlot.DataPoint(i, GetValue(i));
        //        fs.Points.Add(dp);
        //    }
        //    return fs;
        //}

        //private double GetValue(double x)
        //{
        //    double cycle = 0.25;
        //    return Math.Sin(Math.Sqrt(2 * Math.PI * x * cycle / 100 + x));
        //}

        //private FunctionSeries getLine()
        //{
        //    double[] x = new double[100];
        //    double[] y = new double[100];
        //    double cycle = 0.25;
        //    int k = 2;

        //    x[0] = x[1] = y[0] = 0.02;
        //    y[1] = Math.Sin(Math.Sqrt(2 * Math.PI * 2 * cycle / 100 + 2 / 100));
        //    for(int i = 2; i < 100; i+=2)
        //    {
        //        x[k] = y[i - 1];
        //        y[k] = y[i - 1];
        //        x[k + 1] = y[i - 1];
        //        y[k + 1] = Math.Sin(Math.Sqrt(2 * Math.PI * y[i] * cycle / 100 +y[i]));
        //        k += 2;
        //    }
        //    FunctionSeries fs = new FunctionSeries();
        //    for(int i = 0; i < 100; i++)
        //    {
        //        OxyPlot.DataPoint dp = new OxyPlot.DataPoint(x[i], y[i]);
        //        fs.Points.Add(dp);
        //    }
        //    return fs;
        //}
    }
}
