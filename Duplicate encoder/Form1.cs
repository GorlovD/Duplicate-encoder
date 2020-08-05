using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                int j = i + 1;
                while (j < str.Length)
                {
                    if (str[i] == str[j])
                    {
                        str = str.Replace(str[i].ToString(), ")");
                    }
                    j++;
                }
            }
            for (int i = 0; i < str.Length; i++)
                if (str[i].ToString() != ")")
                {
                    str = str.Replace(str[i].ToString(), "(");
                }

            label2.Text = str;

        }

        }
    }

