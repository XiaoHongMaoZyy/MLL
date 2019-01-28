namespace Mulaolao . QuoForms
{
    partial class Form195Query
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CP06 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CP07 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CP08 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CP13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CP64 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(661, 344);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CP06,
            this.CP07,
            this.CP08,
            this.CP13,
            this.CP64});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // CP06
            // 
            this.CP06.Caption = "零件名称";
            this.CP06.FieldName = "CP06";
            this.CP06.Name = "CP06";
            this.CP06.Visible = true;
            this.CP06.VisibleIndex = 0;
            // 
            // CP07
            // 
            this.CP07.Caption = "规格";
            this.CP07.FieldName = "CP07";
            this.CP07.Name = "CP07";
            this.CP07.Visible = true;
            this.CP07.VisibleIndex = 1;
            // 
            // CP08
            // 
            this.CP08.Caption = "单位";
            this.CP08.FieldName = "CP08";
            this.CP08.Name = "CP08";
            this.CP08.Visible = true;
            this.CP08.VisibleIndex = 2;
            // 
            // CP13
            // 
            this.CP13.Caption = "每套数量";
            this.CP13.FieldName = "CP13";
            this.CP13.Name = "CP13";
            this.CP13.Visible = true;
            this.CP13.VisibleIndex = 3;
            // 
            // CP64
            // 
            this.CP64.Caption = "工段";
            this.CP64.FieldName = "CP64";
            this.CP64.Name = "CP64";
            // 
            // Form195Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 344);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form195Query";
            this.Text = "R_509查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn CP06;
        private DevExpress . XtraGrid . Columns . GridColumn CP07;
        private DevExpress . XtraGrid . Columns . GridColumn CP08;
        private DevExpress . XtraGrid . Columns . GridColumn CP13;
        private DevExpress . XtraGrid . Columns . GridColumn CP64;
    }
}