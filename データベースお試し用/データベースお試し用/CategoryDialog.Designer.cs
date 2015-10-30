namespace データベースお試し用
{
    partial class CategoryDialog
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newCategoryName = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 177);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(224, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "追加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(413, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "分類名";
            // 
            // newCategoryName
            // 
            this.newCategoryName.Location = new System.Drawing.Point(59, 14);
            this.newCategoryName.Name = "newCategoryName";
            this.newCategoryName.Size = new System.Drawing.Size(159, 19);
            this.newCategoryName.TabIndex = 4;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(305, 12);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 5;
            this.modifyBtn.Text = "変更";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // CategoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 288);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.newCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listView1);
            this.Name = "CategoryDialog";
            this.Text = "分類管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newCategoryName;
        private System.Windows.Forms.Button modifyBtn;
    }
}