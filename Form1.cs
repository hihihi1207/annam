using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 숫자
        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                if (tbox_first.Text == "")
                {
                    return;
                }
                else
                {
                    tbox_first.Text += "0";
                }
            }
            else
            {
                if (tbox_second.Text == "")
                {
                    return;
                }
                else
                {
                    tbox_second.Text += "0";
                }
            }
        }
        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "3";
            }
            else
            {
                tbox_second.Text += "3";
            }
        }
        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "2";
            }
            else
            {
                tbox_second.Text += "2";
            }
        }
        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "1";
            }
            else
            {
                tbox_second.Text += "1";
            }
        }
        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "6";
            }
            else
            {
                tbox_second.Text += "6";
            }
        }
        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "5";
            }
            else
            {
                tbox_second.Text += "5";
            }
        }
        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "4";
            }
            else
            {
                tbox_second.Text += "4";
            }
        }
        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "9";
            }
            else
            {
                tbox_second.Text += "9";
            }
        }
        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "8";
            }
            else
            {
                tbox_second.Text += "8";
            }
        }
        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                tbox_first.Text += "7";
            }
            else
            {
                tbox_second.Text += "7";
            }
        }


        #endregion

        #region 그외
        private void Btn_c_Click(object sender, EventArgs e)
        {
            tbox_first.Text = "";
            tbox_second.Text = "";
            tbox_sign.Text = "";
            tbox_rlt.Text = "";
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            if (tbox_sign.Text == "")
            {
                if (tbox_first.Text == "")
                {
                    tbox_first.Text = "0.1";
                }
                else
                {
                    tbox_first.Text += ".";
                }
            }
            else
            {
                if (tbox_second.Text == "")
                {
                    tbox_second.Text = "0.1";
                }
                else
                {
                    tbox_second.Text += ".";
                }
            }
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            tbox_sign.Text = "+";
        }
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            tbox_sign.Text = "-";
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (tbox_second.Text == "")
            {
                if (tbox_sign.Text == "")
                {
                    string str = tbox_first.Text;
                    tbox_first.Text = str.Substring(0, str.Length - 1);
                }
                else
                {
                    tbox_sign.Text = "";
                }
            }
            else
            {
                string str = tbox_second.Text;
                tbox_second.Text = str.Substring(0, str.Length - 1);
            }
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            tbox_sign.Text = "➗";
        }

        #endregion

        #region 결과
        private void Btn_Rlt_Click(object sender, EventArgs e)
        {
            double first = double.Parse(tbox_first.Text);
            double second = double.Parse(tbox_second.Text);
            if (tbox_sign.Text == "+")
            {
                tbox_rlt.Text = (first + second).ToString();
            }
            else if (tbox_sign.Text == "-")
            {
                tbox_rlt.Text = (first - second).ToString();
            }
            else if (tbox_sign.Text == "➗")
            {
                tbox_rlt.Text = (first / second).ToString();
            }
        }
        #endregion

    }
}
