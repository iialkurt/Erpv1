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
    public partial class Numarator : Form
    {
        public Numarator()
        {
            InitializeComponent();
        }

        erpEntities db = new erpEntities();
        private void Numarator_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.numarator select new { x.SipBaslangic, x.SipSon }).ToList();
        }
    }
}
