using System . Text;
using StudentMgr;
using System . Data;
using System . Collections;
using System;
using System . Data . SqlClient;
using System . Linq;

namespace MulaolaoBll . Dao
{
    public class MaterialDao
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        public bool Save ( string strWhere ,string num )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            MulaolaoLibrary . MaterialEntity _model = new MulaolaoLibrary . MaterialEntity ( );

            DataTable table;

            string nameOf = string . Empty;
            decimal price = 0M;

            table = get509 ( strWhere );
            if ( table != null && table . Rows . Count > 0 )
            {
                DataTable tableOne = table . DefaultView . ToTable ( true ,"GS46" ,"GS01" ,"GS48" ,"GS49" ,"PQF31" );

                if ( tableOne != null && tableOne . Rows . Count > 0 )
                {
                    foreach ( DataRow row in tableOne.Rows)
                    {
                        _model . EB001 = row [ "GS46" ] . ToString ( );
                        _model . EB002 = row [ "GS01" ] . ToString ( );
                        _model . EB003 = row [ "GS48" ] . ToString ( );
                        _model . EB004 = Convert . ToInt32 ( row [ "GS49" ] . ToString ( ) );
                        _model . EB005 = Convert . ToDateTime ( row [ "PQF31" ] . ToString ( ) );
                        if ( Exists ( _model ) == false )
                            addNum ( _model ,SQLString );
                    }
                }
                if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
                {
                    SQLString . Clear ( );
                    DataRow [ ] rows;
                    if ( tableOne != null && tableOne . Rows . Count > 0 )
                    {
                        foreach ( DataRow r in tableOne.Rows )
                        {
                            _model . EB002 = r [ "GS01" ] . ToString ( );
                            rows = table . Select ( "GS01='" + _model . EB002 + "'" );
                           
                            if ( rows . Length > 0 )
                            {
                                _model . EB006 = _model . EB009 = _model . EB012 = _model . EB015 = _model . EB018 = _model . EB021 = _model . EB024 = _model . EB027 = _model . EB030 = _model . EB033 = _model . EB036 = _model . EB039 = _model . EB042 = 0;
                                foreach ( DataRow row in rows )
                                {
                                    nameOf = row [ "GS71" ] . ToString ( );
                                    price = string . IsNullOrEmpty ( row [ "GS" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GS" ] );
                                    if ( DicStr . plyWood . Equals ( nameOf ) )
                                        _model . EB006 = price;
                                    else if ( DicStr . densityBoard . Equals ( nameOf ) )
                                        _model . EB009 = price;
                                    else if ( DicStr . wood . Equals ( nameOf ) )
                                        _model . EB012 = price;
                                    else if ( DicStr . vehicleParts . Equals ( nameOf ) )
                                        _model . EB015 = price;
                                    else if ( DicStr . lronParts . Equals ( nameOf ) )
                                        _model . EB018 = price;
                                    else if ( DicStr . plasticParts . Equals ( nameOf ) )
                                        _model . EB021 = price;
                                    else if ( DicStr . otherMaterials . Equals ( nameOf ) )
                                        _model . EB024 = price;
                                    else if ( DicStr . packAccess . Equals ( nameOf ) )
                                        _model . EB027 = price;
                                    else if ( "纸箱" . Equals ( nameOf ) )
                                        _model . EB030 = price;
                                    else if ( DicStr . giftBox . Equals ( nameOf ) )
                                        _model . EB033 = price;
                                    else if ( DicStr . endProductOut . Equals ( nameOf ) )
                                        _model . EB036 = price;
                                    else if ( DicStr . oilRoller . Equals ( nameOf ) )
                                        _model . EB039 = price;
                                    else if ( DicStr . inject . Equals ( nameOf ) )
                                        _model . EB042 = price;
                                }
                                edit509 ( _model ,SQLString );
                            }
                        }
                    }
                }
            }

            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = get241 ( strWhere );
                if ( table != null || table . Rows . Count > 0 )
                {
                    foreach ( DataRow row in table . Rows )
                    {
                        _model . EB002 = row [ "AM002" ] . ToString ( );
                        _model . EB008 = string . IsNullOrEmpty ( row [ "JHB" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "JHB" ] );
                        _model . EB011 = string . IsNullOrEmpty ( row [ "MDB" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "MDB" ] );
                        _model . EB014 = string . IsNullOrEmpty ( row [ "MC" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "MC" ] );
                        _model . EB017 = string . IsNullOrEmpty ( row [ "CMJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CMJ" ] );
                        _model . EB020 = string . IsNullOrEmpty ( row [ "TJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "TJ" ] );
                        _model . EB023 = string . IsNullOrEmpty ( row [ "SLJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "SLJ" ] );
                        _model . EB026 = string . IsNullOrEmpty ( row [ "QTCL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "QTCL" ] );
                        _model . EB029 = string . IsNullOrEmpty ( row [ "BZFL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "BZFL" ] );
                        _model . EB032 = string . IsNullOrEmpty ( row [ "ZX" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "ZX" ] );
                        _model . EB035 = string . IsNullOrEmpty ( row [ "CH" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CH" ] );
                        _model . EB038 = string . IsNullOrEmpty ( row [ "CPWW" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CPWW" ] );
                        _model . EB041 = string . IsNullOrEmpty ( row [ "GQYQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GQYQ" ] );
                        _model . EB044 = string . IsNullOrEmpty ( row [ "PQYQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "PQYQ" ] );
                        edit241xj ( _model ,SQLString );
                    }
                }
            }


            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                SQLString . Clear ( );
                table = get241pre ( strWhere );
                if ( table != null || table . Rows . Count > 0 )
                {
                    foreach ( DataRow row in table . Rows )
                    {
                        _model . EB002 = row [ "AM002" ] . ToString ( );
                        _model . EB007 = string . IsNullOrEmpty ( row [ "JHB" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "JHB" ] );
                        _model . EB010 = string . IsNullOrEmpty ( row [ "MDB" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "MDB" ] );
                        _model . EB013 = string . IsNullOrEmpty ( row [ "MC" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "MC" ] );
                        _model . EB016 = string . IsNullOrEmpty ( row [ "CMJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CMJ" ] );
                        _model . EB019 = string . IsNullOrEmpty ( row [ "TJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "TJ" ] );
                        _model . EB022 = string . IsNullOrEmpty ( row [ "SLJ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "SLJ" ] );
                        _model . EB025 = string . IsNullOrEmpty ( row [ "QTCL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "QTCL" ] );
                        _model . EB028 = string . IsNullOrEmpty ( row [ "BZFL" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "BZFL" ] );
                        _model . EB031 = string . IsNullOrEmpty ( row [ "ZX" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "ZX" ] );
                        _model . EB034 = string . IsNullOrEmpty ( row [ "CH" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CH" ] );
                        _model . EB037 = string . IsNullOrEmpty ( row [ "CPWW" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "CPWW" ] );
                        _model . EB040 = string . IsNullOrEmpty ( row [ "GQYQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "GQYQ" ] );
                        _model . EB043 = string . IsNullOrEmpty ( row [ "PQYQ" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( row [ "PQYQ" ] );
                        edit241yj ( _model ,SQLString );
                    }
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        //流水信息
        void addNum ( MulaolaoLibrary . MaterialEntity _model ,Hashtable SQLString )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO R_PQEB (" );
            strSql . Append ( "EB001,EB002,EB003,EB004,EB005) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@EB001,@EB002,@EB003,@EB004,@EB005) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EB001",SqlDbType.NVarChar,50),
                new SqlParameter("@EB002",SqlDbType.NVarChar,50),
                new SqlParameter("@EB003",SqlDbType.NVarChar,50),
                new SqlParameter("@EB004",SqlDbType.Int,4),
                new SqlParameter("@EB005",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _model . EB001;
            parameter [ 1 ] . Value = _model . EB002;
            parameter [ 2 ] . Value = _model . EB003;
            parameter [ 3 ] . Value = _model . EB004;
            parameter [ 4 ] . Value = _model . EB005;

            SQLString . Add ( strSql ,parameter );
        }

        //509
        void edit509 ( MulaolaoLibrary . MaterialEntity _model ,Hashtable SQLString )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEB SET " );
            strSql . Append ( "EB006=@EB006," );
            strSql . Append ( "EB009=@EB009," );
            strSql . Append ( "EB012=@EB012," );
            strSql . Append ( "EB015=@EB015," );
            strSql . Append ( "EB018=@EB018," );
            strSql . Append ( "EB021=@EB021," );
            strSql . Append ( "EB024=@EB024," );
            strSql . Append ( "EB027=@EB027," );
            strSql . Append ( "EB030=@EB030," );
            strSql . Append ( "EB033=@EB033," );
            strSql . Append ( "EB036=@EB036," );
            strSql . Append ( "EB039=@EB039," );
            strSql . Append ( "EB042=@EB042 " );
            strSql . Append ( "WHERE EB002=@EB002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EB002",SqlDbType.NVarChar,50),
                new SqlParameter("@EB006",SqlDbType.Decimal,18),
                new SqlParameter("@EB009",SqlDbType.Decimal,18),
                new SqlParameter("@EB012",SqlDbType.Decimal,18),
                new SqlParameter("@EB015",SqlDbType.Decimal,18),
                new SqlParameter("@EB018",SqlDbType.Decimal,18),
                new SqlParameter("@EB021",SqlDbType.Decimal,18),
                new SqlParameter("@EB024",SqlDbType.Decimal,18),
                new SqlParameter("@EB027",SqlDbType.Decimal,18),
                new SqlParameter("@EB030",SqlDbType.Decimal,18),
                new SqlParameter("@EB033",SqlDbType.Decimal,18),
                new SqlParameter("@EB036",SqlDbType.Decimal,18),
                new SqlParameter("@EB039",SqlDbType.Decimal,18),
                new SqlParameter("@EB042",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EB002;
            parameter [ 1 ] . Value = _model . EB006;
            parameter [ 2 ] . Value = _model . EB009;
            parameter [ 3 ] . Value = _model . EB012;
            parameter [ 4 ] . Value = _model . EB015;
            parameter [ 5 ] . Value = _model . EB018;
            parameter [ 6 ] . Value = _model . EB021;
            parameter [ 7 ] . Value = _model . EB024;
            parameter [ 8 ] . Value = _model . EB027;
            parameter [ 9 ] . Value = _model . EB030;
            parameter [ 10 ] . Value = _model . EB033;
            parameter [ 11 ] . Value = _model . EB036;
            parameter [ 12 ] . Value = _model . EB039;
            parameter [ 13 ] . Value = _model . EB042;

            SQLString . Add ( strSql ,parameter );
        }

        //241 现价
        void edit241xj ( MulaolaoLibrary . MaterialEntity _model ,Hashtable SQLString )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEB SET " );
            strSql . Append ( "EB008=@EB008," );
            strSql . Append ( "EB011=@EB011," );
            strSql . Append ( "EB014=@EB014," );
            strSql . Append ( "EB017=@EB017," );
            strSql . Append ( "EB020=@EB020," );
            strSql . Append ( "EB023=@EB023," );
            strSql . Append ( "EB026=@EB026," );
            strSql . Append ( "EB029=@EB029," );
            strSql . Append ( "EB032=@EB032," );
            strSql . Append ( "EB035=@EB035," );
            strSql . Append ( "EB038=@EB038," );
            strSql . Append ( "EB041=@EB041," );
            strSql . Append ( "EB044=@EB044 " );
            strSql . Append ( "WHERE EB002=@EB002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EB002",SqlDbType.NVarChar,50),
                new SqlParameter("@EB008",SqlDbType.Decimal,18),
                new SqlParameter("@EB011",SqlDbType.Decimal,18),
                new SqlParameter("@EB014",SqlDbType.Decimal,18),
                new SqlParameter("@EB017",SqlDbType.Decimal,18),
                new SqlParameter("@EB020",SqlDbType.Decimal,18),
                new SqlParameter("@EB023",SqlDbType.Decimal,18),
                new SqlParameter("@EB026",SqlDbType.Decimal,18),
                new SqlParameter("@EB029",SqlDbType.Decimal,18),
                new SqlParameter("@EB032",SqlDbType.Decimal,18),
                new SqlParameter("@EB035",SqlDbType.Decimal,18),
                new SqlParameter("@EB038",SqlDbType.Decimal,18),
                new SqlParameter("@EB041",SqlDbType.Decimal,18),
                new SqlParameter("@EB044",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EB002;
            parameter [ 1 ] . Value = _model . EB008;
            parameter [ 2 ] . Value = _model . EB011;
            parameter [ 3 ] . Value = _model . EB014;
            parameter [ 4 ] . Value = _model . EB017;
            parameter [ 5 ] . Value = _model . EB020;
            parameter [ 6 ] . Value = _model . EB023;
            parameter [ 7 ] . Value = _model . EB026;
            parameter [ 8 ] . Value = _model . EB029;
            parameter [ 9 ] . Value = _model . EB032;
            parameter [ 10 ] . Value = _model . EB035;
            parameter [ 11 ] . Value = _model . EB038;
            parameter [ 12 ] . Value = _model . EB041;
            parameter [ 13 ] . Value = _model . EB044;

            SQLString . Add ( strSql ,parameter );
        }

        //241 原价
        void edit241yj ( MulaolaoLibrary . MaterialEntity _model ,Hashtable SQLString )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEB SET " );
            strSql . Append ( "EB007=@EB007," );
            strSql . Append ( "EB010=@EB010," );
            strSql . Append ( "EB013=@EB013," );
            strSql . Append ( "EB016=@EB016," );
            strSql . Append ( "EB019=@EB019," );
            strSql . Append ( "EB022=@EB022," );
            strSql . Append ( "EB025=@EB025," );
            strSql . Append ( "EB028=@EB028," );
            strSql . Append ( "EB031=@EB031," );
            strSql . Append ( "EB034=@EB034," );
            strSql . Append ( "EB037=@EB037," );
            strSql . Append ( "EB040=@EB040," );
            strSql . Append ( "EB043=@EB043 " );
            strSql . Append ( "WHERE EB002=@EB002" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EB002",SqlDbType.NVarChar,50),
                new SqlParameter("@EB007",SqlDbType.Decimal,18),
                new SqlParameter("@EB010",SqlDbType.Decimal,18),
                new SqlParameter("@EB013",SqlDbType.Decimal,18),
                new SqlParameter("@EB016",SqlDbType.Decimal,18),
                new SqlParameter("@EB019",SqlDbType.Decimal,18),
                new SqlParameter("@EB022",SqlDbType.Decimal,18),
                new SqlParameter("@EB025",SqlDbType.Decimal,18),
                new SqlParameter("@EB028",SqlDbType.Decimal,18),
                new SqlParameter("@EB031",SqlDbType.Decimal,18),
                new SqlParameter("@EB034",SqlDbType.Decimal,18),
                new SqlParameter("@EB037",SqlDbType.Decimal,18),
                new SqlParameter("@EB040",SqlDbType.Decimal,18),
                new SqlParameter("@EB043",SqlDbType.Decimal,18)
            };
            parameter [ 0 ] . Value = _model . EB002;
            parameter [ 1 ] . Value = _model . EB007;
            parameter [ 2 ] . Value = _model . EB010;
            parameter [ 3 ] . Value = _model . EB013;
            parameter [ 4 ] . Value = _model . EB016;
            parameter [ 5 ] . Value = _model . EB019;
            parameter [ 6 ] . Value = _model . EB022;
            parameter [ 7 ] . Value = _model . EB025;
            parameter [ 8 ] . Value = _model . EB028;
            parameter [ 9 ] . Value = _model . EB031;
            parameter [ 10 ] . Value = _model . EB034;
            parameter [ 11 ] . Value = _model . EB037;
            parameter [ 12 ] . Value = _model . EB040;
            parameter [ 13 ] . Value = _model . EB043;

            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// 是否存在此流水号
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        bool Exists ( MulaolaoLibrary . MaterialEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM R_PQEB WHERE EB002='{0}'" ,_model . EB002 );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取509数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable get509 ( string strWhere )
        {
            string str = string . Empty;
            str = "'" + DicStr . plyWood + "'";
            str = str + "," + "'" + DicStr . densityBoard + "'";
            str = str + "," + "'" + DicStr . wood + "'";
            str = str + "," + "'" + DicStr . vehicleParts + "'";
            str = str + "," + "'" + DicStr . lronParts + "'";
            str = str + "," + "'" + DicStr . plasticParts + "'";
            str = str + "," + "'" + DicStr . otherMaterials + "'";
            str = str + "," + "'" + DicStr . packAccess + "'";
            str = str + "," + "'" + DicStr . outBox + "'";
            str = str + "," + "'" + DicStr . tundish + "'";
            str = str + "," + "'" + DicStr . innerBox + "'";
            str = str + "," + "'" + DicStr . giftBox + "'";
            str = str + "," + "'" + DicStr . inject + "'";
            str = str + "," + "'" + DicStr . oilRoller + "'";
            str = str + "," + "'" + DicStr . endProductOut + "'";

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "WITH CET AS (" );
            strSql . AppendFormat ( "SELECT GS46,GS01,GS48,GS49,CASE WHEN GS71='{0}' THEN '纸箱' WHEN GS71='{1}' THEN '纸箱' WHEN GS71='{2}' THEN '纸箱' ELSE GS71 END GS71,CONVERT(FLOAT,SUM(GS10*GS11)) GS FROM R_PQP WHERE GS71 IS NOT NULL AND GS01 IS NOT NULL AND GS71 IN ({3}) GROUP BY GS71,GS46,GS01,GS48,GS49 HAVING CONVERT(FLOAT,SUM(GS10*GS11))!=0) " ,DicStr . tundish ,DicStr . innerBox ,DicStr . outBox ,str );
            strSql . Append ( "SELECT CET.*,B.PQF31 FROM CET INNER JOIN R_PQF B ON GS01=B.PQF01 " );
            if ( !string . IsNullOrEmpty ( strWhere ) )
                strSql . AppendFormat ( "  WHERE {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取241数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable get241 ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT AM002,(AM299+AM303+AM305+AM317+AM308+AM323+AM316+AM327)/AM006 JHB,(AM302+AM309+AM312+AM325+AM319+AM322+AM329+AM297)/AM006 MDB,(AM331+AM291+AM334+AM289+AM337+AM341+AM340+AM348+AM344+AM354+AM347+AM360+AM350+AM366+AM353+AM372+AM356+AM335+AM359+AM378+AM362+AM387+AM365+AM393+AM368+AM295+AM371+AM293+AM374+AM269+AM377+AM268+AM380+AM266+AM386+AM383+AM389+AM264+AM392+AM262+AM154+AM156+AM158)/AM006 MC,(AM271+AM275+AM274+AM282+AM278+AM284+AM281+AM286)/AM006 CMJ,(AM210+AM214+AM226+AM228)/AM006 TJ,(AM213+AM220+AM230+AM232)/AM006 SLJ,(AM216+AM222+AM234+AM236)/AM006 QTCL,(AM219+AM224+AM238+AM256+AM137+AM141)/AM006 BZFL,(AM143+AM135+AM146+AM134+AM140+AM147)/AM006 ZX,(AM149+AM131)/AM006 CH,(AM109+AM112+AM113+AM116)/AM006 CPWW,(AM240+AM244+AM243+AM251)/AM006 GQYQ,(AM176+AM179+AM180+AM187+AM183+AM193+AM186+AM199+AM189+AM201+AM192+AM204+AM195+AM206+AM198+AM208)/AM006 PQYQ FROM R_PQAM A INNER JOIN R_PQF B ON A.AM002=B.PQF01 WHERE AM006!=0 " );
            if ( !string . IsNullOrEmpty ( strWhere ) )
                strSql . AppendFormat ( " AND {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取241数据上次
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        DataTable get241pre ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT B.AM002,(SELECT TOP 1 AM002 FROM R_PQAM A WHERE A.AM005=B.AM005 AND A.AM002<B.AM002 ORDER BY A.AM002 DESC) AM FROM R_PQAM B INNER JOIN R_PQF C ON B.AM002=C.PQF01 WHERE {0} ) " ,strWhere );
            strSql . AppendFormat ( "SELECT B.AM002,(AM299+AM303+AM305+AM317+AM308+AM323+AM316+AM327)/AM006 JHB,(AM302+AM309+AM312+AM325+AM319+AM322+AM329+AM297)/AM006 MDB,(AM331+AM291+AM334+AM289+AM337+AM341+AM340+AM348+AM344+AM354+AM347+AM360+AM350+AM366+AM353+AM372+AM356+AM335+AM359+AM378+AM362+AM387+AM365+AM393+AM368+AM295+AM371+AM293+AM374+AM269+AM377+AM268+AM380+AM266+AM386+AM383+AM389+AM264+AM392+AM262+AM154+AM156+AM158)/AM006 MC,(AM271+AM275+AM274+AM282+AM278+AM284+AM281+AM286)/AM006 CMJ,(AM210+AM214+AM226+AM228)/AM006 TJ,(AM213+AM220+AM230+AM232)/AM006 SLJ,(AM216+AM222+AM234+AM236)/AM006 QTCL,(AM219+AM224+AM238+AM256+AM137+AM141)/AM006 BZFL,(AM143+AM135+AM146+AM134+AM140+AM147)/AM006 ZX,(AM149+AM131)/AM006 CH,(AM109+AM112+AM113+AM116)/AM006 CPWW,(AM240+AM244+AM243+AM251)/AM006 GQYQ,(AM176+AM179+AM180+AM187+AM183+AM193+AM186+AM199+AM189+AM201+AM192+AM204+AM195+AM206+AM198+AM208)/AM006 PQYQ FROM R_PQAM A INNER JOIN CET B ON A.AM002=B.AM INNER JOIN R_PQF C ON A.AM002=C.PQF01 WHERE AM006!=0 AND {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据库数据
        /// </summary>
        /// <returns></returns>
        public DataTable getTableView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,EB001,EB002,EB003,EB004,EB005,EB006,EB007,EB008,EB009,EB010,EB011,EB012,EB013,EB014,EB015,EB016,EB017,EB018,EB019,EB020,EB021,EB022,EB023,EB024,EB025,EB026,EB027,EB028,EB029,EB030,EB031,EB032,EB033,EB034,EB035,EB036,EB037,EB038,EB039,EB040,EB041,EB042,EB043,EB044 FROM R_PQEB " );
            strSql . Append ( " WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Edit ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            MulaolaoLibrary . MaterialEntity _model = new MulaolaoLibrary . MaterialEntity ( );
            if ( table != null && table . Rows . Count > 0 )
            {
                for ( int i = 0 ; i < table . Rows . Count ; i++ )
                {
                    _model . EB002 = table . Rows [ i ] [ "EB002" ] . ToString ( );
                    _model . EB024 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB024" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB024" ] . ToString ( ) );
                    _model . EB025 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB025" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB025" ] . ToString ( ) );
                    _model . EB026 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB026" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB026" ] . ToString ( ) );
                    _model . EB027 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB027" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB027" ] . ToString ( ) );
                    _model . EB028 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB028" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB028" ] . ToString ( ) );
                    _model . EB031 = string . IsNullOrEmpty ( table . Rows [ i ] [ "EB031" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "EB031" ] . ToString ( ) );
                    //_model . EB029 = table . Rows [ i ] [ "EB029" ] . ToString ( );
                    //_model . EB030 = table . Rows [ i ] [ "EB030" ] . ToString ( );
                    editAll ( SQLString ,strSql ,_model );
                }
            }
            else
                return false;

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void editAll ( Hashtable SQLString ,StringBuilder strSql ,MulaolaoLibrary . MaterialEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE R_PQEB SET " );
            strSql . Append ( "EB024=@EB024," );
            strSql . Append ( "EB025=@EB025," );
            strSql . Append ( "EB026=@EB026," );
            strSql . Append ( "EB027=@EB027," );
            strSql . Append ( "EB028=@EB028," );
            strSql . Append ( "EB029=@EB029," );
            strSql . Append ( "EB030=@EB030," );
            strSql . Append ( "EB031=@EB031 " );
            strSql . Append ( "WHERE EB002=@EB002 " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@EB002",SqlDbType.NVarChar,50),
                new SqlParameter("@EB024",SqlDbType.Decimal,18),
                new SqlParameter("@EB025",SqlDbType.Decimal,18),
                new SqlParameter("@EB026",SqlDbType.Decimal,18),
                new SqlParameter("@EB027",SqlDbType.Decimal,18),
                new SqlParameter("@EB028",SqlDbType.Decimal,18),
                new SqlParameter("@EB029",SqlDbType.NVarChar,50),
                new SqlParameter("@EB030",SqlDbType.NVarChar,50),
                new SqlParameter("@EB031",SqlDbType.Decimal,18),
            };
            parameter [ 0 ] . Value = _model . EB002;
            parameter [ 1 ] . Value = _model . EB024;
            parameter [ 2 ] . Value = _model . EB025;
            parameter [ 3 ] . Value = _model . EB026;
            parameter [ 4 ] . Value = _model . EB027;
            parameter [ 5 ] . Value = _model . EB028;
            parameter [ 6 ] . Value = _model . EB029;
            parameter [ 7 ] . Value = _model . EB030;
            parameter [ 8 ] . Value = _model . EB031;

            SQLString . Add ( strSql ,parameter );
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

    }
}
