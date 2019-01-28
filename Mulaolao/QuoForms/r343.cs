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

namespace Mulaolao . QuoForms
{
    public partial class r343 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOFEntity model;
        string num=string.Empty;
        decimal outResult=0M;

        public r343 ( MulaolaoLibrary . QUOFEntity model ,string num)
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
            model = _bll . getModel343 ( model . idx );
            if ( model == null )
                return;
            tQUOF006 . Text = model . QUOF006;
            tQUOF007 . Text = model . QUOF007;
            tQUOF008 . Text = model . QUOF008;
            tQUOF009 . Text = model . QUOF009;
            tQUOF010 . Text = model . QUOF010;
            tQUOF011 . Text = Convert . ToDecimal ( model . QUOF011 ) . ToString ( "0.######" );
            tQUOF012 . Text = Convert . ToDecimal ( model . QUOF012 ) . ToString ( "0.######" );
            tQUOF013 . Text = Convert . ToDecimal ( model . QUOF013 ) . ToString ( "0.######" );
            tQUOF014 . Text = Convert . ToDecimal ( model . QUOF014 ) . ToString ( "0.######" );
            tQUOF015 . Text = Convert . ToDecimal ( model . QUOF015 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOF006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOF006 ,"不可为空" );
                return;
            }
            model . QUOF006 = tQUOF006 . Text;
            model . QUOF007 = tQUOF007 . Text;
            model . QUOF008 = tQUOF008 . Text;
            model . QUOF009 = tQUOF009 . Text;
            model . QUOF010 = tQUOF010 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOF011 . Text ) && decimal . TryParse ( tQUOF011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOF011 ,"必须为数字" );
                return;
            }
            model . QUOF011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOF012 . Text ) && decimal . TryParse ( tQUOF012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOF012 ,"必须为数字" );
                return;
            }
            model . QUOF012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOF013 . Text ) && decimal . TryParse ( tQUOF013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOF013 ,"必须为数字" );
                return;
            }
            model . QUOF013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOF014 . Text ) && decimal . TryParse ( tQUOF014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOF014 ,"必须为数字" );
                return;
            }
            model . QUOF014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOF015 . Text ) && decimal . TryParse ( tQUOF015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOF015 ,"必须为数字" );
                return;
            }
            model . QUOF015 = outResult;

            int id = _bll . Save343 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void tQUOF006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To343 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form343Query form = new Form343Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOF006 . Text = row [ "GS07" ] . ToString ( );
                tQUOF007 . Text = row [ "GS08" ] . ToString ( );
                tQUOF011 . Text = row [ "GS10" ] . ToString ( );
                tQUOF010 . Text = row [ "GS09" ] . ToString ( );
            }
        }

    }
}