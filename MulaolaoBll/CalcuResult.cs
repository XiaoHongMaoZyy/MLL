using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace MulaolaoBll
{
    public static class CalcuResult
    {
        /// <summary>
        /// 计算338单价
        /// </summary>
        /// <param name="param1">m³/单价</param>
        /// <param name="param2">m³/张</param>
        /// <param name="param3">异型单价</param>
        /// <returns></returns>
        public static string calcuPriceFor338 ( string param1 ,string param2,string param3 )
        {
            if ( string . IsNullOrEmpty ( param1 ) )
                return string.Empty;
            if ( string . IsNullOrEmpty ( param2 ) )
                return string . Empty;
            decimal ld = Convert . ToDecimal ( param1 );
            decimal lz = Convert . ToDecimal ( param2 );
            decimal yd = string . IsNullOrEmpty ( param3 ) == true ? 0 : Convert . ToDecimal ( param3 );
            param1 = ( ld + yd ) . ToString ( "0.##" );
            ld = Convert . ToDecimal ( param1 );
            return Convert . ToDecimal ( ld * lz ) . ToString ( "0.##" );
        }



    }
}
