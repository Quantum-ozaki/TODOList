using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    public class CSVWriter : IDisposable
    {
        private TextWriter writer;
        private string path;

        public CSVWriter(string path)
        {
            writer = new StreamWriter(new FileStream(path, FileMode.Create), UTF8Encoding.Default);
            this.path = path;
        }

        public void WriteHeader(string value)
        {
            writer.Write(value);
            writer.WriteLine();
        }

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
