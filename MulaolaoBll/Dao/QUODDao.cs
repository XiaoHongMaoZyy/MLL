using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUODDao
    {
        /// <summary>
        /// 获取341数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUODEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOD WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUODEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUODEntity model = new MulaolaoLibrary . QUODEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOD001" ] != null )
                {
                    model . QUOD001 = row [ "QUOD001" ] . ToString ( );
                }
                if ( row [ "QUOD002" ] != null )
                {
                    model . QUOD002 = row [ "QUOD002" ] . ToString ( );
                }
                if ( row [ "QUOD003" ] != null )
                {
                    model . QUOD003 = row [ "QUOD003" ] . ToString ( );
                }
                if ( row [ "QUOD004" ] != null )
                {
                    model . QUOD004 = row [ "QUOD004" ] . ToString ( );
                }
                if ( row [ "QUOD005" ] != null )
                {
                    model . QUOD005 = row [ "QUOD005" ] . ToString ( );
                }
                if ( row [ "QUOD006" ] != null )
                {
                    model . QUOD006 = row [ "QUOD006" ] . ToString ( );
                }
                if ( row [ "QUOD007" ] != null && row [ "QUOD007" ] . ToString ( ) != "" )
                {
                    model . QUOD007 = decimal . Parse ( row [ "QUOD007" ] . ToString ( ) );
                }
                if ( row [ "QUOD008" ] != null && row [ "QUOD008" ] . ToString ( ) != "" )
                {
                    model . QUOD008 = decimal . Parse ( row [ "QUOD008" ] . ToString ( ) );
                }
                if ( row [ "QUOD009" ] != null && row [ "QUOD009" ] . ToString ( ) != "" )
                {
                    model . QUOD009 = decimal . Parse ( row [ "QUOD009" ] . ToString ( ) );
                }
                if ( row [ "QUOD010" ] != null && row [ "QUOD010" ] . ToString ( ) != "" )
                {
                    model . QUOD010 = decimal . Parse ( row [ "QUOD010" ] . ToString ( ) );
                }
                if ( row [ "QUOD011" ] != null && row [ "QUOD011" ] . ToString ( ) != "" )
                {
                    model . QUOD011 = decimal . Parse ( row [ "QUOD011" ] . ToString ( ) );
                }
                if ( row [ "QUOD012" ] != null && row [ "QUOD012" ] . ToString ( ) != "" )
                {
                    model . QUOD012 = decimal . Parse ( row [ "QUOD012" ] . ToString ( ) );
                }
                if ( row [ "QUOD013" ] != null && row [ "QUOD013" ] . ToString ( ) != "" )
                {
                    model . QUOD013 = decimal . Parse ( row [ "QUOD013" ] . ToString ( ) );
                }
                if ( row [ "QUOD014" ] != null && row [ "QUOD014" ] . ToString ( ) != "" )
                {
                    model . QUOD014 = decimal . Parse ( row [ "QUOD014" ] . ToString ( ) );
                }
                if ( row [ "QUOD015" ] != null && row [ "QUOD015" ] . ToString ( ) != "" )
                {
                    model . QUOD015 = decimal . Parse ( row [ "QUOD015" ] . ToString ( ) );
                }
                if ( row [ "QUOD016" ] != null && row [ "QUOD016" ] . ToString ( ) != "" )
                {
                    model . QUOD016 = decimal . Parse ( row [ "QUOD016" ] . ToString ( ) );
                }
                if ( row [ "QUOD017" ] != null && row [ "QUOD017" ] . ToString ( ) != "" )
                {
                    model . QUOD017 = decimal . Parse ( row [ "QUOD017" ] . ToString ( ) );
                }
                if ( row [ "QUOD018" ] != null && row [ "QUOD018" ] . ToString ( ) != "" )
                {
                    model . QUOD018 = decimal . Parse ( row [ "QUOD018" ] . ToString ( ) );
                }
                if ( row [ "QUOD019" ] != null && row [ "QUOD019" ] . ToString ( ) != "" )
                {
                    model . QUOD019 = decimal . Parse ( row [ "QUOD019" ] . ToString ( ) );
                }
                if ( row [ "QUOD020" ] != null && row [ "QUOD020" ] . ToString ( ) != "" )
                {
                    model . QUOD020 = int . Parse ( row [ "QUOD020" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存341数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUODEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUODEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOD(" );
            strSql . Append ( "QUOD001,QUOD002,QUOD003,QUOD004,QUOD005,QUOD006,QUOD007,QUOD008,QUOD009,QUOD010,QUOD011,QUOD012,QUOD013,QUOD014,QUOD015,QUOD016,QUOD017,QUOD018,QUOD019,QUOD020)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOD001,@QUOD002,@QUOD003,@QUOD004,@QUOD005,@QUOD006,@QUOD007,@QUOD008,@QUOD009,@QUOD010,@QUOD011,@QUOD012,@QUOD013,@QUOD014,@QUOD015,@QUOD016,@QUOD017,@QUOD018,@QUOD019,@QUOD020)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOD001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD005", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD007", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD020", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOD001;
            parameters [ 1 ] . Value = model . QUOD002;
            parameters [ 2 ] . Value = model . QUOD003;
            parameters [ 3 ] . Value = model . QUOD004;
            parameters [ 4 ] . Value = model . QUOD005;
            parameters [ 5 ] . Value = model . QUOD006;
            parameters [ 6 ] . Value = model . QUOD007;
            parameters [ 7 ] . Value = model . QUOD008;
            parameters [ 8 ] . Value = model . QUOD009;
            parameters [ 9 ] . Value = model . QUOD010;
            parameters [ 10 ] . Value = model . QUOD011;
            parameters [ 11 ] . Value = model . QUOD012;
            parameters [ 12 ] . Value = model . QUOD013;
            parameters [ 13 ] . Value = model . QUOD014;
            parameters [ 14 ] . Value = model . QUOD015;
            parameters [ 15 ] . Value = model . QUOD016;
            parameters [ 16 ] . Value = model . QUOD017;
            parameters [ 17 ] . Value = model . QUOD018;
            parameters [ 18 ] . Value = model . QUOD019;
            parameters [ 19 ] . Value = model . QUOD020;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUODEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOD set " );
            strSql . Append ( "QUOD001=@QUOD001," );
            strSql . Append ( "QUOD002=@QUOD002," );
            strSql . Append ( "QUOD003=@QUOD003," );
            strSql . Append ( "QUOD004=@QUOD004," );
            strSql . Append ( "QUOD005=@QUOD005," );
            strSql . Append ( "QUOD006=@QUOD006," );
            strSql . Append ( "QUOD007=@QUOD007," );
            strSql . Append ( "QUOD008=@QUOD008," );
            strSql . Append ( "QUOD009=@QUOD009," );
            strSql . Append ( "QUOD010=@QUOD010," );
            strSql . Append ( "QUOD011=@QUOD011," );
            strSql . Append ( "QUOD012=@QUOD012," );
            strSql . Append ( "QUOD013=@QUOD013," );
            strSql . Append ( "QUOD014=@QUOD014," );
            strSql . Append ( "QUOD015=@QUOD015," );
            strSql . Append ( "QUOD016=@QUOD016," );
            strSql . Append ( "QUOD017=@QUOD017," );
            strSql . Append ( "QUOD018=@QUOD018," );
            strSql . Append ( "QUOD019=@QUOD019," );
            strSql . Append ( "QUOD020=@QUOD020" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOD001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD005", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOD007", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOD020", SqlDbType.Int,4),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOD001;
            parameters [ 1 ] . Value = model . QUOD002;
            parameters [ 2 ] . Value = model . QUOD003;
            parameters [ 3 ] . Value = model . QUOD004;
            parameters [ 4 ] . Value = model . QUOD005;
            parameters [ 5 ] . Value = model . QUOD006;
            parameters [ 6 ] . Value = model . QUOD007;
            parameters [ 7 ] . Value = model . QUOD008;
            parameters [ 8 ] . Value = model . QUOD009;
            parameters [ 9 ] . Value = model . QUOD010;
            parameters [ 10 ] . Value = model . QUOD011;
            parameters [ 11 ] . Value = model . QUOD012;
            parameters [ 12 ] . Value = model . QUOD013;
            parameters [ 13 ] . Value = model . QUOD014;
            parameters [ 14 ] . Value = model . QUOD015;
            parameters [ 15 ] . Value = model . QUOD016;
            parameters [ 16 ] . Value = model . QUOD017;
            parameters [ 17 ] . Value = model . QUOD018;
            parameters [ 18 ] . Value = model . QUOD019;
            parameters [ 19 ] . Value = model . QUOD020;
            parameters [ 20 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除341数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOD WHERE idx={0}" ,idx );

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
            strSql . AppendFormat ( "SELECT GS02,GS07,GS08,CONVERT(FLOAT,GS10) GS10 FROM R_PQP WHERE GS70='R_341' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
