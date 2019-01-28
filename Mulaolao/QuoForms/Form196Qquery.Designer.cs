namespace Mulaolao . QuoForms
{
    partial class Form196Qquery
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
            this.AH10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AH11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AH21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AH13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AH119 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(698, 334);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AH10,
            this.AH11,
            this.AH21,
            this.AH13,
            this.AH119});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // AH10
            // 
            this.AH10.Caption = "零件名称";
            this.AH10.FieldName = "AH10";
            this.AH10.Name = "AH10";
            this.AH10.Visible = true;
            this.AH10.VisibleIndex = 0;
            // 
            // AH11
            // 
            this.AH11.Caption = "规格";
            this.AH11.FieldName = "AH11";
            this.AH11.Name = "AH11";
            this.AH11.Visible = true;
            this.AH11.VisibleIndex = 1;
            // 
            // AH21
            // 
            this.AH21.Caption = "计件单位";
            this.AH21.FieldName = "AH21";
            this.AH21.Name = "AH21";
            this.AH21.Visible = true;
            this.AH21.VisibleIndex = 2;
            // 
            // AH13
            // 
            this.AH13.Caption = "每套零件数量";
            this.AH13.FieldName = "AH13";
            this.AH13.Name = "AH13";
            this.AH13.Visible = true;
            this.AH13.VisibleIndex = 3;
            // 
            // AH119
            // 
            this.AH119.Caption = "工段";
            this.AH119.FieldName = "AH119";
            this.AH119.Name = "AH119";
            this.AH119.Visible = true;
            this.AH119.VisibleIndex = 4;
            // 
            // Form196Qquery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 334);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form196Qquery";
            this.Text = "R_509查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn AH10;
        private DevExpress . XtraGrid . Columns . GridColumn AH11;
        private DevExpress . XtraGrid . Columns . GridColumn AH21;
        private DevExpress . XtraGrid . Columns . GridColumn AH13;
        private DevExpress . XtraGrid . Columns . GridColumn AH119;
    }
}