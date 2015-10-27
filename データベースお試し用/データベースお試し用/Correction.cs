using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace データベースお試し用
{
    public class Correction
    {
        public int ID
        {
            get;
            set;
            //ID, important, Content, Remarks, Dated
        }
        public string Important
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
        public string Dated
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
        /// <param name="ID"></param>
        /// <param name="Important"></param>
        /// <param name="Content"></param>
        /// <param name="Remarks"></param>
        /// <param name="Dated"></param>
        /// 
        public Correction(int ID, string Important, string Content, string Remarks, string Dated)
        {
            this.ID = ID;
            this.Important = Important;
            this.Content = Content;
            this.Remarks = Remarks;
            this.Dated = Dated;


        }



}

}

