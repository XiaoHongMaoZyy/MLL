using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class QUOCEDao
    {
        /// <summary>
        /// 获取338数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public MulaolaoLibrary . QUOCEntity getModel ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT * FROM R_QUOC WHERE idx={0}" ,idx );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return null;
            else
                return getDataRow ( table . Rows [ 0 ] );
        }

        public MulaolaoLibrary . QUOCEntity getDataRow ( DataRow row )
        {
            MulaolaoLibrary . QUOCEntity model = new MulaolaoLibrary . QUOCEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOC001" ] != null )
                {
                    model . QUOC001 = row [ "QUOC001" ] . ToString ( );
                }
                if ( row [ "QUOC002" ] != null )
                {
                    model . QUOC002 = row [ "QUOC002" ] . ToString ( );
                }
                if ( row [ "QUOC003" ] != null )
                {
                    model . QUOC003 = row [ "QUOC003" ] . ToString ( );
                }
                if ( row [ "QUOC004" ] != null )
                {
                    model . QUOC004 = row [ "QUOC004" ] . ToString ( );
                }
                if ( row [ "QUOC005" ] != null && row [ "QUOC005" ] . ToString ( ) != "" )
                {
                    model . QUOC005 = int . Parse ( row [ "QUOC005" ] . ToString ( ) );
                }
                if ( row [ "QUOC006" ] != null )
                {
                    model . QUOC006 = row [ "QUOC006" ] . ToString ( );
                }
                if ( row [ "QUOC007" ] != null && row [ "QUOC007" ] . ToString ( ) != "" )
                {
                    model . QUOC007 = decimal . Parse ( row [ "QUOC007" ] . ToString ( ) );
                }
                if ( row [ "QUOC008" ] != null && row [ "QUOC008" ] . ToString ( ) != "" )
                {
                    model . QUOC008 = decimal . Parse ( row [ "QUOC008" ] . ToString ( ) );
                }
                if ( row [ "QUOC009" ] != null && row [ "QUOC009" ] . ToString ( ) != "" )
                {
                    model . QUOC009 = decimal . Parse ( row [ "QUOC009" ] . ToString ( ) );
                }
                if ( row [ "QUOC010" ] != null && row [ "QUOC010" ] . ToString ( ) != "" )
                {
                    model . QUOC010 = decimal . Parse ( row [ "QUOC010" ] . ToString ( ) );
                }
                if ( row [ "QUOC011" ] != null && row [ "QUOC011" ] . ToString ( ) != "" )
                {
                    model . QUOC011 = decimal . Parse ( row [ "QUOC011" ] . ToString ( ) );
                }
                if ( row [ "QUOC012" ] != null && row [ "QUOC012" ] . ToString ( ) != "" )
                {
                    model . QUOC012 = decimal . Parse ( row [ "QUOC012" ] . ToString ( ) );
                }
                if ( row [ "QUOC013" ] != null && row [ "QUOC013" ] . ToString ( ) != "" )
                {
                    model . QUOC013 = decimal . Parse ( row [ "QUOC013" ] . ToString ( ) );
                }
                if ( row [ "QUOC014" ] != null && row [ "QUOC014" ] . ToString ( ) != "" )
                {
                    model . QUOC014 = decimal . Parse ( row [ "QUOC014" ] . ToString ( ) );
                }
                if ( row [ "QUOC015" ] != null )
                {
                    model . QUOC015 = row [ "QUOC015" ] . ToString ( );
                }
                if ( row [ "QUOC016" ] != null && row [ "QUOC016" ] . ToString ( ) != "" )
                {
                    model . QUOC016 = decimal . Parse ( row [ "QUOC016" ] . ToString ( ) );
                }
                if ( row [ "QUOC017" ] != null && row [ "QUOC017" ] . ToString ( ) != "" )
                {
                    model . QUOC017 = decimal . Parse ( row [ "QUOC017" ] . ToString ( ) );
                }
                if ( row [ "QUOC018" ] != null && row [ "QUOC018" ] . ToString ( ) != "" )
                {
                    model . QUOC018 = decimal . Parse ( row [ "QUOC018" ] . ToString ( ) );
                }
                if ( row [ "QUOC019" ] != null && row [ "QUOC019" ] . ToString ( ) != "" )
                {
                    model . QUOC019 = decimal . Parse ( row [ "QUOC019" ] . ToString ( ) );
                }
                if ( row [ "QUOC020" ] != null )
                {
                    model . QUOC020 = row [ "QUOC020" ] . ToString ( );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOCEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOCEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOC(" );
            strSql . Append ( "QUOC001,QUOC002,QUOC003,QUOC004,QUOC005,QUOC006,QUOC007,QUOC008,QUOC009,QUOC010,QUOC011,QUOC012,QUOC013,QUOC014,QUOC015,QUOC016,QUOC017,QUOC018,QUOC019,QUOC020)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOC001,@QUOC002,@QUOC003,@QUOC004,@QUOC005,@QUOC006,@QUOC007,@QUOC008,@QUOC009,@QUOC010,@QUOC011,@QUOC012,@QUOC013,@QUOC014,@QUOC015,@QUOC016,@QUOC017,@QUOC018,@QUOC019,@QUOC020)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOC001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC005", SqlDbType.Int,4),
                    new SqlParameter("@QUOC006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC007", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC015", SqlDbType.NVarChar,5),
                    new SqlParameter("@QUOC016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC020", SqlDbType.NVarChar,20)
            };
            parameters [ 0 ] . Value = model . QUOC001;
            parameters [ 1 ] . Value = model . QUOC002;
            parameters [ 2 ] . Value = model . QUOC003;
            parameters [ 3 ] . Value = model . QUOC004;
            parameters [ 4 ] . Value = model . QUOC005;
            parameters [ 5 ] . Value = model . QUOC006;
            parameters [ 6 ] . Value = model . QUOC007;
            parameters [ 7 ] . Value = model . QUOC008;
            parameters [ 8 ] . Value = model . QUOC009;
            parameters [ 9 ] . Value = model . QUOC010;
            parameters [ 10 ] . Value = model . QUOC011;
            parameters [ 11 ] . Value = model . QUOC012;
            parameters [ 12 ] . Value = model . QUOC013;
            parameters [ 13 ] . Value = model . QUOC014;
            parameters [ 14 ] . Value = model . QUOC015;
            parameters [ 15 ] . Value = model . QUOC016;
            parameters [ 16 ] . Value = model . QUOC017;
            parameters [ 17 ] . Value = model . QUOC018;
            parameters [ 18 ] . Value = model . QUOC019;
            parameters [ 19 ] . Value = model . QUOC020;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOCEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOC set " );
            strSql . Append ( "QUOC001=@QUOC001," );
            strSql . Append ( "QUOC002=@QUOC002," );
            strSql . Append ( "QUOC003=@QUOC003," );
            strSql . Append ( "QUOC004=@QUOC004," );
            strSql . Append ( "QUOC005=@QUOC005," );
            strSql . Append ( "QUOC006=@QUOC006," );
            strSql . Append ( "QUOC007=@QUOC007," );
            strSql . Append ( "QUOC008=@QUOC008," );
            strSql . Append ( "QUOC009=@QUOC009," );
            strSql . Append ( "QUOC010=@QUOC010," );
            strSql . Append ( "QUOC011=@QUOC011," );
            strSql . Append ( "QUOC012=@QUOC012," );
            strSql . Append ( "QUOC013=@QUOC013," );
            strSql . Append ( "QUOC014=@QUOC014," );
            strSql . Append ( "QUOC015=@QUOC015," );
            strSql . Append ( "QUOC016=@QUOC016," );
            strSql . Append ( "QUOC017=@QUOC017," );
            strSql . Append ( "QUOC018=@QUOC018," );
            strSql . Append ( "QUOC019=@QUOC019," );
            strSql . Append ( "QUOC020=@QUOC020" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOC001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC005", SqlDbType.Int,4),
                    new SqlParameter("@QUOC006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOC007", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC008", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC009", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC010", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC015", SqlDbType.NVarChar,5),
                    new SqlParameter("@QUOC016", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC017", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC018", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC019", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOC020", SqlDbType.NVarChar,20),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOC001;
            parameters [ 1 ] . Value = model . QUOC002;
            parameters [ 2 ] . Value = model . QUOC003;
            parameters [ 3 ] . Value = model . QUOC004;
            parameters [ 4 ] . Value = model . QUOC005;
            parameters [ 5 ] . Value = model . QUOC006;
            parameters [ 6 ] . Value = model . QUOC007;
            parameters [ 7 ] . Value = model . QUOC008;
            parameters [ 8 ] . Value = model . QUOC009;
            parameters [ 9 ] . Value = model . QUOC010;
            parameters [ 10 ] . Value = model . QUOC011;
            parameters [ 11 ] . Value = model . QUOC012;
            parameters [ 12 ] . Value = model . QUOC013;
            parameters [ 13 ] . Value = model . QUOC014;
            parameters [ 14 ] . Value = model . QUOC015;
            parameters [ 15 ] . Value = model . QUOC016;
            parameters [ 16 ] . Value = model . QUOC017;
            parameters [ 17 ] . Value = model . QUOC018;
            parameters [ 18 ] . Value = model . QUOC019;
            parameters [ 19 ] . Value = model . QUOC020;
            parameters [ 20 ] . Value = model . idx;

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
            strSql . AppendFormat ( "DELETE FROM R_QUOC WHERE idx={0}" ,idx );

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            return rows > 0 ? true : false;
        }

    }
}
