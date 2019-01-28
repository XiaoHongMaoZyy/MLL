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
using MulaolaoBll;

namespace Mulaolao . QuoForms
{
    public partial class r349 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary .QUOHEntity model=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r349 ( MulaolaoLibrary . QUOHEntity model ,string num )
        {
            InitializeComponent ( );

            _bll = new MulaolaoBll . Bll . QuoBll ( );

            this . model = model;
            this . num = num;

            tQUOH006 . Properties . Items . Add ( DicStr . swwx );
            tQUOH006 . Properties . Items . Add ( DicStr . xxs );
            tQUOH006 . Properties . Items . Add ( DicStr . ygs );
            tQUOH006 . Properties . Items . Add ( DicStr . cks );
            tQUOH006 . Properties . Items . Add ( DicStr . zds );
            tQUOH006 . Properties . Items . Add ( DicStr . tg );
            tQUOH006 . Properties . Items . Add ( DicStr . dg );
            tQUOH006 . Properties . Items . Add ( DicStr . dwlzk );
            tQUOH006 . Properties . Items . Add ( DicStr . swlzk );
            tQUOH006 . Properties . Items . Add ( DicStr . cgjs );

            setValue ( );
        }

        void setValue ( )
        {
            if ( model == null )
                return;
            if ( model . idx < 1 )
                return;
            model = _bll . getModel349 ( model . idx );
            if ( model == null )
                return;
            tQUOH006 . Text = model . QUOH006;
            tQUOH007 . Text = model . QUOH007;
            tQUOH008 . Text = model . QUOH008;
            tQUOH009 . Text = model . QUOH009;
            tQUOH010 . Text = model . QUOH010;
            tQUOH011 . Text = model . QUOH011;
            tQUOH012 . Text = Convert . ToDecimal ( model . QUOH012 ) . ToString ( "0.######" );
            tQUOH013 . Text = Convert . ToDecimal ( model . QUOH013 ) . ToString ( "0.######" );
            tQUOH014 . Text = Convert . ToDecimal ( model . QUOH014 ) . ToString ( "0.######" );
            tQUOH015 . Text = Convert . ToDecimal ( model . QUOH015 ) . ToString ( "0.######" );
            tQUOH016 . Text = Convert . ToDecimal ( model . QUOH016 ) . ToString ( "0.######" );
            tQUOH017 . Text = Convert . ToDecimal ( model . QUOH017 ) . ToString ( "0.######" );
            tQUOH018 . Text = Convert . ToDecimal ( model . QUOH018 ) . ToString ( "0.######" );
            tQUOH019 . Text = Convert . ToDecimal ( model . QUOH019 ) . ToString ( "0.######" );
            tQUOH020 . Text = Convert . ToDecimal ( model . QUOH020 ) . ToString ( "0.######" );
            tQUOH021 . Text = Convert . ToDecimal ( model . QUOH021 ) . ToString ( "0.######" );
            tQUOH022 . Text = Convert . ToDecimal ( model . QUOH022 ) . ToString ( "0.######" );
            tQUOH023 . Text = Convert . ToDecimal ( model . QUOH023 ) . ToString ( "0.######" );
            tQUOH024 . Text = Convert . ToDecimal ( model . QUOH024 ) . ToString ( "0.######" );
            tQUOH025 . Text = Convert . ToDecimal ( model . QUOH025 ) . ToString ( "0.######" );
            tQUOH026 . Text = Convert . ToDecimal ( model . QUOH026 ) . ToString ( "0.######" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            if ( getVaule ( ) == false )
                return;
            int id = _bll . Save349 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        bool getVaule ( )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOH006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOH006 ,"不可为空" );
                return false;
            }
            model . QUOH006 = tQUOH006 . Text;
            model . QUOH007 = tQUOH007 . Text;
            model . QUOH008 = tQUOH008 . Text;
            model . QUOH009 = tQUOH009 . Text;
            model . QUOH010 = tQUOH010 . Text;
            model . QUOH011 = tQUOH011 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH012 . Text ) && decimal . TryParse ( tQUOH012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH012 ,"必须是数字" );
                return false;
            }
            model . QUOH012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH013 . Text ) && decimal . TryParse ( tQUOH013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH013 ,"必须是数字" );
                return false;
            }
            model . QUOH013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH014 . Text ) && decimal . TryParse ( tQUOH014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH014 ,"必须是数字" );
                return false;
            }
            model . QUOH014 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH015 . Text ) && decimal . TryParse ( tQUOH015 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH015 ,"必须是数字" );
                return false;
            }
            model . QUOH015 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH016 . Text ) && decimal . TryParse ( tQUOH016 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH016 ,"必须是数字" );
                return false;
            }
            model . QUOH016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH017 . Text ) && decimal . TryParse ( tQUOH017 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH017 ,"必须是数字" );
                return false;
            }
            model . QUOH017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH018 . Text ) && decimal . TryParse ( tQUOH018 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH018 ,"必须是数字" );
                return false;
            }
            model . QUOH018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH019 . Text ) && decimal . TryParse ( tQUOH019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH019 ,"必须是数字" );
                return false;
            }
            model . QUOH019 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH020 . Text ) && decimal . TryParse ( tQUOH020 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH020 ,"必须是数字" );
                return false;
            }
            model . QUOH020 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH021 . Text ) && decimal . TryParse ( tQUOH021 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH021 ,"必须是数字" );
                return false;
            }
            model . QUOH021 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH022 . Text ) && decimal . TryParse ( tQUOH022 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH022 ,"必须是数字" );
                return false;
            }
            model . QUOH022 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH023 . Text ) && decimal . TryParse ( tQUOH023 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH023 ,"必须是数字" );
                return false;
            }
            model . QUOH023 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH024 . Text ) && decimal . TryParse ( tQUOH024 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH024 ,"必须是数字" );
                return false;
            }
            model . QUOH024 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH025 . Text ) && decimal . TryParse ( tQUOH025 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH025 ,"必须是数字" );
                return false;
            }
            model . QUOH025 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOH026 . Text ) && decimal . TryParse ( tQUOH026 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOH026 ,"必须是数字" );
                return false;
            }
            model . QUOH026 = outResult;

            return true;
        }

        private void tQUOH016_TextChanged ( object sender ,EventArgs e )
        {
            if ( string . IsNullOrEmpty ( tQUOH016 . Text ) ) return;
            model . QUOH016 = Convert . ToDecimal ( tQUOH016 . Text );
            if ( model . QUOH016 == 0 ) return;
            tQUOH015 . Text = Convert . ToDecimal ( model . QUOH005 / model . QUOH016 ) . ToString ( "0.##" );
        }

        private void tQUOH007_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To349 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form349Query form = new Form349Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOH006 . Text = row [ "GS02" ] . ToString ( );
                tQUOH007 . Text = row [ "GS07" ] . ToString ( );
                tQUOH008 . Text = row [ "GS08" ] . ToString ( );
                tQUOH009 . Text = row [ "GS09" ] . ToString ( );
                tQUOH010 . Text = row [ "GS71" ] . ToString ( );
                tQUOH014 . Text = row [ "GS10" ] . ToString ( );
            }
        }

    }
}