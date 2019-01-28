namespace Mulaolao . QuoForms
{
    partial class Form344Query
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
            this.GS02 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS07 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS08 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS78 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(632, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GS02,
            this.GS07,
            this.GS08,
            this.GS78});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // GS02
            // 
            this.GS02.Caption = "部件";
            this.GS02.FieldName = "GS02";
            this.GS02.Name = "GS02";
            this.GS02.Visible = true;
            this.GS02.VisibleIndex = 0;
            // 
            // GS07
            // 
            this.GS07.Caption = "零件";
            this.GS07.FieldName = "GS07";
            this.GS07.Name = "GS07";
            this.GS07.Visible = true;
            this.GS07.VisibleIndex = 1;
            // 
            // GS08
            // 
            this.GS08.Caption = "规格";
            this.GS08.FieldName = "GS08";
            this.GS08.Name = "GS08";
            this.GS08.Visible = true;
            this.GS08.VisibleIndex = 2;
            // 
            // GS78
            // 
            this.GS78.Caption = "重量/套";
            this.GS78.FieldName = "GS78";
            this.GS78.Name = "GS78";
            this.GS78.Visible = true;
            this.GS78.VisibleIndex = 3;
            // 
            // Form344Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 262);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form344Query";
            this.Text = "R_509数据查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn GS02;
        private DevExpress . XtraGrid . Columns . GridColumn GS07;
        private DevExpress . XtraGrid . Columns . GridColumn GS08;
        private DevExpress . XtraGrid . Columns . GridColumn GS78;
    }
}