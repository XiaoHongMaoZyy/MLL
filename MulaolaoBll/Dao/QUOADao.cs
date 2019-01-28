using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;
using System . Data;

namespace MulaolaoBll . Dao
{
    public class QUOADao
    {
        /// <summary>
        /// 195保存
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOAEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            if ( model . idx < 1 )
                return add ( strSql ,model );
            else
            {
                if ( edit ( strSql ,model ) )
                    return 0;
                else
                    return model . idx;
            }
        }

        int add ( StringBuilder strSql ,MulaolaoLibrary . QUOAEntity model )
        {
            strSql . Append ( "insert into R_QUOA(" );
            strSql . Append ( "QUOA010,QUOA001,QUOA002,QUOA003,QUOA004,QUOA005,QUOA006,QUOA007,QUOA008,QUOA009,QUOA011,QUOA012,QUOA013,QUOA014)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOA010,@QUOA001,@QUOA002,@QUOA003,@QUOA004,@QUOA005,@QUOA006,@QUOA007,@QUOA008,@QUOA009,@QUOA011,@QUOA012,@QUOA013,@QUOA014)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOA010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA003", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA004", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA005", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA006", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA009", SqlDbType.NVarChar,50),
                    new SqlParameter("@QUOA011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA014", SqlDbType.Int)
            };
            parameters [ 0 ] . Value = model . QUOA010;
            parameters [ 1 ] . Value = model . QUOA001;
            parameters [ 2 ] . Value = model . QUOA002;
            parameters [ 3 ] . Value = model . QUOA003;
            parameters [ 4 ] . Value = model . QUOA004;
            parameters [ 5 ] . Value = model . QUOA005;
            parameters [ 6 ] . Value = model . QUOA006;
            parameters [ 7 ] . Value = model . QUOA007;
            parameters [ 8 ] . Value = model . QUOA008;
            parameters [ 9 ] . Value = model . QUOA009;
            parameters [ 10 ] . Value = model . QUOA011;
            parameters [ 11 ] . Value = model . QUOA012;
            parameters [ 12 ] . Value = model . QUOA013;
            parameters [ 13 ] . Value = model . QUOA014;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        bool edit ( StringBuilder strSql ,MulaolaoLibrary . QUOAEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOA set " );
            strSql . Append ( "QUOA010=@QUOA010," );
            strSql . Append ( "QUOA001=@QUOA001," );
            strSql . Append ( "QUOA002=@QUOA002," );
            strSql . Append ( "QUOA003=@QUOA003," );
            strSql . Append ( "QUOA004=@QUOA004," );
            strSql . Append ( "QUOA005=@QUOA005," );
            strSql . Append ( "QUOA006=@QUOA006," );
            strSql . Append ( "QUOA007=@QUOA007," );
            strSql . Append ( "QUOA008=@QUOA008," );
            strSql . Append ( "QUOA009=@QUOA009," );
            strSql . Append ( "QUOA011=@QUOA011," );
            strSql . Append ( "QUOA012=@QUOA012," );
            strSql . Append ( "QUOA013=@QUOA013," );
            strSql . Append ( "QUOA014=@QUOA014" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOA010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA003", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA004", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA005", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA006", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOA007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA009", SqlDbType.NVarChar,50),
                    new SqlParameter("@idx", SqlDbType.Int,4),
                    new SqlParameter("@QUOA011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOA014", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = model . QUOA010;
            parameters [ 1 ] . Value = model . QUOA001;
            parameters [ 2 ] . Value = model . QUOA002;
            parameters [ 3 ] . Value = model . QUOA003;
            parameters [ 4 ] . Value = model . QUOA004;
            parameters [ 5 ] . Value = model . QUOA005;
            parameters [ 6 ] . Value = model . QUOA006;
            parameters [ 7 ] . Value = model . QUOA007;
            parameters [ 8 ] . Value = model . QUOA008;
            parameters [ 9 ] . Value = model . QUOA009;
            parameters [ 10 ] . Value = model . idx;
            parameters [ 11 ] . Value = model . QUOA011;
            parameters [ 12 ] . Value = model . QUOA012;
            parameters [ 13 ] . Value = model . QUOA013;
            parameters [ 14 ] . Value = model . QUOA014;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? true : false;
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOAEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOA WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table != null && table . Rows . Count > 0 )
                return getRow ( table . Rows [ 0 ] );
            else
                return null;
        }

        public MulaolaoLibrary . QUOAEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOAEntity model = new MulaolaoLibrary . QUOAEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOA010" ] != null )
                {
                    model . QUOA010 = row [ "QUOA010" ] . ToString ( );
                }
                if ( row [ "QUOA001" ] != null )
                {
                    model . QUOA001 = row [ "QUOA001" ] . ToString ( );
                }
                if ( row [ "QUOA002" ] != null )
                {
                    model . QUOA002 = row [ "QUOA002" ] . ToString ( );
                }
                if ( row [ "QUOA003" ] != null && row [ "QUOA003" ] . ToString ( ) != "" )
                {
                    model . QUOA003 = decimal . Parse ( row [ "QUOA003" ] . ToString ( ) );
                }
                if ( row [ "QUOA004" ] != null && row [ "QUOA004" ] . ToString ( ) != "" )
                {
                    model . QUOA004 = decimal . Parse ( row [ "QUOA004" ] . ToString ( ) );
                }
                if ( row [ "QUOA005" ] != null && row [ "QUOA005" ] . ToString ( ) != "" )
                {
                    model . QUOA005 = decimal . Parse ( row [ "QUOA005" ] . ToString ( ) );
                }
                if ( row [ "QUOA006" ] != null && row [ "QUOA006" ] . ToString ( ) != "" )
                {
                    model . QUOA006 = decimal . Parse ( row [ "QUOA006" ] . ToString ( ) );
                }
                if ( row [ "QUOA007" ] != null )
                {
                    model . QUOA007 = row [ "QUOA007" ] . ToString ( );
                }
                if ( row [ "QUOA008" ] != null )
                {
                    model . QUOA008 = row [ "QUOA008" ] . ToString ( );
                }
                if ( row [ "QUOA009" ] != null )
                {
                    model . QUOA009 = row [ "QUOA009" ] . ToString ( );
                }
                if ( row [ "QUOA011" ] != null )
                {
                    model . QUOA011 = row [ "QUOA011" ] . ToString ( );
                }
                if ( row [ "QUOA012" ] != null )
                {
                    model . QUOA012 = row [ "QUOA012" ] . ToString ( );
                }
                if ( row [ "QUOA013" ] != null )
                {
                    model . QUOA013 = row [ "QUOA013" ] . ToString ( );
                }
                if ( row [ "QUOA014" ] != null && row [ "QUOA014" ] . ToString ( ) != "" )
                {
                    model . QUOA014 = int . Parse ( row [ "QUOA014" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 删除 195
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOA WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

    }
}
