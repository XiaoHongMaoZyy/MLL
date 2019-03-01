using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace MulaolaoLibrary
{
    public class ReviewsEntity
    {
        private long _id;
        private string _res01;
        private string _res02;
        private string _res03;
        private DateTime _res04;
        private string _res05;
        private string _res06;
        private string _res07;
        private DateTime _res08;
        private string _res09;
        private string _res10;
        private string _res11;
        private string _res12;
        private string _res13;

        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 程序编号
        /// </summary>
        public string RES01
        {
            get
            {
                return _res01;
            }

            set
            {
                _res01 = value;
            }
        }
        /// <summary>
        /// 单据是否是补充/返单或者其他
        /// </summary>
        public string RES02
        {
            get
            {
                return _res02;
            }

            set
            {
                _res02 = value;
            }
        }
        /// <summary>
        /// 送审人编号
        /// </summary>
        public string RES03
        {
            get
            {
                return _res03;
            }

            set
            {
                _res03 = value;
            }
        }
        /// <summary>
        /// 送审时间
        /// </summary>
        public DateTime RES04
        {
            get
            {
                return _res04;
            }

            set
            {
                _res04 = value;
            }
        }
        /// <summary>
        /// 送审状态
        /// </summary>
        public string RES05
        {
            get
            {
                return _res05;
            }

            set
            {
                _res05 = value;
            }
        }
        /// <summary>
        /// 送审内容
        /// </summary>
        public string RES06
        {
            get
            {
                return _res06;
            }

            set
            {
                _res06 = value;
            }
        }
        /// <summary>
        /// 送审意见
        /// </summary>
        public string RES07
        {
            get
            {
                return _res07;
            }

            set
            {
                _res07 = value;
            }
        }
        /// <summary>
        /// 打印时间
        /// </summary>
        public DateTime RES08
        {
            get
            {
                return _res08;
            }

            set
            {
                _res08 = value;
            }
        }
        /// <summary>
        /// 流水号
        /// </summary>
        public string RES09
        {
            get
            {
                return _res09;
            }

            set
            {
                _res09 = value;
            }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string RES10
        {
            get
            {
                return _res10;
            }

            set
            {
                _res10 = value;
            }
        }
        /// <summary>
        /// 货号
        /// </summary>
        public string RES11
        {
            get
            {
                return _res11;
            }

            set
            {
                _res11 = value;
            }
        }
        /// <summary>
        /// 生产车间
        /// </summary>
        public string RES12
        {
            get
            {
                return _res12;
            }

            set
            {
                _res12 = value;
            }
        }
        /// <summary>
        /// 开合同人
        /// </summary>
        public string RES13
        {
            get
            {
                return _res13;
            }

            set
            {
                _res13 = value;
            }
        }

    }
}
