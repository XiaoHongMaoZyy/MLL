using Mulaolao . Class;
using System;
using System . Data;
using System . Windows . Forms;

namespace Mulaolao . Contract
{
    public partial class R_FrmPQJ : Form
    {
        public R_FrmPQJ( DataTable table )
        {
            InitializeComponent( );
            GridViewMoHuSelect . SetFilter ( gridView1 );
            GrivColumnStyle . setColumnStyle ( new DevExpress . XtraGrid . Views . Grid . GridView [ ] { gridView1 } );

            gridControl1 . DataSource = table;
        }

        DataRow row;

        private void gridView1_DoubleClick( object sender, EventArgs e )
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
