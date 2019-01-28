using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOFDao
    {
        /// <summary>
        /// 获取343数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOFEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOF WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOFEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOFEntity model = new MulaolaoLibrary . QUOFEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOF001" ] != null )
                {
                    model . QUOF001 = row [ "QUOF001" ] . ToString ( );
                }
                if ( row [ "QUOF002" ] != null )
                {
                    model . QUOF002 = row [ "QUOF002" ] . ToString ( );
                }
                if ( row [ "QUOF003" ] != null )
                {
                    model . QUOF003 = row [ "QUOF003" ] . ToString ( );
                }
                if ( row [ "QUOF004" ] != null )
                {
                    model . QUOF004 = row [ "QUOF004" ] . ToString ( );
                }
                if ( row [ "QUOF005" ] != null && row [ "QUOF005" ] . ToString ( ) != "" )
                {
                    model . QUOF005 = int . Parse ( row [ "QUOF005" ] . ToString ( ) );
                }
                if ( row [ "QUOF006" ] != null )
                {
                    model . QUOF006 = row [ "QUOF006" ] . ToString ( );
                }
                if ( row [ "QUOF007" ] != null )
                {
                    model . QUOF007 = row [ "QUOF007" ] . ToString ( );
                }
                if ( row [ "QUOF008" ] != null )
                {
                    model . QUOF008 = row [ "QUOF008" ] . ToString ( );
                }
                if ( row [ "QUOF009" ] != null )
                {
                    model . QUOF009 = row [ "QUOF009" ] . ToString ( );
                }
                if ( row [ "QUOF010" ] != null )
                {
                    model . QUOF010 = row [ "QUOF010" ] . ToString ( );
                }
                if ( row [ "QUOF011" ] != null && row [ "QUOF011" ] . ToString ( ) != "" )
                {
                    model . QUOF011 = decimal . Parse ( row [ "QUOF011" ] . ToString ( ) );
                }
                if ( row [ "QUOF012" ] != null && row [ "QUOF012" ] . ToString ( ) != "" )
                {
                    model . QUOF012 = decimal . Parse ( row [ "QUOF012" ] . ToString ( ) );
                }
                if ( row [ "QUOF013" ] != null && row [ "QUOF013" ] . ToString ( ) != "" )
                {
                    model . QUOF013 = decimal . Parse ( row [ "QUOF013" ] . ToString ( ) );
                }
                if ( row [ "QUOF014" ] != null && row [ "QUOF014" ] . ToString ( ) != "" )
                {
                    model . QUOF014 = decimal . Parse ( row [ "QUOF014" ] . ToString ( ) );
                }
                if ( row [ "QUOF015" ] != null && row [ "QUOF015" ] . ToString ( ) != "" )
                {
                    model . QUOF015 = decimal . Parse ( row [ "QUOF015" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOFEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOFEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOF(" );
            strSql . Append ( "QUOF001,QUOF002,QUOF003,QUOF004,QUOF005,QUOF006,QUOF007,QUOF008,QUOF009,QUOF010,QUOF011,QUOF012,QUOF013,QUOF014,QUOF015)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOF001,@QUOF002,@QUOF003,@QUOF004,@QUOF005,@QUOF006,@QUOF007,@QUOF008,@QUOF009,@QUOF010,@QUOF011,@QUOF012,@QUOF013,@QUOF014,@QUOF015)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOF001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF005", SqlDbType.Int,4),
                    new SqlParameter("@QUOF006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF015", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOF001;
            parameters [ 1 ] . Value = model . QUOF002;
            parameters [ 2 ] . Value = model . QUOF003;
            parameters [ 3 ] . Value = model . QUOF004;
            parameters [ 4 ] . Value = model . QUOF005;
            parameters [ 5 ] . Value = model . QUOF006;
            parameters [ 6 ] . Value = model . QUOF007;
            parameters [ 7 ] . Value = model . QUOF008;
            parameters [ 8 ] . Value = model . QUOF009;
            parameters [ 9 ] . Value = model . QUOF010;
            parameters [ 10 ] . Value = model . QUOF011;
            parameters [ 11 ] . Value = model . QUOF012;
            parameters [ 12 ] . Value = model . QUOF013;
            parameters [ 13 ] . Value = model . QUOF014;
            parameters [ 14 ] . Value = model . QUOF015;
            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOFEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOF set " );
            strSql . Append ( "QUOF001=@QUOF001," );
            strSql . Append ( "QUOF002=@QUOF002," );
            strSql . Append ( "QUOF003=@QUOF003," );
            strSql . Append ( "QUOF004=@QUOF004," );
            strSql . Append ( "QUOF005=@QUOF005," );
            strSql . Append ( "QUOF006=@QUOF006," );
            strSql . Append ( "QUOF007=@QUOF007," );
            strSql . Append ( "QUOF008=@QUOF008," );
            strSql . Append ( "QUOF009=@QUOF009," );
            strSql . Append ( "QUOF010=@QUOF010," );
            strSql . Append ( "QUOF011=@QUOF011," );
            strSql . Append ( "QUOF012=@QUOF012," );
            strSql . Append ( "QUOF013=@QUOF013," );
            strSql . Append ( "QUOF014=@QUOF014," );
            strSql . Append ( "QUOF015=@QUOF015" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOF001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF005", SqlDbType.Int,4),
                    new SqlParameter("@QUOF006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOF011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOF015", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOF001;
            parameters [ 1 ] . Value = model . QUOF002;
            parameters [ 2 ] . Value = model . QUOF003;
            parameters [ 3 ] . Value = model . QUOF004;
            parameters [ 4 ] . Value = model . QUOF005;
            parameters [ 5 ] . Value = model . QUOF006;
            parameters [ 6 ] . Value = model . QUOF007;
            parameters [ 7 ] . Value = model . QUOF008;
            parameters [ 8 ] . Value = model . QUOF009;
            parameters [ 9 ] . Value = model . QUOF010;
            parameters [ 10 ] . Value = model . QUOF011;
            parameters [ 11 ] . Value = model . QUOF012;
            parameters [ 12 ] . Value = model . QUOF013;
            parameters [ 13 ] . Value = model . QUOF014;
            parameters [ 14 ] . Value = model . QUOF015;
            parameters [ 15 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除343数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOF WHERE idx={0}" ,idx );

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
            strSql . AppendFormat ( "SELECT GS07,GS08,CONVERT(FLOAT,GS10) GS10,GS09 FROM R_PQP WHERE GS07 IS NOT NULL AND GS07!='' AND GS70='R_343' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
