using System;
using System . Windows . Forms;
using DevExpress . XtraEditors;
using System . Data;

namespace Mulaolao . QuoForms
{
    public partial class r342 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary . QUOEEntity model=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r342 ( MulaolaoLibrary . QUOEEntity model ,string num)
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
            model = _bll . getModel342 ( model . idx );
            if ( model == null )
                return;
            tQUOE006 . Text = model . QUOE006;
            tQUOE007 . Text = model . QUOE007;
            tQUOE008 . Text = Convert . ToDecimal ( model . QUOE008 ) . ToString ( "0.######" );
            tQUOE009 . Text = Convert . ToDecimal ( model . QUOE009 ) . ToString ( "0.######" );
            tQUOE010 . Text = Convert . ToDecimal ( model . QUOE010 ) . ToString ( "0.######" );
            tQUOE011 . Text = Convert . ToDecimal ( model . QUOE011 ) . ToString ( "0.######" );
            tQUOE012 . Text = Convert . ToDecimal ( model . QUOE012 ) . ToString ( "0.######" );
            tQUOE013 . Text = Convert . ToDecimal ( model . QUOE013 ) . ToString ( "0.######" );
            tQUOE014 . Text = Convert . ToDecimal ( model . QUOE014 ) . ToString ( "0.######" );
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOE006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOE006 ,"不可为空" );
                return;
            }
            model . QUOE006 = tQUOE006 . Text;
            model . QUOE007 = tQUOE007 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE008 . Text ) && decimal . TryParse ( tQUOE008 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE008 ,"必须是数字" );
                return;
            }
            model . QUOE008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE009 . Text ) && decimal . TryParse ( tQUOE009 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE009 ,"必须是数字" );
                return;
            }
            model . QUOE009 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE010 . Text ) && decimal . TryParse ( tQUOE010 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE010 ,"必须是数字" );
                return;
            }
            model . QUOE010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE011 . Text ) && decimal . TryParse ( tQUOE011 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE011 ,"必须是数字" );
                return;
            }
            model . QUOE011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE012 . Text ) && decimal . TryParse ( tQUOE012 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE012 ,"必须是数字" );
                return;
            }
            model . QUOE012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE013 . Text ) && decimal . TryParse ( tQUOE013 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE013 ,"必须是数字" );
                return;
            }
            model . QUOE013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOE014 . Text ) && decimal . TryParse ( tQUOE014 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOE014 ,"必须是数字" );
                return;
            }
            model . QUOE014 = outResult;

            int id = _bll . Save342 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void tQUOE006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            DataTable table = _bll . getTableFor509To342 ( num );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Form342Query form = new Form342Query ( table );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                DataRow row = form . getRow;
                tQUOE006 . Text = row [ "GS02" ] . ToString ( );
                tQUOE007 . Text = row [ "GS07" ] . ToString ( );
                tQUOE009 . Text = row [ "GS10" ] . ToString ( );
                string spe = row [ "GS08" ] . ToString ( );
                if ( string . IsNullOrEmpty ( spe ) )
                    return;
                string [ ] speS = spe . Split ( '*' );
                if ( speS . Length < 1 )
                    return;
                if ( speS [ 0 ] . Contains ( "Φ" ) )
                {
                    tQUOE013 . Text = tQUOE014 . Text = ( Convert . ToDecimal ( speS [ 0 ] . Replace ( 'Φ' ,' ' ) ) / 10 ) . ToString ( "0.###" );
                    if ( !string . IsNullOrEmpty ( speS [ 1 ] ) )
                        tQUOE012 . Text = ( Convert . ToDecimal ( speS [ 1 ] ) / 10 ) . ToString ( "0.###" );
                    else
                        tQUOE012 . Text = string . Empty;
                }
                else
                {
                    tQUOE012 . Text = tQUOE013 . Text = tQUOE014 . Text = string . Empty;
                    if ( !string . IsNullOrEmpty ( speS [ 0 ] ) && decimal . TryParse ( speS [ 0 ] ,out outResult ) )
                        tQUOE012 . Text = ( Convert . ToDecimal ( speS [ 0 ] ) / 10 ) . ToString ( "0.###" );
                    if ( !string . IsNullOrEmpty ( speS [ 1 ] ) && decimal . TryParse ( speS [ 1 ] ,out outResult ) )
                        tQUOE013 . Text = ( Convert . ToDecimal ( speS [ 1 ] ) / 10 ) . ToString ( "0.###" );
                    if ( !string . IsNullOrEmpty ( speS [ 2 ] ) && decimal . TryParse ( speS [ 2 ] ,out outResult ) )
                        tQUOE014 . Text = ( Convert . ToDecimal ( speS [ 2 ] ) / 10 ) . ToString ( "0.###" );
                }
            }
        }

    }
}