using Integral.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot.Series;
using OxyPlot;
using System.Security.Cryptography.X509Certificates;

//TestFirst

namespace Integral
{
    public partial class MainWindow : Window
    {
        List<List<double>> y = new List<List<double>>();
        public int i = 1;
        public int OldCount = 0;
        public MainWindow()
        {
            InitializeComponent();
            y.Add(new List<double>());
            y[0].Add(0);
            y[0].Add(0);
        }

        public void tbCalculate_Click(object sender, RoutedEventArgs e)
        {
            double b = Convert.ToDouble(tbUpper.Text);
            double a = Convert.ToDouble(tbLower.Text);
            int count = Convert.ToInt32(tbCount.Text);
            if (count < OldCount)
            {
                y.Clear();
                y.Add(new List<double>());
                y[0].Add(0);
                y[0].Add(0);
                i = 1;
                (graph1.Model.Series[0] as FunctionSeries).Points.Clear();
                graph1.InvalidatePlot();
            }
            Stopwatch time = new Stopwatch();
            time.Start();
            IntegralCalculator calculator = GetCalculator();
            double result = calculator.Calculate(a, b, count);
            time.Stop();
            double time1 = time.ElapsedMilliseconds;
            y.Add(new List<double>());
            y[i].Add(count);
            y[i].Add(time1);
            tbTime.Text = Convert.ToString(time1);
            tbResult.Text = Convert.ToString(result);
            (graph1.Model.Series[0] as FunctionSeries).Points.Clear();
            for (int j = 0; j <= i; j++)
            (graph1.Model.Series[0] as FunctionSeries).Points.Add(new DataPoint(y[j][0], y[j][1]));
            graph1.InvalidatePlot();
            OldCount = count;
            i++;
        }

        private IntegralCalculator GetCalculator()
        {
            IntegralCalculator a = null;
            if (MethodSelection.SelectedIndex == 0)
                a = new MiddleRectanglesIntegral();
            if (MethodSelection.SelectedIndex == 1)
                a = new TrapezoidIntegral();
            return a;
        }

        private void tbClear_Chart(object sender, RoutedEventArgs e)
        {
            (graph1.Model.Series[0] as FunctionSeries).Points.Clear();
            graph1.InvalidatePlot();
            y.Clear();
        }
    }
}
