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
            //ID, importance, Content, Remarks, Dated
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
        public string date
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
        /// <param name="importance"></param>
        /// <param name="Content"></param>
        /// <param name="Remarks"></param>
        /// <param name="Dated"></param>
        /// 



}

}

