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
    /// CSVからTODOリストを復元する
    /// </summary>
    public class CSVReader : IDisposable
    {
        private TextReader reader;
        private string path;
        private int header_count;

        public CSVReader(string path)
        {
            reader = new StreamReader(new FileStream(path, FileMode.Open), UTF8Encoding.Default);
            this.path = path;
        }

        /// <summary>
        /// ヘッダーを読み込む
        /// </summary>
        public void ReadHeader()
        {
            string line = reader.ReadLine();
            header_count = line.Split(',').Length;
        }

        /// <summary>
        /// TODOリストの1行を読み込む
        /// </summary>
        /// <returns></returns>
        public ListViewItem Read()
        {

            string line = reader.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                return null;
            }

            string[] cur_line = line.Split(',');
            if (cur_line.Length != header_count)
            {
                throw new Exception("ヘッダーの数と列の数が一致していません!");
            }

            var item = new ListViewItem();
            foreach (var line_item in cur_line)
            {
                item.SubItems.Add(line_item.Substring(1, line_item.Length - 2));
            }

            return item;
        }

        /// <summary>
        /// インスタンスを破棄する
        /// </summary>
        public void Dispose()
        {
            reader.Close();
        }
    }
}
