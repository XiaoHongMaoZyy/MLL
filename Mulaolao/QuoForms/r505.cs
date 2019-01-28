using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Text;
using System . Linq;
using System . Windows . Forms;
using DevExpress . XtraEditors;

namespace Mulaolao . QuoForms
{
    public partial class r505 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOKEntity model;
        string num=string.Empty;
        decimal outResult=0M;

        public r505 ( MulaolaoLibrary . QUOKEntity model ,string num )
        {
            InitializeComponent ( );

            _bll = new MulaolaoBll . Bll . QuoBll ( );

            this . model = model;
            this . num = num;

            setValue ( );
        }

        private void setValue ( )
        {
            if ( model == null )
                return;
            if ( model . idx < 1 )
                return;
            model = _bll . getModel505 ( model . idx );
            if ( model == null )
                return;
            tQUOK006 . Text = model . QUOK006;
            tQUOK007 . Text = model . QUOK007;
            tQUOK008 . Text = Convert . ToDecimal ( model . QUOK008 ) . ToString ( "0.######" );
            tQUOK009 . Text = model . QUOK009;
            tQUOK010 . Text = Convert . ToDecimal ( model . QUOK010 ) . ToString ( "0.######" );
            tQUOK011 . Text = Convert . ToDecimal ( model . QUOK011 ) . ToString ( "0.######" );
            tQUOK012 . Text = Convert . ToDecimal ( model . QUOK012 ) . ToString ( "0.######" );
            tQUOK013 . Text = Convert . ToDecimal ( model . QUOK013 ) . ToString ( "0.######" );
            tQUOK014 . Text = Convert . ToDecimal ( model . QUOK014 ) . ToString ( "0.######" );
            tQUOK015 . Text = Convert . ToDecimal ( model . QUOK015 ) . ToString ( "0.######" );
            tQUOK016 . Text = Convert . ToDecimal ( model . QUOK016 ) . ToString ( "0.######" );
            tQUOK017 . Text = Convert . ToDecimal ( model . QUOK017 ) . ToString ( "0.######" );
            tQUOK018 . Text = Convert . ToDecimal ( model . QUOK018 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            int id = _bll . Save505 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        bool getValue ( )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOK006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOK006 ,"不可为空" );
                return false;
            }
            model . QUOK006 = tQUOK006 . Text;
            model . QUOK007 = tQUOK007 . Text;
            model . QUOK009 = tQUOK009 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK008 . Text ) && decimal . TryParse ( tQUOK008 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK008 ,"必须是数字" );
                return false;
            }
            model . QUOK008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK010 . Text ) && decimal . TryParse ( tQUOK010 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK010 ,"必须是数字" );
                return false;
            }
            model . QUOK010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK011 . Text ) && decimal . TryParse ( tQUOK011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK011 ,"必须是数字" );
                return false;
            }
            model . QUOK011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK012 . Text ) && decimal . TryParse ( tQUOK012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK012 ,"必须是数字" );
                return false;
            }
            model . QUOK012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK013 . Text ) && decimal . TryParse ( tQUOK013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK013 ,"必须是数字" );
                return false;
            }
            model . QUOK013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK014 . Text ) && decimal . TryParse ( tQUOK014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK014 ,"必须是数字" );
                return false;
            }
            model . QUOK014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK015 . Text ) && decimal . TryParse ( tQUOK015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK015 ,"必须是数字" );
                return false;
            }
            model . QUOK015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK016 . Text ) && decimal . TryParse ( tQUOK016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK016 ,"必须是数字" );
                return false;
            }
            model . QUOK016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK017 . Text ) && decimal . TryParse ( tQUOK017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK017 ,"必须是数字" );
                return false;
            }
            model . QUOK017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOK018 . Text ) && decimal . TryParse ( tQUOK018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOK018 ,"必须是数字" );
                return false;
            }
            model . QUOK018 = outResult;

            return true;
        }

        private void tQUOK006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To505 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form505Query form = new Form505Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOK006 . Text = row [ "GS07" ] . ToString ( );
                tQUOK009 . Text = row [ "GS08" ] . ToString ( );
            }
        }

    }
}