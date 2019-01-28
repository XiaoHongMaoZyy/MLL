using DevExpress . XtraEditors;
using Mulaolao . Class;
using Mulaolao . QuoForms;
using MulaolaoBll;
using System;
using System . Collections . Generic;
using System . Data;
using System . Windows . Forms;

namespace Mulaolao . Base
{
    public partial class FormQuotation :FormChild
    {
        MulaolaoLibrary.QuoEntity _quo=null;
        MulaolaoLibrary.QupEntity _qup=null;
        MulaolaoBll.Bll.QuoBll _bll=null;

        Form form=null;

        MulaolaoLibrary.QUOAEntity model195=null;
        MulaolaoLibrary.QUOBEntity model196=null;
        MulaolaoLibrary.QUOCEntity model338=null;
        MulaolaoLibrary.QUODEntity model341=null;
        MulaolaoLibrary.QUOEEntity model342=null;
        MulaolaoLibrary.QUOFEntity model343=null;
        MulaolaoLibrary.QUOGEntity model347=null;
        MulaolaoLibrary.QUOHEntity model349=null;
        MulaolaoLibrary.QUOIEntity model339=null;
        MulaolaoLibrary.QUOJEntity model344=null;
        MulaolaoLibrary.QUOKEntity model505=null;
        MulaolaoLibrary.QUOLEntity model495=null;

        DataTable tableView;
        DataRow selectRow; 
        string state="",strWhere="",conState=string.Empty;

        bool result=false;
        int id=0,selectIdx;

        DateTime dt;

        public FormQuotation ( )
        {
            InitializeComponent ( );

            _bll = new MulaolaoBll . Bll . QuoBll ( );
            _quo = new MulaolaoLibrary . QuoEntity ( );
            _qup = new MulaolaoLibrary . QupEntity ( );
            controlUnEnable ( );
            InitData ( );
            GridViewMoHuSelect . SetFilter ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 ,ViewFor } );
            GrivColumnStyle . setColumnStyle ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 ,ViewFor } );
            dt = Drity . GetDt ( );
        }

        #region Main
        protected override void select ( )
        {
            SelectAll . FormQuotationQuery form = new SelectAll . FormQuotationQuery ( );
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                _quo . QUO001 = form . getOdd;
                if ( _quo . QUO001 == null || _quo . QUO001 == string . Empty )
                    return;
                strWhere = "1=1";
                strWhere = strWhere + " AND QUO001='" + _quo . QUO001 + "'";

                _quo = _bll . getModel ( strWhere );
                if ( _quo == null )
                    return;
                setValue ( );

                queryTable ( );

                toolAdd . Enabled = toolSelect . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolPrint . Enabled = toolExport . Enabled = toolLibrary . Enabled = toolStorage . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolReview . Enabled = true;
                toolSave . Enabled = toolCancel . Enabled = false;
            }

            base . select ( );
        }
        protected override void add ( )
        {
            controlClear ( );
            controlEnable ( );
            state = "add";

            _quo . QUO001 = _bll . getOddNum ( );
            toolSelect . Enabled = toolAdd . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = false;
            toolSave . Enabled = toolCancel . Enabled = true;
            tableView = _bll . getTableView ( "1=2" );
            gridControl1 . DataSource = tableView;

            base . add ( );
        }
        protected override void update ( )
        {
            controlEnable ( );
            toolSelect . Enabled = toolAdd . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = false;
            toolSave . Enabled = toolCancel . Enabled = true;
            state = "edit";

            base . update ( );
        }
        protected override void delete ( )
        {
            if ( string . IsNullOrEmpty ( _quo . QUO001 ) )
            {
                MessageBox . Show ( "请选择需要删除的单据" );
                return;
            }

            result = _bll . Delete ( _quo . QUO001 );
            if ( result )
            {
                XtraMessageBox . Show ( "成功删除" );
                controlUnEnable ( );
                controlClear ( );
                toolSelect . Enabled = toolAdd . Enabled = true;
                toolSave . Enabled = toolCancel . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = false;
            }
            else
                XtraMessageBox . Show ( "删除失败" );


            base . delete ( );
        }
        protected override void save ( )
        {
            if ( getValue ( ) == false )
                return;
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . Save ( _quo ,state );
            if ( result )
            {
                XtraMessageBox . Show ( "成功保存" );
                controlUnEnable ( );
                toolSelect . Enabled = toolAdd . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = true;
                toolSave . Enabled = toolCancel . Enabled = false;
            }
            else
                XtraMessageBox . Show ( "保存失败" );

            base . save ( );
        }
        protected override void cancel ( )
        {
            controlUnEnable ( );
            if ( state . Equals ( "add" ) )
            {
                controlClear ( );
                toolSelect . Enabled = toolAdd . Enabled = true;
                toolSave . Enabled = toolCancel . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = false;
            }
            else if ( state . Equals ( "edit" ) )
            {
                toolSelect . Enabled = toolAdd . Enabled = toolDelete . Enabled = toolUpdate . Enabled = toolReview . Enabled = toolPrint . Enabled = toolExport . Enabled = toolMaintain . Enabled = toolcopy . Enabled = toolLibrary . Enabled = toolStorage . Enabled = true;
                toolSave . Enabled = toolCancel . Enabled = false;
            }

            base . cancel ( );
        }
        #endregion

        #region Event
        //类别
        private void txtQUP002_TextChanged ( object sender ,EventArgs e )
        {
            switch ( txtQUP002 . Text )
            {
                case "成品委外":
                txtQUP003 . Text = DicStr . r195;
                break;
                case "热转印":
                txtQUP003 . Text = DicStr . r196;
                break;
                case "装运.代理":
                txtQUP003 . Text = DicStr . r243;
                break;
                case "胶合板":
                txtQUP003 . Text = DicStr . r338;
                break;
                case "密度板":
                txtQUP003 . Text = DicStr . r338;
                break;
                case "木材":
                txtQUP003 . Text = DicStr . r341;
                break;
                case "车木件":
                txtQUP003 . Text = DicStr . r342;
                break;
                case "铁件":
                txtQUP003 . Text = DicStr . r343;
                break;
                case "塑料件":
                txtQUP003 . Text = DicStr . r347;
                break;
                case "喷漆工资":
                txtQUP003 . Text = DicStr . r495;
                break;
                case "油漆款":
                txtQUP003 . Text = DicStr . r339;
                break;
                case "滚漆款":
                txtQUP003 . Text = DicStr . r344;
                break;
                case "包装材料":
                txtQUP003 . Text = DicStr . r349;
                break;
                case "夹料工资":
                txtQUP003 . Text = DicStr . r505;
                break;
            }
        }
        private void gridView1_RowClick ( object sender ,DevExpress . XtraGrid . Views . Grid . RowClickEventArgs e )
        {
            selectIdx = gridView1 . FocusedRowHandle;
            selectRow = gridView1 . GetFocusedDataRow ( );
            if ( selectRow == null )
                return;
            txtQUP002 . Text = selectRow [ "QUOA013" ] . ToString ( );
            txtQUOA012 . Text = selectRow [ "QUOA012" ] . ToString ( );
            _qup . QUR003 = txtQUP003 . Text;
            id = string . IsNullOrEmpty ( selectRow [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( selectRow [ "idx" ] );
            setValueToModel ( );
        }
        private void gridView1_CustomDrawRowFooterCell ( object sender ,DevExpress . XtraGrid . Views . Grid . FooterCellCustomDrawEventArgs e )
        {
            decimal c1 = 0M, c2 = QUO993 . SummaryItem . SummaryValue == null ? 0 : Convert . ToDecimal ( QUO993 . SummaryItem . SummaryValue );
            if ( e . Column == this . U3 )
            {
                c1 = this . gridView1 . GetRowFooterCellText ( e . RowHandle ,this . QUO993 ) == string . Empty ? 0 : Convert . ToDecimal ( this . gridView1 . GetRowFooterCellText ( e . RowHandle ,this . QUO993 ) );
                e . Info . DisplayText = ( c1 / c2 * 100 ) . ToString ( "0.##" ) + "%";
            }
        }
        #endregion

        #region Edit
        void setValueToModel ( )
        {
            if ( DicStr . r195 . Equals ( _qup . QUR003 ) )
            {
                model195 = new MulaolaoLibrary . QUOAEntity ( );
                model195 . idx = id;
            }
            else if ( DicStr . r196 . Equals ( _qup . QUR003 ) )
            {
                model196 = new MulaolaoLibrary . QUOBEntity ( );
                model196 . idx = id;
            }
            else if ( DicStr . r338 . Equals ( _qup . QUR003 ) )
            {
                model338 = new MulaolaoLibrary . QUOCEntity ( );
                model338 . idx = id;
            }
            else if ( DicStr . r341 . Equals ( _qup . QUR003 ) )
            {
                model341 = new MulaolaoLibrary . QUODEntity ( );
                model341 . idx = id;
            }
            else if ( DicStr . r342 . Equals ( _qup . QUR003 ) )
            {
                model342 = new MulaolaoLibrary . QUOEEntity ( );
                model342 . idx = id;
            }
            else if ( DicStr . r343 . Equals ( _qup . QUR003 ) )
            {
                model343 = new MulaolaoLibrary . QUOFEntity ( );
                model343 . idx = id;
            }
            else if ( DicStr . r347 . Equals ( _qup . QUR003 ) )
            {
                model347 = new MulaolaoLibrary . QUOGEntity ( );
                model347 . idx = id;
            }
            else if ( DicStr . r349 . Equals ( _qup . QUR003 ) )
            {
                model349 = new MulaolaoLibrary . QUOHEntity ( );
                model349 . idx = id;
            }
            else if ( DicStr . r339 . Equals ( _qup . QUR003 ) )
            {
                model339 = new MulaolaoLibrary . QUOIEntity ( );
                model339 . idx = id;
            }
            else if ( DicStr . r344 . Equals ( _qup . QUR003 ) )
            {
                model344 = new MulaolaoLibrary . QUOJEntity ( );
                model344 . idx = id;
            }
            else if ( DicStr . r505 . Equals ( _qup . QUR003 ) )
            {
                model505 = new MulaolaoLibrary . QUOKEntity ( );
                model505 . idx = id;
            }
            else if ( DicStr . r495 . Equals ( _qup . QUR003 ) )
            {
                model495 = new MulaolaoLibrary . QUOLEntity ( );
                model495 . idx = id;
            }
        }
        #endregion

        #region Method
        void InitData ( )
        {
            DataTable tableFor = _bll . getTableFor ( );
            txtQUO010 . Properties . DataSource = tableFor;
            txtQUO010 . Properties . DisplayMember = "DBA002";
            txtQUO010 . Properties . ValueMember = "DBA002";
        }
        void controlEnable ( )
        {
            foreach ( Control ct in layoutControl1 . Controls )
            {
                if ( ct . GetType ( ) == typeof ( TextEdit ) )
                {
                    TextEdit td = ct as TextEdit;
                    td . Enabled = true;
                }
                if ( ct . GetType ( ) == typeof ( DateEdit ) )
                {
                    DateEdit td = ct as DateEdit;
                    td . Enabled = true;
                }
                if ( ct . GetType ( ) == typeof ( SimpleButton ) )
                {
                    SimpleButton td = ct as SimpleButton;
                    td . Enabled = true;
                }
                if ( ct . GetType ( ) == typeof ( GridLookUpEdit ) )
                {
                    GridLookUpEdit gl = ct as GridLookUpEdit;
                    gl . Enabled = true;
                }
            }
            foreach ( Control ct in layoutControl2 . Controls )
            {
                if ( ct . GetType ( ) == typeof ( TextEdit ) )
                {
                    TextEdit td = ct as TextEdit;
                    td . Enabled = true;
                }
                if ( ct . GetType ( ) == typeof ( ComboBoxEdit ) )
                {
                    ComboBoxEdit td = ct as ComboBoxEdit;
                    td . Enabled = true;
                }
                if ( ct . GetType ( ) == typeof ( SimpleButton ) )
                {
                    SimpleButton td = ct as SimpleButton;
                    td . Enabled = true;
                }
            }
        }
        void controlUnEnable ( )
        {
            foreach ( Control ct in layoutControl1 . Controls )
            {
                if ( ct . GetType ( ) == typeof ( TextEdit ) )
                {
                    TextEdit td = ct as TextEdit;
                    td . Enabled = false;
                }
                if ( ct . GetType ( ) == typeof ( DateEdit ) )
                {
                    DateEdit td = ct as DateEdit;
                    td . Enabled = false;
                }
                if ( ct . GetType ( ) == typeof ( SimpleButton ) )
                {
                    SimpleButton td = ct as SimpleButton;
                    td . Enabled = false;
                }
                if ( ct . GetType ( ) == typeof ( GridLookUpEdit ) )
                {
                    GridLookUpEdit gl = ct as GridLookUpEdit;
                    gl . Enabled = false;
                }
            }
            foreach ( Control ct in layoutControl2 . Controls )
            {
                if ( ct . GetType ( ) == typeof ( TextEdit ) )
                {
                    TextEdit td = ct as TextEdit;
                    td . Enabled = false;
                }
                if ( ct . GetType ( ) == typeof ( ComboBoxEdit ) )
                {
                    ComboBoxEdit td = ct as ComboBoxEdit;
                    td . Enabled = false;
                }
                if ( ct . GetType ( ) == typeof ( SimpleButton ) )
                {
                    SimpleButton td = ct as SimpleButton;
                    td . Enabled = false;
                }

            }
        }
        void controlClear ( )
        {
            foreach ( Control ct in layoutControl1 . Controls )
            {
                if ( ct . GetType ( ) == typeof ( TextEdit ) )
                {
                    TextEdit td = ct as TextEdit;
                    td . Text = string . Empty;
                }
                if ( ct . GetType ( ) == typeof ( DateEdit ) )
                {
                    DateEdit td = ct as DateEdit;
                    td . Text = string . Empty;
                }
                if ( ct . GetType ( ) == typeof ( ImageEdit ) )
                {
                    ImageEdit td = ct as ImageEdit;
                    td . Image = null;
                }
                if ( ct . GetType ( ) == typeof ( GridLookUpEdit ) )
                {
                    GridLookUpEdit gl = ct as GridLookUpEdit;
                    gl . EditValue = null;
                }
            }
            gridControl1 . DataSource = null;
        }
        bool getValue ( )
        {
            if ( string . IsNullOrEmpty ( txtQUO002 . Text ) )
            {
                XtraMessageBox . Show ( "客户名称不可为空" );
                return false;
            }
            if ( string . IsNullOrEmpty ( txtQUO004 . Text ) )
            {
                XtraMessageBox . Show ( "产品名称不可为空" );
                return false;
            }
            if ( string . IsNullOrEmpty ( txtQUO010 . Text ) )
            {
                XtraMessageBox . Show ( "业务员不可为空" );
                return false;
            }
            int num = 0;
            if ( !string . IsNullOrEmpty ( txtQUO007 . Text ) && int . TryParse ( txtQUO007 . Text ,out num ) == false )
            {
                XtraMessageBox . Show ( "数量请输入整数" );
                return false;
            }
            _quo . QUO007 = num;
            if ( string . IsNullOrEmpty ( txtQUO008 . Text ) )
            {
                XtraMessageBox . Show ( "报价日期不可为空" );
                return false;
            }
            _quo . QUO008 = Convert . ToDateTime ( txtQUO008 . Text );

            _quo . QUO002 = txtQUO002 . Text;
            _quo . QUO003 = txtQUO003 . Text;
            _quo . QUO004 = txtQUO004 . Text;
            _quo . QUO005 = txtQUO005 . Text;
            _quo . QUO006 = txtQUO006 . Text;
            _quo . QUO010 = txtQUO010 . Text;

            return true;
        }
        void setValue ( )
        {
            txtQUO002 . Text = _quo . QUO002;
            txtQUO003 . Text = _quo . QUO003;
            txtQUO004 . Text = _quo . QUO004;
            txtQUO005 . Text = _quo . QUO005;
            txtQUO006 . Text = _quo . QUO006;
            txtQUO007 . Text = _quo . QUO007 . ToString ( );
            txtQUO008 . Text = _quo . QUO008 . ToString ( );
            pic . Image = ReadOrWriteImageOfPicutre . ReadPicture ( _quo . QUO009 );
            txtQUO010 . Text = _quo . QUO010;
        }
        #endregion

        #region Click
        //新增
        private void btnAdd_Click ( object sender ,System . EventArgs e )
        {
            conState = "add";
            if ( string . IsNullOrEmpty ( txtQUP002 . Text ) )
            {
                XtraMessageBox . Show ( "请选择合同代号和材种" );
                return;
            }
            if ( string . IsNullOrEmpty ( txtQUOA012 . Text ) )
            {
                XtraMessageBox . Show ( "请选择类别" );
                return;
            }
            _qup . QUR003 = txtQUP003 . Text;
            selectRow = tableView . NewRow ( );
            choiseCon ( );
        }
        //编辑
        private void btnEdit_Click ( object sender ,System . EventArgs e )
        {
            conState = "edit";
            choiseCon ( );
        }
        //删除
        private void btnDelete_Click ( object sender ,System . EventArgs e )
        {
            if ( selectRow == null )
                return;
            if ( XtraMessageBox . Show ( "确认删除选中内容?" ,"提示" ,MessageBoxButtons . OKCancel ) == DialogResult . OK )
            {
                _qup . idx = string . IsNullOrEmpty ( selectRow [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( selectRow [ "idx" ] . ToString ( ) );

                if ( deleteCon ( ) )
                {
                    tableView . Rows . Remove ( selectRow );
                    gridControl1 . RefreshDataSource ( );
                }
            }
        }
        //刷新表内容
        private void btnRefresh_Click ( object sender ,System . EventArgs e )
        {
            queryTable ( );
        }
        //预览图片
        private void btnPre_Click ( object sender ,EventArgs e )
        {
            _quo . QUO009 = ReadOrWriteImageOfPicutre . ReadPicture ( pic );
        }
        //删除图片
        private void btnRemove_Click ( object sender ,EventArgs e )
        {
            pic . Image = null;
            _quo . QUO009 = new byte [ 0 ];
        }
        #endregion

        #region Read
        void choiseCon ( )
        {
            if ( DicStr . r195 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model195 = new MulaolaoLibrary . QUOAEntity ( );
                read195 ( );
            }
            else if ( DicStr . r196 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model196 = new MulaolaoLibrary . QUOBEntity ( );
                read196 ( );
            }
            else if ( DicStr . r338 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model338 = new MulaolaoLibrary . QUOCEntity ( );
                read338 ( );
            }
            else if ( DicStr . r341 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model341 = new MulaolaoLibrary . QUODEntity ( );
                read341 ( );
            }
            else if ( DicStr . r342 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model342 = new MulaolaoLibrary . QUOEEntity ( );
                read342 ( );
            }
            else if ( DicStr . r343 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model343 = new MulaolaoLibrary . QUOFEntity ( );
                read343 ( );
            }
            else if ( DicStr . r347 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model347 = new MulaolaoLibrary . QUOGEntity ( );
                read347 ( );
            }
            else if ( DicStr . r349 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model349 = new MulaolaoLibrary . QUOHEntity ( );
                read349 ( );
            }
            else if ( DicStr . r339 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model339 = new MulaolaoLibrary . QUOIEntity ( );
                read339 ( );
            }
            else if ( DicStr . r344 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model344 = new MulaolaoLibrary . QUOJEntity ( );
                read344 ( );
            }
            else if ( DicStr . r505 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model505 = new MulaolaoLibrary . QUOKEntity ( );
                read505 ( );
            }
            else if ( DicStr . r495 . Equals ( _qup . QUR003 ) )
            {
                if ( "add" . Equals ( conState ) )
                    model495 = new MulaolaoLibrary . QUOLEntity ( );
                read495 ( );
            }
            gridControl1 . RefreshDataSource ( );
        }
        void read195 ( )
        {
            model195 . QUOA010 = _quo . QUO001;
            model195 . QUOA011 = txtQUP003 . Text;
            model195 . QUOA012 = txtQUOA012 . Text;
            model195 . QUOA013 = txtQUP002 . Text;
            model195 . QUOA014 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );

            form = new r195 ( model195 ,txtQUO006 . Text );
            formResult ( );
        }
        void read196 ( )
        {
            model196 . QUOB001 = _quo . QUO001;
            model196 . QUOB002 = txtQUP003 . Text;
            model196 . QUOB003 = txtQUP002 . Text;
            model196 . QUOB004 = txtQUOA012 . Text;
            model196 . QUOB017 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r196 ( model196 ,txtQUO006 . Text );
            formResult ( );
        }
        void read338 ( )
        {
            model338 . QUOC001 = _quo . QUO001;
            model338 . QUOC002 = txtQUOA012 . Text;
            model338 . QUOC003 = txtQUP003 . Text;
            model338 . QUOC004 = txtQUP002 . Text;
            model338 . QUOC005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r338 ( model338 ,txtQUO006 . Text );
            formResult ( );
        }
        void read341 ( )
        {
            model341 . QUOD001 = _quo . QUO001;
            model341 . QUOD002 = txtQUOA012 . Text;
            model341 . QUOD003 = txtQUP003 . Text;
            model341 . QUOD004 = txtQUP002 . Text;
            model341 . QUOD020 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r341 ( model341 ,txtQUO006 . Text );
            formResult ( );
        }
        void read342 ( )
        {
            model342 . QUOE001 = _quo . QUO001;
            model342 . QUOE002 = txtQUOA012 . Text;
            model342 . QUOE003 = txtQUP003 . Text;
            model342 . QUOE004 = txtQUP002 . Text;
            model342 . QUOE005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r342 ( model342 ,txtQUO006 . Text );
            formResult ( );
        }
        void read343 ( )
        {
            model343 . QUOF001 = _quo . QUO001;
            model343 . QUOF002 = txtQUOA012 . Text;
            model343 . QUOF003 = txtQUP003 . Text;
            model343 . QUOF004 = txtQUP002 . Text;
            model343 . QUOF005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r343 ( model343 ,txtQUO006 . Text );
            formResult ( );
        }
        void read347 ( )
        {
            model347 . QUOG001 = _quo . QUO001;
            model347 . QUOG002 = txtQUOA012 . Text;
            model347 . QUOG003 = txtQUP003 . Text;
            model347 . QUOG004 = txtQUP002 . Text;
            model347 . QUOG005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r347 ( model347 ,txtQUO006 . Text );
            formResult ( );
        }
        void read349 ( )
        {
            model349 . QUOH001 = _quo . QUO001;
            model349 . QUOH002 = txtQUOA012 . Text;
            model349 . QUOH003 = txtQUP003 . Text;
            model349 . QUOH004 = txtQUP002 . Text;
            model349 . QUOH005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r349 ( model349 ,txtQUO006 . Text );
            formResult ( );
        }
        void read339 ( )
        {
            model339 . QUOI001 = _quo . QUO001;
            model339 . QUOI002 = txtQUOA012 . Text;
            model339 . QUOI003 = txtQUP003 . Text;
            model339 . QUOI004 = txtQUP002 . Text;
            model339 . QUOI005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r339 ( model339 ,txtQUO006 . Text );
            formResult ( );
        }
        void read344 ( )
        {
            model344 . QUOJ001 = _quo . QUO001;
            model344 . QUOJ002 = txtQUOA012 . Text;
            model344 . QUOJ003 = txtQUP003 . Text;
            model344 . QUOJ004 = txtQUP002 . Text;
            model344 . QUOJ005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r344 ( model344 ,txtQUO006 . Text );
            formResult ( );
        }
        void read505 ( )
        {
            model505 . QUOK001 = _quo . QUO001;
            model505 . QUOK002 = txtQUOA012 . Text;
            model505 . QUOK003 = txtQUP003 . Text;
            model505 . QUOK004 = txtQUP002 . Text;
            model505 . QUOK005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r505 ( model505 ,txtQUO006 . Text );
            formResult ( );
        }
        void read495 ( )
        {
            model495 . QUOL001 = _quo . QUO001;
            model495 . QUOL002 = txtQUOA012 . Text;
            model495 . QUOL003 = txtQUP003 . Text;
            model495 . QUOL004 = txtQUP002 . Text;
            model495 . QUOL005 = string . IsNullOrEmpty ( txtQUO007 . Text ) == true ? 0 : Convert . ToInt32 ( txtQUO007 . Text );
            form = new r495 ( model495 ,txtQUO006 . Text );
            formResult ( );
        }
        void formResult ( )
        {
            if ( form . ShowDialog ( ) == DialogResult . OK )
            {
                XtraMessageBox . Show ( "保存成功" );
                queryTable ( );
            }
        }
        void queryTable ( )
        {
            tableView = _bll . getTableView ( _quo . QUO001 );
            gridControl1 . DataSource = tableView;
        }
        bool deleteCon ( )
        {
            if ( DicStr . r195 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete195 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r196 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete196 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r338 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete338 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r341 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete341 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r342 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete342 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r343 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete343 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r347 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete347 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r349 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete349 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r339 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete339 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r344 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete344 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r505 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete505 ( _qup . idx );
                titelResult ( );
            }
            else if ( DicStr . r495 . Equals ( _qup . QUR003 ) )
            {
                result = _bll . Delete495 ( _qup . idx );
                titelResult ( );
            }

            return result;
        }
        void titelResult ( )
        {
            if ( result )
                XtraMessageBox . Show ( "成功删除" );
            else
                XtraMessageBox . Show ( "删除失败" );
        }
        #endregion

    }
}




