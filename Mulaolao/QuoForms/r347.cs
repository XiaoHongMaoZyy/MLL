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
    public partial class r347 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary .QUOGEntity model=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r347 ( MulaolaoLibrary . QUOGEntity model ,string num )
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
            model = _bll . getModel347 ( model . idx );
            if ( model == null )
                return;
            tQUOG006 . Text = model . QUOG006;
            tQUOG007 . Text = model . QUOG007;
            tQUOG008 . Text = model . QUOG008;
            tQUOG009 . Text = model . QUOG009;
            tQUOG010 . Text = model . QUOG010;
            tQUOG011 . Text = Convert . ToDecimal ( model . QUOG011 ) . ToString ( "0.######" );
            tQUOG012 . Text = Convert . ToDecimal ( model . QUOG012 ) . ToString ( "0.######" );
            tQUOG013 . Text = Convert . ToDecimal ( model . QUOG013 ) . ToString ( "0.######" );
            tQUOG014 . Text = Convert . ToDecimal ( model . QUOG014 ) . ToString ( "0.######" );
            tQUOG015 . Text = Convert . ToDecimal ( model . QUOG015 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOG006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOG006 ,"不可为空" );
                return;
            }
            model . QUOG006 = tQUOG006 . Text;
            model . QUOG007 = tQUOG007 . Text;
            model . QUOG008 = tQUOG008 . Text;
            model . QUOG009 = tQUOG009 . Text;
            model . QUOG010 = tQUOG010 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOG011 . Text ) && decimal . TryParse ( tQUOG011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOG011 ,"不可为空" );
                return;
            }
            model . QUOG011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOG012 . Text ) && decimal . TryParse ( tQUOG012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOG012 ,"不可为空" );
                return;
            }
            model . QUOG012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOG013 . Text ) && decimal . TryParse ( tQUOG013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOG013 ,"不可为空" );
                return;
            }
            model . QUOG013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOG014 . Text ) && decimal . TryParse ( tQUOG014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOG014 ,"不可为空" );
                return;
            }
            model . QUOG014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOG015 . Text ) && decimal . TryParse ( tQUOG015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOG015 ,"不可为空" );
                return;
            }
            model . QUOG015 = outResult;

            int id = _bll . Save347 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void tQUOG006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To347 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form347Query form = new Form347Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOG006 . Text = row [ "GS07" ] . ToString ( );
                tQUOG007 . Text = row [ "GS08" ] . ToString ( );
                tQUOG008 . Text = row [ "GS09" ] . ToString ( );
                tQUOG011 . Text = row [ "GS10" ] . ToString ( );
                tQUOG009 . Text = row [ "GS71" ] . ToString ( );
            }
        }

    }
}