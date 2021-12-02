using Erpv1.EntityFramework;
using Erpv1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erpv1.Tanimlamalar
{
    public partial class MusterlListesi : Form
    {
        public MusterlListesi()
        {
            InitializeComponent();
        }
        erpEntities db = new erpEntities();
        cari ms = new cari();
        public int id;
        Repository<cari> repo = new Repository<cari>();
        private void MusterlListesi_Load(object sender, EventArgs e)
        {
           bindingSource1.DataSource = (from x in db.cari select new {x.id, x.Firma_Adi, x.Yetkili_Ad_Soyad }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            Pazarlama.frmSiparis fr = (Pazarlama.frmSiparis)this.Owner;
            //fr.btnMusteriAdi.Text = gridView1.GetFocusedRowCellValue("Firma_Adi").ToString();
            //fr.txtyetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili_Ad_Soyad").ToString();
            id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());

            var cari = repo.Find(y => y.id == id);
            fr.txtTelefon.Text = cari.Telefon;
            fr.txtFirmaAdi.Text = cari.Firma_Adi;
            fr.txtIlgili.Text = cari.Yetkili_Ad_Soyad;
            fr.txtAdres.Text = cari.Adres;
            fr.txtUlke.Text = cari.Ulke;
            
            this.Close();
        }
    }
}
