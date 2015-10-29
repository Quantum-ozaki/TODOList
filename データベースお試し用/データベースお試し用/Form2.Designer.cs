namespace データベースお試し用
{
    partial class Form2
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
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxS
            // 
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Location = new System.Drawing.Point(12, 16);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(63, 20);
            this.comboBoxS.TabIndex = 9;
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(12, 67);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(155, 19);
            this.textBoxS2.TabIndex = 8;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(12, 42);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(155, 19);
            this.textBoxS.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "修正";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBoxS);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.textBoxS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Button button5;
       internal string important;
        private System.Windows.Forms.Label label1;

        public int ID { get; internal set; }
        public int Dated { get; internal set; }
    }
}