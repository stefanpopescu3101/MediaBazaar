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
using OxyPlot.WindowsForms;

namespace MediaBazaarApp
{
    public partial class ProductStatistics : Form
    {
      
        public ProductStatistics()
        {
            InitializeComponent();
            this.CenterToParent();
            CreateChart();
            PieChartForFloor();
            PieChartForBrand();
        }

        private void CreateChart()
        {
            PlotView plotView = new PlotView();
            plotView.Location = new Point(0, 0);
            plotView.Size = new Size(1100, 629);
            this.tabPage1.Controls.Add(plotView);

            int year = DateTime.Now.Year; // make it dynamic

            plotView.Model = new PlotModel { Title = "Growth of product purchases over the year (" + year + ")." };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.Add("January");
            categoryAxis.Labels.Add("February");
            categoryAxis.Labels.Add("March");
            categoryAxis.Labels.Add("April");
            categoryAxis.Labels.Add("May");
            categoryAxis.Labels.Add("June");
            categoryAxis.Labels.Add("July");
            categoryAxis.Labels.Add("August");
            categoryAxis.Labels.Add("September");
            categoryAxis.Labels.Add("October");
            categoryAxis.Labels.Add("November");
            categoryAxis.Labels.Add("December");
            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };

            plotView.Model.Series.Add(GetProductsPurchases());
            plotView.Model.Axes.Add(categoryAxis);
            plotView.Model.Axes.Add(valueAxis);

        }

        private BarSeries GetProductsPurchases()
        {
            var s2 = new BarSeries { Title = "Purchased products", StrokeColor = OxyColors.Black, StrokeThickness = 1 };

      
            s2.Items.Add(new BarItem { Value = 10000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 8000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 30000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 20000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 25000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 60000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 65000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 80000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 90000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 100000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 200000, Color = OxyColors.Green });
            s2.Items.Add(new BarItem { Value = 200000, Color = OxyColors.Green });

            return s2;
        }
        private void PieChartForFloor()
        {
            PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(1100, 629);
            this.tabPage2.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Percentage Of Products Per Floor " };

            var s1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            s1.Slices.Add(new PieSlice("Health", 95));
            s1.Slices.Add(new PieSlice("Entertainment", 80));
            s1.Slices.Add(new PieSlice("Media", 90));

            pv.Model.Series.Add(s1);
        }

        private void PieChartForBrand()
        {
            PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(1100, 629);
            this.tabPage3.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Percentage Of Most Sold Brand" };

            var s1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            s1.Slices.Add(new PieSlice("Rat", 75));
            s1.Slices.Add(new PieSlice("CoolBrandYo", 50));
            s1.Slices.Add(new PieSlice("Apple", 90));
            s1.Slices.Add(new PieSlice("SmartTools", 20));

            pv.Model.Series.Add(s1);
        }
        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            //CreateBarChart();
        }

    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void btnLoadStats_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
