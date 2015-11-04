using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace データベースお試し用
{
    /// <summary>
    /// 分類のモデルクラス(完全にテーブルの内容をマッピングしているわけではない)
    /// </summary>
    public class Category : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public object Clone()
        {
            return new Category { Id = Id, Name = Name, CreatedDate = CreatedDate };
        }
    }
}
