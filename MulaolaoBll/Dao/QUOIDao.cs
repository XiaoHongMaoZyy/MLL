using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Text;
using StudentMgr;

namespace MulaolaoBll . Dao
{
    public class QUOIDao
    {
        /// <summary>
		/// 得到一个对象实体  339
		/// </summary>
		public MulaolaoLibrary . QUOIEntity GetModel ( int idx )
        {

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select  top 1 idx,QUOI001,QUOI002,QUOI003,QUOI004,QUOI005,QUOI006,QUOI007,QUOI008,QUOI009,QUOI010,QUOI011,QUOI012,QUOI013,QUOI014,QUOI015,QUOI016,QUOI017,QUOI018,QUOI019,QUOI020,QUOI021,QUOI022,QUOI023,QUOI024,QUOI025 from R_QUOI " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            DataTable ds = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) ,parameters );
            if ( ds . Rows . Count > 0 )
                return DataRowToModel ( ds . Rows [ 0 ] );
            else
                return null;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MulaolaoLibrary.QUOIEntity DataRowToModel ( DataRow row )
        {
            MulaolaoLibrary . QUOIEntity model = new MulaolaoLibrary . QUOIEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOI001" ] != null )
                {
                    model . QUOI001 = row [ "QUOI001" ] . ToString ( );
                }
                if ( row [ "QUOI002" ] != null )
                {
                    model . QUOI002 = row [ "QUOI002" ] . ToString ( );
                }
                if ( row [ "QUOI003" ] != null )
                {
                    model . QUOI003 = row [ "QUOI003" ] . ToString ( );
                }
                if ( row [ "QUOI004" ] != null )
                {
                    model . QUOI004 = row [ "QUOI004" ] . ToString ( );
                }
                if ( row [ "QUOI005" ] != null && row [ "QUOI005" ] . ToString ( ) != "" )
                {
                    model . QUOI005 = int . Parse ( row [ "QUOI005" ] . ToString ( ) );
                }
                if ( row [ "QUOI006" ] != null )
                {
                    model . QUOI006 = row [ "QUOI006" ] . ToString ( );
                }
                if ( row [ "QUOI007" ] != null )
                {
                    model . QUOI007 = row [ "QUOI007" ] . ToString ( );
                }
                if ( row [ "QUOI008" ] != null )
                {
                    model . QUOI008 = row [ "QUOI008" ] . ToString ( );
                }
                if ( row [ "QUOI009" ] != null )
                {
                    model . QUOI009 = row [ "QUOI009" ] . ToString ( );
                }
                if ( row [ "QUOI010" ] != null )
                {
                    model . QUOI010 = row [ "QUOI010" ] . ToString ( );
                }
                if ( row [ "QUOI011" ] != null )
                {
                    model . QUOI011 = row [ "QUOI011" ] . ToString ( );
                }
                if ( row [ "QUOI012" ] != null && row [ "QUOI012" ] . ToString ( ) != "" )
                {
                    model . QUOI012 = decimal . Parse ( row [ "QUOI012" ] . ToString ( ) );
                }
                if ( row [ "QUOI013" ] != null && row [ "QUOI013" ] . ToString ( ) != "" )
                {
                    model . QUOI013 = decimal . Parse ( row [ "QUOI013" ] . ToString ( ) );
                }
                if ( row [ "QUOI014" ] != null && row [ "QUOI014" ] . ToString ( ) != "" )
                {
                    model . QUOI014 = decimal . Parse ( row [ "QUOI014" ] . ToString ( ) );
                }
                if ( row [ "QUOI015" ] != null && row [ "QUOI015" ] . ToString ( ) != "" )
                {
                    model . QUOI015 = decimal . Parse ( row [ "QUOI015" ] . ToString ( ) );
                }
                if ( row [ "QUOI016" ] != null && row [ "QUOI016" ] . ToString ( ) != "" )
                {
                    model . QUOI016 = decimal . Parse ( row [ "QUOI016" ] . ToString ( ) );
                }
                if ( row [ "QUOI017" ] != null && row [ "QUOI017" ] . ToString ( ) != "" )
                {
                    model . QUOI017 = decimal . Parse ( row [ "QUOI017" ] . ToString ( ) );
                }
                if ( row [ "QUOI018" ] != null && row [ "QUOI018" ] . ToString ( ) != "" )
                {
                    model . QUOI018 = decimal . Parse ( row [ "QUOI018" ] . ToString ( ) );
                }
                if ( row [ "QUOI019" ] != null && row [ "QUOI019" ] . ToString ( ) != "" )
                {
                    model . QUOI019 = decimal . Parse ( row [ "QUOI019" ] . ToString ( ) );
                }
                if ( row [ "QUOI020" ] != null && row [ "QUOI020" ] . ToString ( ) != "" )
                {
                    model . QUOI020 = decimal . Parse ( row [ "QUOI020" ] . ToString ( ) );
                }
                if ( row [ "QUOI021" ] != null && row [ "QUOI021" ] . ToString ( ) != "" )
                {
                    model . QUOI021 = decimal . Parse ( row [ "QUOI021" ] . ToString ( ) );
                }
                if ( row [ "QUOI022" ] != null )
                {
                    model . QUOI022 = row [ "QUOI022" ] . ToString ( );
                }
                if ( row [ "QUOI023" ] != null && row [ "QUOI023" ] . ToString ( ) != "" )
                {
                    model . QUOI023 = decimal . Parse ( row [ "QUOI023" ] . ToString ( ) );
                }
                if ( row [ "QUOI024" ] != null && row [ "QUOI024" ] . ToString ( ) != "" )
                {
                    model . QUOI024 = decimal . Parse ( row [ "QUOI024" ] . ToString ( ) );
                }
                if ( row [ "QUOI025" ] != null )
                {
                    model . QUOI025 = row [ "QUOI025" ] . ToString ( );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存339数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOIEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOIEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOI(" );
            strSql . Append ( "QUOI001,QUOI002,QUOI003,QUOI004,QUOI005,QUOI006,QUOI007,QUOI008,QUOI009,QUOI010,QUOI011,QUOI012,QUOI013,QUOI014,QUOI015,QUOI016,QUOI017,QUOI018,QUOI019,QUOI020,QUOI021,QUOI022,QUOI023,QUOI024,QUOI025)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOI001,@QUOI002,@QUOI003,@QUOI004,@QUOI005,@QUOI006,@QUOI007,@QUOI008,@QUOI009,@QUOI010,@QUOI011,@QUOI012,@QUOI013,@QUOI014,@QUOI015,@QUOI016,@QUOI017,@QUOI018,@QUOI019,@QUOI020,@QUOI021,@QUOI022,@QUOI023,@QUOI024,@QUOI025)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOI001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI005", SqlDbType.Int,4),
                    new SqlParameter("@QUOI006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI022", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI025", SqlDbType.NVarChar,20)};
            parameters [ 0 ] . Value = model . QUOI001;
            parameters [ 1 ] . Value = model . QUOI002;
            parameters [ 2 ] . Value = model . QUOI003;
            parameters [ 3 ] . Value = model . QUOI004;
            parameters [ 4 ] . Value = model . QUOI005;
            parameters [ 5 ] . Value = model . QUOI006;
            parameters [ 6 ] . Value = model . QUOI007;
            parameters [ 7 ] . Value = model . QUOI008;
            parameters [ 8 ] . Value = model . QUOI009;
            parameters [ 9 ] . Value = model . QUOI010;
            parameters [ 10 ] . Value = model . QUOI011;
            parameters [ 11 ] . Value = model . QUOI012;
            parameters [ 12 ] . Value = model . QUOI013;
            parameters [ 13 ] . Value = model . QUOI014;
            parameters [ 14 ] . Value = model . QUOI015;
            parameters [ 15 ] . Value = model . QUOI016;
            parameters [ 16 ] . Value = model . QUOI017;
            parameters [ 17 ] . Value = model . QUOI018;
            parameters [ 18 ] . Value = model . QUOI019;
            parameters [ 19 ] . Value = model . QUOI020;
            parameters [ 20 ] . Value = model . QUOI021;
            parameters [ 21 ] . Value = model . QUOI022;
            parameters [ 22 ] . Value = model . QUOI023;
            parameters [ 23 ] . Value = model . QUOI024;
            parameters [ 24 ] . Value = model . QUOI025;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOIEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOI set " );
            strSql . Append ( "QUOI001=@QUOI001," );
            strSql . Append ( "QUOI002=@QUOI002," );
            strSql . Append ( "QUOI003=@QUOI003," );
            strSql . Append ( "QUOI004=@QUOI004," );
            strSql . Append ( "QUOI005=@QUOI005," );
            strSql . Append ( "QUOI006=@QUOI006," );
            strSql . Append ( "QUOI007=@QUOI007," );
            strSql . Append ( "QUOI008=@QUOI008," );
            strSql . Append ( "QUOI009=@QUOI009," );
            strSql . Append ( "QUOI010=@QUOI010," );
            strSql . Append ( "QUOI011=@QUOI011," );
            strSql . Append ( "QUOI012=@QUOI012," );
            strSql . Append ( "QUOI013=@QUOI013," );
            strSql . Append ( "QUOI014=@QUOI014," );
            strSql . Append ( "QUOI015=@QUOI015," );
            strSql . Append ( "QUOI016=@QUOI016," );
            strSql . Append ( "QUOI017=@QUOI017," );
            strSql . Append ( "QUOI018=@QUOI018," );
            strSql . Append ( "QUOI019=@QUOI019," );
            strSql . Append ( "QUOI020=@QUOI020," );
            strSql . Append ( "QUOI021=@QUOI021," );
            strSql . Append ( "QUOI022=@QUOI022," );
            strSql . Append ( "QUOI023=@QUOI023," );
            strSql . Append ( "QUOI024=@QUOI024," );
            strSql . Append ( "QUOI025=@QUOI025" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOI001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI005", SqlDbType.Int,4),
                    new SqlParameter("@QUOI006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI022", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOI023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOI025", SqlDbType.NVarChar,20),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOI001;
            parameters [ 1 ] . Value = model . QUOI002;
            parameters [ 2 ] . Value = model . QUOI003;
            parameters [ 3 ] . Value = model . QUOI004;
            parameters [ 4 ] . Value = model . QUOI005;
            parameters [ 5 ] . Value = model . QUOI006;
            parameters [ 6 ] . Value = model . QUOI007;
            parameters [ 7 ] . Value = model . QUOI008;
            parameters [ 8 ] . Value = model . QUOI009;
            parameters [ 9 ] . Value = model . QUOI010;
            parameters [ 10 ] . Value = model . QUOI011;
            parameters [ 11 ] . Value = model . QUOI012;
            parameters [ 12 ] . Value = model . QUOI013;
            parameters [ 13 ] . Value = model . QUOI014;
            parameters [ 14 ] . Value = model . QUOI015;
            parameters [ 15 ] . Value = model . QUOI016;
            parameters [ 16 ] . Value = model . QUOI017;
            parameters [ 17 ] . Value = model . QUOI018;
            parameters [ 18 ] . Value = model . QUOI019;
            parameters [ 19 ] . Value = model . QUOI020;
            parameters [ 20 ] . Value = model . QUOI021;
            parameters [ 21 ] . Value = model . QUOI022;
            parameters [ 22 ] . Value = model . QUOI023;
            parameters [ 23 ] . Value = model . QUOI024;
            parameters [ 24 ] . Value = model . QUOI025;
            parameters [ 25 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除339数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOI WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

        /// <summary>
        /// 读取495数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor495 ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT PY25,PY36,PY24,PY11,PY12,PY14,PY18,PY15,PY02 FROM R_PQY A,R_REVIEWS D WHERE A.PY33=D.RES06 AND RES05='执行' AND PY01='{0}' ORDER BY A.idx ASC" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
