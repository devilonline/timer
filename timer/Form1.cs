using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        private int TotalSeconds;

        public Form1()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TotalSeconds > 0)

            {
                TotalSeconds--;
                int minutes = TotalSeconds / 60;
                int seconds = TotalSeconds - (minutes * 60);
                this.label1.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else

            {
                this.timer1.Stop();
                MessageBox.Show("fim");
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 61; i++)
            {
                this.comboBox1.Items.Add(i.ToString("D2"));
                this.comboBox2.Items.Add(i.ToString("D2"));


            }

            string minutos = ConfigurationManager.AppSettings["minutos"];
            string segundos = ConfigurationManager.AppSettings["segundos"];

            //label3.Text = minutos;


            this.comboBox1.SelectedIndex = Int32.Parse(minutos);
            this.comboBox2.SelectedIndex = Int32.Parse(segundos);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());
            TotalSeconds = (minutes * 60) + seconds;

            this.timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //add_time = TotalSeconds.AddMinutes(2);
        }
    }
}
