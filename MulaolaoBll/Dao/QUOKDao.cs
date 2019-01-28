using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Text;
using StudentMgr;

namespace MulaolaoBll . Dao
{
    public class QUOKDao
    {
        /// <summary>
        /// 获取505数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOKEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select * from R_QUOK " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) ,parameters );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOKEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOKEntity model = new MulaolaoLibrary . QUOKEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOK001" ] != null )
                {
                    model . QUOK001 = row [ "QUOK001" ] . ToString ( );
                }
                if ( row [ "QUOK002" ] != null )
                {
                    model . QUOK002 = row [ "QUOK002" ] . ToString ( );
                }
                if ( row [ "QUOK003" ] != null )
                {
                    model . QUOK003 = row [ "QUOK003" ] . ToString ( );
                }
                if ( row [ "QUOK004" ] != null )
                {
                    model . QUOK004 = row [ "QUOK004" ] . ToString ( );
                }
                if ( row [ "QUOK005" ] != null && row [ "QUOK005" ] . ToString ( ) != "" )
                {
                    model . QUOK005 = int . Parse ( row [ "QUOK005" ] . ToString ( ) );
                }
                if ( row [ "QUOK006" ] != null )
                {
                    model . QUOK006 = row [ "QUOK006" ] . ToString ( );
                }
                if ( row [ "QUOK007" ] != null )
                {
                    model . QUOK007 = row [ "QUOK007" ] . ToString ( );
                }
                if ( row [ "QUOK008" ] != null && row [ "QUOK008" ] . ToString ( ) != "" )
                {
                    model . QUOK008 = decimal . Parse ( row [ "QUOK008" ] . ToString ( ) );
                }
                if ( row [ "QUOK009" ] != null )
                {
                    model . QUOK009 = row [ "QUOK009" ] . ToString ( );
                }
                if ( row [ "QUOK010" ] != null && row [ "QUOK010" ] . ToString ( ) != "" )
                {
                    model . QUOK010 = decimal . Parse ( row [ "QUOK010" ] . ToString ( ) );
                }
                if ( row [ "QUOK011" ] != null && row [ "QUOK011" ] . ToString ( ) != "" )
                {
                    model . QUOK011 = decimal . Parse ( row [ "QUOK011" ] . ToString ( ) );
                }
                if ( row [ "QUOK012" ] != null && row [ "QUOK012" ] . ToString ( ) != "" )
                {
                    model . QUOK012 = decimal . Parse ( row [ "QUOK012" ] . ToString ( ) );
                }
                if ( row [ "QUOK013" ] != null && row [ "QUOK013" ] . ToString ( ) != "" )
                {
                    model . QUOK013 = decimal . Parse ( row [ "QUOK013" ] . ToString ( ) );
                }
                if ( row [ "QUOK014" ] != null && row [ "QUOK014" ] . ToString ( ) != "" )
                {
                    model . QUOK014 = decimal . Parse ( row [ "QUOK014" ] . ToString ( ) );
                }
                if ( row [ "QUOK015" ] != null && row [ "QUOK015" ] . ToString ( ) != "" )
                {
                    model . QUOK015 = decimal . Parse ( row [ "QUOK015" ] . ToString ( ) );
                }
                if ( row [ "QUOK016" ] != null && row [ "QUOK016" ] . ToString ( ) != "" )
                {
                    model . QUOK016 = decimal . Parse ( row [ "QUOK016" ] . ToString ( ) );
                }
                if ( row [ "QUOK017" ] != null && row [ "QUOK017" ] . ToString ( ) != "" )
                {
                    model . QUOK017 = decimal . Parse ( row [ "QUOK017" ] . ToString ( ) );
                }
                if ( row [ "QUOK018" ] != null && row [ "QUOK018" ] . ToString ( ) != "" )
                {
                    model . QUOK018 = decimal . Parse ( row [ "QUOK018" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存505数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOKEntity model )
        {
            if ( model . idx < 1 )
              return  add ( model );
            else
              return  edit ( model );
        }

        int add ( MulaolaoLibrary . QUOKEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOK(" );
            strSql . Append ( "QUOK001,QUOK002,QUOK003,QUOK004,QUOK005,QUOK006,QUOK007,QUOK008,QUOK009,QUOK010,QUOK011,QUOK012,QUOK013,QUOK014,QUOK015,QUOK016,QUOK017,QUOK018)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOK001,@QUOK002,@QUOK003,@QUOK004,@QUOK005,@QUOK006,@QUOK007,@QUOK008,@QUOK009,@QUOK010,@QUOK011,@QUOK012,@QUOK013,@QUOK014,@QUOK015,@QUOK016,@QUOK017,@QUOK018)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOK001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK005", SqlDbType.Int,4),
                    new SqlParameter("@QUOK006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK018", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOK001;
            parameters [ 1 ] . Value = model . QUOK002;
            parameters [ 2 ] . Value = model . QUOK003;
            parameters [ 3 ] . Value = model . QUOK004;
            parameters [ 4 ] . Value = model . QUOK005;
            parameters [ 5 ] . Value = model . QUOK006;
            parameters [ 6 ] . Value = model . QUOK007;
            parameters [ 7 ] . Value = model . QUOK008;
            parameters [ 8 ] . Value = model . QUOK009;
            parameters [ 9 ] . Value = model . QUOK010;
            parameters [ 10 ] . Value = model . QUOK011;
            parameters [ 11 ] . Value = model . QUOK012;
            parameters [ 12 ] . Value = model . QUOK013;
            parameters [ 13 ] . Value = model . QUOK014;
            parameters [ 14 ] . Value = model . QUOK015;
            parameters [ 15 ] . Value = model . QUOK016;
            parameters [ 16 ] . Value = model . QUOK017;
            parameters [ 17 ] . Value = model . QUOK018;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOKEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOK set " );
            strSql . Append ( "QUOK001=@QUOK001," );
            strSql . Append ( "QUOK002=@QUOK002," );
            strSql . Append ( "QUOK003=@QUOK003," );
            strSql . Append ( "QUOK004=@QUOK004," );
            strSql . Append ( "QUOK005=@QUOK005," );
            strSql . Append ( "QUOK006=@QUOK006," );
            strSql . Append ( "QUOK007=@QUOK007," );
            strSql . Append ( "QUOK008=@QUOK008," );
            strSql . Append ( "QUOK009=@QUOK009," );
            strSql . Append ( "QUOK010=@QUOK010," );
            strSql . Append ( "QUOK011=@QUOK011," );
            strSql . Append ( "QUOK012=@QUOK012," );
            strSql . Append ( "QUOK013=@QUOK013," );
            strSql . Append ( "QUOK014=@QUOK014," );
            strSql . Append ( "QUOK015=@QUOK015," );
            strSql . Append ( "QUOK016=@QUOK016," );
            strSql . Append ( "QUOK017=@QUOK017," );
            strSql . Append ( "QUOK018=@QUOK018" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOK001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK005", SqlDbType.Int,4),
                    new SqlParameter("@QUOK006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOK010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOK018", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOK001;
            parameters [ 1 ] . Value = model . QUOK002;
            parameters [ 2 ] . Value = model . QUOK003;
            parameters [ 3 ] . Value = model . QUOK004;
            parameters [ 4 ] . Value = model . QUOK005;
            parameters [ 5 ] . Value = model . QUOK006;
            parameters [ 6 ] . Value = model . QUOK007;
            parameters [ 7 ] . Value = model . QUOK008;
            parameters [ 8 ] . Value = model . QUOK009;
            parameters [ 9 ] . Value = model . QUOK010;
            parameters [ 10 ] . Value = model . QUOK011;
            parameters [ 11 ] . Value = model . QUOK012;
            parameters [ 12 ] . Value = model . QUOK013;
            parameters [ 13 ] . Value = model . QUOK014;
            parameters [ 14 ] . Value = model . QUOK015;
            parameters [ 15 ] . Value = model . QUOK016;
            parameters [ 16 ] . Value = model . QUOK017;
            parameters [ 17 ] . Value = model . QUOK018;
            parameters [ 18 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "delete from R_QUOK " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            if ( rows > 0 )
                return true;
            else
                return false;
        }

    }
}
