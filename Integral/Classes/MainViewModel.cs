using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Series;
using OxyPlot;

namespace Integral.Classes
{
    public class MainViewModel
    {
        public MainViewModel()
        {

            this.MyModel = new PlotModel { Title = "График зависимости времени вычисления от количества разбиений" };
            FunctionSeries ser = new FunctionSeries()
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
                MarkerFill = OxyColors.Blue
            };
            this.MyModel.Series.Add(ser);
        }

        public PlotModel MyModel { get; private set; }
    }
}
