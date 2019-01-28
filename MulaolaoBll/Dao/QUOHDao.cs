using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOHDao
    {
        /// <summary>
        /// 获取一个实体  349
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOHEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOH WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOHEntity getRow ( DataRow row )
        {
            MulaolaoLibrary . QUOHEntity model = new MulaolaoLibrary . QUOHEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOH001" ] != null )
                {
                    model . QUOH001 = row [ "QUOH001" ] . ToString ( );
                }
                if ( row [ "QUOH002" ] != null )
                {
                    model . QUOH002 = row [ "QUOH002" ] . ToString ( );
                }
                if ( row [ "QUOH003" ] != null )
                {
                    model . QUOH003 = row [ "QUOH003" ] . ToString ( );
                }
                if ( row [ "QUOH004" ] != null )
                {
                    model . QUOH004 = row [ "QUOH004" ] . ToString ( );
                }
                if ( row [ "QUOH005" ] != null && row [ "QUOH005" ] . ToString ( ) != "" )
                {
                    model . QUOH005 = int . Parse ( row [ "QUOH005" ] . ToString ( ) );
                }
                if ( row [ "QUOH006" ] != null )
                {
                    model . QUOH006 = row [ "QUOH006" ] . ToString ( );
                }
                if ( row [ "QUOH007" ] != null )
                {
                    model . QUOH007 = row [ "QUOH007" ] . ToString ( );
                }
                if ( row [ "QUOH008" ] != null )
                {
                    model . QUOH008 = row [ "QUOH008" ] . ToString ( );
                }
                if ( row [ "QUOH009" ] != null )
                {
                    model . QUOH009 = row [ "QUOH009" ] . ToString ( );
                }
                if ( row [ "QUOH010" ] != null )
                {
                    model . QUOH010 = row [ "QUOH010" ] . ToString ( );
                }
                if ( row [ "QUOH011" ] != null )
                {
                    model . QUOH011 = row [ "QUOH011" ] . ToString ( );
                }
                if ( row [ "QUOH012" ] != null && row [ "QUOH012" ] . ToString ( ) != "" )
                {
                    model . QUOH012 = decimal . Parse ( row [ "QUOH012" ] . ToString ( ) );
                }
                if ( row [ "QUOH013" ] != null && row [ "QUOH013" ] . ToString ( ) != "" )
                {
                    model . QUOH013 = decimal . Parse ( row [ "QUOH013" ] . ToString ( ) );
                }
                if ( row [ "QUOH014" ] != null && row [ "QUOH014" ] . ToString ( ) != "" )
                {
                    model . QUOH014 = decimal . Parse ( row [ "QUOH014" ] . ToString ( ) );
                }
                if ( row [ "QUOH015" ] != null && row [ "QUOH015" ] . ToString ( ) != "" )
                {
                    model . QUOH015 = decimal . Parse ( row [ "QUOH015" ] . ToString ( ) );
                }
                if ( row [ "QUOH016" ] != null && row [ "QUOH016" ] . ToString ( ) != "" )
                {
                    model . QUOH016 = decimal . Parse ( row [ "QUOH016" ] . ToString ( ) );
                }
                if ( row [ "QUOH017" ] != null && row [ "QUOH017" ] . ToString ( ) != "" )
                {
                    model . QUOH017 = decimal . Parse ( row [ "QUOH017" ] . ToString ( ) );
                }
                if ( row [ "QUOH018" ] != null && row [ "QUOH018" ] . ToString ( ) != "" )
                {
                    model . QUOH018 = decimal . Parse ( row [ "QUOH018" ] . ToString ( ) );
                }
                if ( row [ "QUOH019" ] != null && row [ "QUOH019" ] . ToString ( ) != "" )
                {
                    model . QUOH019 = decimal . Parse ( row [ "QUOH019" ] . ToString ( ) );
                }
                if ( row [ "QUOH020" ] != null && row [ "QUOH020" ] . ToString ( ) != "" )
                {
                    model . QUOH020 = decimal . Parse ( row [ "QUOH020" ] . ToString ( ) );
                }
                if ( row [ "QUOH021" ] != null && row [ "QUOH021" ] . ToString ( ) != "" )
                {
                    model . QUOH021 = decimal . Parse ( row [ "QUOH021" ] . ToString ( ) );
                }
                if ( row [ "QUOH022" ] != null && row [ "QUOH022" ] . ToString ( ) != "" )
                {
                    model . QUOH022 = decimal . Parse ( row [ "QUOH022" ] . ToString ( ) );
                }
                if ( row [ "QUOH023" ] != null && row [ "QUOH023" ] . ToString ( ) != "" )
                {
                    model . QUOH023 = decimal . Parse ( row [ "QUOH023" ] . ToString ( ) );
                }
                if ( row [ "QUOH024" ] != null && row [ "QUOH024" ] . ToString ( ) != "" )
                {
                    model . QUOH024 = decimal . Parse ( row [ "QUOH024" ] . ToString ( ) );
                }
                if ( row [ "QUOH025" ] != null && row [ "QUOH025" ] . ToString ( ) != "" )
                {
                    model . QUOH025 = decimal . Parse ( row [ "QUOH025" ] . ToString ( ) );
                }
                if ( row [ "QUOH026" ] != null && row [ "QUOH026" ] . ToString ( ) != "" )
                {
                    model . QUOH026 = decimal . Parse ( row [ "QUOH026" ] . ToString ( ) );
                }
            }
            return model;
        }
        
        /// <summary>
        /// 保存349数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOHEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOHEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOH(" );
            strSql . Append ( "QUOH001,QUOH002,QUOH003,QUOH004,QUOH005,QUOH006,QUOH007,QUOH008,QUOH009,QUOH010,QUOH011,QUOH012,QUOH013,QUOH014,QUOH015,QUOH016,QUOH017,QUOH018,QUOH019,QUOH020,QUOH021,QUOH022,QUOH023,QUOH024,QUOH025,QUOH026)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOH001,@QUOH002,@QUOH003,@QUOH004,@QUOH005,@QUOH006,@QUOH007,@QUOH008,@QUOH009,@QUOH010,@QUOH011,@QUOH012,@QUOH013,@QUOH014,@QUOH015,@QUOH016,@QUOH017,@QUOH018,@QUOH019,@QUOH020,@QUOH021,@QUOH022,@QUOH023,@QUOH024,@QUOH025,@QUOH026)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOH001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH005", SqlDbType.Int,4),
                    new SqlParameter("@QUOH006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH025", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH026", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOH001;
            parameters [ 1 ] . Value = model . QUOH002;
            parameters [ 2 ] . Value = model . QUOH003;
            parameters [ 3 ] . Value = model . QUOH004;
            parameters [ 4 ] . Value = model . QUOH005;
            parameters [ 5 ] . Value = model . QUOH006;
            parameters [ 6 ] . Value = model . QUOH007;
            parameters [ 7 ] . Value = model . QUOH008;
            parameters [ 8 ] . Value = model . QUOH009;
            parameters [ 9 ] . Value = model . QUOH010;
            parameters [ 10 ] . Value = model . QUOH011;
            parameters [ 11 ] . Value = model . QUOH012;
            parameters [ 12 ] . Value = model . QUOH013;
            parameters [ 13 ] . Value = model . QUOH014;
            parameters [ 14 ] . Value = model . QUOH015;
            parameters [ 15 ] . Value = model . QUOH016;
            parameters [ 16 ] . Value = model . QUOH017;
            parameters [ 17 ] . Value = model . QUOH018;
            parameters [ 18 ] . Value = model . QUOH019;
            parameters [ 19 ] . Value = model . QUOH020;
            parameters [ 20 ] . Value = model . QUOH021;
            parameters [ 21 ] . Value = model . QUOH022;
            parameters [ 22 ] . Value = model . QUOH023;
            parameters [ 23 ] . Value = model . QUOH024;
            parameters [ 24 ] . Value = model . QUOH025;
            parameters [ 25 ] . Value = model . QUOH026;
            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOHEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOH set " );
            strSql . Append ( "QUOH001=@QUOH001," );
            strSql . Append ( "QUOH002=@QUOH002," );
            strSql . Append ( "QUOH003=@QUOH003," );
            strSql . Append ( "QUOH004=@QUOH004," );
            strSql . Append ( "QUOH005=@QUOH005," );
            strSql . Append ( "QUOH006=@QUOH006," );
            strSql . Append ( "QUOH007=@QUOH007," );
            strSql . Append ( "QUOH008=@QUOH008," );
            strSql . Append ( "QUOH009=@QUOH009," );
            strSql . Append ( "QUOH010=@QUOH010," );
            strSql . Append ( "QUOH011=@QUOH011," );
            strSql . Append ( "QUOH012=@QUOH012," );
            strSql . Append ( "QUOH013=@QUOH013," );
            strSql . Append ( "QUOH014=@QUOH014," );
            strSql . Append ( "QUOH015=@QUOH015," );
            strSql . Append ( "QUOH016=@QUOH016," );
            strSql . Append ( "QUOH017=@QUOH017," );
            strSql . Append ( "QUOH018=@QUOH018," );
            strSql . Append ( "QUOH019=@QUOH019," );
            strSql . Append ( "QUOH020=@QUOH020," );
            strSql . Append ( "QUOH021=@QUOH021," );
            strSql . Append ( "QUOH022=@QUOH022," );
            strSql . Append ( "QUOH023=@QUOH023," );
            strSql . Append ( "QUOH024=@QUOH024," );
            strSql . Append ( "QUOH025=@QUOH025," );
            strSql . Append ( "QUOH026=@QUOH026" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOH001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH005", SqlDbType.Int,4),
                    new SqlParameter("@QUOH006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOH012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH024", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH025", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOH026", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOH001;
            parameters [ 1 ] . Value = model . QUOH002;
            parameters [ 2 ] . Value = model . QUOH003;
            parameters [ 3 ] . Value = model . QUOH004;
            parameters [ 4 ] . Value = model . QUOH005;
            parameters [ 5 ] . Value = model . QUOH006;
            parameters [ 6 ] . Value = model . QUOH007;
            parameters [ 7 ] . Value = model . QUOH008;
            parameters [ 8 ] . Value = model . QUOH009;
            parameters [ 9 ] . Value = model . QUOH010;
            parameters [ 10 ] . Value = model . QUOH011;
            parameters [ 11 ] . Value = model . QUOH012;
            parameters [ 12 ] . Value = model . QUOH013;
            parameters [ 13 ] . Value = model . QUOH014;
            parameters [ 14 ] . Value = model . QUOH015;
            parameters [ 15 ] . Value = model . QUOH016;
            parameters [ 16 ] . Value = model . QUOH017;
            parameters [ 17 ] . Value = model . QUOH018;
            parameters [ 18 ] . Value = model . QUOH019;
            parameters [ 19 ] . Value = model . QUOH020;
            parameters [ 20 ] . Value = model . QUOH021;
            parameters [ 21 ] . Value = model . QUOH022;
            parameters [ 22 ] . Value = model . QUOH023;
            parameters [ 23 ] . Value = model . QUOH024;
            parameters [ 24 ] . Value = model . QUOH025;
            parameters [ 25 ] . Value = model . QUOH026;
            parameters [ 26 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除349数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOH WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

        /// <summary>
        /// 获取349数据
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable getTableFor509 ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GS02,GS07,GS71,GS08,GS09,CONVERT(FLOAT,GS10) GS10 FROM R_PQP WHERE GS70='R_349' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
