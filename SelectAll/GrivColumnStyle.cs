﻿using DevExpress . XtraGrid . Views . Grid;

namespace Mulaolao
{
    public static class GrivColumnStyle
    {
        public static void setColumnStyle ( GridView [ ] grids )
        {
            foreach ( GridView gv in grids )
            {
                foreach ( DevExpress . XtraGrid . Columns . GridColumn co in gv . Columns )
                {
                    co . OptionsFilter . FilterPopupMode = DevExpress . XtraGrid . Columns . FilterPopupMode . CheckedList;
                    co . AppearanceCell . Font = new System . Drawing . Font ( "宋体" ,10.5F ,System . Drawing . FontStyle . Bold );
                    co . AppearanceCell . Options . UseFont = true;
                    co . AppearanceCell . Options . UseTextOptions = true;
                    co . AppearanceCell . TextOptions . HAlignment = DevExpress . Utils . HorzAlignment . Center;
                    co . AppearanceCell . TextOptions . WordWrap = DevExpress . Utils . WordWrap . Wrap;
                    co . AppearanceHeader . Font = new System . Drawing . Font ( "宋体" ,10.5F ,System . Drawing . FontStyle . Bold );
                    co . AppearanceHeader . Options . UseFont = true;
                    co . AppearanceHeader . Options . UseTextOptions = true;
                    co . AppearanceHeader . TextOptions . HAlignment = DevExpress . Utils . HorzAlignment . Center;
                    co . AppearanceHeader . TextOptions . WordWrap = DevExpress . Utils . WordWrap . Wrap;
                }
            }
        }

        public static void setColumnStyleFormat ( GridView [ ] grids )
        {
            foreach ( GridView gv in grids )
            {
                foreach ( DevExpress . XtraGrid . Columns . GridColumn co in gv . Columns )
                {
                    if ( co . FieldName != "EB005" && co . FieldName != "EC005" )
                    {
                        co . DisplayFormat . FormatType = DevExpress . Utils . FormatType . Custom;
                        co . DisplayFormat . FormatString = "0.##";
                    }
                }
            }
        }

    }
}
