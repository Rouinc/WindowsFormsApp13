using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Formdata : System.Windows.Forms.Form
    {
        public Formdata()
        {
            InitializeComponent();
        }
        public DataTable dt = new DataTable();

        private void buttonlihatdata_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Nama");
            dt.Rows.Add("Alamat");
            dt.Rows.Add("No. telpon");
            dt.Columns.Add(textboxnama.Text);
            dt.Columns.Add(textboxalamat.Text);
            dt.Columns.Add(textboxtelpon.Text);
        }
    }
}
