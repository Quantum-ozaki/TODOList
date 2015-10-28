using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    public partial class Form3 : Form
    {

        private Correction correction;
        private Form4 form;

        public Form3(Correction cn, Form4 form)
        {
            InitializeComponent();
            this.form = form;


            this.correction = cn;

            string strid = cn.id.ToString();
            string strData = cn.date.ToString();

            dateTimePicker2.Text = strData;
            label6.Text = strid;
            comboBox1.Text = cn.category;
            textBox1.Text = cn.content;
            textBox2.Text = cn.price;
            textBox3.Text = cn.remarks;
        }

        public string importance { get; internal set; }
        public string content { get; internal set; }
        public string category { get; internal set; }
        public string price { get; internal set; }
        public string date { get; internal set; }
        public string remarks { get; internal set; }

        private void button2_Click(object sender, EventArgs e)
        {

            //----1.データを作る為にリストビューから値を取得

            Correction se = new Correction();

            //----2.値を詰め込む

            string strid = se.id.ToString();
            se.id = int.Parse(this.label6.Text);
            se.category = this.comboBox1.Text;
            se.content = this.textBox1.Text;
            se.price = this.textBox2.Text;
            se.remarks = this.textBox3.Text;

            string strData = this.dateTimePicker2.Text;
            se.date = DateTime.Parse(strData);


            form.SetcontentItems(se);
            this.Close();
        }
    }
}
