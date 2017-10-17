using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Random R = new Random(); //Рандом
        int Mode = 0;//Режим-подпункт лабы
        int startR = 1;//начальный разряд в графике
        int countR = 6;//число разрядов

        public Form1()
        {
            InitializeComponent();
            RefrashMode();
        }
        //-------------------------------------------------------

        //обновляем отображаемые поля под соответствующий режим
        public void RefrashMode()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            dataGridView1.Visible = false;

            dataGridView1.Rows.Clear();
            chart1.Series.Clear();


            switch (Mode)
            {
                case 0:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    break;
                case 1:
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    break;
                case 2:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    break;
                case 3:
                    dataGridView1.Rows.Add("A", 0.20);
                    dataGridView1.Rows.Add("B", 0.10);
                    dataGridView1.Rows.Add("C", 0.40);
                    dataGridView1.Rows.Add("D", 0.30);

                    dataGridView1.Visible = true;
                    label5.Visible = true;
                    break;
            }
            
        }

        //-------------------------------------------------------

        //Имитация случайного события
        //PA - вероятность события, X - случайная число
        public int randomEvent(double PA, double X)
        {
            return (PA >= X ? 1 : 0);
        }

        //Имитация сложного события
        //PA,PB - вероятности событий, X1,X2 - случайные числа
        public int complexEvent(double PA, double PB, double X1, double X2)
        {
            if (X1 <= PA)
                if (X2 <= PB)
                    return 3;
                else
                    return 2;
            else
                if (X2 <= PB)
                return 1;
            else
                return 0;
        }

        //Имитация сложного события, состоящего из зависимых событий.
        //PA,PB,PBA - вероятности событий, X1,X2 - случайные числа
        public int complexFromDependent(double PA, double PB, double PBA, double X1, double X2)
        {
            double PBNA = (PA == 1 ? 0 : (PB - PBA * PA) / (1 - PA));
            if (X1 <= PA)
                if (X2 <= PBA)
                    return 3;
                else
                    return 2;
            else
                if (X2 <= PBNA)
                return 1;
            else
                return 0;
        }

        //Имитация событий, составляющих полную группу
        //PS - вероятности событий, X - случайное число
        public int fullGroup(List<double> PS, double X)
        {
            double sum = 0;
            foreach (var I in PS)
                sum += I;

            if (sum != 1)
                return -1;

            sum = 0;
            for (int i = 0; i < PS.Count; i++)
            {
                sum += PS[i];
                if (X <= sum)
                    return i;
            }

            return -1;
        }
        //-------------------------------------------------------

        //Методы одиночной генерации. Выводит результат в labal4.
       
        public void randomEventGen()
        {
            double PA = Convert.ToDouble(textBox1.Text);
            if (randomEvent(PA, R.NextDouble()) > 0)
                label4.Text = "A";
            else
                label4.Text = "!A";
        }

        public void complexEventGen()
        {
            double PA = Convert.ToDouble(textBox1.Text);
            double PB = Convert.ToDouble(textBox2.Text);

            switch (complexEvent(PA, PB, R.NextDouble(), R.NextDouble()))
            {
                case 0:
                    label4.Text = "!A!B";
                    break;
                case 1:
                    label4.Text = "!AB";
                    break;
                case 2:
                    label4.Text = "A!B";
                    break;
                case 3:
                    label4.Text = "AB";
                    break;
            }
        }

        public void complexFromDependentGen()
        {
            double PA = Convert.ToDouble(textBox1.Text);
            double PB = Convert.ToDouble(textBox2.Text);
            double PBA = Convert.ToDouble(textBox3.Text);

            switch (complexFromDependent(PA, PB, PBA, R.NextDouble(), R.NextDouble()))
            {
                case 0:
                    label4.Text = "!A!B";
                    break;
                case 1:
                    label4.Text = "!AB";
                    break;
                case 2:
                    label4.Text = "A!B";
                    break;
                case 3:
                    label4.Text = "AB";
                    break;
            }
        }

        public void fullGroupGen()
        {
            List<double> PS = new List<double>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                PS.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));

            int result = fullGroup(PS, R.NextDouble());
            label4.Text = (result == -1 ? "Неопределено" : dataGridView1.Rows[result].Cells[0].Value.ToString());
        }
        //-------------------------------------------------------

        //Методы для вывода гистограмм. Выводит результат в chart1. randomEventStat расписан более подробно.
        
        public void randomEventStat()
        {
            double PA = Convert.ToDouble(textBox1.Text);//задаваемая вероятность

            chart1.Series.Clear();//очищаем гистограмму

            for (int i = 0; i < countR; i++)//для кажой степени
                chart1.Series.Add("n = " + (Math.Pow(10, startR + i)).ToString());//заполняем названия серий-итераций

            for (int i = 0; i < countR; i++)//для каждой степени
            {
                double Y = 0, N = 0;//счетчики произошло/непроизошло
                for (int j = 0; j < Math.Pow(10, startR + i); j++)//пробегаем от 0 до 10 в степени ***
                    if (randomEvent(PA, R.NextDouble()) == 1) //если метод выдает 1
                        Y++; //увеличиваем счетчик "произошло"
                    else//иначе
                        N++; //увеличиваем счетчик "непроизошло"

                //Math.Pow(10, startR + i) является общим числом попытки генерации события
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("A", Y / Math.Pow(10, startR + i));//указываем процент "произошедших" в гистограмме
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("!A", N / Math.Pow(10, startR + i));//указываем процент "непроизошедших" в гистограмме
                //переходим к следующей степени
            }
        }

        public void complexEventStat()
        {
            double PA = Convert.ToDouble(textBox1.Text);
            double PB = Convert.ToDouble(textBox2.Text);

            chart1.Series.Clear();

            for (int i = 0; i < countR; i++)
                chart1.Series.Add("n = " + (Math.Pow(10, startR + i)).ToString());

            for (int i = 0; i < countR; i++)
            {
                double YY = 0, YN = 0, NY = 0, NN = 0;
                for (int j = 0; j < Math.Pow(10, startR + i); j++)
                    switch (complexEvent(PA, PB, R.NextDouble(), R.NextDouble()))
                    {
                        case 0:
                            NN++;
                            break;
                        case 1:
                            NY++;
                            break;
                        case 2:
                            YN++;
                            break;
                        case 3:
                            YY++;
                            break;
                    }
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("AB", YY / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("A!B", YN / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("!AB", NY / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("!A!B", NN / Math.Pow(10, startR + i));
            }
        }

        public void complexFromDependentStat()
        {
            double PA = Convert.ToDouble(textBox1.Text);
            double PB = Convert.ToDouble(textBox2.Text);
            double PBA = Convert.ToDouble(textBox3.Text);

            chart1.Series.Clear();

            for (int i = 0; i < countR; i++)
                chart1.Series.Add("n = " + (Math.Pow(10, startR + i)).ToString());

            for (int i = 0; i < countR; i++)
            {
                double YY = 0, YN = 0, NY = 0, NN = 0;
                for (int j = 0; j < Math.Pow(10, startR + i); j++)
                {
                    int result = complexFromDependent(PA, PB, PBA, R.NextDouble(), R.NextDouble());
                    switch (result)
                    {
                        case 0:
                            NN++;
                            break;
                        case 1:
                            NY++;
                            break;
                        case 2:
                            YN++;
                            break;
                        case 3:
                            YY++;
                            break;
                    }
                }
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("AB", YY / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("A!B", YN / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("!AB", NY / Math.Pow(10, startR + i));
                chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY("!A!B", NN / Math.Pow(10, startR + i));
            }
        }

        public void fullGroupStat()
        {
            List<double> PS = new List<double>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                PS.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));

            chart1.Series.Clear();

            for (int i = 0; i < countR; i++)
                chart1.Series.Add("n = " + (Math.Pow(10, startR + i)).ToString());

            for (int i = 0; i < countR; i++)
            {
                double[] results = new double[dataGridView1.Rows.Count - 1];
                for (int j = 0; j < results.Length; j++)
                    results[j] = 0;
                for (int j = 0; j < Math.Pow(10, startR + i); j++)
                {
                    int result = fullGroup(PS, R.NextDouble());
                    if (result != -1)
                        results[result]++;
                }

                for (int j = 0; j < results.Length; j++)
                    chart1.Series["n = " + (Math.Pow(10, startR + i)).ToString()].Points.AddXY(dataGridView1.Rows[j].Cells[0].Value.ToString(), results[j] / Math.Pow(10, startR + i));
            }
        }
        //-------------------------------------------------------

        //Установка через меню "Режима"
        private void имитацияСлучайногоСобытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = 0;
            RefrashMode();
        }

        private void имитацияСложногоСобытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = 1;
            RefrashMode();
        }

        private void имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = 2;
            RefrashMode();
        }

        private void имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = 3;
            RefrashMode();
        }


        //Кнопка "Генерация"
        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case 0:
                    randomEventGen();
                    break;
                case 1:
                    complexEventGen();
                    break;
                case 2:
                    complexFromDependentGen();
                    break;
                case 3:
                    fullGroupGen();
                    break;
            }
        }
        //Кнопка "Статистика"
        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case 0:
                    randomEventStat();
                    break;
                case 1:
                    complexEventStat();
                    break;
                case 2:
                    complexFromDependentStat();
                    break;
                case 3:
                    fullGroupStat();
                    break;
            }
            chart1.Refresh();
        }
        
    }
}
