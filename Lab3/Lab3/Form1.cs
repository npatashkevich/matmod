using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            z1.GraphPane.Title = "Плотность распределения";
            z2.GraphPane.Title = "Плотность вероятности";
            z1.AxisChange();
            z1.Invalidate();
            z2.AxisChange();
            z2.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphPane pane = z1.GraphPane;
            pane.CurveList.Clear();

            pane.AddCurve("x0 = 0, q = 1", GetList(0,1), Color.Blue, SymbolType.None);
            pane.AddCurve("x0 = 0, q = 0.5", GetList(0, 0.5), Color.Red, SymbolType.None);
            pane.AddCurve("x0 = 0, q = 2", GetList(0, 2), Color.Green, SymbolType.None);
            pane.AddCurve("x0 = -2, q = 1", GetList(-2, 1), Color.Purple, SymbolType.None);
            
            z1.AxisChange();
            z1.Invalidate();

            pane = z2.GraphPane;
            pane.CurveList.Clear();

            pane.AddCurve("x0 = 0, q = 1", GetList(0, 1, false), Color.Blue, SymbolType.None);
            pane.AddCurve("x0 = 0, q = 0.5", GetList(0, 0.5, false), Color.Red, SymbolType.None);
            pane.AddCurve("x0 = 0, q = 2", GetList(0, 2, false), Color.Green, SymbolType.None);
            pane.AddCurve("x0 = -2, q = 1", GetList(-2, 1, false), Color.Purple, SymbolType.None);

            z2.AxisChange();
            z2.Invalidate();
        }

        public PointPairList GetList(double x0, double q, bool NotRevers = true, int n = 100000, int b = 50, double min = -5, double max = 5)
        {
            PointPairList list = new PointPairList();
            if (NotRevers) {
                for (double x = min; x <= max; x+= 0.1)
                    list.Add(x, Generaters.Koshi(x, x0, q));
            }
            else {
                var cauchy = from x in Generaters.UniformDistribution() select  Generaters.Revers(x, x0, q);
                int[] histogram = Generaters.CreateHistogram(cauchy.Take(n), b, min, max);
                double sum = 0;
                for (double x = 0; x < histogram.Length; x += 1)
                    sum += histogram[(int)x];

                // Заполняем список точек
                for (double x = 0; x < histogram.Length; x += 1)
                    list.Add(x / b, histogram[(int)x] / sum);
            }
            return list;
        }
    }

    public class Generaters
    {
        public static Random random = new Random();
        public static IEnumerable<double> UniformDistribution()
        {
            while (true) yield return random.NextDouble();
        }

        public static double Revers(double p, double x0, double q)
        {
            return x0 + q * Math.Tan(Math.PI * (p - 1 / 2.0));
        }

        public static double Koshi(double p, double x0, double q)
        {
            return 1/Math.PI * Math.Atan((p - x0)/q) + 1/2.0;
        }

        public static int[] CreateHistogram(IEnumerable<double> data, int buckets, double min, double max)
        {
            int[] results = new int[buckets];
            double multiplier = buckets / (max - min);
            foreach (double datum in data)
            {
                double index = (datum - min) * multiplier;
                if (0.0 <= index && index < buckets)
                    results[(int)index] += 1;
            }
            return results;
        }
    }
}
