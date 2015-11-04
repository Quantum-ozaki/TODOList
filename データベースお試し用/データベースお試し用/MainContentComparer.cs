using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    /// <summary>
    /// TODOリストのカラム順に並び替えを行うIComparer
    /// </summary>
    public class MainContentComparer : IComparer
    {
        /// <summary>
        /// 並び替えの対象となる列番号
        /// </summary>
        public int ColumnNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 要素の並び替えを行う
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            var lhs = (ListViewItem)x;
            var rhs = (ListViewItem)y;

            return lhs.SubItems[ColumnNumber].Text.CompareTo(rhs.SubItems[ColumnNumber].Text);
        }
    }
}
