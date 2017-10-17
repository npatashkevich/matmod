using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SquareRandom SquareRandom = new SquareRandom(1994);
        MultKongRandom MultKongRandom = new MultKongRandom(1,  991, 983);

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = SquareRandom.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Random = 0;
            if (radioButton1.Checked)
                Random = SquareRandom.Next();
            else
                Random = MultKongRandom.Next();
            textBox1.Text = Random.ToString();
        }

        public void Equability(int k, int n, int start_n = 100)
        {
            Random R = new Random();
            List<float> Values = new List<float>();
            List<float> Intervals = new List<float>();
            for (int i = 0; i < k+1; i++)
                Intervals.Add((1f / k) * i);
            List<List<float>> Results = new List<List<float>>();
            for (int i = 0; i < n; i++) {
                Results.Add(new List<float>());
                for (int j = 0; j < k; j++)
                    Results[Results.Count - 1].Add(0);
            }
            for (int i = 0; i < start_n * Math.Pow(10, n-1); i++)
            {
                if (radioButton1.Checked)
                    Values.Add(SquareRandom.Next());
                else
                    Values.Add(MultKongRandom.Next());
                float Value = (float)(R.NextDouble());
                Values.Add(Value);
            }

            int counter = 0;
            foreach (var f in Values)
            {
                int pos = -1;
                for (int j = 1; j < Intervals.Count; j++)
                    if (f <= Intervals[j])
                    {
                        pos = j - 1;
                        break;
                    }
                for (int j = 0; j < n; j++)
                    if (counter < start_n * Math.Pow(10, j))
                        Results[j][pos] = Results[j][pos] + 1;//(float)(Results[j][pos] + f);
                counter++;
            }
            
            for (int j = 0; j < n; j++)
                for (int i = 0; i < k; i++)
                    Results[j][i] = Results[j][i] / (float)(start_n * Math.Pow(10, j));

            chart1.Series.Clear();
            for (int j = 0; j < n; j++)
                chart1.Series.Add("n = " + (start_n * Math.Pow(10, j)).ToString());

            for (int j = 0; j < n; j++)
            {
                float sum = 0;
                for (int i = 0; i < k; i++)
                {
                    chart1.Series["n = " + (start_n * Math.Pow(10, j)).ToString()].Points.AddXY(Intervals[i].ToString()
                    + "-" + Intervals[i + 1].ToString(), Results[j][i]);
                    sum += Results[j][i];
                }
                chart1.Series["n = " + (start_n * Math.Pow(10, j)).ToString()].Points.AddXY("All", sum);
            }

            float sumM = 0;
            for (int i = 0; i < Values.Count; i++)
                sumM += Values[i];
            Console.WriteLine(sumM/(float)Values.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equability(10, 5, 100);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Visible = radioButton1.Checked;
                groupBox3.Visible = !radioButton1.Checked;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox3.Visible = radioButton2.Checked;
                groupBox2.Visible = !radioButton2.Checked;
            }
        }
    }

    public class SquareRandom
    {
        int seed;
        int min_seed = 102, max_seed = 9999;
        int value;

        public int Value
        {
            get { return value; }
        }

        public SquareRandom(int seed = 1357)
        {
            this.seed = seed;
            value = seed;
        }

        public int NextInt()
        {
            string s = (value * value).ToString();
            for (int i = 0; i < 8 - s.Length; i++)
                s = "0" + s;
            int new_value = Convert.ToInt32(s.Substring(2, 4));
            if (new_value == value)
            {
                value = seed;
                return NextInt();
            }
            else
            {
                value = new_value;
                return Value;
            }
        }

        public float Next()
        {
            NextInt();
            return (value - min_seed) / ((max_seed - min_seed)*1f);
        }
    }

    public class MultKongRandom
    {
        int seed;
        int k, m;
        int value;

        public int Value
        {
            get { return value; }
        }

        public MultKongRandom(int seed = 10, int k = 7, int m = 13)
        {
            this.seed = seed;
            this.k = k;
            this.m = m;
            this.value = seed;
        }

        public int NextInt()
        {
            int new_value = (value * k) % m;
            if (new_value == value)
            {
                value = seed;
                return NextInt();
            }
            else
            {
                value = new_value;
                return Value;
            }
        }

        public float Next()
        {
            NextInt();
            return (value - 1f) / (m - 1f);
        }
    }
}
