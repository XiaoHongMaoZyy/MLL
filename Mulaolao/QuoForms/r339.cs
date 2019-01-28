using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Text;
using System . Linq;
using System . Windows . Forms;
using DevExpress . XtraEditors;
using Mulaolao . Class;
using Mulaolao . Contract;
using Mulaolao . Other;
using MulaolaoBll;

namespace Mulaolao . QuoForms
{
    public partial class r339 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOIEntity model;
        string num=string.Empty;
        decimal outResult=0M;

        public r339 ( MulaolaoLibrary . QUOIEntity model ,string num )
        {
            InitializeComponent ( );

            _bll = new MulaolaoBll . Bll . QuoBll ( );

            this . model = model;
            this . num = num;

            setValue ( );
        }

        void setValue ( )
        {
            if ( model == null )
                return;
            if ( model . idx < 1 )
                return;
            model = _bll . getModel339 ( model . idx );
            if ( model == null )
                return;
            tQUOI006 . Text = model . QUOI006;
            tQUOI007 . Text = model . QUOI007;
            tQUOI008 . Text = model . QUOI008;
            tQUOI009 . Text = model . QUOI009;
            tQUOI010 . Text = model . QUOI010;
            tQUOI011 . Text = model . QUOI011;
            tQUOI012 . Text = Convert . ToDecimal ( model . QUOI012 ) . ToString ( "0.######" );
            tQUOI013 . Text = Convert . ToDecimal ( model . QUOI013 ) . ToString ( "0.######" );
            tQUOI014 . Text = Convert . ToDecimal ( model . QUOI014 ) . ToString ( "0.######" );
            tQUOI015 . Text = Convert . ToDecimal ( model . QUOI015 ) . ToString ( "0.######" );
            tQUOI016 . Text = Convert . ToDecimal ( model . QUOI016 ) . ToString ( "0.######" );
            tQUOI017 . Text = Convert . ToDecimal ( model . QUOI017 ) . ToString ( "0.######" );
            tQUOI018 . Text = Convert . ToDecimal ( model . QUOI018 ) . ToString ( "0.######" );
            tQUOI019 . Text = Convert . ToDecimal ( model . QUOI019 ) . ToString ( "0.######" );
            tQUOI020 . Text = Convert . ToDecimal ( model . QUOI020 ) . ToString ( "0.######" );
            tQUOI021 . Text = Convert . ToDecimal ( model . QUOI021 ) . ToString ( "0.######" );
            tQUOI022 . Text = model . QUOI022;
            tQUOI023 . Text = Convert . ToDecimal ( model . QUOI023 ) . ToString ( "0.######" );
            tQUOI024 . Text = Convert . ToDecimal ( model . QUOI024 ) . ToString ( "0.######" );
            tQUOI025 . Text = model . QUOI025;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            int id = _bll . Save339 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        bool getValue ( )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOI006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOI006 ,"不可为空" );
                return false;
            }
            model . QUOI006 = tQUOI006 . Text;
            model . QUOI007 = tQUOI007 . Text;
            model . QUOI008 = tQUOI008 . Text;
            model . QUOI009 = tQUOI009 . Text;
            model . QUOI010 = tQUOI010 . Text;
            model . QUOI011 = tQUOI011 . Text;
            model . QUOI022 = tQUOI022 . Text;
            model . QUOI025 = tQUOI025 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI012 . Text ) && decimal . TryParse ( tQUOI012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI012 ,"必须是数字" );
                return false;
            }
            model . QUOI012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI013 . Text ) && decimal . TryParse ( tQUOI013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI013 ,"必须是数字" );
                return false;
            }
            model . QUOI013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI014 . Text ) && decimal . TryParse ( tQUOI014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI014 ,"必须是数字" );
                return false;
            }
            model . QUOI014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI015 . Text ) && decimal . TryParse ( tQUOI015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI015 ,"必须是数字" );
                return false;
            }
            model . QUOI015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI016 . Text ) && decimal . TryParse ( tQUOI016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI016 ,"必须是数字" );
                return false;
            }
            model . QUOI016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI017 . Text ) && decimal . TryParse ( tQUOI017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI017 ,"必须是数字" );
                return false;
            }
            model . QUOI017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI018 . Text ) && decimal . TryParse ( tQUOI018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI018 ,"必须是数字" );
                return false;
            }
            model . QUOI018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI019 . Text ) && decimal . TryParse ( tQUOI019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI019 ,"必须是数字" );
                return false;
            }
            model . QUOI019 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI020 . Text ) && decimal . TryParse ( tQUOI020 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI020 ,"必须是数字" );
                return false;
            }
            model . QUOI020 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI021 . Text ) && decimal . TryParse ( tQUOI021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI021 ,"必须是数字" );
                return false;
            }
            model . QUOI021 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI023 . Text ) && decimal . TryParse ( tQUOI023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI023 ,"必须是数字" );
                return false;
            }
            model . QUOI023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI024 . Text ) && decimal . TryParse ( tQUOI024 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI024 ,"必须是数字" );
                return false;
            }
            model . QUOI024 = outResult;
            return true;
        }

        private void tQUOI017_TextChanged ( object sender ,EventArgs e )
        {
            CalcuMJ ( );
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI018_TextChanged ( object sender ,EventArgs e )
        {
            CalcuMJ ( );
            CalcuBS ( );
            CalcuPM ( );
        }
        void CalcuMJ ( )
        {
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI017 . Text ) && decimal . TryParse ( tQUOI017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI017 ,"必须是数字" );
                return;
            }
            model . QUOI017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI018 . Text ) && decimal . TryParse ( tQUOI018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI018 ,"必须是数字" );
                return;
            }
            model . QUOI018 = outResult;
            t3 . Text = Convert . ToDecimal ( model . QUOI017 * model . QUOI018 ) . ToString ( "0.##" );
        }

        private void tQUOI012_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI014_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI023_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI016_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI021_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        private void tQUOI015_TextChanged ( object sender ,EventArgs e )
        {
            CalcuBS ( );
            CalcuPM ( );
        }
        void CalcuBS ( )
        {
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI012 . Text ) && decimal . TryParse ( tQUOI012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI012 ,"必须是数字" );
                return;
            }
            model . QUOI012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI014 . Text ) && decimal . TryParse ( tQUOI014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI014 ,"必须是数字" );
                return;
            }
            model . QUOI014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI023 . Text ) && decimal . TryParse ( tQUOI023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI023 ,"必须是数字" );
                return;
            }
            model . QUOI023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI016 . Text ) && decimal . TryParse ( tQUOI016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI016 ,"必须是数字" );
                return;
            }
            model . QUOI016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI021 . Text ) && decimal . TryParse ( tQUOI021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI021 ,"必须是数字" );
                return;
            }
            model . QUOI021 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI015 . Text ) && decimal . TryParse ( tQUOI015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI015 ,"必须是数字" );
                return;
            }
            model . QUOI015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI017 . Text ) && decimal . TryParse ( tQUOI017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI017 ,"必须是数字" );
                return;
            }
            model . QUOI017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI018 . Text ) && decimal . TryParse ( tQUOI018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI018 ,"必须是数字" );
                return;
            }
            model . QUOI018 = outResult;
            if ( model . QUOI015 == 0 || model . QUOI017 == 0 || model . QUOI018 == 0 )
                return;
            t1 . Text = Convert . ToDecimal ( model . QUOI012 * model . QUOI014 * model . QUOI005 * model . QUOI023 * model . QUOI016 * model . QUOI021 / model . QUOI015 / model . QUOI017 / model . QUOI018 / 100 ) . ToString ( "0.###" );
        }

        private void tQUOI013_TextChanged ( object sender ,EventArgs e )
        {
            CalcuPM ( );
        }
        void CalcuPM ( )
        {
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI012 . Text ) && decimal . TryParse ( tQUOI012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI012 ,"必须是数字" );
                return;
            }
            model . QUOI012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI023 . Text ) && decimal . TryParse ( tQUOI023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI023 ,"必须是数字" );
                return;
            }
            model . QUOI023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI017 . Text ) && decimal . TryParse ( tQUOI017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI017 ,"必须是数字" );
                return;
            }
            model . QUOI017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI018 . Text ) && decimal . TryParse ( tQUOI018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI018 ,"必须是数字" );
                return;
            }
            model . QUOI018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI014 . Text ) && decimal . TryParse ( tQUOI014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI014 ,"必须是数字" );
                return;
            }
            model . QUOI014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI013 . Text ) && decimal . TryParse ( tQUOI013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI013 ,"必须是数字" );
                return;
            }
            model . QUOI013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI015 . Text ) && decimal . TryParse ( tQUOI015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI015 ,"必须是数字" );
                return;
            }
            model . QUOI015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI016 . Text ) && decimal . TryParse ( tQUOI016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI016 ,"必须是数字" );
                return;
            }
            model . QUOI016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOI021 . Text ) && decimal . TryParse ( tQUOI021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOI021 ,"必须是数字" );
                return;
            }
            model . QUOI021 = outResult;
            if ( model . QUOI015 == 0 )
                return;
            t2 . Text = Convert . ToDecimal ( model . QUOI012 * model . QUOI023 * model . QUOI017 * model . QUOI018 * model . QUOI014 * model . QUOI013 * model . QUOI016 * model . QUOI021 / model . QUOI015 / 10000 / 100 ) . ToString ( "0.###" );
        }

        private void tQUOI006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor495 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            R_FrmPQJ form = new R_FrmPQJ ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOI006 . Text = row [ "PY25" ] . ToString ( );
                tQUOI007 . Text = row [ "PY36" ] . ToString ( );
                tQUOI009 . Text = row [ "PY24" ] . ToString ( );
                tQUOI022 . Text = row [ "PY02" ] . ToString ( );
                tQUOI017 . Text = row [ "PY14" ] . ToString ( );
                tQUOI018 . Text = row [ "PY18" ] . ToString ( );
                tQUOI023 . Text = row [ "PY11" ] . ToString ( );
                tQUOI021 . Text = row [ "PY15" ] . ToString ( );
                tQUOI016 . Text = row [ "PY12" ] . ToString ( );
            }
        }

        string state=string.Empty;
        private void tQUOI009_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            if ( string . IsNullOrEmpty ( tQUOI009 . Text ) )
                return;
            model . QUOI009 = tQUOI009 . Text;
            R_FrmR_519select se = null;
            if ( model . QUOI009 . Equals ( DicStr . sljpq ) )
            {
                se = new R_FrmR_519select ( "" ,"2" ,"1" );
                state = "1";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( model . QUOI009 . Equals ( DicStr . jdpt ) )
            {
                se = new R_FrmR_519select ( "" ,"2" ,"2" );
                state = "2";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( model . QUOI009 . Equals ( DicStr . jq ) )
            {
                se = new R_FrmR_519select ( "" ,"2" ,"3" );
                state = "3";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( model . QUOI009 . Equals ( DicStr . fb ) )
            {
                se = new R_FrmR_519select ( "" ,"2" ,"4" );
                state = "4";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( model . QUOI009 . Equals ( DicStr . tb ) )
            {
                se = new R_FrmR_519select ( "" ,"2" ,"5" );
                state = "5";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
        }
        private void se_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            if ( state . Equals ( "1" ) )
            {
                tQUOI012 . Text = e . ConOne;
                tQUOI010 . Text = e . ConTwo;
                tQUOI015 . Text = e . ConTre;
                tQUOI011 . Text = e . ConFiv;
                tQUOI019 . Text = e . ConSix;
                tQUOI020 . Text = e . ConSev;
                tQUOI024 . Text = String . Empty;
            }
            else if ( state . Equals ( "2" ) )
            {
                tQUOI012 . Text = e . ConOne;
                tQUOI010 . Text = e . ConTwo;
                tQUOI015 . Text = e . ConTre;
                tQUOI011 . Text = e . ConFiv;
                tQUOI019 . Text = e . ConSix;
                tQUOI020 . Text = e . ConSev;
                tQUOI024 . Text = String . Empty;
            }
            else if ( state . Equals ( "3" ) )
            {
                tQUOI012 . Text = e . ConOne;
                tQUOI010 . Text = e . ConTwo;
                tQUOI015 . Text = e . ConTre;
                tQUOI011 . Text = e . ConFiv;
                tQUOI019 . Text = e . ConSix;
                tQUOI024 . Text = String . Empty;
                tQUOI020 . Text = String . Empty;
            }
            else if ( state . Equals ( "4" ) )
            {
                tQUOI013 . Text = e . ConOne;
                tQUOI010 . Text = e . ConTwo;
                tQUOI015 . Text = e . ConTre;
                tQUOI011 . Text = e . ConFiv;
                tQUOI019 . Text = e . ConSix;
                tQUOI024 . Text = e . ConSev;
                tQUOI020 . Text = String . Empty;
            }
            else if ( state . Equals ( "5" ) )
            {
                tQUOI013 . Text = e . ConOne;
                tQUOI010 . Text = e . ConTwo;
                tQUOI015 . Text = e . ConTre;
                tQUOI019 . Text = e . ConEgi;
                tQUOI025 . Text = e . ConSix;
                tQUOI011 . Text = e . ConSev;
                tQUOI024 . Text = e . ConNin;
                tQUOI020 . Text = String . Empty;
            }
        }
    }

}