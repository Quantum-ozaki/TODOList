namespace データベースお試し用
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BudgetBtn = new System.Windows.Forms.Button();
            this.PercentageLbl = new System.Windows.Forms.Label();
            this.UserateLbl = new System.Windows.Forms.Label();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.userateBar = new System.Windows.Forms.ProgressBar();
            this.btnTotal = new System.Windows.Forms.Button();
            this.CommentLbl = new System.Windows.Forms.Label();
            this.CommenTxt = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.ThismonthLbl = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.catergoryComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noteLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.priceLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainLbl = new System.Windows.Forms.Label();
            this.csvOutBtn = new System.Windows.Forms.Button();
            this.categoryDialogBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.csvInBtn = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(605, 68);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 40;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(97, 198);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(16, 198);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 38;
            this.changeBtn.Text = "変更";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(282, 114);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 19);
            this.textBox10.TabIndex = 37;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(524, 68);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 42;
            this.connectBtn.Text = "接続";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.BudgetBtn);
            this.tabPage3.Controls.Add(this.PercentageLbl);
            this.tabPage3.Controls.Add(this.UserateLbl);
            this.tabPage3.Controls.Add(this.MoneyLbl);
            this.tabPage3.Controls.Add(this.userateBar);
            this.tabPage3.Controls.Add(this.btnTotal);
            this.tabPage3.Controls.Add(this.CommentLbl);
            this.tabPage3.Controls.Add(this.CommenTxt);
            this.tabPage3.Controls.Add(this.budgetTextBox);
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
            this.BudgetBtn.Click += new System.EventHandler(this.budgetBtn_Click);
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
            // userateBar
            // 
            this.userateBar.Location = new System.Drawing.Point(27, 64);
            this.userateBar.Name = "userateBar";
            this.userateBar.Size = new System.Drawing.Size(124, 26);
            this.userateBar.TabIndex = 48;
            this.userateBar.Click += new System.EventHandler(this.progressBar1_Click);
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
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(85, 22);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(66, 19);
            this.budgetTextBox.TabIndex = 27;
            this.budgetTextBox.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
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
            this.tabPage1.Controls.Add(this.catergoryComboBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.priceTextBox);
            this.tabPage1.Controls.Add(this.changeBtn);
            this.tabPage1.Controls.Add(this.noteTextBox);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.noteLbl);
            this.tabPage1.Controls.Add(this.registerBtn);
            this.tabPage1.Controls.Add(this.priceLbl);
            this.tabPage1.Controls.Add(this.dateLbl);
            this.tabPage1.Controls.Add(this.nameLbl);
            this.tabPage1.Controls.Add(this.categoryLbl);
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
            // catergoryComboBox
            // 
            this.catergoryComboBox.FormattingEnabled = true;
            this.catergoryComboBox.Location = new System.Drawing.Point(51, 47);
            this.catergoryComboBox.Name = "catergoryComboBox";
            this.catergoryComboBox.Size = new System.Drawing.Size(121, 20);
            this.catergoryComboBox.TabIndex = 32;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(51, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 19);
            this.nameTextBox.TabIndex = 28;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(51, 99);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 19);
            this.priceTextBox.TabIndex = 29;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(51, 124);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(121, 19);
            this.noteTextBox.TabIndex = 30;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(51, 22);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 19);
            this.dateTimePicker.TabIndex = 31;
            this.dateTimePicker.Value = new System.DateTime(2015, 10, 28, 15, 24, 45, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Location = new System.Drawing.Point(14, 127);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(29, 12);
            this.noteLbl.TabIndex = 38;
            this.noteLbl.Text = "備考";
            this.noteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(97, 148);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 33;
            this.registerBtn.Text = "登録";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(14, 101);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(29, 12);
            this.priceLbl.TabIndex = 37;
            this.priceLbl.Text = "金額";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(14, 24);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(29, 12);
            this.dateLbl.TabIndex = 34;
            this.dateLbl.Text = "日付";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(14, 76);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 12);
            this.nameLbl.TabIndex = 36;
            this.nameLbl.Text = "品名";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(14, 51);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(29, 12);
            this.categoryLbl.TabIndex = 35;
            this.categoryLbl.Text = "分類";
            this.categoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.LightGray;
            this.listView2.ForeColor = System.Drawing.Color.Black;
            this.listView2.Location = new System.Drawing.Point(192, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(471, 234);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
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
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainLbl.Location = new System.Drawing.Point(17, 39);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(126, 28);
            this.mainLbl.TabIndex = 45;
            this.mainLbl.Text = "家計簿アプリ";
            // 
            // csvOutBtn
            // 
            this.csvOutBtn.Location = new System.Drawing.Point(429, 68);
            this.csvOutBtn.Name = "csvOutBtn";
            this.csvOutBtn.Size = new System.Drawing.Size(91, 23);
            this.csvOutBtn.TabIndex = 46;
            this.csvOutBtn.Text = "CSV出力";
            this.csvOutBtn.UseVisualStyleBackColor = true;
            this.csvOutBtn.Click += new System.EventHandler(this.csvOutBtn_Click);
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
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(708, 24);
            this.mainMenu.TabIndex = 49;
            this.mainMenu.Text = "mainMenu";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // csvInBtn
            // 
            this.csvInBtn.Location = new System.Drawing.Point(337, 68);
            this.csvInBtn.Name = "csvInBtn";
            this.csvInBtn.Size = new System.Drawing.Size(86, 23);
            this.csvInBtn.TabIndex = 50;
            this.csvInBtn.Text = "CSV入力";
            this.csvInBtn.UseVisualStyleBackColor = true;
            this.csvInBtn.Click += new System.EventHandler(this.csvInBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.csvInBtn);
            this.Controls.Add(this.categoryDialogBtn);
            this.Controls.Add(this.csvOutBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
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
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label CommentLbl;
        private System.Windows.Forms.TextBox CommenTxt;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Label ThismonthLbl;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox catergoryComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button csvOutBtn;
        private System.Windows.Forms.Button btnTotal;

        private System.Windows.Forms.Button categoryDialogBtn;
        private System.Windows.Forms.Label MoneyLbl;

        private System.Windows.Forms.ProgressBar userateBar;
        private System.Windows.Forms.Label PercentageLbl;
        private System.Windows.Forms.Label UserateLbl;
        private System.Windows.Forms.Button BudgetBtn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Button csvInBtn;
    }
}