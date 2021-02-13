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
            txtI.Enabled = false;
            txtU.Enabled = false;
            txtR.Enabled = false;

        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxR.Checked)
            {
                labelU.Enabled = true;
                labelI.Enabled = true;
                txtI.Enabled = true;
                txtU.Enabled = true;
                checkBoxU.Enabled = false;
                checkBoxI.Enabled = false;
            }
            if (!checkBoxR.Checked)
            {
                labelU.Enabled = false;
                labelI.Enabled = false;
                txtI.Enabled = false;
                txtU.Enabled = false;
                checkBoxU.Enabled = true;
                checkBoxI.Enabled = true;
                txtI.Text = string.Empty;
                txtU.Text = string.Empty;
                txtR.Text = string.Empty;
            }
        }

        private void checkBoxU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxU.Checked)
            {
                labelR.Enabled = true;
                labelI.Enabled = true;
                txtI.Enabled = true;
                txtR.Enabled = true;
                checkBoxR.Enabled = false;
                checkBoxI.Enabled = false;
            }
            if (!checkBoxU.Checked)
            {
                labelR.Enabled = false;
                labelI.Enabled = false;
                txtI.Enabled = false;
                txtR.Enabled = false;
                checkBoxR.Enabled = true;
                checkBoxI.Enabled = true;
                txtI.Text = string.Empty;
                txtU.Text = string.Empty;
                txtR.Text = string.Empty;
            }
        }

        private void checkBoxI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxI.Checked)
            {
                labelR.Enabled = true;
                labelU.Enabled = true;
                txtU.Enabled = true;
                txtR.Enabled = true;
                checkBoxR.Enabled = false;
                checkBoxU.Enabled = false;
            }
            if (!checkBoxI.Checked)
            {
                labelR.Enabled = false;
                labelU.Enabled = false;
                txtU.Enabled = false;
                txtR.Enabled = false;
                checkBoxR.Enabled = true;
                checkBoxU.Enabled = true;
                txtI.Text = string.Empty;
                txtU.Text = string.Empty;
                txtR.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxR.Checked)
            {
                txtAnswer.Text = "R - Сопротивление равно:";
                try
                {
                    U = Convert.ToDouble(txtU.Text);
                    I = Convert.ToDouble(txtI.Text);
                }
                catch 
                {
                    txtAnswer.Text = "Попробуйте заново!";
                    txtIntAsw.Text = string.Empty;
                    MessageBox.Show("Введите цифровые значения!", "Ошибка!");
                    return;
                }
                R = U / I;
                txtIntAsw.Text = Convert.ToString(R);
            }
            if (checkBoxI.Checked)
            {
                txtAnswer.Text = "I - Сила тока равна:";
                try
                {
                    U = Convert.ToDouble(txtU.Text);
                    R = Convert.ToDouble(txtR.Text);
                }
                catch
                {
                    txtAnswer.Text = "Попробуйте заново!";
                    txtIntAsw.Text = string.Empty;
                    MessageBox.Show("Введите цифровые значения!", "Ошибка!");
                    return;

                }
                I = U / R;
                txtIntAsw.Text = Convert.ToString(I);
            }
            if (checkBoxU.Checked)
            {
                txtAnswer.Text = "U - Напряжение равняется:";
                try
                {
                    I = Convert.ToDouble(txtI.Text);
                    R = Convert.ToDouble(txtR.Text);
                }
                catch
                {
                    txtAnswer.Text = "Попробуйте заново!";
                    txtIntAsw.Text = string.Empty;
                    MessageBox.Show("Введите цифровые значения!", "Ошибка!");
                    return;
                }
                U = I * R;
                txtIntAsw.Text = Convert.ToString(U);
            }
        }
    }
}
