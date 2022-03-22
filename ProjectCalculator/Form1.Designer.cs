
namespace ProjectCalculator
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dsplyBox = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.txtSign);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btnMulti);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dsplyBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 716);
            this.panel1.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(10, 73);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(591, 42);
            this.txtValue.TabIndex = 18;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSign.Location = new System.Drawing.Point(607, 73);
            this.txtSign.Multiline = true;
            this.txtSign.Name = "txtSign";
            this.txtSign.ReadOnly = true;
            this.txtSign.Size = new System.Drawing.Size(27, 42);
            this.txtSign.TabIndex = 17;
            this.txtSign.Text = "0";
            this.txtSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiv.Location = new System.Drawing.Point(400, 579);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(115, 66);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.Control;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMulti.Location = new System.Drawing.Point(400, 486);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(115, 66);
            this.btnMulti.TabIndex = 15;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinus.Location = new System.Drawing.Point(400, 391);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(115, 66);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlus.Location = new System.Drawing.Point(400, 297);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(115, 66);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.Control;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDot.Location = new System.Drawing.Point(10, 579);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(115, 66);
            this.btnDot.TabIndex = 12;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(270, 579);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(115, 66);
            this.button11.TabIndex = 11;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZero.Location = new System.Drawing.Point(140, 579);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(115, 66);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(270, 486);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 66);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(140, 486);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 66);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(10, 486);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 66);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(270, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(140, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(10, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(270, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(140, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(10, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsplyBox
            // 
            this.dsplyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dsplyBox.Location = new System.Drawing.Point(10, 121);
            this.dsplyBox.Multiline = true;
            this.dsplyBox.Name = "dsplyBox";
            this.dsplyBox.ReadOnly = true;
            this.dsplyBox.Size = new System.Drawing.Size(624, 154);
            this.dsplyBox.TabIndex = 0;
            this.dsplyBox.Text = "0";
            this.dsplyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(530, 297);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 160);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(530, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 160);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "AC";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 718);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "mainForm";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dsplyBox;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
    }
}

