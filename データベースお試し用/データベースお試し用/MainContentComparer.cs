using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    public class MainContentComparer : IComparer
    {
        public int ColumnNumber
        {
            get;
            set;
        }

        public int Compare(object x, object y)
        {
            var lhs = (ListViewItem)x;
            var rhs = (ListViewItem)y;

            return lhs.SubItems[ColumnNumber].Text.CompareTo(rhs.SubItems[ColumnNumber].Text);
        }
    }
}
