using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Components;
using WindowsFormsApp1.Conditions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Pizza pizza1 = new Italian();
        Pizza pizza2 = new Sicilian();
        Pizza pizza3 = new Hawaiian();
        Pizza pizza4 = new Margarita();
        Pizza pizza5 = new Calzone();
        int Buf = 0;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "3";
            textBox3.Text = "4";
            textBox4.Text = "5";
            textBox5.Text = "1";
            textBox6.Text = "2";
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "5";
                textBox8.Text = $"{pizza1.getDescription()}";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "6";
                textBox8.Text = $"{pizza2.getDescription()}";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "7";
                textBox8.Text = $"{pizza3.getDescription()}";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "8";
                textBox8.Text = $"{pizza4.getDescription()}";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "9";
                textBox8.Text = $"{pizza5.getDescription()}";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buf = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            pizza1 = new Cheese(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox2.SelectedIndex == 1&Buf==0)
                        {
                            
                            pizza1 = new Cheese(pizza1);
                            pizza1 = new Cheese(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                        else if (comboBox2.SelectedIndex == 1&Buf==1)
                        {
                          
                            pizza1 = new Cheese(pizza1);

                            textBox8.Text = $"{pizza1.getDescription()}";
                        }

                    }
                    break;

               case 1:
                {

                        if (comboBox2.SelectedIndex == 1)
                        {
                            pizza2 = new Cheese(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox2.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza2 = new Cheese(pizza2);
                            pizza2 = new Cheese(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                        else if (comboBox2.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza2 = new Cheese(pizza2);

                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                    }
              break;

                case 2:
                    {

                        if (comboBox2.SelectedIndex == 0)
                        {
                            pizza3 = new Cheese(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            pizza3 = new Cheese(new Cheese(new Hawaiian()));
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            pizza3 = new Cheese(new Cheese(new Cheese(new Hawaiian())));
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                    }
                    break;
            }
        }

        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buf = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            pizza1 = new Bacon(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 0)
                        {
                           
                            pizza1 = new Bacon(pizza1);
                            pizza1 = new Bacon(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 1)
                        {
                            MessageBox.Show(Buf.ToString());
                            pizza1 = new Bacon(pizza1);

                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                    }
                    break;

                case 1:
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            pizza2 = new Bacon(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 0)
                        {
                           
                            pizza2 = new Bacon(pizza2);
                            pizza2 = new Bacon(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza2 = new Bacon(pizza2);

                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                    }
                    break;

                case 2:
                    {

                        if (comboBox3.SelectedIndex == 0)
                        {
                            pizza3 = new Bacon(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza3 = new Bacon(pizza3);
                            pizza3 = new Bacon(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox3.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza3 = new Bacon(pizza3);

                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                    }
                    break;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buf = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBox4.SelectedIndex == 0)
                        {
                            pizza1 = new Chicken(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza1 = new Chicken(pizza1);
                            pizza1 = new Chicken(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza1 = new Chicken(pizza1);

                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                    }
                    break;

                case 1:
                    {
                        if (comboBox4.SelectedIndex == 0)
                        {
                            pizza2 = new Chicken(pizza2);
                            textBox8.Text = $"{pizza3.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza2 = new Chicken(pizza2);
                            pizza2 = new Chicken(pizza2);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza2 = new Chicken(pizza2);

                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                    }
                    break;

                case 2:
                    {

                        if (comboBox4.SelectedIndex == 0)
                        {
                            pizza3 = new Chicken(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza3 = new Chicken(pizza3);
                            pizza3 = new Chicken(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox4.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza3 = new Chicken(pizza3);

                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                    }
                    break;
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buf = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBox5.SelectedIndex == 0)
                        {
                            pizza1 = new Tomatoes(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza1 = new Tomatoes(pizza1);
                            pizza1 = new Tomatoes(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza1 = new Tomatoes(pizza1);

                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                    }
                    break;

                case 1:
                    {
                        if (comboBox5.SelectedIndex == 0)
                        {
                            pizza2 = new Tomatoes(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza2 = new Tomatoes(pizza2);
                            pizza2 = new Tomatoes(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza2 = new Tomatoes(pizza2);

                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                    }
                    break;

                case 2:
                    {

                        if (comboBox5.SelectedIndex == 0)
                        {
                            pizza3 = new Tomatoes(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza3 = new Tomatoes(pizza3);
                            pizza3 = new Tomatoes(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox5.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza3 = new Tomatoes(pizza3);

                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                    }
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buf = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            pizza1 = new Olives(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza1 = new Olives(pizza1);
                            pizza1 = new Olives(pizza1);
                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza1 = new Olives(pizza1);

                            textBox8.Text = $"{pizza1.getDescription()}";
                        }
                    }
                    break;

                case 1:
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            pizza2 = new Olives(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza2 = new Olives(pizza2);
                            pizza2 = new Olives(pizza2);
                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza2 = new Olives(pizza2);

                            textBox8.Text = $"{pizza2.getDescription()}";
                        }
                    }
                    break;

                case 2:
                    {

                        if (comboBox6.SelectedIndex == 0)
                        {
                            pizza3 = new Olives(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                            Buf++;
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 0)
                        {
                            pizza3 = new Olives(pizza3);
                            pizza3 = new Olives(pizza3);
                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                        else if (comboBox6.SelectedIndex == 1 & Buf == 1)
                        {
                            pizza3 = new Olives(pizza3);

                            textBox8.Text = $"{pizza3.getDescription()}";
                        }
                    }
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Buf = 0;
            textBox8.Text = null;
            textBox7.Text = null;
            pizza1 = new Italian();
            pizza2 = new Sicilian();
            pizza3 = new Hawaiian();
            pizza4 = new Margarita();
            pizza5 = new Calzone();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = Convert.ToInt16(textBox1.Text)+ Convert.ToInt16(textBox2.Text)* Convert.ToInt16(comboBox2.Text)+ Convert.ToInt16(textBox3.Text) * Convert.ToInt16(comboBox3.Text)+ Convert.ToInt16(textBox4.Text) * Convert.ToInt16(comboBox4.Text)+ Convert.ToInt16(textBox5.Text) * Convert.ToInt16(comboBox5.Text)+Convert.ToInt16(textBox6.Text) * Convert.ToInt16(comboBox6.Text);
            textBox7.Text = Sum.ToString();


        }
    }
}
