using System;
using System . Data;
using System . Windows . Forms;
using DevExpress . XtraEditors;

namespace Mulaolao . QuoForms
{
    public partial class r196 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOBEntity model = null;
        string num=string.Empty;
        decimal outResult=0M;

        public r196 ( MulaolaoLibrary . QUOBEntity model,string num )
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
            model = _bll . getModel196 ( model . idx );
            if ( model == null )
                return;

            tQUOB005 . Text = model . QUOB005;
            tQUOB006 . Text = model . QUOB006;
            tQUOB007 . Text = model . QUOB007;
            tQUOB008 . Text = Convert . ToDecimal ( model . QUOB008 ) . ToString ( "0.######" );
            tQUOB009 . Text = Convert . ToDecimal ( model . QUOB009 ). ToString ( "0.######" );
            tQUOB010 . Text = Convert . ToDecimal ( model . QUOB010 ). ToString ( "0.######" );
            tQUOB011 . Text = Convert . ToDecimal ( model . QUOB011 ). ToString ( "0.######" );
            tQUOB012 . Text = model . QUOB012;
            tQUOB013 . Text = model . QUOB013;
            tQUOB014 . Text = model . QUOB014;
            tQUOB015 . Text = Convert . ToDecimal ( model . QUOB015) . ToString ( "0.######" );
            tQUOB016 . Text = model . QUOB016;
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOB005 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOB005 ,"不可为空" );
                return;
            }
            model . QUOB005 = tQUOB005 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOB008 . Text ) && decimal . TryParse ( tQUOB008 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOB008 ,"必须是数字" );
                return;
            }
            model . QUOB008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOB009 . Text ) && decimal . TryParse ( tQUOB009 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOB009 ,"必须是数字" );
                return;
            }
            model . QUOB009 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOB010 . Text ) && decimal . TryParse ( tQUOB010 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOB010 ,"必须是数字" );
                return;
            }
            model . QUOB010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOB011 . Text ) && decimal . TryParse ( tQUOB011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOB011 ,"必须是数字" );
                return;
            }
            model . QUOB011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOB015 . Text ) && decimal . TryParse ( tQUOB015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOB015 ,"必须是数字" );
                return;
            }
            model . QUOB015 = outResult;
            model . QUOB006 = tQUOB006 . Text;
            model . QUOB007 = tQUOB007 . Text;
            model . QUOB012 = tQUOB012 . Text;
            model . QUOB013 = tQUOB013 . Text;
            model . QUOB014 = tQUOB014 . Text;
            model . QUOB016 = tQUOB006 . Text;

            int id = _bll . Save196 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void tQUOB005_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To196 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form196Qquery form = new Form196Qquery ( table );
            if ( form . DialogResult == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOB005 . Text = row [ "AH10" ] . ToString ( );
                tQUOB006 . Text = row [ "AH11" ] . ToString ( );
                tQUOB014 . Text = row [ "AH12" ] . ToString ( );
                tQUOB008 . Text = row [ "AH13" ] . ToString ( );
                tQUOB013 . Text = row [ "AH119" ] . ToString ( );
            }
        }

    }
}