using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace データベースお試し用
{
    public class Correction
    {
        public int id
        {
            get;
            set;
            //id, importance, content, Remarks, dated
        }
        public string importance
        {
            get;
            set;
        }
        public string content
        {
            get;
            set;
        }
        public string remarks
        {
            get;
            set;
        }

        public string category_id
        {
            get;
            set;
        }

        public string price
        {
            get;
            set;
        }

        public DateTime date

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
            this.id = id;
            this.importance = importance;
            this.content = content;
            this.remarks = remarks;
            this.date = date;


        }




}

}

