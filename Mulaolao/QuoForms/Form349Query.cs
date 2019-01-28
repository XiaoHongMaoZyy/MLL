using System;
using System . Data;
using System . Windows . Forms;
using Mulaolao . Class;

namespace Mulaolao . QuoForms
{
    public partial class Form349Query :DevExpress . XtraEditors . XtraForm
    {
        public Form349Query ( DataTable table)
        {
            InitializeComponent ( );

            GridViewMoHuSelect . SetFilter ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 } );
            GrivColumnStyle . setColumnStyle ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 } );

            gridControl1 . DataSource = table;
        }

        DataRow row;

        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            row = gridView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;
            this . DialogResult = DialogResult . OK;
        }

        public DataRow getRow
        {
            get
            {
                return row;
            }
        }

    }
}