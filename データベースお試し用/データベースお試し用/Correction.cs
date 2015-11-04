using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace データベースお試し用
{
    /// <summary>
    /// TODOリストコンテンツのモデルクラス
    /// </summary>
    public class Correction
    {
        // プロパティは単語の先頭大文字にしましょう
        public int Id
        {
            get;
            set;
            //id, importance, content, Remarks, dated
        }

        public string Importance
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }
        public string Remarks
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// 引数なしコンストラクタ
        /// </summary>
        public Correction()
        {
            //何もしない
        }

        /// <summary>
        /// 引数ありコンストラクタ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="importance"></param>
        /// <param name="content"></param>
        /// <param name="Remarks"></param>
        /// <param name="date"></param>
        /// 

        public Correction(int id, string importance, string content, string remarks, DateTime date)
        {
            this.Id = id;
            this.Importance = importance;
            this.Content = content;
            this.Remarks = remarks;
            this.Date = date;


        }




}

}

