using Erpv1.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erpv1.Pazarlama
{
    public partial class SipListele : Form
    {
        public SipListele()
        {
            InitializeComponent();
        }

        erpEntities db = new erpEntities();
        private void SipListele_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            SiparisListeleGrid.DataSource = (from x in db.Siparis
                                             select new
                                             {
                                                 x.ID,x.TARIH,
                                               SiparisNo =   x.SIP_NO,
                                                 x.FIRMA_ADI,
                                                 x.ULKE
                                             }).ToList();
        }
    }
}
