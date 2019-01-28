namespace Mulaolao . QuoForms
{
    partial class Form343Query
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GS07 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS08 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GS09 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(736, 262);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GS07,
            this.GS08,
            this.GS10,
            this.GS09});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // GS07
            // 
            this.GS07.Caption = "零件名称";
            this.GS07.FieldName = "GS07";
            this.GS07.Name = "GS07";
            this.GS07.Visible = true;
            this.GS07.VisibleIndex = 0;
            // 
            // GS08
            // 
            this.GS08.Caption = "规格";
            this.GS08.FieldName = "GS08";
            this.GS08.Name = "GS08";
            this.GS08.Visible = true;
            this.GS08.VisibleIndex = 1;
            // 
            // GS10
            // 
            this.GS10.Caption = "每套数量";
            this.GS10.FieldName = "GS10";
            this.GS10.Name = "GS10";
            this.GS10.Visible = true;
            this.GS10.VisibleIndex = 2;
            // 
            // GS09
            // 
            this.GS09.Caption = "单位";
            this.GS09.FieldName = "GS09";
            this.GS09.Name = "GS09";
            this.GS09.Visible = true;
            this.GS09.VisibleIndex = 3;
            // 
            // Form343Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 262);
            this.Controls.Add(this.gridControl2);
            this.Name = "Form343Query";
            this.Text = "R_509查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress . XtraGrid . GridControl gridControl2;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraGrid . Columns . GridColumn GS07;
        private DevExpress . XtraGrid . Columns . GridColumn GS08;
        private DevExpress . XtraGrid . Columns . GridColumn GS10;
        private DevExpress . XtraGrid . Columns . GridColumn GS09;
    }
}