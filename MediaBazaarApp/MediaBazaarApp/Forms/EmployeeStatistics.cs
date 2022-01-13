using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace MediaBazaarApp
{
    public partial class EmployeeStatistics : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;
        StatisticsManager statisticsManager;
        PlotView plotShifts;

        public EmployeeStatistics(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
            statisticsManager = new StatisticsManager();
            plotShifts = new PlotView();

            CreateFiredChart();
            //CreateHoursChart();
            CreatePTvsFT();
            LoadCombobox();
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
        }

        private void CreateBarChart()
        {
            var pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(1100, 629);
            this.tabPage1.Controls.Add(pv);
            //this.Controls.Add(pv);
            pv.Model = new PlotModel();
            pv.Model.Title = "Number of Employees Hired & Fired in the last four months.";
            pv.Model.IsLegendVisible = true;
            //{
            //    Title = "BarSeries",
            //    LegendPlacement = LegendPlacement.Outside,
            //    LegendPosition = LegendPosition.BottomCenter,
            //    LegendOrientation = LegendOrientation.Horizontal,
            //    LegendBorderThickness = 0
            //};

            //model.Title = "BarSeries";


            var s1 = new BarSeries { Title = "Series 1", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            s1.Items.Add(new BarItem { Value = 57, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = 16, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = 33, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = 21, Color = OxyColors.Green });

            var s2 = new BarSeries { Title = "Series 2", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            s2.Items.Add(new BarItem { Value = 31, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = 15, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = 21, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = 8, Color = OxyColors.Red });

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.Add("September");
            categoryAxis.Labels.Add("October");
            categoryAxis.Labels.Add("November");
            categoryAxis.Labels.Add("December");
            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };
            pv.Model.Series.Add(s1);
            pv.Model.Series.Add(s2);
            pv.Model.Axes.Add(categoryAxis);
            pv.Model.Axes.Add(valueAxis);

            //return pv;
        }

        private void CreateLineChart()
        {
            PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(1100, 629);
            //this.Controls.Add(pv);
            this.tabPage2.Controls.Add(pv);


            pv.Model = new PlotModel { Title = "Employees' hours worked per month" };

            FunctionSeries fs = new FunctionSeries();
            fs.Points.Add(new OxyPlot.DataPoint(0, 57));
            fs.Points.Add(new OxyPlot.DataPoint(1, 40));
            fs.Points.Add(new OxyPlot.DataPoint(2, 51));
            fs.Points.Add(new OxyPlot.DataPoint(3, 64));
            fs.Points.Add(new OxyPlot.DataPoint(4, 50));
            fs.Points.Add(new OxyPlot.DataPoint(5, 45));
            fs.Points.Add(new OxyPlot.DataPoint(6, 52));
            fs.Points.Add(new OxyPlot.DataPoint(7, 58));
            fs.Points.Add(new OxyPlot.DataPoint(8, 62));
            fs.Points.Add(new OxyPlot.DataPoint(9, 55));
            fs.Points.Add(new OxyPlot.DataPoint(10, 49));
            fs.Points.Add(new OxyPlot.DataPoint(11, 53));
            pv.Model.Series.Add(fs);

            //pv.Model.Series.Add(getFunction());
            //pv.Model.Series.Add(getLine());

            //pv.Model.Series.Add(new FunctionSeries(Math.Exp, 0, 1, 0.1, "e(x)"));
            //pv.Model.Series.Add(new FunctionSeries(Math.Log, 0.1, 1, 0.1, "log(x)"));
            //pv.Model.Series.Add(new FunctionSeries(Math.Tan, -1, 1, 0.1, "tan(x)"));

            //return pv;
        }

        private void CreatePTvsFT()
        {
            PlotView plotView = new PlotView();
            plotView.Location = new Point(0, 0);
            plotView.Size = new Size(1100, 629);
            this.tabPage3.Controls.Add(plotView);

            plotView.Model = new PlotModel { Title = "Number of employees with part time vs full time contracts." };

            var s1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            int pt = statisticsManager.GetPartTimeEmp();
            int ft = statisticsManager.GetFullTimeEmp();

            s1.Slices.Add(new PieSlice("Part Time", pt));
            s1.Slices.Add(new PieSlice("Full Time", ft));

            plotView.Model.Series.Add(s1);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateShiftChart(int id)
        {
            PlotView plotView = new PlotView();
            plotView.Location = new Point(0, 0);
            plotView.Size = new Size(1100, 629);
            this.tabPage2.Controls.Add(plotView);

            plotView.Model = new PlotModel { Title = "Number of hours worked by employee - "+ id};

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.Add("MORNING");
            categoryAxis.Labels.Add("AFTERNOON");
            categoryAxis.Labels.Add("EVENING");

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };

            plotView.Model.Series.Add(GetEmployeeHours(id));
            plotView.Model.Axes.Add(categoryAxis);
            plotView.Model.Axes.Add(valueAxis);

        }

        private void CreateFiredChart()
        {
            PlotView plotView = new PlotView();
            plotView.Location = new Point(0, 0);
            plotView.Size = new Size(1100, 629);
            this.tabPage1.Controls.Add(plotView);

            int year = 2021; // make it dynamic

            plotView.Model = new PlotModel { Title = "Number of fired and hired employees over the year ("+year+")."};
            
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

            plotView.Model.Series.Add(GetFiredEmployees());
            plotView.Model.Series.Add(GetHiredEmployees());
            plotView.Model.Axes.Add(categoryAxis);
            plotView.Model.Axes.Add(valueAxis);

        }

        private BarSeries GetHiredEmployees()
        {
            var s1 = new BarSeries { Title = "Hired employees", StrokeColor = OxyColors.Black, StrokeThickness = 1 };

            int jan = 0;
            int feb = 0;
            int mar = 0;
            int apr = 0;
            int may = 0;
            int jun = 0;
            int jul = 0;
            int aug = 0;
            int sep = 0;
            int oct = 0;
            int nov = 0;
            int dec = 0;

            foreach (Employee employee in employeeManager.GetEmployees())
            {
                DateTime date = Convert.ToDateTime(employee.LastWorkingDate);
                int month = date.Month;

                if (month == 1) { jan++; }
                else if (month == 2) { feb++; }
                else if (month == 3) { mar++; }
                else if (month == 4) { apr++; }
                else if (month == 5) { may++; }
                else if (month == 6) { jun++; }
                else if (month == 7) { jul++; }
                else if (month == 8) { aug++; }
                else if (month == 9) { sep++; }
                else if (month == 10) { oct++; }
                else if (month == 11) { nov++; }
                else if (month == 12) { dec++; }
            }

            s1.Items.Add(new BarItem { Value = jan, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = feb, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = mar, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = apr, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = may, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = jun, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = jul, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = aug, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = sep, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = oct, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = nov, Color = OxyColors.Green });
            s1.Items.Add(new BarItem { Value = dec, Color = OxyColors.Green });

            return s1;
        }

        private BarSeries GetFiredEmployees()
        {
            var s2 = new BarSeries { Title = "Fired employees", StrokeColor = OxyColors.Black, StrokeThickness = 1 };

            int jan = 0;
            int feb = 0;
            int mar = 0;
            int apr = 0;
            int may = 0;
            int jun = 0;
            int jul = 0;
            int aug = 0;
            int sep = 0;
            int oct = 0;
            int nov = 0;
            int dec = 0;

            foreach(Employee employee in statisticsManager.GetTerminatedEmployees())
            {
                DateTime date = Convert.ToDateTime(employee.LastWorkingDate);
                int month = date.Month;

                if(month == 1) { jan++; }
                else if(month == 2) { feb++; }
                else if(month == 3) { mar++; }
                else if (month == 4) { apr++; }
                else if (month == 5) { may++; }
                else if (month == 6) { jun++; }
                else if (month == 7) { jul++; }
                else if (month == 8) { aug++; }
                else if (month == 9) { sep++; }
                else if (month == 10) { oct++; }
                else if (month == 11) { nov++; }
                else if (month == 12) { dec++; }
            }

            s2.Items.Add(new BarItem { Value = jan, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = feb, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = mar, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = apr, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = may, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = jun, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = jul, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = aug, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = sep, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = oct, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = nov, Color = OxyColors.Red });
            s2.Items.Add(new BarItem { Value = dec, Color = OxyColors.Red });

            return s2;
        }

        private FunctionSeries EmployeesHoursFunction(int id)
        {
            FunctionSeries fs = new FunctionSeries();

            foreach(Employee employee in statisticsManager.GetEmployeesHoursWorked())
            {
                if(employee.ID == id)
                {
                    for (int m=0; m < 13; m++)
                    {
                        DataPoint dp = new DataPoint(m, employee.Hours);
                        fs.Points.Add(dp);
                    }
                }
            }
            return fs;
        }

        private FunctionSeries EmployeeHoursFunction(int id)
        {
            FunctionSeries fs = new FunctionSeries();

            foreach (WorkShift shift in statisticsManager.GetEmployeeHoursWorked(id))
            {
                if (shift.Type == "MORNING")
                {
                    DataPoint dp = new DataPoint(1, shift.HoursWorked);
                    fs.Points.Add(dp);
                }
                else if (shift.Type == "AFTERNOON")
                {
                    DataPoint dp = new DataPoint(2, shift.HoursWorked);
                    fs.Points.Add(dp);
                }
                else if (shift.Type == "EVENING")
                {
                    DataPoint dp = new DataPoint(3, shift.HoursWorked);
                    fs.Points.Add(dp);
                }
            }
            return fs;
        }

        private BarSeries GetEmployeeHours(int id)
        {
            var s2 = new BarSeries { Title = "Number of hours", StrokeColor = OxyColors.Black, StrokeThickness = 1 };

            int shift1 = 0;
            int shift2 = 0;
            int shift3 = 0;

            foreach (WorkShift shift in statisticsManager.GetEmployeeHoursWorked(id))
            {
                if (shift.Type == "MORNING") { shift1 = shift.HoursWorked; }
                else if (shift.Type == "AFTERNOON") { shift2 = shift.HoursWorked; }
                else if (shift.Type == "EVENING") { shift3 = shift.HoursWorked; }
            }

            s2.Items.Add(new BarItem { Value = shift1, Color = OxyColors.Yellow });
            s2.Items.Add(new BarItem { Value = shift2, Color = OxyColors.Fuchsia });
            s2.Items.Add(new BarItem { Value = shift3, Color = OxyColors.Blue });

            return s2;
        }

        private void CreateHoursChart(int id)
        {
            PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(1100, 629);
            this.tabPage2.Controls.Add(pv);

            pv.Model = new PlotModel { Title = "Employees' hours worked per month" };

            pv.Model.Series.Add(EmployeeHoursFunction(id));
            pv.Model.InvalidatePlot(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        public void LoadCombobox()
        {
            Dictionary<int, string> comboBoxSource = new Dictionary<int, string>();
            foreach (Employee emp in employeeManager.GetEmployees())
            {
                comboBoxSource.Add(emp.ID, emp.FullName);
            }

            cbEmployees.DataSource = new BindingSource(comboBoxSource, null);
            cbEmployees.DisplayMember = "Value";
            cbEmployees.ValueMember = "Key";

            //cbEmployees.Items.Clear();
            //foreach (Employee e in employeeManager.GetEmployees())
            //{
            //    cbEmployees.Items.Add(e.FirstName + " " + e.LastName);
            //}
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cbEmployees.SelectedItem).Key;
            string name = ((KeyValuePair<int, string>)cbEmployees.SelectedItem).Value;

            this.tabPage2.Controls.Remove(plotShifts);

            //CreateHoursChart(id);
            //CreateShiftChart(id);
            //PlotView plotView = new PlotView();
            plotShifts.Location = new Point(0, 0);
            plotShifts.Size = new Size(1100, 629);
            this.tabPage2.Controls.Add(plotShifts);

            plotShifts.Model = new PlotModel { Title = "Number of hours worked by employee ID: " + id };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.Add("MORNING");
            categoryAxis.Labels.Add("AFTERNOON");
            categoryAxis.Labels.Add("EVENING");

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };

            plotShifts.Model.Series.Add(GetEmployeeHours(id));
            plotShifts.Model.Axes.Add(categoryAxis);
            plotShifts.Model.Axes.Add(valueAxis);

        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.tabPage2.Controls.Remove(pv);
        }

        private void NiceColumns()
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
