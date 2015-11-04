using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    /// <summary>
    /// CSV出力を行うクラス
    /// </summary>
    public class CSVWriter : IDisposable
    {
        private TextWriter writer;
        private string path;

        public CSVWriter(string path)
        {
            writer = new StreamWriter(new FileStream(path, FileMode.Create), UTF8Encoding.Default);
            this.path = path;
        }

        /// <summary>
        /// ヘッダー行を出力する
        /// </summary>
        /// <param name="value"></param>
        public void WriteHeader(string value)
        {
            writer.Write(value);
            writer.WriteLine();
        }

        /// <summary>
        /// TODOリストの1行を出力する
        /// </summary>
        /// <param name="viewItem"></param>
        public void Write(ListViewItem viewItem)
        {
            bool first = true;
            foreach (var item in viewItem.SubItems)
            {
                if (!first)
                    writer.Write(",");
                else
                    first = false;

                writer.Write("\"{0}\"", ((ListViewItem.ListViewSubItem)item).Text);
            }
            writer.WriteLine();
        }

        public void Dispose()
        {
            writer.Close();
        }
    }
}
