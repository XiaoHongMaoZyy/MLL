using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Text;
using StudentMgr;


namespace MulaolaoBll . Dao
{
    public class QUOLDao
    {
        /// <summary>
        /// 得到一个对象实体  495
        /// </summary>
        public MulaolaoLibrary.QUOLEntity GetModel ( int idx )
        {

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select * from R_QUOL " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            DataTable ds =SqlHelper  . ExecuteDataTable ( strSql . ToString ( ) ,parameters );
            if ( ds . Rows . Count > 0 )
                return DataRowToModel ( ds . Rows [ 0 ] );
            else
                return null;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MulaolaoLibrary . QUOLEntity DataRowToModel ( DataRow row )
        {
            MulaolaoLibrary . QUOLEntity model = new MulaolaoLibrary . QUOLEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOL001" ] != null )
                {
                    model . QUOL001 = row [ "QUOL001" ] . ToString ( );
                }
                if ( row [ "QUOL002" ] != null )
                {
                    model . QUOL002 = row [ "QUOL002" ] . ToString ( );
                }
                if ( row [ "QUOL003" ] != null )
                {
                    model . QUOL003 = row [ "QUOL003" ] . ToString ( );
                }
                if ( row [ "QUOL004" ] != null )
                {
                    model . QUOL004 = row [ "QUOL004" ] . ToString ( );
                }
                if ( row [ "QUOL005" ] != null && row [ "QUOL005" ] . ToString ( ) != "" )
                {
                    model . QUOL005 = int . Parse ( row [ "QUOL005" ] . ToString ( ) );
                }
                if ( row [ "QUOL006" ] != null )
                {
                    model . QUOL006 = row [ "QUOL006" ] . ToString ( );
                }
                if ( row [ "QUOL007" ] != null )
                {
                    model . QUOL007 = row [ "QUOL007" ] . ToString ( );
                }
                if ( row [ "QUOL008" ] != null && row [ "QUOL008" ] . ToString ( ) != "" )
                {
                    model . QUOL008 = decimal . Parse ( row [ "QUOL008" ] . ToString ( ) );
                }
                if ( row [ "QUOL009" ] != null && row [ "QUOL009" ] . ToString ( ) != "" )
                {
                    model . QUOL009 = decimal . Parse ( row [ "QUOL009" ] . ToString ( ) );
                }
                if ( row [ "QUOL010" ] != null && row [ "QUOL010" ] . ToString ( ) != "" )
                {
                    model . QUOL010 = decimal . Parse ( row [ "QUOL010" ] . ToString ( ) );
                }
                if ( row [ "QUOL011" ] != null )
                {
                    model . QUOL011 = row [ "QUOL011" ] . ToString ( );
                }
                if ( row [ "QUOL012" ] != null && row [ "QUOL012" ] . ToString ( ) != "" )
                {
                    model . QUOL012 = decimal . Parse ( row [ "QUOL012" ] . ToString ( ) );
                }
                if ( row [ "QUOL013" ] != null && row [ "QUOL013" ] . ToString ( ) != "" )
                {
                    model . QUOL013 = int . Parse ( row [ "QUOL013" ] . ToString ( ) );
                }
                if ( row [ "QUOL014" ] != null && row [ "QUOL014" ] . ToString ( ) != "" )
                {
                    model . QUOL014 = decimal . Parse ( row [ "QUOL014" ] . ToString ( ) );
                }
                if ( row [ "QUOL015" ] != null && row [ "QUOL015" ] . ToString ( ) != "" )
                {
                    model . QUOL015 = decimal . Parse ( row [ "QUOL015" ] . ToString ( ) );
                }
                if ( row [ "QUOL016" ] != null )
                {
                    model . QUOL016 = row [ "QUOL016" ] . ToString ( );
                }
                if ( row [ "QUOL017" ] != null )
                {
                    model . QUOL017 = row [ "QUOL017" ] . ToString ( );
                }
                if ( row [ "QUOL018" ] != null && row [ "QUOL018" ] . ToString ( ) != "" )
                {
                    model . QUOL018 = decimal . Parse ( row [ "QUOL018" ] . ToString ( ) );
                }
                if ( row [ "QUOL019" ] != null && row [ "QUOL019" ] . ToString ( ) != "" )
                {
                    model . QUOL019 = decimal . Parse ( row [ "QUOL019" ] . ToString ( ) );
                }
                if ( row [ "QUOL020" ] != null && row [ "QUOL020" ] . ToString ( ) != "" )
                {
                    model . QUOL020 = decimal . Parse ( row [ "QUOL020" ] . ToString ( ) );
                }
                if ( row [ "QUOL021" ] != null && row [ "QUOL021" ] . ToString ( ) != "" )
                {
                    model . QUOL021 = decimal . Parse ( row [ "QUOL021" ] . ToString ( ) );
                }
                if ( row [ "QUOL022" ] != null && row [ "QUOL022" ] . ToString ( ) != "" )
                {
                    model . QUOL022 = decimal . Parse ( row [ "QUOL022" ] . ToString ( ) );
                }
                if ( row [ "QUOL023" ] != null && row [ "QUOL023" ] . ToString ( ) != "" )
                {
                    model . QUOL023 = decimal . Parse ( row [ "QUOL023" ] . ToString ( ) );
                }
                if ( row [ "QUOL024" ] != null )
                {
                    model . QUOL024 = row [ "QUOL024" ] . ToString ( );
                }
                if ( row [ "QUOL025" ] != null && row [ "QUOL025" ] . ToString ( ) != "" )
                {
                    model . QUOL025 = decimal . Parse ( row [ "QUOL025" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存数据  495
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOLEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOLEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOL(" );
            strSql . Append ( "QUOL001,QUOL002,QUOL003,QUOL004,QUOL005,QUOL006,QUOL007,QUOL008,QUOL009,QUOL010,QUOL011,QUOL012,QUOL013,QUOL014,QUOL015,QUOL016,QUOL017,QUOL018,QUOL019,QUOL020,QUOL021,QUOL022,QUOL023,QUOL024,QUOL025)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOL001,@QUOL002,@QUOL003,@QUOL004,@QUOL005,@QUOL006,@QUOL007,@QUOL008,@QUOL009,@QUOL010,@QUOL011,@QUOL012,@QUOL013,@QUOL014,@QUOL015,@QUOL016,@QUOL017,@QUOL018,@QUOL019,@QUOL020,@QUOL021,@QUOL022,@QUOL023,@QUOL024,@QUOL025)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOL001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL005", SqlDbType.Int,4),
                    new SqlParameter("@QUOL006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL013", SqlDbType.Int,4),
                    new SqlParameter("@QUOL014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL016", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL017", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL024", SqlDbType.NVarChar,10),
                    new SqlParameter("@QUOL025", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOL001;
            parameters [ 1 ] . Value = model . QUOL002;
            parameters [ 2 ] . Value = model . QUOL003;
            parameters [ 3 ] . Value = model . QUOL004;
            parameters [ 4 ] . Value = model . QUOL005;
            parameters [ 5 ] . Value = model . QUOL006;
            parameters [ 6 ] . Value = model . QUOL007;
            parameters [ 7 ] . Value = model . QUOL008;
            parameters [ 8 ] . Value = model . QUOL009;
            parameters [ 9 ] . Value = model . QUOL010;
            parameters [ 10 ] . Value = model . QUOL011;
            parameters [ 11 ] . Value = model . QUOL012;
            parameters [ 12 ] . Value = model . QUOL013;
            parameters [ 13 ] . Value = model . QUOL014;
            parameters [ 14 ] . Value = model . QUOL015;
            parameters [ 15 ] . Value = model . QUOL016;
            parameters [ 16 ] . Value = model . QUOL017;
            parameters [ 17 ] . Value = model . QUOL018;
            parameters [ 18 ] . Value = model . QUOL019;
            parameters [ 19 ] . Value = model . QUOL020;
            parameters [ 20 ] . Value = model . QUOL021;
            parameters [ 21 ] . Value = model . QUOL022;
            parameters [ 22 ] . Value = model . QUOL023;
            parameters [ 23 ] . Value = model . QUOL024;
            parameters [ 24 ] . Value = model . QUOL025;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOLEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOL set " );
            strSql . Append ( "QUOL001=@QUOL001," );
            strSql . Append ( "QUOL002=@QUOL002," );
            strSql . Append ( "QUOL003=@QUOL003," );
            strSql . Append ( "QUOL004=@QUOL004," );
            strSql . Append ( "QUOL005=@QUOL005," );
            strSql . Append ( "QUOL006=@QUOL006," );
            strSql . Append ( "QUOL007=@QUOL007," );
            strSql . Append ( "QUOL008=@QUOL008," );
            strSql . Append ( "QUOL009=@QUOL009," );
            strSql . Append ( "QUOL010=@QUOL010," );
            strSql . Append ( "QUOL011=@QUOL011," );
            strSql . Append ( "QUOL012=@QUOL012," );
            strSql . Append ( "QUOL013=@QUOL013," );
            strSql . Append ( "QUOL014=@QUOL014," );
            strSql . Append ( "QUOL015=@QUOL015," );
            strSql . Append ( "QUOL016=@QUOL016," );
            strSql . Append ( "QUOL017=@QUOL017," );
            strSql . Append ( "QUOL018=@QUOL018," );
            strSql . Append ( "QUOL019=@QUOL019," );
            strSql . Append ( "QUOL020=@QUOL020," );
            strSql . Append ( "QUOL021=@QUOL021," );
            strSql . Append ( "QUOL022=@QUOL022," );
            strSql . Append ( "QUOL023=@QUOL023," );
            strSql . Append ( "QUOL024=@QUOL024," );
            strSql . Append ( "QUOL025=@QUOL025" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOL001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL005", SqlDbType.Int,4),
                    new SqlParameter("@QUOL006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL011", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL013", SqlDbType.Int,4),
                    new SqlParameter("@QUOL014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL015", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL016", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL017", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOL018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL020", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL021", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL022", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL023", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOL024", SqlDbType.NVarChar,10),
                    new SqlParameter("@QUOL025", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOL001;
            parameters [ 1 ] . Value = model . QUOL002;
            parameters [ 2 ] . Value = model . QUOL003;
            parameters [ 3 ] . Value = model . QUOL004;
            parameters [ 4 ] . Value = model . QUOL005;
            parameters [ 5 ] . Value = model . QUOL006;
            parameters [ 6 ] . Value = model . QUOL007;
            parameters [ 7 ] . Value = model . QUOL008;
            parameters [ 8 ] . Value = model . QUOL009;
            parameters [ 9 ] . Value = model . QUOL010;
            parameters [ 10 ] . Value = model . QUOL011;
            parameters [ 11 ] . Value = model . QUOL012;
            parameters [ 12 ] . Value = model . QUOL013;
            parameters [ 13 ] . Value = model . QUOL014;
            parameters [ 14 ] . Value = model . QUOL015;
            parameters [ 15 ] . Value = model . QUOL016;
            parameters [ 16 ] . Value = model . QUOL017;
            parameters [ 17 ] . Value = model . QUOL018;
            parameters [ 18 ] . Value = model . QUOL019;
            parameters [ 19 ] . Value = model . QUOL020;
            parameters [ 20 ] . Value = model . QUOL021;
            parameters [ 21 ] . Value = model . QUOL022;
            parameters [ 22 ] . Value = model . QUOL023;
            parameters [ 23 ] . Value = model . QUOL024;
            parameters [ 24 ] . Value = model . QUOL025;
            parameters [ 25 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "delete from R_QUOL " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            if ( rows > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
