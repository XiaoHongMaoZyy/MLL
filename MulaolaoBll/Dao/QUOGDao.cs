using System;
using System . Collections . Generic;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Text;
using StudentMgr;

namespace MulaolaoBll . Dao
{
    public class QUOGDao
    {
        /// <summary>
		/// 得到一个对象实体  347
		/// </summary>
		public MulaolaoLibrary.QUOGEntity getModel ( int idx )
        {

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "select  top 1 idx,QUOG001,QUOG002,QUOG003,QUOG004,QUOG005,QUOG006,QUOG007,QUOG008,QUOG009,QUOG010,QUOG011,QUOG012,QUOG013,QUOG014,QUOG015 from R_QUOG " );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@idx", SqlDbType.Int,4)
            };
            parameters [ 0 ] . Value = idx;

            DataTable ds = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) ,parameters );
            if ( ds . Rows . Count > 0 )
                return DataRowToModel ( ds. Rows [ 0 ] );
            else
                return null;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MulaolaoLibrary . QUOGEntity DataRowToModel ( DataRow row )
        {
            MulaolaoLibrary . QUOGEntity model = new MulaolaoLibrary . QUOGEntity ( );
            if ( row != null )
            {
                if ( row [ "idx" ] != null && row [ "idx" ] . ToString ( ) != "" )
                {
                    model . idx = int . Parse ( row [ "idx" ] . ToString ( ) );
                }
                if ( row [ "QUOG001" ] != null )
                {
                    model . QUOG001 = row [ "QUOG001" ] . ToString ( );
                }
                if ( row [ "QUOG002" ] != null )
                {
                    model . QUOG002 = row [ "QUOG002" ] . ToString ( );
                }
                if ( row [ "QUOG003" ] != null )
                {
                    model . QUOG003 = row [ "QUOG003" ] . ToString ( );
                }
                if ( row [ "QUOG004" ] != null )
                {
                    model . QUOG004 = row [ "QUOG004" ] . ToString ( );
                }
                if ( row [ "QUOG005" ] != null && row [ "QUOG005" ] . ToString ( ) != "" )
                {
                    model . QUOG005 = int . Parse ( row [ "QUOG005" ] . ToString ( ) );
                }
                if ( row [ "QUOG006" ] != null )
                {
                    model . QUOG006 = row [ "QUOG006" ] . ToString ( );
                }
                if ( row [ "QUOG007" ] != null )
                {
                    model . QUOG007 = row [ "QUOG007" ] . ToString ( );
                }
                if ( row [ "QUOG008" ] != null )
                {
                    model . QUOG008 = row [ "QUOG008" ] . ToString ( );
                }
                if ( row [ "QUOG009" ] != null )
                {
                    model . QUOG009 = row [ "QUOG009" ] . ToString ( );
                }
                if ( row [ "QUOG010" ] != null )
                {
                    model . QUOG010 = row [ "QUOG010" ] . ToString ( );
                }
                if ( row [ "QUOG011" ] != null && row [ "QUOG011" ] . ToString ( ) != "" )
                {
                    model . QUOG011 = decimal . Parse ( row [ "QUOG011" ] . ToString ( ) );
                }
                if ( row [ "QUOG012" ] != null && row [ "QUOG012" ] . ToString ( ) != "" )
                {
                    model . QUOG012 = decimal . Parse ( row [ "QUOG012" ] . ToString ( ) );
                }
                if ( row [ "QUOG013" ] != null && row [ "QUOG013" ] . ToString ( ) != "" )
                {
                    model . QUOG013 = decimal . Parse ( row [ "QUOG013" ] . ToString ( ) );
                }
                if ( row [ "QUOG014" ] != null && row [ "QUOG014" ] . ToString ( ) != "" )
                {
                    model . QUOG014 = decimal . Parse ( row [ "QUOG014" ] . ToString ( ) );
                }
                if ( row [ "QUOG015" ] != null && row [ "QUOG015" ] . ToString ( ) != "" )
                {
                    model . QUOG015 = decimal . Parse ( row [ "QUOG015" ] . ToString ( ) );
                }
            }
            return model;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Save ( MulaolaoLibrary . QUOGEntity model )
        {
            if ( model . idx < 1 )
                return add ( model );
            else
                return edit ( model );
        }

        int add ( MulaolaoLibrary . QUOGEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "insert into R_QUOG(" );
            strSql . Append ( "QUOG001,QUOG002,QUOG003,QUOG004,QUOG005,QUOG006,QUOG007,QUOG008,QUOG009,QUOG010,QUOG011,QUOG012,QUOG013,QUOG014,QUOG015)" );
            strSql . Append ( " values (" );
            strSql . Append ( "@QUOG001,@QUOG002,@QUOG003,@QUOG004,@QUOG005,@QUOG006,@QUOG007,@QUOG008,@QUOG009,@QUOG010,@QUOG011,@QUOG012,@QUOG013,@QUOG014,@QUOG015)" );
            strSql . Append ( ";select @@IDENTITY" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOG001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG005", SqlDbType.Int,4),
                    new SqlParameter("@QUOG006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG015", SqlDbType.Decimal,9)};
            parameters [ 0 ] . Value = model . QUOG001;
            parameters [ 1 ] . Value = model . QUOG002;
            parameters [ 2 ] . Value = model . QUOG003;
            parameters [ 3 ] . Value = model . QUOG004;
            parameters [ 4 ] . Value = model . QUOG005;
            parameters [ 5 ] . Value = model . QUOG006;
            parameters [ 6 ] . Value = model . QUOG007;
            parameters [ 7 ] . Value = model . QUOG008;
            parameters [ 8 ] . Value = model . QUOG009;
            parameters [ 9 ] . Value = model . QUOG010;
            parameters [ 10 ] . Value = model . QUOG011;
            parameters [ 11 ] . Value = model . QUOG012;
            parameters [ 12 ] . Value = model . QUOG013;
            parameters [ 13 ] . Value = model . QUOG014;
            parameters [ 14 ] . Value = model . QUOG015;

            return SqlHelper . ExecuteSqlReturnId ( strSql . ToString ( ) ,parameters );
        }

        int edit ( MulaolaoLibrary . QUOGEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "update R_QUOG set " );
            strSql . Append ( "QUOG001=@QUOG001," );
            strSql . Append ( "QUOG002=@QUOG002," );
            strSql . Append ( "QUOG003=@QUOG003," );
            strSql . Append ( "QUOG004=@QUOG004," );
            strSql . Append ( "QUOG005=@QUOG005," );
            strSql . Append ( "QUOG006=@QUOG006," );
            strSql . Append ( "QUOG007=@QUOG007," );
            strSql . Append ( "QUOG008=@QUOG008," );
            strSql . Append ( "QUOG009=@QUOG009," );
            strSql . Append ( "QUOG010=@QUOG010," );
            strSql . Append ( "QUOG011=@QUOG011," );
            strSql . Append ( "QUOG012=@QUOG012," );
            strSql . Append ( "QUOG013=@QUOG013," );
            strSql . Append ( "QUOG014=@QUOG014," );
            strSql . Append ( "QUOG015=@QUOG015" );
            strSql . Append ( " where idx=@idx" );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@QUOG001", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG002", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG003", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG004", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG005", SqlDbType.Int,4),
                    new SqlParameter("@QUOG006", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG007", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG008", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG009", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG010", SqlDbType.NVarChar,20),
                    new SqlParameter("@QUOG011", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG012", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG013", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG014", SqlDbType.Decimal,9),
                    new SqlParameter("@QUOG015", SqlDbType.Decimal,9),
                    new SqlParameter("@idx", SqlDbType.Int,4)};
            parameters [ 0 ] . Value = model . QUOG001;
            parameters [ 1 ] . Value = model . QUOG002;
            parameters [ 2 ] . Value = model . QUOG003;
            parameters [ 3 ] . Value = model . QUOG004;
            parameters [ 4 ] . Value = model . QUOG005;
            parameters [ 5 ] . Value = model . QUOG006;
            parameters [ 6 ] . Value = model . QUOG007;
            parameters [ 7 ] . Value = model . QUOG008;
            parameters [ 8 ] . Value = model . QUOG009;
            parameters [ 9 ] . Value = model . QUOG010;
            parameters [ 10 ] . Value = model . QUOG011;
            parameters [ 11 ] . Value = model . QUOG012;
            parameters [ 12 ] . Value = model . QUOG013;
            parameters [ 13 ] . Value = model . QUOG014;
            parameters [ 14 ] . Value = model . QUOG015;
            parameters [ 15 ] . Value = model . idx;

            int rows = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameters );
            return rows > 0 ? model . idx : 0;
        }

        /// <summary>
        /// 删除347数据
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM R_QUOG WHERE idx={0}" ,idx );

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
            strSql . AppendFormat ( "SELECT GS07,GS08,GS09,CONVERT(FLOAT,GS10) GS10,GS71 FROM R_PQP WHERE GS07!='' AND GS70='R_347' AND GS01='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
