﻿namespace データベースお試し用
{
    partial class Form4
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
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BudgetBtn = new System.Windows.Forms.Button();
            this.PercentageLbl = new System.Windows.Forms.Label();
            this.UserateLbl = new System.Windows.Forms.Label();
            this.MoneyLbl = new System.Windows.Forms.Label();

            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTotal = new System.Windows.Forms.Button();
            this.CommentLbl = new System.Windows.Forms.Label();
            this.CommenTxt = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ThismonthLbl = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.csvBtn = new System.Windows.Forms.Button();

            this.categoryDialogBtn = new System.Windows.Forms.Button();

            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(605, 69);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 40;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(97, 198);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(16, 198);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 38;
            this.buttonChange.Text = "変更";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(282, 114);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 19);
            this.textBox10.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "接続";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.BudgetBtn);
            this.tabPage3.Controls.Add(this.PercentageLbl);
            this.tabPage3.Controls.Add(this.UserateLbl);
            this.tabPage3.Controls.Add(this.MoneyLbl);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.btnTotal);
            this.tabPage3.Controls.Add(this.CommentLbl);
            this.tabPage3.Controls.Add(this.CommenTxt);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.ThismonthLbl);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(663, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "集計表示";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // BudgetBtn
            // 
            this.BudgetBtn.Location = new System.Drawing.Point(86, 166);
            this.BudgetBtn.Name = "BudgetBtn";
            this.BudgetBtn.Size = new System.Drawing.Size(79, 23);
            this.BudgetBtn.TabIndex = 52;
            this.BudgetBtn.Text = "登録";
            this.BudgetBtn.UseVisualStyleBackColor = true;
            this.BudgetBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PercentageLbl
            // 
            this.PercentageLbl.AutoSize = true;
            this.PercentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.PercentageLbl.Location = new System.Drawing.Point(152, 77);
            this.PercentageLbl.Name = "PercentageLbl";
            this.PercentageLbl.Size = new System.Drawing.Size(29, 12);
            this.PercentageLbl.TabIndex = 51;
            this.PercentageLbl.Text = "00％";
            this.PercentageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserateLbl
            // 
            this.UserateLbl.AutoSize = true;
            this.UserateLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserateLbl.Location = new System.Drawing.Point(22, 48);
            this.UserateLbl.Name = "UserateLbl";
            this.UserateLbl.Size = new System.Drawing.Size(65, 12);
            this.UserateLbl.TabIndex = 50;
            this.UserateLbl.Text = "予算使用率";
            this.UserateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLbl.Location = new System.Drawing.Point(154, 26);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(17, 12);
            this.MoneyLbl.TabIndex = 49;
            this.MoneyLbl.Text = "円";
            this.MoneyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(124, 26);
            this.progressBar1.TabIndex = 48;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(24, 195);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(141, 23);
            this.btnTotal.TabIndex = 48;
            this.btnTotal.Text = "月別集計";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // CommentLbl
            // 
            this.CommentLbl.AutoSize = true;
            this.CommentLbl.Location = new System.Drawing.Point(22, 97);
            this.CommentLbl.Name = "CommentLbl";
            this.CommentLbl.Size = new System.Drawing.Size(38, 12);
            this.CommentLbl.TabIndex = 31;
            this.CommentLbl.Text = "コメント";
            this.CommentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommenTxt
            // 
            this.CommenTxt.Location = new System.Drawing.Point(27, 114);
            this.CommenTxt.Multiline = true;
            this.CommenTxt.Name = "CommenTxt";
            this.CommenTxt.Size = new System.Drawing.Size(138, 45);
            this.CommenTxt.TabIndex = 30;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(85, 22);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(66, 19);
            this.textBox11.TabIndex = 27;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // ThismonthLbl
            // 
            this.ThismonthLbl.AutoSize = true;
            this.ThismonthLbl.BackColor = System.Drawing.Color.Transparent;
            this.ThismonthLbl.Location = new System.Drawing.Point(22, 25);
            this.ThismonthLbl.Name = "ThismonthLbl";
            this.ThismonthLbl.Size = new System.Drawing.Size(63, 12);
            this.ThismonthLbl.TabIndex = 28;
            this.ThismonthLbl.Text = "00月の予算";
            this.ThismonthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.LightGray;
            this.listView3.Location = new System.Drawing.Point(192, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(471, 234);
            this.listView3.TabIndex = 26;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.buttonChange);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "一覧表示";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "チェックした項目を";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 19);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 19);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 19);
            this.textBox3.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(51, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 19);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Value = new System.DateTime(2015, 10, 28, 15, 24, 45, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "備考";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "登録";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "金額";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "日付";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "品名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "分類";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.LightGray;
            this.listView2.ForeColor = System.Drawing.Color.Maroon;
            this.listView2.Location = new System.Drawing.Point(192, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(471, 234);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 260);
            this.tabControl1.TabIndex = 41;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(708, 24);
            this.mainMenu.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "家計簿アプリ";
            // 
            // csvBtn
            // 
            this.csvBtn.Location = new System.Drawing.Point(401, 69);
            this.csvBtn.Name = "csvBtn";
            this.csvBtn.Size = new System.Drawing.Size(119, 23);
            this.csvBtn.TabIndex = 46;
            this.csvBtn.Text = "CSV出力";
            this.csvBtn.UseVisualStyleBackColor = true;
            this.csvBtn.Click += new System.EventHandler(this.csvBtn_Click);
            // 

            // categoryDialogBtn
            // 
            this.categoryDialogBtn.Location = new System.Drawing.Point(484, 37);
            this.categoryDialogBtn.Name = "categoryDialogBtn";
            this.categoryDialogBtn.Size = new System.Drawing.Size(156, 26);
            this.categoryDialogBtn.TabIndex = 48;
            this.categoryDialogBtn.Text = "分類管理";
            this.categoryDialogBtn.UseVisualStyleBackColor = true;
            this.categoryDialogBtn.Click += new System.EventHandler(this.categoryDialogBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.categoryDialogBtn);
            this.Controls.Add(this.csvBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox10);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label CommentLbl;
        private System.Windows.Forms.TextBox CommenTxt;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label ThismonthLbl;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button csvBtn;
        private System.Windows.Forms.Button btnTotal;

        private System.Windows.Forms.Button categoryDialogBtn;
        private System.Windows.Forms.Label MoneyLbl;

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label PercentageLbl;
        private System.Windows.Forms.Label UserateLbl;
        private System.Windows.Forms.Button BudgetBtn;
    }
}