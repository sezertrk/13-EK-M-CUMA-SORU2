using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aps = int.Parse(textBox1.Text);
            int ds = int.Parse(textBox2.Text);
            int ks = int.Parse(textBox3.Text);
            int tur = int.Parse(textBox4.Text);
            int toplam = 0;

            switch (tur)
            {
                case 1:
                    {
                        for (int i = 0; i < aps; i++)
                        {
                            for (int j = 0; j < ds; j++)
                            {
                                for (int k = 0; k < ks; k++)
                                {
                                    toplam = toplam + 20;
                                    textBox5.Text = toplam.ToString();
                                }
                            }
                        } break;
                    }
                case 2:
                    {
                        for (int i = 0; i < aps; i++)
                        {
                            for (int j = 0; j < ds; j++)
                            {
                                for (int k = 0; k < ks; k++)
                                {
                                    toplam = toplam + 50;
                                    textBox5.Text = toplam.ToString();
                                }
                            }
                        } break;
                    }
                case 3:
                    {
                        for (int i = 0; i < aps; i++)
                        {
                            for (int j = 0; j < ds; j++)
                            {
                                for (int k = 0; k < ks; k++)
                                {
                                    toplam = toplam + 100;
                                    textBox5.Text = toplam.ToString();
                                }
                            }
                        } break;
                    }
                default: MessageBox .Show ("Hatalı Kod");
                    break;
                    
            }













        }
    }
}
