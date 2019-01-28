using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOBDao
    {
        /// <summary>
        /// 获取196数据列表
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOBEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOB WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }


        public MulaolaoLibrary . QUOBEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOBEntity model = new MulaolaoLibrary . QUOBEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOB001" ] != null )
                {
                    model . QUOB001 = row [ "QUOB001" ] . ToString ( );
                }
                if ( row [ "QUOB002" ] != null )
                {
                    model . QUOB002 = row [ "QUOB002" ] . ToString ( );
                }
                if ( row [ "QUOB003" ] != null )
                {
                    model . QUOB003 = row [ "QUOB003" ] . ToString ( );
                }
                if ( row [ "QUOB004" ] != null )
                {
                    model . QUOB004 = row [ "QUOB004" ] . ToString ( );
                }
                if ( row [ "QUOB005" ] != null )
                {
                    model . QUOB005 = row [ "QUOB005" ] . ToString ( );
                }
                if ( row [ "QUOB006" ] != null )
                {
                    model . QUOB006 = row [ "QUOB006" ] . ToString ( );
                }
                if ( row [ "QUOB007" ] != null )
                {
                    model . QUOB007 = row [ "QUOB007" ] . ToString ( );
                }
                if ( row [ "QUOB008" ] != null && row [ "QUOB008" ] . ToString ( ) != "" )
                {
                    model . QUOB008 = decimal . Parse ( row [ "QUOB008" ] . ToString ( ) );
                }
                if ( row [ "QUOB009" ] != null && row [ "QUOB009" ] . ToString ( ) != "" )
                {
                    model . QUOB009 = decimal . Parse ( row [ "QUOB009" ] . ToString ( ) );
                }
                if ( row [ "QUOB010" ] != null && row [ "QUOB010" ] . ToString ( ) != "" )
                {
                    model . QUOB010 = decimal . Parse ( row [ "QUOB010" ] . ToString ( ) );
                }
                if ( row [ "QUOB011" ] != null && row [ "QUOB011" ] . ToString ( ) != "" )
                {
                    model . QUOB011 = decimal . Parse ( row [ "QUOB011" ] . ToString ( ) );
                }
                if ( row [ "QUOB012" ] != null )
                {
                    model . QUOB012 = row [ "QUOB012" ] . ToString ( );
                }
                if ( row [ "QUOB013" ] != null )
                {
                    model . QUOB013 = row [ "QUOB013" ] . ToString ( );
                }
                if ( row [ "QUOB014" ] != null )
                {
                    model . QUOB014 = row [ "QUOB014" ] . ToString ( );
                }
                if ( row [ "QUOB015" ] != null && row [ "QUOB015" ] . ToString ( ) != "" )
                {
                    model . QUOB015 = decimal . Parse ( row [ "QUOB015" ] . ToString ( ) );
                }
                if ( row [ "QUOB016" ] != null )
                {
                    model . QUOB016 = row [ "QUOB016" ] . ToString ( );
                }
                if ( row [ "QUOB017" ] != null && row [ "QUOB017" ] . ToString ( ) != ""  )
                {
                    model . QUOB017 = int . Parse ( row [ "QUOB017" ] . ToString ( ) );
                }
                if ( row [ "QUOB018" ] != null )
                {
                    model . QUOB018 = row [ "QUOB018" ] . ToString ( );
                }
                if ( row [ "QUOB019" ] != null )
                {
                    model . QUOB019 = row [ "QUOB019" ] . ToString ( );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存196数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary.QUOBEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOBEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOB(" );
            strSql . Append ( "QUOB001,QUOB002,QUOB003,QUOB004,QUOB005,QUOB006,QUOB007,QUOB008,QUOB009,QUOB010,QUOB011,QUOB012,QUOB013,QUOB014,QUOB015,QUOB016,QUOB017)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOB001,@QUOB002,@QUOB003,@QUOB004,@QUOB005,@QUOB006,@QUOB007,@QUOB008,@QUOB009,@QUOB010,@QUOB011,@QUOB012,@QUOB013,@QUOB014,@QUOB015,@QUOB016,@QUOB017)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOB001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB005", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB014", SqlDbType.NVarChar,10),
                    new SqlParameter("@QUOB015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB016", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB017", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . QUOB001;
            parameters [ 1 ] . Value = model . QUOB002;
            parameters [ 2 ] . Value = model . QUOB003;
            parameters [ 3 ] . Value = model . QUOB004;
            parameters [ 4 ] . Value = model . QUOB005;
            parameters [ 5 ] . Value = model . QUOB006;
            parameters [ 6 ] . Value = model . QUOB007;
            parameters [ 7 ] . Value = model . QUOB008;
            parameters [ 8 ] . Value = model . QUOB009;
            parameters [ 9 ] . Value = model . QUOB010;
            parameters [ 10 ] . Value = model . QUOB011;
            parameters [ 11 ] . Value = model . QUOB012;
            parameters [ 12 ] . Value = model . QUOB013;
            parameters [ 13 ] . Value = model . QUOB014;
            parameters [ 14 ] . Value = model . QUOB015;
            parameters [ 15 ] . Value = model . QUOB016;
            parameters [ 16 ] . Value = model . QUOB017;
            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOBEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOB set " );
            strSql . Append ( "QUOB001=@QUOB001," );
            strSql . Append ( "QUOB002=@QUOB002," );
            strSql . Append ( "QUOB003=@QUOB003," );
            strSql . Append ( "QUOB004=@QUOB004," );
            strSql . Append ( "QUOB005=@QUOB005," );
            strSql . Append ( "QUOB006=@QUOB006," );
            strSql . Append ( "QUOB007=@QUOB007," );
            strSql . Append ( "QUOB008=@QUOB008," );
            strSql . Append ( "QUOB009=@QUOB009," );
            strSql . Append ( "QUOB010=@QUOB010," );
            strSql . Append ( "QUOB011=@QUOB011," );
            strSql . Append ( "QUOB012=@QUOB012," );
            strSql . Append ( "QUOB013=@QUOB013," );
            strSql . Append ( "QUOB014=@QUOB014," );
            strSql . Append ( "QUOB015=@QUOB015," );
            strSql . Append ( "QUOB016=@QUOB016," );
            strSql . Append ( "QUOB017=@QUOB017" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOB001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB005", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB014", SqlDbType.NVarChar,10),
                    new SqlParameter("@QUOB015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOB016", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOB017", SqlDbType.Int,4),
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . QUOB001;
            parameters [ 1 ] . Value = model . QUOB002;
            parameters [ 2 ] . Value = model . QUOB003;
            parameters [ 3 ] . Value = model . QUOB004;
            parameters [ 4 ] . Value = model . QUOB005;
            parameters [ 5 ] . Value = model . QUOB006;
            parameters [ 6 ] . Value = model . QUOB007;
            parameters [ 7 ] . Value = model . QUOB008;
            parameters [ 8 ] . Value = model . QUOB009;
            parameters [ 9 ] . Value = model . QUOB010;
            parameters [ 10 ] . Value = model . QUOB011;
            parameters [ 11 ] . Value = model . QUOB012;
            parameters [ 12 ] . Value = model . QUOB013;
            parameters [ 13 ] . Value = model . QUOB014;
            parameters [ 14 ] . Value = model . QUOB015;
            parameters [ 15 ] . Value = model . QUOB016;
            parameters [ 16 ] . Value = model . QUOB017;
            parameters [ 17 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOB WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

    }
}
