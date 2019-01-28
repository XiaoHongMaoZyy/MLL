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
    public partial class r341 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUODEntity model=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r341 ( MulaolaoLibrary . QUODEntity model ,string num )
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
            model = _bll . getModel341 ( model . idx );
            if ( model == null )
                return;
            tQUOD005 . Text = model . QUOD005;
            tQUOD006 . Text = model . QUOD006;
            tQUOD007 . Text =Convert.ToDecimal( model . QUOD007 ). ToString ( "0.######" );
            tQUOD008 . Text = Convert . ToDecimal ( model . QUOD008 ) . ToString ( "0.######" );
            tQUOD009 . Text = Convert . ToDecimal ( model . QUOD009 ) . ToString ( "0.######" );
            tQUOD010 . Text = Convert . ToDecimal ( model . QUOD010 ) . ToString ( "0.######" );
            tQUOD011 . Text = Convert . ToDecimal ( model . QUOD011 ) . ToString ( "0.######" );
            tQUOD012 . Text = Convert . ToDecimal ( model . QUOD012 ) . ToString ( "0.######" );
            tQUOD013 . Text = Convert . ToDecimal ( model . QUOD013 ) . ToString ( "0.######" );
            tQUOD014 . Text = Convert . ToDecimal ( model . QUOD014 ) . ToString ( "0.######" );
            tQUOD015 . Text = Convert . ToDecimal ( model . QUOD015 ) . ToString ( "0.######" );
            tQUOD016 . Text = Convert . ToDecimal ( model . QUOD016 ) . ToString ( "0.######" );
            tQUOD017 . Text = Convert . ToDecimal ( model . QUOD017 ) . ToString ( "0.######" );
            tQUOD018 . Text = Convert . ToDecimal ( model . QUOD018 ) . ToString ( "0.######" );
            tQUOD019 . Text = Convert . ToDecimal ( model . QUOD019 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSave_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;

            int id = _bll . Save341 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void CalcOne_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            if ( model . QUOD010 == 0 || model . QUOD012 == 0 )
                textEdit10 . Text = 0 . ToString ( );
            else
                textEdit10 . Text = Convert . ToDecimal ( model . QUOD020 * model . QUOD008 * model . QUOD013 * model . QUOD014 * model . QUOD015 * Convert . ToDecimal ( 0.000001 ) / model . QUOD010 / model . QUOD012 ) . ToString ( "0.###" );
        }

        private void CalcTwo_Click ( object sender ,EventArgs e )
        {
            if ( getValue ( ) == false )
                return;
            if ( model . QUOD016 == 0 || model . QUOD017 == 0 || model . QUOD018 == 0 )
                textEdit11 . Text = 0 . ToString ( );
            else
                textEdit11 . Text = Convert . ToDecimal ( model . QUOD013 * model . QUOD014 * model . QUOD015 / model . QUOD016 / model . QUOD017 / model . QUOD018 ) . ToString ( "0.###" );
        }

        bool getValue ( )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOD005 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOD005 ,"不可为空" );
                return false;
            }
            model . QUOD005 = tQUOD005 . Text;
            model . QUOD006 = tQUOD006 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD007 . Text ) && decimal . TryParse ( tQUOD007 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD007 ,"必须是数字" );
                return false;
            }
            model . QUOD007 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD008 . Text ) && decimal . TryParse ( tQUOD008 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD008 ,"必须是数字" );
                return false;
            }
            model . QUOD008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD009 . Text ) && decimal . TryParse ( tQUOD009 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD009 ,"必须是数字" );
                return false;
            }
            model . QUOD009 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD010 . Text ) && decimal . TryParse ( tQUOD010 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD010 ,"必须是数字" );
                return false;
            }
            model . QUOD010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD011 . Text ) && decimal . TryParse ( tQUOD011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD011 ,"必须是数字" );
                return false;
            }
            model . QUOD011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD012 . Text ) && decimal . TryParse ( tQUOD012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD012 ,"必须是数字" );
                return false;
            }
            model . QUOD012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD013 . Text ) && decimal . TryParse ( tQUOD013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD013 ,"必须是数字" );
                return false;
            }
            model . QUOD013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD014 . Text ) && decimal . TryParse ( tQUOD014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD014 ,"必须是数字" );
                return false;
            }
            model . QUOD014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD015 . Text ) && decimal . TryParse ( tQUOD015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD015 ,"必须是数字" );
                return false;
            }
            model . QUOD015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD016 . Text ) && decimal . TryParse ( tQUOD016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD016 ,"必须是数字" );
                return false;
            }
            model . QUOD016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD017 . Text ) && decimal . TryParse ( tQUOD017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD017 ,"必须是数字" );
                return false;
            }
            model . QUOD017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD018 . Text ) && decimal . TryParse ( tQUOD018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD018 ,"必须是数字" );
                return false;
            }
            model . QUOD018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOD019 . Text ) && decimal . TryParse ( tQUOD019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOD019 ,"必须是数字" );
                return false;
            }
            model . QUOD019 = outResult;

            return true;
        }

        private void tQUOD005_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To341 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form341Query form = new Form341Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOD005 . Text = row [ "GS02" ] . ToString ( );
                tQUOD006 . Text = row [ "GS07" ] . ToString ( );
                tQUOD008 . Text = row [ "GS10" ] . ToString ( );
                string spe = row [ "GS08" ] . ToString ( );
                if ( string . IsNullOrEmpty ( spe ) )
                    return;
                if ( !spe . Contains ( "*" ) )
                    return;
                string [ ] speS = spe . Split ( '*' );
                if ( speS . Length < 1 )
                    return;
                if ( string . IsNullOrEmpty ( speS [ 0 ] ) )
                    return;
                if ( decimal . TryParse ( speS [ 0 ] ,out outResult ) == false )
                    return;
                tQUOD016 . Text = ( Convert . ToDecimal ( speS [ 0 ] ) / 10 ) . ToString ( "0.###" );
                if ( string . IsNullOrEmpty ( speS [ 1 ] ) )
                    return;
                if ( decimal . TryParse ( speS [ 1 ] ,out outResult ) == false )
                    return;
                tQUOD017 . Text = ( Convert . ToDecimal ( speS [ 1 ] ) / 10 ) . ToString ( "0.###" );
                if ( string . IsNullOrEmpty ( speS [ 2 ] ) )
                    return;
                if ( decimal . TryParse ( speS [ 2 ] ,out outResult ) == false )
                    return;
                tQUOD018 . Text = ( Convert . ToDecimal ( speS [ 2 ] ) / 10 ) . ToString ( "0.###" );
            }
        }


    }
}