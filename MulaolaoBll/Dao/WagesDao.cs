using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Collections;
using System . Data;
using System . Data . SqlClient;

namespace MulaolaoBll . Dao
{
    public class WagesDao
    {
        /*
        public bool Save ( )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            MulaolaoLibrary . WagesEntity _model = new MulaolaoLibrary . WagesEntity ( );

            #region 白坯

            #endregion

            #region 后段

            #endregion

            #region 检验

            #endregion

            #region 包装

            #endregion

            #region 承揽

            #endregion

        }

        DataTable getBP ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "" );
        }

        */


        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Edit ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            MulaolaoLibrary . WagesEntity _model = new MulaolaoLibrary . WagesEntity ( );

            if ( table != null && table . Rows . Count > 0 )
            {
                for ( int i = 0 ; i < table . Rows . Count ; i++ )
                {
                    _model . EC002 = table . Rows [ i ] [ "EC002" ] . ToString ( );
                    _model . EC024 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EC024" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EC024" ] . ToString ( ) );
                    _model . EC025 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EC025" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EC025" ] . ToString ( ) );
                    _model . EC026 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EC026" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EC026" ] . ToString ( ) );
                    _model . EC027 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EC027" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EC027" ] . ToString ( ) );
                    _model . EC028 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EC028" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EC028" ] . ToString ( ) );
                    //_model . EC029 = table . Rows [ i ] [ "EC029" ] . ToString ( );
                    //_model . EC030 = table . Rows [ i ] [ "EC030" ] . ToString ( );

                    editAll ( SQLString ,strSql ,_model );
                }
            }
            else
                return false;

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void editAll ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC024=@EC024," );
            strSql . Append ( "EC025=@EC025," );
            strSql . Append ( "EC026=@EC026," );
            strSql . Append ( "EC027=@EC027," );
            strSql . Append ( "EC028=@EC028," );
            strSql . Append ( "EC029=@EC029," );
            strSql . Append ( "EC030=@EC030 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parametre = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC024",SqlDbType.Decimal,18),
                new SqlParameter("@EC025",SqlDbType.Decimal,18),
                new SqlParameter("@EC026",SqlDbType.Decimal,18),
                new SqlParameter("@EC027",SqlDbType.Decimal,18),
                new SqlParameter("@EC028",SqlDbType.Decimal,18),
                new SqlParameter("@EC029",SqlDbType.NVarChar,50),
                new SqlParameter("@EC030",SqlDbType.NVarChar,255)
            };
            parametre [ 0 ] . Value = _model . EC002;
            parametre [ 1 ] . Value = _model . EC024;
            parametre [ 2 ] . Value = _model . EC025;
            parametre [ 3 ] . Value = _model . EC026;
            parametre [ 4 ] . Value = _model . EC027;
            parametre [ 5 ] . Value = _model . EC028;
            parametre [ 6 ] . Value = _model . EC029;
            parametre [ 7 ] . Value = _model . EC030;

            SQLString . Add ( strSql ,parametre );
        }

        /// <summary>
        /// 获取产品名称
        /// </summary>
        /// <returns></returns>
        public DataTable getPro ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT AM002,AM003,AM005 FROM R_PQAM " );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTabelView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT idx,EC001,EC002,EC003,EC004,EC005,ISNULL(EC006,0) EC006,ISNULL(EC007,0)EC007,ISNULL(EC008,0)EC008,ISNULL(EC009,0)EC009,ISNULL(EC010,0)EC010,ISNULL(EC011,0)EC011,ISNULL(EC012,0)EC012,ISNULL(EC013,0)EC013,ISNULL(EC014,0)EC014,ISNULL(EC015,0)EC015,ISNULL(EC016,0)EC016,ISNULL(EC017,0)EC017,ISNULL(EC018,0)EC018,ISNULL(EC019,0)EC019,ISNULL(EC020,0)EC020,ISNULL(EC021,0)EC021,ISNULL(EC022,0)EC022,ISNULL(EC023,0)EC023,ISNULL(EC024,0)EC024,ISNULL(EC025,0)EC025,ISNULL(EC026,0)EC026,ISNULL(EC027,0)EC027,ISNULL(EC028,0)EC028,ISNULL(EC029,0)EC029,ISNULL(EC030,0)EC030,ISNULL(EC031,0)EC031,ISNULL(EC032,0)EC032 FROM R_PQEC WHERE {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool Save ( string strWhere )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            MulaolaoLibrary . WagesEntity _model = new MulaolaoLibrary . WagesEntity ( );

            DataTable table = getTableForNum ( strWhere );

            if ( table != null && table . Rows . Count > 0 )
            {
                foreach ( DataRow row in table . Rows )
                {
                    _model . EC001 = row [ "PQF04" ] . ToString ( );
                    _model . EC002 = row [ "PQF01" ] . ToString ( );
                    _model . EC003 = row [ "PQF03" ] . ToString ( );
                    _model . EC004 = string . IsNullOrEmpty ( row [ "PQF06" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "PQF06" ] . ToString ( ) );
                    if ( string . IsNullOrEmpty ( row [ "PQF31" ] . ToString ( ) ) )
                        _model . EC005 = null;
                    else
                        _model . EC005 = Convert . ToDateTime ( row [ "PQF31" ] . ToString ( ) );

                    if ( !Exists ( _model ) )
                        addW ( SQLString ,strSql ,_model );
                }
            }
            DataRow [ ] rows;
            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = getTableFor509 ( strWhere );
                if ( table != null && table . Rows . Count > 0 )
                {
                    rows = table . Select ( "GS72='" + DicStr . dk + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC019 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509DK ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . rzy + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC021 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509RZY ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . qdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC006 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509QD ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . hdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC009 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509HD ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . jygz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC012 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509JY ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . bzgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC015 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509BZ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . gq + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC024 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509GQ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . pq + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC027 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509PQ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "GS72='" + DicStr . clgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GS01" ] . ToString ( );
                            _model . EC030 = string . IsNullOrEmpty ( row [ "GS36" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS36" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor509CL ( SQLString ,strSql ,_model );
                        }
                    }

                }
            }


            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = getTableFor317 ( strWhere );
                if ( table != null && table . Rows . Count > 0 )
                {
                    rows = table . Select ( "LX='" + DicStr . qdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC008 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317QD ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . hdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC011 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317HD ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . jygz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC014 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317JY ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . bzgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC017 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317BZ ( SQLString ,strSql ,_model );
                        }
                    }
                }
            }

            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = getTableFor317YJ ( strWhere );
                if ( table != null && table . Rows . Count > 0 )
                {
                    rows = table . Select ( "LX='" + DicStr . qdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC007 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317QDYJ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . hdgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC010 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317HDYJ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . jygz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC013 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317JYYJ ( SQLString ,strSql ,_model );
                        }
                    }
                    rows = table . Select ( "LX='" + DicStr . bzgz + "'" );
                    if ( rows . Length > 0 )
                    {
                        foreach ( DataRow row in rows )
                        {
                            _model . EC002 = row [ "GZ01" ] . ToString ( );
                            _model . EC016 = string . IsNullOrEmpty ( row [ "DJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DJ" ] . ToString ( ) );
                            if ( Exists ( _model ) )
                                editFor317BZYJ ( SQLString ,strSql ,_model );
                        }
                    }
                }
            }

            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = getTableFor241XJ ( strWhere );
                if ( table != null && table . Rows . Count > 0 )
                {
                    foreach ( DataRow row in table . Rows )
                    {
                        _model . EC002 = row [ "AM002" ] . ToString ( );
                        _model . EC020 = string . IsNullOrEmpty ( row [ "DK" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DK" ] . ToString ( ) );
                        _model . EC023 = string . IsNullOrEmpty ( row [ "RZY" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "RZY" ] . ToString ( ) );
                        _model . EC026 = string . IsNullOrEmpty ( row [ "GQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GQ" ] . ToString ( ) );
                        _model . EC029 = string . IsNullOrEmpty ( row [ "PQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "PQ" ] . ToString ( ) );
                        _model . EC032 = string . IsNullOrEmpty ( row [ "BZFL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "BZFL" ] . ToString ( ) );
                        if ( Exists ( _model ) )
                            editFor241DK ( SQLString ,strSql ,_model );
                    }
                }
            }

            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = getTableFor241YJ ( strWhere );
                if ( table != null && table . Rows . Count > 0 )
                {
                    foreach ( DataRow row in table . Rows )
                    {
                        _model . EC002 = row [ "AM002" ] . ToString ( );
                        _model . EC019 = string . IsNullOrEmpty ( row [ "DK" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "DK" ] . ToString ( ) );
                        _model . EC022 = string . IsNullOrEmpty ( row [ "RZY" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "RZY" ] . ToString ( ) );
                        _model . EC025 = string . IsNullOrEmpty ( row [ "GQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GQ" ] . ToString ( ) );
                        _model . EC028 = string . IsNullOrEmpty ( row [ "PQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "PQ" ] . ToString ( ) );
                        _model . EC031 = string . IsNullOrEmpty ( row [ "BZFL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "BZFL" ] . ToString ( ) );
                        if ( Exists ( _model ) )
                            editFor241DKYJ ( SQLString ,strSql ,_model );
                    }
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }
        
        void addW ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO R_PQEC (" );
            strSql . Append ( "EC001,EC002,EC003,EC004,EC005) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@EC001,@EC002,@EC003,@EC004,@EC005) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC001",SqlDbType.NVarChar,50),
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC003",SqlDbType.NVarChar,50),
                new SqlParameter("@EC004",SqlDbType.Int,4),
                new SqlParameter("@EC005",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _model . EC001;
            parameter [ 1 ] . Value = _model . EC002;
            parameter [ 2 ] . Value = _model . EC003;
            parameter [ 3 ] . Value = _model . EC004;
            parameter [ 4 ] . Value = _model . EC005;

            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// 509 雕刻
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509DK ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC019=@EC019 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC019",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC019;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor241DK ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC020=@EC020," );
            strSql . Append ( "EC023=@EC023," );
            strSql . Append ( "EC026=@EC026," );
            strSql . Append ( "EC029=@EC029," );
            strSql . Append ( "EC032=@EC032 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC020",SqlDbType.Decimal,18),
                new SqlParameter("@EC023",SqlDbType.Decimal,18),
                new SqlParameter("@EC026",SqlDbType.Decimal,18),
                new SqlParameter("@EC029",SqlDbType.Decimal,18),
                new SqlParameter("@EC032",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC020;
            parameter [ 2 ] . Value = _model . EC023;
            parameter [ 3 ] . Value = _model . EC026;
            parameter [ 4 ] . Value = _model . EC029;
            parameter [ 5 ] . Value = _model . EC032;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor241DKYJ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC019=@EC019," );
            strSql . Append ( "EC022=@EC022," );
            strSql . Append ( "EC025=@EC025," );
            strSql . Append ( "EC028=@EC028," );
            strSql . Append ( "EC031=@EC031 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC019",SqlDbType.Decimal,18),
                new SqlParameter("@EC022",SqlDbType.Decimal,18),
                new SqlParameter("@EC025",SqlDbType.Decimal,18),
                new SqlParameter("@EC028",SqlDbType.Decimal,18),
                new SqlParameter("@EC031",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC019;
            parameter [ 2 ] . Value = _model . EC022;
            parameter [ 3 ] . Value = _model . EC025;
            parameter [ 4 ] . Value = _model . EC028;
            parameter [ 5 ] . Value = _model . EC031;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 热转印
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509RZY ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC021=@EC021 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC021",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC021;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 前道
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509QD ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC006=@EC006 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC006",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC006;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317QD ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC008=@EC008 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC008",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC008;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317QDYJ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC007=@EC007 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC007",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC007;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 后道
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509HD ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC009=@EC009 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC009",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC009;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317HD ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC011=@EC011 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC011",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC011;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317HDYJ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC010=@EC010 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC010",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC010;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 检验
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509JY ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC012=@EC012 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC012",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC012;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317JY ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC014=@EC014 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC014",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC014;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317JYYJ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC013=@EC013 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC013",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC013;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 包装
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509BZ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC015=@EC015 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC015",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC015;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317BZ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC017=@EC017 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC017",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC017;

            SQLString . Add ( strSql ,parameter );
        }
        void editFor317BZYJ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC016=@EC016 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC016",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC016;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 滚漆
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509GQ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC024=@EC024 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC024",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC024;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 喷漆
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509PQ ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC027=@EC027 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC027",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC027;

            SQLString . Add ( strSql ,parameter );
        }
        /// <summary>
        /// 承揽
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void editFor509CL ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . WagesEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEC SET " );
            strSql . Append ( "EC030=@EC030 " );
            strSql . Append ( "WHERE EC002=@EC002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EC002",SqlDbType.NVarChar,50),
                new SqlParameter("@EC030",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EC002;
            parameter [ 1 ] . Value = _model . EC030;

            SQLString . Add ( strSql ,parameter );
        }


        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        bool Exists ( MulaolaoLibrary . WagesEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM R_PQEC WHERE EC002='{0}'" ,_model . EC002 );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取流水号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableForNum ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT PQF01,PQF03,PQF04,PQF06,PQF31 FROM R_PQF WHERE {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取509单价
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableFor509 ( string strWhere )
        {
            string strOne = string . Empty, strTwo = string . Empty;
            strOne = "'" + DicStr . qdgz + "'";
            strOne = strOne + "," + "'" + DicStr . hdgz + "'";
            strOne = strOne + "," + "'" + DicStr . jygz + "'";
            strOne = strOne + "," + "'" + DicStr . bzgz + "'";
            strOne = strOne + "," + "'" + DicStr . gq + "'";
            strOne = strOne + "," + "'" + DicStr . pq + "'";
            strOne = strOne + "," + "'" + DicStr . clgz + "'";

            strTwo = "'" + DicStr . dk + "'";
            strTwo = strTwo+","+ "'" + DicStr . rzy + "'";

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "WITH CET AS ( " );
            strSql . AppendFormat ( "SELECT GS01,GS72,CONVERT(FLOAT,SUM(GS36)) GS36 FROM R_PQP A INNER JOIN R_PQF B ON A.GS01=B.PQF01 WHERE GS72 IN ({1}) AND GS35 NOT IN ({2}) AND GS01 IS NOT NULL AND {0} GROUP BY GS01,GS72)," ,strWhere ,strOne ,strTwo );
            strSql . Append ( "CFT AS (" );
            strSql . AppendFormat ( "SELECT GS01,GS35,CONVERT(FLOAT,SUM(GS36)) GS36 FROM R_PQP A INNER JOIN R_PQF B ON A.GS01=B.PQF01 WHERE GS35 IN ({1}) AND GS01 IS NOT NULL AND {0} GROUP BY GS01,GS35)" ,strWhere ,strTwo );
            strSql . Append ( ",CHT AS (SELECT * FROM CET A UNION ALL SELECT * FROM CFT B) " );
            strSql . Append ( "SELECT GS01,GS72,SUM(GS36) GS36 FROM CHT GROUP BY GS01,GS72 ORDER BY GS01" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 317 单价现价
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableFor317 ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GZ01,'{1}' LX,SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 DJ FROM R_PQW A INNER JOIN TPADBA B ON A.GZ32=B.DBA001 INNER JOIN R_PQF C ON A.GZ01=C.PQF01 WHERE DBA960='男' AND GZ04!='检验' AND {0} GROUP BY GZ01,GZ34" ,strWhere ,DicStr . qdgz );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( " SELECT GZ01,'{1}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN TPADBA B ON A.GZ32=B.DBA001  INNER JOIN R_PQF C ON A.GZ01=C.PQF01 WHERE DBA960 IN ('女','其他') AND GZ04!='检验' AND {0} GROUP BY GZ01,GZ34 " ,strWhere ,DicStr . hdgz );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( "SELECT GZ01,'{1}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN R_PQF C ON A.GZ01=C.PQF01 WHERE GZ04='检验' AND {0} GROUP BY GZ01,GZ34" ,strWhere ,DicStr . jygz );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( "SELECT GZ01,'{1}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN R_PQF C ON A.GZ01=C.PQF01 WHERE GZ04='包装' AND {0} GROUP BY GZ01,GZ34" ,strWhere ,DicStr . bzgz );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 317 单价原价
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableFor317YJ ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT DISTINCT A.GZ01,(SELECT TOP 1 B.GZ01 FROM R_PQW B WHERE A.GZ23=B.GZ23 AND A.GZ01>B.GZ01 ORDER BY B.GZ01 DESC) GZ FROM R_PQW A INNER JOIN R_PQF C ON A.GZ01=C.PQF01 WHERE {0})" ,strWhere );
            strSql . AppendFormat ( "SELECT D.GZ01,'{1}' LX,SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 DJ FROM R_PQW A INNER JOIN TPADBA B ON A.GZ32=B.DBA001 INNER JOIN R_PQF C ON A.GZ01=C.PQF01 INNER JOIN CET D ON A.GZ01=D.GZ01 WHERE DBA960='男' AND GZ04!='检验' AND {1} GROUP BY D.GZ01,GZ34" ,DicStr . qdgz ,strWhere );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( "SELECT D.GZ01,'{0}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN TPADBA B ON A.GZ32=B.DBA001  INNER JOIN R_PQF C ON A.GZ01=C.PQF01 INNER JOIN CET D ON A.GZ01=D.GZ01 WHERE DBA960 IN ('女','其他') AND GZ04!='检验' AND {1} GROUP BY D.GZ01,GZ34" ,DicStr . hdgz ,strWhere );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( "SELECT D.GZ01,'{0}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN R_PQF C ON A.GZ01=C.PQF01 INNER JOIN CET D ON A.GZ01=D.GZ01 WHERE GZ04='检验' AND {1} GROUP BY D.GZ01,GZ34" ,DicStr . jygz ,strWhere );
            strSql . Append ( " UNION ALL " );
            strSql . AppendFormat ( "SELECT D.GZ01,'{0}',SUM(GZ06*GZ25*1.0*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 FROM R_PQW A INNER JOIN R_PQF C ON A.GZ01=C.PQF01 INNER JOIN CET D ON A.GZ01=D.GZ01 WHERE GZ04='包装' AND {1} GROUP BY D.GZ01,GZ34" ,DicStr . bzgz ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 241 单价现价
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableFor241XJ ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT AM002,AM071/AM006 DK,AM085/AM006 RZY,AM250/AM006 GQ,AM089/AM006 PQ,(AM073+AM075+AM077+AM079+AM081+AM083+AM087+AM091+AM093)/AM006 BZFL FROM R_PQAM A INNER JOIN R_PQF C ON A.AM002=C.PQF01 WHERE AM006!=0 and {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 241 单价原价
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getTableFor241YJ ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT B.AM002,(SELECT TOP 1 AM002 FROM R_PQAM A WHERE A.AM005=B.AM005 AND A.AM002<B.AM002 ORDER BY A.AM002 DESC) AM FROM R_PQAM B INNER JOIN R_PQF C ON B.AM002=C.PQF01 WHERE {0})" ,strWhere );
            strSql . AppendFormat ( "SELECT D.AM002,AM071/AM006 DK,AM085/AM006 RZY,AM250/AM006 GQ,AM089/AM006 PQ,(AM073+AM075+AM077+AM079+AM081+AM083+AM087+AM091+AM093)/AM006 BZFL FROM R_PQAM A INNER JOIN R_PQF C ON A.AM002=C.PQF01 INNER JOIN CET D ON A.AM002=D.AM002 WHERE AM006!=0 and {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 检验
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getCheck ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT GZ01,GZ23,GZ22,PQF31,SUM(GZ06*GZ25*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 GZ,GZ34 FROM R_PQW A INNER JOIN R_PQF E ON GZ01=PQF01 LEFT JOIN R_PQAA B ON A.GZ04=B.GX02 WHERE GX04='检验' AND {0} GROUP BY GZ01,GZ23,GZ34,GZ22,PQF31 " ,strWhere );
            strSql . Append ( "),CFT AS(" );
            strSql . Append ( "SELECT GZ01,GZ23,GZ22,PQF31,GZ34,SUM(GZ) GZ,(SELECT SUM(GZ) FROM CET WHERE GZ01 IN (SELECT MAX(GZ01) FROM CET B WHERE B.GZ01<A.GZ01 AND B.GZ23=A.GZ23 GROUP BY B.GZ23)) GZ1 FROM CET A GROUP BY GZ01,GZ23,GZ22,GZ34,PQF31) " );
            strSql . Append ( "SELECT GZ01,GZ23,GZ22,GZ34,PQF31,GZ,ISNULL(GZ1,0) GZ1 FROM CFT ORDER BY GZ01 " );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 包装
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable getPack ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT GZ01,GZ23,GZ22,PQF31,SUM(GZ06*GZ25*GZ41+GZ36*(GZ12+GZ13+GZ14))/GZ34 GZ,GZ34 FROM R_PQW A INNER JOIN R_PQF E ON GZ01=PQF01 LEFT JOIN R_PQAA B ON A.GZ04=B.GX02 WHERE GX04='包装' AND {0} GROUP BY GZ01,GZ23,GZ34,GZ22,PQF31 " ,strWhere );
            strSql . Append ( "),CFT AS(" );
            strSql . Append ( "SELECT GZ01,GZ23,GZ22,PQF31,GZ34,SUM(GZ) GZ,(SELECT SUM(GZ) FROM CET WHERE GZ01 IN (SELECT MAX(GZ01) FROM CET B WHERE B.GZ01<A.GZ01 AND B.GZ23=A.GZ23 GROUP BY B.GZ23)) GZ1 FROM CET A GROUP BY GZ01,GZ23,GZ22,GZ34,PQF31) " );
            strSql . Append ( "SELECT GZ01,GZ23,GZ22,GZ34,PQF31,GZ,ISNULL(GZ1,0) GZ1 FROM CFT ORDER BY GZ01 " );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
