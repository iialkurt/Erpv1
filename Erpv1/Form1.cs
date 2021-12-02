using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erpv1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSiparis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pazarlama.frmSiparis fr = new Pazarlama.frmSiparis();
            fr.Show();
        }

        private void brnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tanimlamalar.Musteriler fr = new Tanimlamalar.Musteriler();
            fr.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
