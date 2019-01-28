using System;
using System . Data;
using System . Windows . Forms;
using Mulaolao . Class;
using DevExpress . XtraEditors;

namespace Mulaolao . QuoForms
{
    public partial class r195 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOAEntity model=null;
        decimal outResult=0M;
        string num=string.Empty;

        public r195 ( MulaolaoLibrary . QUOAEntity model ,string num )
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
            if ( model . idx > 0 )
                model = _bll . getModel195 ( model . idx );
            if ( model == null )
                return;
            tQUOA001 . Text = model . QUOA001;
            tQUOA002 . Text = model . QUOA002;
            tQUOA003 . Text = Convert . ToDecimal ( model . QUOA003 ) . ToString ( "0.######" );
            tQUOA004 . Text = Convert . ToDecimal ( model . QUOA004 ) . ToString ( "0.######" );
            tQUOA005 . Text = Convert . ToDecimal ( model . QUOA005 ) . ToString ( "0.######" );
            tQUOA006 . Text = Convert . ToDecimal ( model . QUOA006 ) . ToString ( "0.######" );
            tQUOA007 . Text = model . QUOA007;
            tQUOA008 . Text = model . QUOA008;
            tQUOA009 . Text = model . QUOA009;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOA001 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOA001 ,"不可为空" );
                return;
            }
            model . QUOA001 = tQUOA001 . Text;
            model . QUOA002 = tQUOA002 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOA005 . Text ) && decimal . TryParse ( tQUOA005 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOA005 ,"必须是数字" );
                return;
            }
            model . QUOA005 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOA003 . Text ) && decimal . TryParse ( tQUOA003 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOA003 ,"必须是数字" );
                return;
            }
            model . QUOA003 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOA004 . Text ) && decimal . TryParse ( tQUOA004 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOA004 ,"必须是数字" );
                return;
            }
            model . QUOA004 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOA006 . Text ) && decimal . TryParse ( tQUOA006 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOA006 ,"必须是数字" );
                return;
            }
            model . QUOA006 = outResult;
            model . QUOA007 = tQUOA007 . Text;
            model . QUOA008 = tQUOA008 . Text;
            model . QUOA009 = tQUOA009 . Text;

            int id = _bll . Save195 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }
        
        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void tQUOA001_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable tableOne = _bll . getTableFor509To195 ( num );
            if ( tableOne == null || tableOne . Rows . Count < 1 )
                return;
            Form195Query form = new Form195Query ( tableOne );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOA001 . Text = row [ "CP06" ] . ToString ( );
                tQUOA002 . Text = row [ "CP07" ] . ToString ( );
                tQUOA009 . Text = row [ "CP08" ] . ToString ( );
                tQUOA005 . Text = row [ "CP13" ] . ToString ( );
                tQUOA008 . Text = row [ "CP64" ] . ToString ( );
            }
        }

    }
}