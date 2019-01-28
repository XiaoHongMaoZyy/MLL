using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOJDao
    {
        /// <summary>
        /// 获取344数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOJEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOJ WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOJEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOJEntity model = new MulaolaoLibrary . QUOJEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOJ001" ] != null )
                {
                    model . QUOJ001 = row [ "QUOJ001" ] . ToString ( );
                }
                if ( row [ "QUOJ002" ] != null )
                {
                    model . QUOJ002 = row [ "QUOJ002" ] . ToString ( );
                }
                if ( row [ "QUOJ003" ] != null )
                {
                    model . QUOJ003 = row [ "QUOJ003" ] . ToString ( );
                }
                if ( row [ "QUOJ004" ] != null )
                {
                    model . QUOJ004 = row [ "QUOJ004" ] . ToString ( );
                }
                if ( row [ "QUOJ005" ] != null && row [ "QUOJ005" ] . ToString ( ) != "" )
                {
                    model . QUOJ005 = int . Parse ( row [ "QUOJ005" ] . ToString ( ) );
                }
                if ( row [ "QUOJ006" ] != null )
                {
                    model . QUOJ006 = row [ "QUOJ006" ] . ToString ( );
                }
                if ( row [ "QUOJ007" ] != null )
                {
                    model . QUOJ007 = row [ "QUOJ007" ] . ToString ( );
                }
                if ( row [ "QUOJ008" ] != null )
                {
                    model . QUOJ008 = row [ "QUOJ008" ] . ToString ( );
                }
                if ( row [ "QUOJ009" ] != null )
                {
                    model . QUOJ009 = row [ "QUOJ009" ] . ToString ( );
                }
                if ( row [ "QUOJ010" ] != null )
                {
                    model . QUOJ010 = row [ "QUOJ010" ] . ToString ( );
                }
                if ( row [ "QUOJ011" ] != null && row [ "QUOJ011" ] . ToString ( ) != "" )
                {
                    model . QUOJ011 = decimal . Parse ( row [ "QUOJ011" ] . ToString ( ) );
                }
                if ( row [ "QUOJ012" ] != null )
                {
                    model . QUOJ012 = row [ "QUOJ012" ] . ToString ( );
                }
                if ( row [ "QUOJ013" ] != null )
                {
                    model . QUOJ013 = row [ "QUOJ013" ] . ToString ( );
                }
                if ( row [ "QUOJ014" ] != null )
                {
                    model . QUOJ014 = row [ "QUOJ014" ] . ToString ( );
                }
                if ( row [ "QUOJ015" ] != null )
                {
                    model . QUOJ015 = row [ "QUOJ015" ] . ToString ( );
                }
                if ( row [ "QUOJ016" ] != null && row [ "QUOJ016" ] . ToString ( ) != "" )
                {
                    model . QUOJ016 = decimal . Parse ( row [ "QUOJ016" ] . ToString ( ) );
                }
                if ( row [ "QUOJ017" ] != null && row [ "QUOJ017" ] . ToString ( ) != "" )
                {
                    model . QUOJ017 = decimal . Parse ( row [ "QUOJ017" ] . ToString ( ) );
                }
                if ( row [ "QUOJ018" ] != null && row [ "QUOJ018" ] . ToString ( ) != "" )
                {
                    model . QUOJ018 = decimal . Parse ( row [ "QUOJ018" ] . ToString ( ) );
                }
                if ( row [ "QUOJ019" ] != null && row [ "QUOJ019" ] . ToString ( ) != "" )
                {
                    model . QUOJ019 = decimal . Parse ( row [ "QUOJ019" ] . ToString ( ) );
                }
                if ( row [ "QUOJ020" ] != null && row [ "QUOJ020" ] . ToString ( ) != "" )
                {
                    model . QUOJ020 = decimal . Parse ( row [ "QUOJ020" ] . ToString ( ) );
                }
                if ( row [ "QUOJ021" ] != null && row [ "QUOJ021" ] . ToString ( ) != "" )
                {
                    model . QUOJ021 = decimal . Parse ( row [ "QUOJ021" ] . ToString ( ) );
                }
                if ( row [ "QUOJ022" ] != null && row [ "QUOJ022" ] . ToString ( ) != "" )
                {
                    model . QUOJ022 = decimal . Parse ( row [ "QUOJ022" ] . ToString ( ) );
                }
                if ( row [ "QUOJ023" ] != null && row [ "QUOJ023" ] . ToString ( ) != "" )
                {
                    model . QUOJ023 = decimal . Parse ( row [ "QUOJ023" ] . ToString ( ) );
                }
                if ( row [ "QUOJ024" ] != null && row [ "QUOJ024" ] . ToString ( ) != "" )
                {
                    model . QUOJ024 = decimal . Parse ( row [ "QUOJ024" ] . ToString ( ) );
                }
                if ( row [ "QUOJ025" ] != null && row [ "QUOJ025" ] . ToString ( ) != "" )
                {
                    model . QUOJ025 = decimal . Parse ( row [ "QUOJ025" ] . ToString ( ) );
                }
                if ( row [ "QUOJ026" ] != null && row [ "QUOJ026" ] . ToString ( ) != "" )
                {
                    model . QUOJ026 = decimal . Parse ( row [ "QUOJ026" ] . ToString ( ) );
                }
                if ( row [ "QUOJ027" ] != null && row [ "QUOJ027" ] . ToString ( ) != "" )
                {
                    model . QUOJ027 = decimal . Parse ( row [ "QUOJ027" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存344数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOJEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOJEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOJ(" );
            strSql . Append ( "QUOJ001,QUOJ002,QUOJ003,QUOJ004,QUOJ005,QUOJ006,QUOJ007,QUOJ008,QUOJ009,QUOJ010,QUOJ011,QUOJ012,QUOJ013,QUOJ014,QUOJ015,QUOJ016,QUOJ017,QUOJ018,QUOJ019,QUOJ020,QUOJ021,QUOJ022,QUOJ023,QUOJ024,QUOJ025,QUOJ026,QUOJ027)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOJ001,@QUOJ002,@QUOJ003,@QUOJ004,@QUOJ005,@QUOJ006,@QUOJ007,@QUOJ008,@QUOJ009,@QUOJ010,@QUOJ011,@QUOJ012,@QUOJ013,@QUOJ014,@QUOJ015,@QUOJ016,@QUOJ017,@QUOJ018,@QUOJ019,@QUOJ020,@QUOJ021,@QUOJ022,@QUOJ023,@QUOJ024,@QUOJ025,@QUOJ026,@QUOJ027)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOJ001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ005", SqlDbType.Int,4),
                    new SqlParameter("@QUOJ006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ014", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ015", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ025", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ026", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ027", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOJ001;
            parameters [ 1 ] . Value = model . QUOJ002;
            parameters [ 2 ] . Value = model . QUOJ003;
            parameters [ 3 ] . Value = model . QUOJ004;
            parameters [ 4 ] . Value = model . QUOJ005;
            parameters [ 5 ] . Value = model . QUOJ006;
            parameters [ 6 ] . Value = model . QUOJ007;
            parameters [ 7 ] . Value = model . QUOJ008;
            parameters [ 8 ] . Value = model . QUOJ009;
            parameters [ 9 ] . Value = model . QUOJ010;
            parameters [ 10 ] . Value = model . QUOJ011;
            parameters [ 11 ] . Value = model . QUOJ012;
            parameters [ 12 ] . Value = model . QUOJ013;
            parameters [ 13 ] . Value = model . QUOJ014;
            parameters [ 14 ] . Value = model . QUOJ015;
            parameters [ 15 ] . Value = model . QUOJ016;
            parameters [ 16 ] . Value = model . QUOJ017;
            parameters [ 17 ] . Value = model . QUOJ018;
            parameters [ 18 ] . Value = model . QUOJ019;
            parameters [ 19 ] . Value = model . QUOJ020;
            parameters [ 20 ] . Value = model . QUOJ021;
            parameters [ 21 ] . Value = model . QUOJ022;
            parameters [ 22 ] . Value = model . QUOJ023;
            parameters [ 23 ] . Value = model . QUOJ024;
            parameters [ 24 ] . Value = model . QUOJ025;
            parameters [ 25 ] . Value = model . QUOJ026;
            parameters [ 26 ] . Value = model . QUOJ027;
            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOJEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOJ set " );
            strSql . Append ( "QUOJ001=@QUOJ001," );
            strSql . Append ( "QUOJ002=@QUOJ002," );
            strSql . Append ( "QUOJ003=@QUOJ003," );
            strSql . Append ( "QUOJ004=@QUOJ004," );
            strSql . Append ( "QUOJ005=@QUOJ005," );
            strSql . Append ( "QUOJ006=@QUOJ006," );
            strSql . Append ( "QUOJ007=@QUOJ007," );
            strSql . Append ( "QUOJ008=@QUOJ008," );
            strSql . Append ( "QUOJ009=@QUOJ009," );
            strSql . Append ( "QUOJ010=@QUOJ010," );
            strSql . Append ( "QUOJ011=@QUOJ011," );
            strSql . Append ( "QUOJ012=@QUOJ012," );
            strSql . Append ( "QUOJ013=@QUOJ013," );
            strSql . Append ( "QUOJ014=@QUOJ014," );
            strSql . Append ( "QUOJ015=@QUOJ015," );
            strSql . Append ( "QUOJ016=@QUOJ016," );
            strSql . Append ( "QUOJ017=@QUOJ017," );
            strSql . Append ( "QUOJ018=@QUOJ018," );
            strSql . Append ( "QUOJ019=@QUOJ019," );
            strSql . Append ( "QUOJ020=@QUOJ020," );
            strSql . Append ( "QUOJ021=@QUOJ021," );
            strSql . Append ( "QUOJ022=@QUOJ022," );
            strSql . Append ( "QUOJ023=@QUOJ023," );
            strSql . Append ( "QUOJ024=@QUOJ024," );
            strSql . Append ( "QUOJ025=@QUOJ025," );
            strSql . Append ( "QUOJ026=@QUOJ026," );
            strSql . Append ( "QUOJ027=@QUOJ027" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOJ001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ005", SqlDbType.Int,4),
                    new SqlParameter("@QUOJ006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ012", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ013", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ014", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ015", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOJ016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ025", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ026", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOJ027", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOJ001;
            parameters [ 1 ] . Value = model . QUOJ002;
            parameters [ 2 ] . Value = model . QUOJ003;
            parameters [ 3 ] . Value = model . QUOJ004;
            parameters [ 4 ] . Value = model . QUOJ005;
            parameters [ 5 ] . Value = model . QUOJ006;
            parameters [ 6 ] . Value = model . QUOJ007;
            parameters [ 7 ] . Value = model . QUOJ008;
            parameters [ 8 ] . Value = model . QUOJ009;
            parameters [ 9 ] . Value = model . QUOJ010;
            parameters [ 10 ] . Value = model . QUOJ011;
            parameters [ 11 ] . Value = model . QUOJ012;
            parameters [ 12 ] . Value = model . QUOJ013;
            parameters [ 13 ] . Value = model . QUOJ014;
            parameters [ 14 ] . Value = model . QUOJ015;
            parameters [ 15 ] . Value = model . QUOJ016;
            parameters [ 16 ] . Value = model . QUOJ017;
            parameters [ 17 ] . Value = model . QUOJ018;
            parameters [ 18 ] . Value = model . QUOJ019;
            parameters [ 19 ] . Value = model . QUOJ020;
            parameters [ 20 ] . Value = model . QUOJ021;
            parameters [ 21 ] . Value = model . QUOJ022;
            parameters [ 22 ] . Value = model . QUOJ023;
            parameters [ 23 ] . Value = model . QUOJ024;
            parameters [ 24 ] . Value = model . QUOJ025;
            parameters [ 25 ] . Value = model . QUOJ026;
            parameters [ 26 ] . Value = model . QUOJ027;
            parameters [ 27 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model.idx : 0;
        }

        /// <summary>
        /// 删除344数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOJ WHERE idx={0}" ,idx );

            int rwos = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rwos > 0 ? true : false;
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509 ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GS02,GS07,GS08,CONVERT(FLOAT,GS78) GS78 FROM R_PQP WHERE GS70='R_344' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
