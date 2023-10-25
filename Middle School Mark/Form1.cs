using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Middle_School_Mark
{
    public partial class Form1 : Form
    {

        List<byte> mark = new List<byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void add_mark(byte m)
        {
            mark.Add(m);
            Marks.Text = Marks.Text + m + ", ";
            float pluss = 0;

            for (int i = 0; i < mark.Count; i++)
            {
                pluss = pluss + mark[i];
            }

            label2.Text = Convert.ToString(Math.Round(pluss / mark.Count, 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_mark(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_mark(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_mark(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_mark(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mark.Clear();
            Marks.Text = "";
            label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Marks.Text != "")
            {
                Marks.Text = Marks.Text.Remove(Marks.Text.Length - 3);


                mark.Remove(mark.Last());

                float pluss = 0;

                for (int i = 0; i < mark.Count; i++)
                {
                    pluss = pluss + mark[i];
                }

                label2.Text = Convert.ToString(Math.Round(pluss / mark.Count, 2));

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '2':
                    button4.PerformClick();
                    break;
                case '3':
                    button3.PerformClick();
                    break;
                case '4':
                    button2.PerformClick();
                    break;
                case '5':
                    button1.PerformClick();
                    break;
                case (char)Keys.Back:
                    button6.PerformClick();
                    break;

            }
        }
    }
}
