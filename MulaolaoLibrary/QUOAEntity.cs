using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace MulaolaoLibrary
{
    public class QUOAEntity
    {
        private int _idx;
        private string _quoa010;
        private string _quoa001;
        private string _quoa002;
        private decimal? _quoa003;
        private decimal? _quoa004;
        private decimal? _quoa005;
        private decimal? _quoa006;
        private string _quoa007;
        private string _quoa008;
        private string _quoa009;
        private string _quoa011;
        private string _quoa012;
        private string _quoa013;
        private int? _quoa014;

        /// <summary>
        /// 
        /// </summary>
        public int idx
        {
            set
            {
                _idx = value;
            }
            get
            {
                return _idx;
            }
        }
        /// <summary>
        /// 504单号
        /// </summary>
        public string QUOA010
        {
            set
            {
                _quoa010 = value;
            }
            get
            {
                return _quoa010;
            }
        }
        /// <summary>
        /// 物品名称
        /// </summary>
        public string QUOA001
        {
            set
            {
                _quoa001 = value;
            }
            get
            {
                return _quoa001;
            }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string QUOA002
        {
            set
            {
                _quoa002 = value;
            }
            get
            {
                return _quoa002;
            }
        }
        /// <summary>
        /// 内价不含税
        /// </summary>
        public decimal? QUOA003
        {
            set
            {
                _quoa003 = value;
            }
            get
            {
                return _quoa003;
            }
        }
        /// <summary>
        /// 外价含税
        /// </summary>
        public decimal? QUOA004
        {
            set
            {
                _quoa004 = value;
            }
            get
            {
                return _quoa004;
            }
        }
        /// <summary>
        /// 每套部件个数
        /// </summary>
        public decimal? QUOA005
        {
            set
            {
                _quoa005 = value;
            }
            get
            {
                return _quoa005;
            }
        }
        /// <summary>
        /// 预付款
        /// </summary>
        public decimal? QUOA006
        {
            set
            {
                _quoa006 = value;
            }
            get
            {
                return _quoa006;
            }
        }
        /// <summary>
        /// 工序
        /// </summary>
        public string QUOA007
        {
            set
            {
                _quoa007 = value;
            }
            get
            {
                return _quoa007;
            }
        }
        /// <summary>
        /// 工段
        /// </summary>
        public string QUOA008
        {
            set
            {
                _quoa008 = value;
            }
            get
            {
                return _quoa008;
            }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string QUOA009
        {
            set
            {
                _quoa009 = value;
            }
            get
            {
                return _quoa009;
            }
        }
        /// <summary>
        /// 合同代号
        /// </summary>
        public string QUOA011
        {
            set
            {
                _quoa011 = value;
            }
            get
            {
                return _quoa011;
            }
        }
        /// <summary>
        /// 类别
        /// </summary>
        public string QUOA012
        {
            set
            {
                _quoa012 = value;
            }
            get
            {
                return _quoa012;
            }
        }
        /// <summary>
        /// 材种
        /// </summary>
        public string QUOA013
        {
            set
            {
                _quoa013 = value;
            }
            get
            {
                return _quoa013;
            }
        }
        /// <summary>
        /// 产品数量
        /// </summary>
        public int? QUOA014
        {
            get
            {
                return _quoa014;
            }
            set
            {
                _quoa014 = value;
            }
        }

    }
}
