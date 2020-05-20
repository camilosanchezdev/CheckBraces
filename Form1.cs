using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Braces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List list1;
            list1 = new List();
            string checkBraces = textBox1.Text;
            for (int i = 0; i < checkBraces.Length; i++)
            {
                if (checkBraces.ElementAt(i) == '(' || checkBraces.ElementAt(i) == '[' || checkBraces.ElementAt(i) == '{')
                {
                    list1.Insert(checkBraces.ElementAt(i));
                }
                else
                {
                    if (checkBraces.ElementAt(i) == ')')
                    {
                        if (list1.Extract() != '(')
                        {
                            MessageBox.Show("Incorrect!");
                            return;
                        }
                    }
                    else
                    {
                        if (checkBraces.ElementAt(i) == ']')
                        {
                            if (list1.Extract() != '[')
                            {
                                MessageBox.Show("Incorrect!");
                                return;
                            }
                        }
                        else
                        {
                            if (checkBraces.ElementAt(i) == '}')
                            {
                                if (list1.Extract() != '{')
                                {
                                    MessageBox.Show("Incorrect!");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (list1.Empty())
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            
        }
    }
}
