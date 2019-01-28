using System;
using System . Data;
using System . Windows . Forms;
using DevExpress . XtraEditors;
using Mulaolao . Other;
using MulaolaoBll;

namespace Mulaolao . QuoForms
{
    public partial class r338 :DevExpress . XtraEditors . XtraForm
    {
        MulaolaoBll.Bll.QuoBll _bll=null;
        MulaolaoLibrary.QUOCEntity model=null;
        string num=string.Empty;
        decimal outResult=0M;

        public r338 ( MulaolaoLibrary . QUOCEntity model ,string num)
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
            model = _bll . getModel338 ( model . idx );
            if ( model == null )
                return;
            tQUOC006 . Text = model . QUOC006;
            tQUOC007 . Text = Convert . ToDecimal ( model . QUOC007 ) . ToString ( "0.######" );
            tQUOC008 . Text = Convert . ToDecimal ( model . QUOC008 ) . ToString ( "0.######" );
            tQUOC009 . Text = Convert . ToDecimal ( model . QUOC009 ) . ToString ( "0.######" );
            tQUOC010 . Text = Convert . ToDecimal ( model . QUOC010 ) . ToString ( "0.######" );
            tQUOC011 . Text = Convert . ToDecimal ( model . QUOC011 ) . ToString ( "0.######" );
            tQUOC012 . Text = Convert . ToDecimal ( model . QUOC012 ) . ToString ( "0.######" );
            tQUOC012 . Tag = Convert . ToDecimal ( model . QUOC012 ) . ToString ( "0.######" );
            tQUOC013 . Text = Convert . ToDecimal ( model . QUOC013 ) . ToString ( "0.######" );
            tQUOC014 . Text = Convert . ToDecimal ( model . QUOC014 ) . ToString ( "0.######" );
            tQUOC015 . Text = model . QUOC015;
            tQUOC016 . Text = Convert . ToDecimal ( model . QUOC016 ) . ToString ( "0.######" );
            tQUOC017 . Text = Convert . ToDecimal ( model . QUOC017 ) . ToString ( "0.######" );
            tQUOC018 . Text = Convert . ToDecimal ( model . QUOC018 ) . ToString ( "0.######" );
            tQUOC019 . Text = Convert . ToDecimal ( model . QUOC019 ) . ToString ( "0.######" );
            tQUOC020 . Text = model . QUOC020;
        }

        private void btnSure_Click ( object sender ,EventArgs e )
        {
            dxErrorProvider1 . ClearErrors ( );
            if ( string . IsNullOrEmpty ( tQUOC006 . Text ) )
            {
                dxErrorProvider1 . SetError ( tQUOC006 ,"不可为空" );
                return;
            }
            model . QUOC006 = tQUOC006 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC007 . Text ) && decimal . TryParse ( tQUOC007 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC007 ,"必须是数字" );
                return;
            }
            model . QUOC007 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC008 . Text ) && decimal . TryParse ( tQUOC008 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC008 ,"必须是数字" );
                return;
            }
            model . QUOC008 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC009 . Text ) && decimal . TryParse ( tQUOC009 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC009 ,"必须是数字" );
                return;
            }
            model . QUOC009 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC010 . Text ) && decimal . TryParse ( tQUOC010 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC010 ,"必须是数字" );
                return;
            }
            model . QUOC010 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC011 . Text ) && decimal . TryParse ( tQUOC011 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC011 ,"必须是数字" );
                return;
            }
            model . QUOC011 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC012 . Text ) && decimal . TryParse ( tQUOC012 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC012 ,"必须是数字" );
                return;
            }
            model . QUOC012 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC013 . Text ) && decimal . TryParse ( tQUOC013 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC013 ,"必须是数字" );
                return;
            }
            model . QUOC013 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC014 . Text ) && decimal . TryParse ( tQUOC014 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC014 ,"必须是数字" );
                return;
            }
            model . QUOC014 = outResult;
            model . QUOC015 = tQUOC015 . Text;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC016 . Text ) && decimal . TryParse ( tQUOC016 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC016 ,"必须是数字" );
                return;
            }
            model . QUOC016 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC017 . Text ) && decimal . TryParse ( tQUOC017 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC017 ,"必须是数字" );
                return;
            }
            model . QUOC017 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC018 . Text ) && decimal . TryParse ( tQUOC018 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC018 ,"必须是数字" );
                return;
            }
            model . QUOC018 = outResult;
            outResult = 0M;
            if ( !string . IsNullOrEmpty ( tQUOC019 . Text ) && decimal . TryParse ( tQUOC019 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC019 ,"必须是数字" );
                return;
            }
            model . QUOC019 = outResult;

            int id = _bll . Save338 ( model );
            if ( id > 0 )
                this . DialogResult = DialogResult . OK;
            else
                XtraMessageBox . Show ( "保存失败" );
        }

        private void btnCancel_Click ( object sender ,EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }

        private void tQUOC012_TextChanged ( object sender ,EventArgs e )
        {
            if ( !string . IsNullOrEmpty ( tQUOC012 . Text ) && decimal . TryParse ( tQUOC012 . Text ,out
                    outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC012 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC016 . Text ) && decimal . TryParse ( tQUOC016 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC016 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC019 . Text ) && decimal . TryParse ( tQUOC019 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC019 ,"必须是数字" );
                return;
            }
            textEdit7 . Text = MulaolaoBll . CalcuResult . calcuPriceFor338 ( tQUOC012 . Text ,tQUOC016 . Text ,tQUOC019 . Text );
        }

        private void tQUOC016_TextChanged ( object sender ,EventArgs e )
        {
            if ( !string . IsNullOrEmpty ( tQUOC012 . Text ) && decimal . TryParse ( tQUOC012 . Text ,out
                    outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC012 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC016 . Text ) && decimal . TryParse ( tQUOC016 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC016 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC019 . Text ) && decimal . TryParse ( tQUOC019 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC019 ,"必须是数字" );
                return;
            }
            textEdit7 . Text = MulaolaoBll . CalcuResult . calcuPriceFor338 ( tQUOC012 . Text ,tQUOC016 . Text ,tQUOC019 . Text );
        }

        private void tQUOC019_TextChanged ( object sender ,EventArgs e )
        {
            if ( !string . IsNullOrEmpty ( tQUOC012 . Text ) && decimal . TryParse ( tQUOC012 . Text ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC012 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC016 . Text ) && decimal . TryParse ( tQUOC016 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC016 ,"必须是数字" );
                return;
            }
            if ( !string . IsNullOrEmpty ( tQUOC019 . Text ) && decimal . TryParse ( tQUOC019 . Text ,out
               outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC019 ,"必须是数字" );
                return;
            }
            textEdit7 . Text = MulaolaoBll . CalcuResult . calcuPriceFor338 ( tQUOC012 . Text ,tQUOC016 . Text ,tQUOC019 . Text );
            calcu ( );
        }

        void calcu ( )
        {
            outResult = 0M;
            if ( tQUOC012 . Tag != null && !string . IsNullOrEmpty ( tQUOC012 . Tag.ToString() ) && decimal . TryParse ( tQUOC012 . Tag.ToString() ,out
                 outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC012 ,"必须是数字" );
                return;
            }
            model . QUOC012 = outResult;
            outResult = 0M;
            if (  !string . IsNullOrEmpty ( tQUOC019 . Text ) && decimal . TryParse ( tQUOC019 . Text ,out outResult ) == false )
            {
                dxErrorProvider1 . SetError ( tQUOC019 ,"必须是数字" );
                return;
            }
            model . QUOC019 = outResult;
            tQUOC012 . Text = ( model . QUOC019 + model . QUOC012 ) . ToString ( );
        }

        private void tQUOC006_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
            FormJiaoMiDu form = new FormJiaoMiDu ( );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                string info = form . getStr;
                DataRow row = form . getRow;
                string spe = string . Empty;
                tQUOC019 . Text = string . Empty;
                if ( DicStr . plyWood . Equals ( info ) )
                {
                    tQUOC006 . Text = DicStr . plyWood;
                    spe = row [ "QJB003" ] . ToString ( );
                    if ( spe != string . Empty )
                    {
                        tQUOC007 . Text = spe . Split ( '*' ) [ 0 ] . ToString ( );
                        tQUOC008 . Text = spe . Split ( '*' ) [ 1 ] . ToString ( );
                        tQUOC009 . Text = spe . Split ( '*' ) [ 2 ] . ToString ( );
                    }
                    tQUOC020 . Text = row [ "QJB002" ] . ToString ( );
                    tQUOC015 . Text = row [ "QJB011" ] . ToString ( );
                    tQUOC012 . Tag = tQUOC012 . Text = string . IsNullOrEmpty ( row [ "QJB007" ] . ToString ( ) ) == true ? 0 . ToString ( ) : ( string . IsNullOrEmpty ( row [ "QJB008" ] . ToString ( ) ) == true ? 0 . ToString ( ) : ( Convert . ToDecimal ( row [ "QJB007" ] ) / Convert . ToDecimal ( row [ "QJB008" ] ) ) . ToString ( "0.##" ) );
                    tQUOC016 . Text = row [ "QJB008" ] . ToString ( );
                }
                else if ( DicStr . densityBoard . Equals ( info ) )
                {
                    tQUOC006 . Text = DicStr . densityBoard;
                    spe = row [ "QMD003" ] . ToString ( );
                    if ( spe != string . Empty )
                    {
                        tQUOC007 . Text = spe . Split ( '*' ) [ 0 ] . ToString ( );
                        tQUOC008 . Text = spe . Split ( '*' ) [ 1 ] . ToString ( );
                        tQUOC009 . Text = spe . Split ( '*' ) [ 2 ] . ToString ( );
                    }
                    tQUOC020 . Text = row [ "QMD002" ] . ToString ( );
                    tQUOC015 . Text = row [ "QMD009" ] . ToString ( );
                    tQUOC012 . Tag = tQUOC012 . Text = string . IsNullOrEmpty ( row [ "QMD006" ] . ToString ( ) ) == true ? 0 . ToString ( ) : ( string . IsNullOrEmpty ( row [ "QMD007" ] . ToString ( ) ) == true ? 0 . ToString ( ) : ( Convert . ToDecimal ( row [ "QMD006" ] ) / Convert . ToDecimal ( row [ "QMD007" ] ) ) . ToString ( "0.##" ) );
                    tQUOC016 . Text = row [ "QMD007" ] . ToString ( );
                }
            }
        }

    }
}