using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOEDao
    {
        /// <summary>
        /// 获取342数据列表
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOEEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOE WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOEEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOEEntity model = new MulaolaoLibrary . QUOEEntity ( );

            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOE001" ] != null )
                {
                    model . QUOE001 = row [ "QUOE001" ] . ToString ( );
                }
                if ( row [ "QUOE002" ] != null )
                {
                    model . QUOE002 = row [ "QUOE002" ] . ToString ( );
                }
                if ( row [ "QUOE003" ] != null )
                {
                    model . QUOE003 = row [ "QUOE003" ] . ToString ( );
                }
                if ( row [ "QUOE004" ] != null )
                {
                    model . QUOE004 = row [ "QUOE004" ] . ToString ( );
                }
                if ( row [ "QUOE005" ] != null && row [ "QUOE005" ] . ToString ( ) != "" )
                {
                    model . QUOE005 = int . Parse ( row [ "QUOE005" ] . ToString ( ) );
                }
                if ( row [ "QUOE006" ] != null )
                {
                    model . QUOE006 = row [ "QUOE006" ] . ToString ( );
                }
                if ( row [ "QUOE007" ] != null )
                {
                    model . QUOE007 = row [ "QUOE007" ] . ToString ( );
                }
                if ( row [ "QUOE008" ] != null && row [ "QUOE008" ] . ToString ( ) != "" )
                {
                    model . QUOE008 = decimal . Parse ( row [ "QUOE008" ] . ToString ( ) );
                }
                if ( row [ "QUOE009" ] != null && row [ "QUOE009" ] . ToString ( ) != "" )
                {
                    model . QUOE009 = decimal . Parse ( row [ "QUOE009" ] . ToString ( ) );
                }
                if ( row [ "QUOE010" ] != null && row [ "QUOE010" ] . ToString ( ) != "" )
                {
                    model . QUOE010 = decimal . Parse ( row [ "QUOE010" ] . ToString ( ) );
                }
                if ( row [ "QUOE011" ] != null && row [ "QUOE011" ] . ToString ( ) != "" )
                {
                    model . QUOE011 = decimal . Parse ( row [ "QUOE011" ] . ToString ( ) );
                }
                if ( row [ "QUOE012" ] != null && row [ "QUOE012" ] . ToString ( ) != "" )
                {
                    model . QUOE012 = decimal . Parse ( row [ "QUOE012" ] . ToString ( ) );
                }
                if ( row [ "QUOE013" ] != null && row [ "QUOE013" ] . ToString ( ) != "" )
                {
                    model . QUOE013 = decimal . Parse ( row [ "QUOE013" ] . ToString ( ) );
                }
                if ( row [ "QUOE014" ] != null && row [ "QUOE014" ] . ToString ( ) != "" )
                {
                    model . QUOE014 = decimal . Parse ( row [ "QUOE014" ] . ToString ( ) );
                }
            }

            return model;
        }

        /// <summary>
        /// 保存342数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOEEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOEEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOE(" );
            strSql . Append ( "QUOE001,QUOE002,QUOE003,QUOE004,QUOE005,QUOE006,QUOE007,QUOE008,QUOE009,QUOE010,QUOE011,QUOE012,QUOE013,QUOE014)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOE001,@QUOE002,@QUOE003,@QUOE004,@QUOE005,@QUOE006,@QUOE007,@QUOE008,@QUOE009,@QUOE010,@QUOE011,@QUOE012,@QUOE013,@QUOE014)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOE001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE005", SqlDbType.Int,4),
                    new SqlParameter("@QUOE006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE014", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOE001;
            parameters [ 1 ] . Value = model . QUOE002;
            parameters [ 2 ] . Value = model . QUOE003;
            parameters [ 3 ] . Value = model . QUOE004;
            parameters [ 4 ] . Value = model . QUOE005;
            parameters [ 5 ] . Value = model . QUOE006;
            parameters [ 6 ] . Value = model . QUOE007;
            parameters [ 7 ] . Value = model . QUOE008;
            parameters [ 8 ] . Value = model . QUOE009;
            parameters [ 9 ] . Value = model . QUOE010;
            parameters [ 10 ] . Value = model . QUOE011;
            parameters [ 11 ] . Value = model . QUOE012;
            parameters [ 12 ] . Value = model . QUOE013;
            parameters [ 13 ] . Value = model . QUOE014;
            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOEEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOE set " );
            strSql . Append ( "QUOE001=@QUOE001," );
            strSql . Append ( "QUOE002=@QUOE002," );
            strSql . Append ( "QUOE003=@QUOE003," );
            strSql . Append ( "QUOE004=@QUOE004," );
            strSql . Append ( "QUOE005=@QUOE005," );
            strSql . Append ( "QUOE006=@QUOE006," );
            strSql . Append ( "QUOE007=@QUOE007," );
            strSql . Append ( "QUOE008=@QUOE008," );
            strSql . Append ( "QUOE009=@QUOE009," );
            strSql . Append ( "QUOE010=@QUOE010," );
            strSql . Append ( "QUOE011=@QUOE011," );
            strSql . Append ( "QUOE012=@QUOE012," );
            strSql . Append ( "QUOE013=@QUOE013," );
            strSql . Append ( "QUOE014=@QUOE014" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOE001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE005", SqlDbType.Int,4),
                    new SqlParameter("@QUOE006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOE008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOE014", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOE001;
            parameters [ 1 ] . Value = model . QUOE002;
            parameters [ 2 ] . Value = model . QUOE003;
            parameters [ 3 ] . Value = model . QUOE004;
            parameters [ 4 ] . Value = model . QUOE005;
            parameters [ 5 ] . Value = model . QUOE006;
            parameters [ 6 ] . Value = model . QUOE007;
            parameters [ 7 ] . Value = model . QUOE008;
            parameters [ 8 ] . Value = model . QUOE009;
            parameters [ 9 ] . Value = model . QUOE010;
            parameters [ 10 ] . Value = model . QUOE011;
            parameters [ 11 ] . Value = model . QUOE012;
            parameters [ 12 ] . Value = model . QUOE013;
            parameters [ 13 ] . Value = model . QUOE014;
            parameters [ 14 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除342数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOE WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509 ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GS02,GS07,GS08,CONVERT(FLOAT,GS10) GS10 FROM R_PQP WHERE GS70='R_342' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
