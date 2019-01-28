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
using Mulaolao . Other;

namespace Mulaolao . QuoForms
{
    public partial class r344 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoLibrary.QUOJEntity model;
        MulaolaoBll .Bll.QuoBll _bll=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r344 ( MulaolaoLibrary . QUOJEntity model ,string num )
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

            model = _bll . getModel344 ( model . idx );
            if ( model == null )
                return;
            tQUOJ006 . Text = model . QUOJ006;
            tQUOJ007 . Text = model . QUOJ007;
            tQUOJ008 . Text = model . QUOJ008;
            tQUOJ009 . Text = model . QUOJ009;
            tQUOJ010 . Text = model . QUOJ010;
            tQUOJ011 . Text = Convert . ToDecimal ( model . QUOJ011 ) . ToString ( "0.######" );
            tQUOJ012 . Text = model . QUOJ012;
            tQUOJ013 . Text = model . QUOJ013;
            tQUOJ014 . Text = model . QUOJ014;
            tQUOJ015 . Text = model . QUOJ015;
            tQUOJ016 . Text = Convert . ToDecimal ( model . QUOJ016 ) . ToString ( "0.######" );
            tQUOJ017 . Text = Convert . ToDecimal ( model . QUOJ017 ) . ToString ( "0.######" );
            tQUOJ018 . Text = Convert . ToDecimal ( model . QUOJ018 ) . ToString ( "0.######" );
            tQUOJ019 . Text = Convert . ToDecimal ( model . QUOJ019 ) . ToString ( "0.######" );
            tQUOJ020 . Text = Convert . ToDecimal ( model . QUOJ020 ) . ToString ( "0.######" );
            tQUOJ021 . Text = Convert . ToDecimal ( model . QUOJ021 ) . ToString ( "0.######" );
            tQUOJ022 . Text = Convert . ToDecimal ( model . QUOJ022 ) . ToString ( "0.######" );
            tQUOJ023 . Text = Convert . ToDecimal ( model . QUOJ023 ) . ToString ( "0.######" );
            tQUOJ024 . Text = Convert . ToDecimal ( model . QUOJ024 ) . ToString ( "0.######" );
            tQUOJ025 . Text = Convert . ToDecimal ( model . QUOJ025 ) . ToString ( "0.######" );
            tQUOJ026 . Text = Convert . ToDecimal ( model . QUOJ026 ) . ToString ( "0.######" );
            tQUOJ027 . Text = Convert . ToDecimal ( model . QUOJ027 ) . ToString ( "0.######" );
        }

        private void btnSure_Click ( object s ,EventArgs e)
        {
            if ( getValue ( ) == false )
                return;
            int id = _bll . Save344 ( model );
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
            if ( string . IsNullOrEmpty ( tQUOJ006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOJ006 ,"不可为空" );
                return false;
            }
            model . QUOJ006 = tQUOJ006 . Text;
            model . QUOJ007 = tQUOJ007 . Text;
            model . QUOJ008 = tQUOJ008 . Text;
            model . QUOJ009 = tQUOJ009 . Text;
            model . QUOJ010 = tQUOJ010 . Text;
            model . QUOJ012 = tQUOJ012 . Text;
            model . QUOJ013 = tQUOJ013 . Text;
            model . QUOJ014 = tQUOJ014 . Text;
            model . QUOJ015 = tQUOJ015 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ011 . Text ) && decimal . TryParse ( tQUOJ011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ011 ,"不可为空" );
                return false;
            }
            model . QUOJ011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ016 . Text ) && decimal . TryParse ( tQUOJ016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ016 ,"不可为空" );
                return false;
            }
            model . QUOJ016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ017 . Text ) && decimal . TryParse ( tQUOJ017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ017 ,"不可为空" );
                return false;
            }
            model . QUOJ017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ018 . Text ) && decimal . TryParse ( tQUOJ018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ018 ,"不可为空" );
                return false;
            }
            model . QUOJ018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ019 . Text ) && decimal . TryParse ( tQUOJ019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ019 ,"不可为空" );
                return false;
            }
            model . QUOJ019 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ020 . Text ) && decimal . TryParse ( tQUOJ020 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ020 ,"不可为空" );
                return false;
            }
            model . QUOJ020 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ021 . Text ) && decimal . TryParse ( tQUOJ021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ021 ,"不可为空" );
                return false;
            }
            model . QUOJ021 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ022 . Text ) && decimal . TryParse ( tQUOJ022 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ022 ,"不可为空" );
                return false;
            }
            model . QUOJ022 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ023 . Text ) && decimal . TryParse ( tQUOJ023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ023 ,"不可为空" );
                return false;
            }
            model . QUOJ023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ024 . Text ) && decimal . TryParse ( tQUOJ024 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ024 ,"不可为空" );
                return false;
            }
            model . QUOJ024 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ025 . Text ) && decimal . TryParse ( tQUOJ025 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ025 ,"不可为空" );
                return false;
            }
            model . QUOJ025 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ026 . Text ) && decimal . TryParse ( tQUOJ026 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ026 ,"不可为空" );
                return false;
            }
            model . QUOJ026 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOJ027 . Text ) && decimal . TryParse ( tQUOJ027 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOJ027 ,"不可为空" );
                return false;
            }
            model . QUOJ027 = outResult;
            return true;
        }

        private void tQUOJ006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To344 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form344Query form = new Form344Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOJ006 . Text = row [ "GS02" ] . ToString ( );
                tQUOJ007 . Text = row [ "GS07" ] . ToString ( );
                tQUOJ008 . Text = row [ "GS08" ] . ToString ( );
                tQUOJ016 . Text = row [ "GS78" ] . ToString ( );
            }
        }

        private void tQUOJ009_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            if ( string . IsNullOrEmpty ( tQUOJ012 . Text ) )
            {
                XtraMessageBox . Show ( "请选择厂内或厂外" );
                return;
            }
            R_FrmR_519select se = new R_FrmR_519select ( );
            se . StartPosition = FormStartPosition . CenterScreen;
            se . PassDataBetweenForm += new R_FrmR_519select . PassDataBetweenFormHandler ( se_PassDataBetweenForm );
            se . zhi = "7";
            se . ShowDialog ( );
        }
        private void se_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            tQUOJ009 . Text = e . ConOne;
            tQUOJ010 . Text = e . ConTwo;
            tQUOJ015 . Text = e . ConTre;
            tQUOJ011 . Text = e . ConFor;
            tQUOJ027 . Text = e . ConFiv;
            tQUOJ021 . Text = e . ConSix;
            tQUOJ019 . Text = e . ConSev;
            tQUOJ020 . Text = e . ConEgi;
            tQUOJ018 . Text = e . ConNin;
        }
    }
}

