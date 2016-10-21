using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WindowsPhoneApplication1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btntotal_Click(object sender, RoutedEventArgs e)
        {
            if (textBox3.Text == "div")
            {
                if (textBox4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(textBox2.Text);
                    Decimal b = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = Convert.ToString(a / b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(textBox2.Text);
                    Int16 b = Convert.ToInt16(textBox1.Text);
                    textBox1.Text = Convert.ToString(a / b);
                }

            }
            if (textBox3.Text == "mul")
            {
                if (textBox4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(textBox2.Text);
                    Decimal b = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = Convert.ToString(a * b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(textBox2.Text);
                    Int16 b = Convert.ToInt16(textBox1.Text);
                    textBox1.Text = Convert.ToString(a * b);
                }

            }
            if (textBox3.Text == "sum")
            {
                if (textBox4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(textBox2.Text);
                    Decimal b = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = Convert.ToString(a + b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(textBox2.Text);
                    Int16 b = Convert.ToInt16(textBox1.Text);
                    textBox1.Text = Convert.ToString(a + b);
                }

            }
            if (textBox3.Text == "minus")
            {
                if (textBox4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(textBox2.Text);
                    Decimal b = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = Convert.ToString(a - b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(textBox2.Text);
                    Int16 b = Convert.ToInt16(textBox1.Text);
                    textBox1.Text = Convert.ToString(a - b);
                }

            }
        }
        private void btnone_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void btntwo_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text+"2";
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {

            if (textBox4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            textBox1.Text = "";

            textBox3.Text = "div";
        
        }

        private void btnthree_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnfour_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnfive_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnsix_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnseven_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btneight_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnzero_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btndot_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox4.Text = "dot";
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            textBox1.Text = "";
           
            textBox3.Text = "mul";
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            else
            {

                Int16 a = Convert.ToInt16(textBox1.Text);
                textBox2.Text = Convert.ToString(a);    
            }
            textBox1.Text = "";
            
            textBox3.Text = "sum";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(textBox1.Text);
                textBox2.Text = Convert.ToString(a);
            }
                
            textBox1.Text = "";
            
            textBox3.Text = "minus";
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}