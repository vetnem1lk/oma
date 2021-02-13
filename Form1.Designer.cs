
namespace Oma
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.checkBoxU = new System.Windows.Forms.CheckBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.labelU = new System.Windows.Forms.Label();
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.labelI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtIntAsw = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Закон Ома";
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxR.Location = new System.Drawing.Point(15, 212);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(173, 24);
            this.checkBoxR.TabIndex = 1;
            this.checkBoxR.Text = "R - Сопротивление";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // checkBoxU
            // 
            this.checkBoxU.AutoSize = true;
            this.checkBoxU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxU.Location = new System.Drawing.Point(18, 160);
            this.checkBoxU.Name = "checkBoxU";
            this.checkBoxU.Size = new System.Drawing.Size(148, 24);
            this.checkBoxU.TabIndex = 3;
            this.checkBoxU.Text = "U - Напряжение";
            this.checkBoxU.UseVisualStyleBackColor = true;
            this.checkBoxU.CheckedChanged += new System.EventHandler(this.checkBoxU_CheckedChanged);
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxI.Location = new System.Drawing.Point(18, 264);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(124, 24);
            this.checkBoxI.TabIndex = 5;
            this.checkBoxI.Text = "I - Сила тока";
            this.checkBoxI.UseVisualStyleBackColor = true;
            this.checkBoxI.CheckedChanged += new System.EventHandler(this.checkBoxI_CheckedChanged);
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelU.Location = new System.Drawing.Point(275, 135);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(133, 20);
            this.labelU.TabIndex = 7;
            this.labelU.Text = "U - Напряжение ";
            // 
            // txtU
            // 
            this.txtU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtU.Location = new System.Drawing.Point(279, 158);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(126, 26);
            this.txtU.TabIndex = 8;
            this.txtU.TextChanged += new System.EventHandler(this.txtU_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtR.Location = new System.Drawing.Point(279, 210);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(126, 26);
            this.txtR.TabIndex = 10;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(275, 187);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(158, 20);
            this.labelR.TabIndex = 9;
            this.labelR.Text = "R - Сопротивление ";
            // 
            // textBox6
            // 
            this.textBox6.AcceptsReturn = true;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(12, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(702, 26);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Вычисление силы тока, сопротивления или напряжения по закону Ома.";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Что хотите найти?";
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtI.Location = new System.Drawing.Point(279, 262);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(126, 26);
            this.txtI.TabIndex = 15;
            this.txtI.TextChanged += new System.EventHandler(this.txtI_TextChanged);
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelI.Location = new System.Drawing.Point(275, 239);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(113, 20);
            this.labelI.TabIndex = 14;
            this.labelI.Text = "I - Сила тока  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(230, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите открывшиеся поля:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(279, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.Location = new System.Drawing.Point(427, 158);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(287, 22);
            this.txtAnswer.TabIndex = 18;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIntAsw
            // 
            this.txtIntAsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntAsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIntAsw.Location = new System.Drawing.Point(427, 214);
            this.txtIntAsw.Name = "txtIntAsw";
            this.txtIntAsw.ReadOnly = true;
            this.txtIntAsw.Size = new System.Drawing.Size(287, 22);
            this.txtIntAsw.TabIndex = 19;
            this.txtIntAsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 2);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIntAsw);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.labelU);
            this.Controls.Add(this.checkBoxI);
            this.Controls.Add(this.checkBoxU);
            this.Controls.Add(this.checkBoxR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закон Ома";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxU;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtIntAsw;
        private System.Windows.Forms.Panel panel1;
    }
}

