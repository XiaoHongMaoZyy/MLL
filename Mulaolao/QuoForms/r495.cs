using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Text;
using System . Linq;
using System . Windows . Forms;
using DevExpress . XtraEditors;
using Mulaolao . Other;
using StudentMgr;
using Mulaolao . Class;

namespace Mulaolao . QuoForms
{
    public partial class r495 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOLEntity model;
        string num=string.Empty;
        decimal outResult=0M;
        int outInt=0;

        public r495 ( MulaolaoLibrary . QUOLEntity model ,string num )
        {
            InitializeComponent ( );

            _bll = new MulaolaoBll . Bll . QuoBll ( );

            this . model = model;
            this . num = num;


            tQUOL011 . Properties . Items . Add ( MulaolaoBll . DicStr . sljpq );
            tQUOL011 . Properties . Items . Add ( MulaolaoBll . DicStr . jdpt );
            tQUOL011 . Properties . Items . Add ( MulaolaoBll . DicStr . jq );
            tQUOL011 . Properties . Items . Add ( MulaolaoBll . DicStr . fb );
            tQUOL011 . Properties . Items . Add ( MulaolaoBll . DicStr . tb );

            setValue ( );
        }

        private void setValue ( )
        {
            if ( model == null )
                return;
            if ( model . idx < 1 )
                return;
            model = _bll . getModel495 ( model . idx );
            if ( model == null )
                return;
            tQUOL006 . Text = model . QUOL006;
            tQUOL007 . Text = model . QUOL007;
            tQUOL008 . Text = Convert . ToDecimal ( model . QUOL008 ) . ToString ( "0.######" );
            tQUOL009 . Text = Convert . ToDecimal ( model . QUOL009 ) . ToString ( "0.######" );
            tQUOL010 . Text = Convert . ToDecimal ( model . QUOL010 ) . ToString ( "0.######" );
            tQUOL011 . Text = model . QUOL011;
            tQUOL012 . Text = Convert . ToDecimal ( model . QUOL012 ) . ToString ( "0.######" );
            tQUOL013 . Text = model . QUOL013 . ToString ( );
            tQUOL013 . Text = Convert . ToDecimal ( model . QUOL013 ) . ToString ( "0.######" );
            tQUOL014 . Text = Convert . ToDecimal ( model . QUOL014 ) . ToString ( "0.######" );
            tQUOL015 . Text = Convert . ToDecimal ( model . QUOL015 ) . ToString ( "0.######" );
            tQUOL016 . Text = model . QUOL016;
            tQUOL017 . Text = model . QUOL017;
            tQUOL018 . Text = Convert . ToDecimal ( model . QUOL018 ) . ToString ( "0.######" );
            tQUOL019 . Text = Convert . ToDecimal ( model . QUOL019 ) . ToString ( "0.######" );
            tQUOL020 . Text = Convert . ToDecimal ( model . QUOL020 ) . ToString ( "0.######" );
            tQUOL021 . Text = Convert . ToDecimal ( model . QUOL021 ) . ToString ( "0.######" );
            tQUOL022 . Text = Convert . ToDecimal ( model . QUOL022 ) . ToString ( "0.######" );
            tQUOL023 . Text = Convert . ToDecimal ( model . QUOL023 ) . ToString ( "0.######" );
            tQUOL024 . Text = model . QUOL024;
            tQUOL025 . Text = Convert . ToDecimal ( model . QUOL025 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            outInt = _bll . Save495 ( model );
            if ( outInt > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        bool getValue ( )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOL006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOL006 ,"不可为空" );
                return false;
            }
            model . QUOL006 = tQUOL006 . Text;
            model . QUOL007 = tQUOL007 . Text;
            model . QUOL011 = tQUOL011 . Text;
            model . QUOL016 = tQUOL016 . Text;
            model . QUOL017 = tQUOL017 . Text;
            model . QUOL024 = tQUOL024 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL008 . Text ) && decimal . TryParse ( tQUOL008 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL008 ,"必须是数字" );
                return false;
            }
            model . QUOL008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL009 . Text ) && decimal . TryParse ( tQUOL009 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL009 ,"必须是数字" );
                return false;
            }
            model . QUOL009 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL010 . Text ) && decimal . TryParse ( tQUOL010 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL010 ,"必须是数字" );
                return false;
            }
            model . QUOL010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL012 . Text ) && decimal . TryParse ( tQUOL012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL012 ,"必须是数字" );
                return false;
            }
            model . QUOL012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL014 . Text ) && decimal . TryParse ( tQUOL014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL014 ,"必须是数字" );
                return false;
            }
            model . QUOL014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL015 . Text ) && decimal . TryParse ( tQUOL015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL015 ,"必须是数字" );
                return false;
            }
            model . QUOL015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL015 . Text ) && decimal . TryParse ( tQUOL015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL015 ,"必须是数字" );
                return false;
            }
            model . QUOL015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL018 . Text ) && decimal . TryParse ( tQUOL018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL018 ,"必须是数字" );
                return false;
            }
            model . QUOL018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL019 . Text ) && decimal . TryParse ( tQUOL019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL019 ,"必须是数字" );
                return false;
            }
            model . QUOL019 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL020 . Text ) && decimal . TryParse ( tQUOL020 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL020 ,"必须是数字" );
                return false;
            }
            model . QUOL020 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL021 . Text ) && decimal . TryParse ( tQUOL021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL021 ,"必须是数字" );
                return false;
            }
            model . QUOL021 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL022 . Text ) && decimal . TryParse ( tQUOL022 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL022 ,"必须是数字" );
                return false;
            }
            model . QUOL022 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL023 . Text ) && decimal . TryParse ( tQUOL023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL023 ,"必须是数字" );
                return false;
            }
            model . QUOL023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL025 . Text ) && decimal . TryParse ( tQUOL025 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL025 ,"必须是数字" );
                return false;
            }
            model . QUOL025 = outResult;
            outInt = 0;
            if ( !string . IsNullOrEmpty ( tQUOL013 . Text ) && int . TryParse ( tQUOL013 . Text ,out outInt ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL013 ,"必须是整数" );
                return false;
            }
            model . QUOL013 = outInt;

            return true;
        }

        private void tQUOL014_TextChanged ( object sender ,EventArgs e )
        {
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL014 . Text ) && decimal . TryParse ( tQUOL014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL014 ,"必须是数字" );
                return;
            }
            model . QUOL014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOL015 . Text ) && decimal . TryParse ( tQUOL015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOL015 ,"必须是数字" );
                return;
            }
            model . QUOL015 = outResult;
            textBox1 . Text = Convert . ToDecimal ( model . QUOL014 * model . QUOL015 ) . ToString ( "0.######" );
        }

        string r519ben=string.Empty;
        private void button5_Click ( object sender ,EventArgs e )
        {
            if ( string . IsNullOrEmpty ( tQUOL011 . Text ) )
            {
                XtraMessageBox . Show ( "请选择加工工艺" );
                return;
            }
            R_FrmR_519select se = new R_FrmR_519select ( );
            se . chose = "1";
            DataTable r519;
            if ( tQUOL011 . Text . Equals ( MulaolaoBll . DicStr . sljpq ) )
            {
                r519 = SqlHelper . ExecuteDataTable ( "SELECT * FROM R_PQA" );
                se . zhi = "1";
                r519ben = "1";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( tQUOL011 . Text . Equals ( MulaolaoBll . DicStr . jdpt ) )
            {
                r519 = SqlHelper . ExecuteDataTable ( "SELECT * FROM R_PQD" );
                se . zhi = "2";
                r519ben = "2";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( tQUOL011 . Text . Equals ( MulaolaoBll . DicStr . jq ) )
            {
                r519 = SqlHelper . ExecuteDataTable ( "SELECT * FROM R_PQE" );
                se . zhi = "3";
                r519ben = "3";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( tQUOL011 . Text . Equals ( MulaolaoBll . DicStr . fb ) )
            {
                r519 = SqlHelper . ExecuteDataTable ( "SELECT * FROM R_PQB" );
                se . zhi = "4";
                r519ben = "4";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
            else if ( tQUOL011 . Text . Equals ( MulaolaoBll . DicStr . tb ) )
            {
                r519 = SqlHelper . ExecuteDataTable ( "SELECT * FROM R_PQC" );
                se . zhi = "5";
                r519ben = "5";
                se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
                se . StartPosition = FormStartPosition . CenterScreen;
                se . ShowDialog ( );
            }
        }
        private void se_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            if ( r519ben . Equals ( "1" ) )
            {
                tQUOL021 . Text = e . ConOne;
                tQUOL022 . Text = e . ConTwo;
                tQUOL023 . Text = e . ConTre;
                tQUOL019 . Text = e . ConFor;
                tQUOL017 . Text = e . ConFiv;
                tQUOL016 . Text = e . ConSix;
                tQUOL018 . Text = "";
                tQUOL025 . Text = e . ConSev;
            }
            else if ( r519ben == "2" )
            {
                tQUOL021 . Text = e . ConOne;
                tQUOL022 . Text = e . ConTwo;
                tQUOL023 . Text = e . ConTre;
                tQUOL019 . Text = e . ConFor;
                tQUOL017 . Text = e . ConFiv;
                tQUOL016 . Text = e . ConSix;
                tQUOL018 . Text = "";
                tQUOL025 . Text = e . ConSev;
            }
            else if ( r519ben == "3" )
            {
                tQUOL021 . Text = e . ConOne;
                tQUOL022 . Text = e . ConTwo;
                tQUOL019 . Text = e . ConTre;
                tQUOL017 . Text = e . ConFor;
                tQUOL016 . Text = e . ConFiv;
                tQUOL023 . Text = "";
                tQUOL025 . Text = e . ConSix;
            }
            else if ( r519ben == "4" )
            {
                tQUOL018 . Text = e . ConOne;
                tQUOL017 . Text = e . ConTwo;
                tQUOL016 . Text = e . ConTre;
                tQUOL023 . Text = "";
                tQUOL021 . Text = "";
                tQUOL022 . Text = "";
                tQUOL019 . Text = "";
                tQUOL025 . Text = e . ConFor;
            }
            else if ( r519ben == "5" )
            {
                tQUOL021 . Text = e . ConOne;
                tQUOL022 . Text = e . ConTwo;
                tQUOL018 . Text = e . ConTre;
                tQUOL017 . Text = e . ConFor;
                tQUOL016 . Text = e . ConFiv;
                tQUOL023 . Text = "";
                tQUOL019 . Text = "";
                tQUOL025 . Text = e . ConSix;
                tQUOL024 . Text = e . ConSev;
            }
        }

    }
}