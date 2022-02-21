namespace TemperatureCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConvertCtoF = new System.Windows.Forms.Button();
            this.buttonConvertFtoC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConvertCtoF
            // 
            this.buttonConvertCtoF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvertCtoF.Location = new System.Drawing.Point(417, 45);
            this.buttonConvertCtoF.Name = "buttonConvertCtoF";
            this.buttonConvertCtoF.Size = new System.Drawing.Size(97, 38);
            this.buttonConvertCtoF.TabIndex = 0;
            this.buttonConvertCtoF.Text = "C to F";
            this.buttonConvertCtoF.UseVisualStyleBackColor = true;
            this.buttonConvertCtoF.Click += new System.EventHandler(this.buttonConvertCtoF_Click);
            // 
            // buttonConvertFtoC
            // 
            this.buttonConvertFtoC.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvertFtoC.Location = new System.Drawing.Point(417, 90);
            this.buttonConvertFtoC.Name = "buttonConvertFtoC";
            this.buttonConvertFtoC.Size = new System.Drawing.Size(97, 41);
            this.buttonConvertFtoC.TabIndex = 1;
            this.buttonConvertFtoC.Text = "F to C";
            this.buttonConvertFtoC.UseVisualStyleBackColor = true;
            this.buttonConvertFtoC.Click += new System.EventHandler(this.buttonConvertFtoC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "F";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(163, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxC.Location = new System.Drawing.Point(163, 49);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(248, 34);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxF
            // 
            this.textBoxF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxF.Location = new System.Drawing.Point(163, 93);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(248, 34);
            this.textBoxF.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvertFtoC);
            this.Controls.Add(this.buttonConvertCtoF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConvertCtoF;
        private Button buttonConvertFtoC;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textBoxC;
        private TextBox textBoxF;
    }
}