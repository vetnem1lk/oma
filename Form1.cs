using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double R, U, I;

        private void Form1_Load(object sender, EventArgs e)
        {
            labelR.Enabled = false;
            labelU.Enabled = false;
            labelI.Enabled = false;
            label6.Enabled = false;
            txtI.Enabled = false;
            txtU.Enabled = false;
            txtR.Enabled = false;
            button1.Enabled = false;
        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxR.Checked)
            {
                labelU.Enabled = true;
                labelI.Enabled = true;
                label6.Enabled = true;
                txtI.Enabled = true;
                txtU.Enabled = true;
                checkBoxU.Enabled = false;
                checkBoxI.Enabled = false;
                label4.Enabled = false;
            }
            else
            {
                labelU.Enabled = false;
                labelI.Enabled = false;
                label6.Enabled = false;
                txtI.Enabled = false;
                txtU.Enabled = false;
                checkBoxU.Enabled = true;
                checkBoxI.Enabled = true;
                label4.Enabled = true;
                ClearFields();
            }
        }

        private void checkBoxU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxU.Checked)
            {
                labelR.Enabled = true;
                labelI.Enabled = true;
                label6.Enabled = true;
                txtI.Enabled = true;
                txtR.Enabled = true;
                checkBoxR.Enabled = false;
                checkBoxI.Enabled = false; 
                label4.Enabled = false;
            }
            else
            {
                labelR.Enabled = false;
                labelI.Enabled = false;
                label6.Enabled = false;
                txtI.Enabled = false;
                txtR.Enabled = false;
                checkBoxR.Enabled = true;
                checkBoxI.Enabled = true;
                label4.Enabled = true;
                ClearFields();
            }
        }

        private void checkBoxI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxI.Checked)
            {
                labelR.Enabled = true;
                labelU.Enabled = true;
                label6.Enabled = true;
                txtU.Enabled = true;
                txtR.Enabled = true;
                checkBoxR.Enabled = false;
                checkBoxU.Enabled = false;
                label4.Enabled = false;
            }
            else
            {
                labelR.Enabled = false;
                labelU.Enabled = false;
                label6.Enabled = false;
                txtU.Enabled = false;
                txtR.Enabled = false;
                checkBoxR.Enabled = true;
                checkBoxU.Enabled = true;
                label4.Enabled = true;
                ClearFields();
            }
        }

        private void EmptyString()
        {
            if (txtU.TextLength == 0)
                txtU.BackColor = Color.Snow;

            if (txtR.TextLength == 0)
                txtR.BackColor = Color.Snow;

            if (txtI.TextLength == 0)
                txtI.BackColor = Color.Snow;
        }

        private void ClearFields()
        {
            txtI.Text = string.Empty;
            txtU.Text = string.Empty;
            txtR.Text = string.Empty;
            txtAnswer.Text = string.Empty;
            txtIntAsw.Text = string.Empty;
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (txtU.TextLength > 0)
            {
                try
                {
                    U = Convert.ToDouble(txtU.Text);
                    txtU.BackColor = Color.White;
                }
                catch
                {
                    txtU.BackColor = Color.Red;
                }
            }

            if (checkBoxR.Checked && txtU.BackColor == Color.White && txtI.BackColor == Color.White)
                button1.Enabled = true;
            else if (checkBoxI.Checked && txtU.BackColor == Color.White && txtR.BackColor == Color.White)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (txtI.TextLength > 0)
            {
                try
                {
                    I = Convert.ToDouble(txtI.Text);
                    txtI.BackColor = Color.White;
                }
                catch
                {
                    txtI.BackColor = Color.Red;
                }
            }

            if (checkBoxR.Checked && txtU.BackColor == Color.White && txtI.BackColor == Color.White)
                button1.Enabled = true;
            else if (checkBoxU.Checked && txtI.BackColor == Color.White && txtR.BackColor == Color.White)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            EmptyString();

            if (txtR.TextLength > 0)
            {
                try
                {
                    R = Convert.ToDouble(txtR.Text);
                    txtR.BackColor = Color.White;
                }
                catch
                {
                    txtR.BackColor = Color.Red;
                }
            }

            if (checkBoxI.Checked && txtU.BackColor == Color.White && txtR.BackColor == Color.White)
                button1.Enabled = true;
            else if (checkBoxU.Checked && txtI.BackColor == Color.White && txtR.BackColor == Color.White)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxR.Checked)
            {
                R = U / I;
                txtAnswer.Text = "R - Сопротивление равно:";
                txtIntAsw.Text = Convert.ToString(R);
            }
            if (checkBoxI.Checked)
            {
                I = U / R;
                txtAnswer.Text = "I - Сила тока равна:";
                txtIntAsw.Text = Convert.ToString(I);
            }
            if (checkBoxU.Checked)
            {
                U = I * R;
                txtAnswer.Text = "U - Напряжение равняется:";
                txtIntAsw.Text = Convert.ToString(U);
            }
        }     
    }
}
