using Erpv1.EntityFramework;
using Erpv1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erpv1.Pazarlama
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }


        erpEntities db = new erpEntities();
        Repository<Siparis> repo = new Repository<Siparis>();
        Siparis t = new Siparis();

        public void listele()
        {
            txtKayitNo.Text = t.ID.ToString();
            txtSipNo.Text = t.SIP_NO;

            
        }

        public void sipdaglistele()
        {
            int kayitno = int.Parse(txtKayitNo.Text);

            db.SipDag.Load();
            SipDagBindingSource.DataSource = db.SipDag.Local.Where(x => x.REF_NO == kayitno);


        }
        public void sonid()
        {
            int intIdt = db.Siparis.Max(u => u.ID);
            var deger = repo.Find(x => x.ID == intIdt);
            txtKayitNo.Text = deger.ID.ToString();
            txtSipNo.Text = deger.SIP_NO;
            txtFirmaAdi.Text = deger.FIRMA_ADI;
            txtIlgili.Text = deger.ILGILI;
            txtAdres.Text = deger.ADRES;
            txtUlke.Text = deger.ULKE;
            MemoAciklama.Text = deger.ACIKLAMA;
        }

        private void btnMusteriAdi_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Tanimlamalar.MusterlListesi fr = new Tanimlamalar.MusterlListesi();
            fr.gridView1.OptionsBehavior.Editable = false;
            fr.Show(this);
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            int intIdt = db.Siparis.Max(u => u.ID);
            if (intIdt != 0)
            {
                sonid();
                sipdaglistele();

            }
          

        }

      

        private void btnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            t.SIP_NO = txtSipNo.Text;
            t.FIRMA_ADI = txtFirmaAdi.Text;
            t.ILGILI = txtIlgili.Text;
            t.ADRES = txtAdres.Text;
            t.ULKE = txtUlke.Text;
            t.ACIKLAMA = MemoAciklama.Text;
            if (txtKayitNo.Text=="")
                {
                    DialogResult cevap;
         
                    cevap = MessageBox.Show("Kayıt Etmek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                    if (cevap == DialogResult.Yes)
                        {
                        repo.TAdd(t);
                        MessageBox.Show("Kayıt Başarılı");
                        listele();
                        sipdaglistele();
                }
                
                }
            else
            {
                int kayitid = int.Parse(txtKayitNo.Text);
                var s = repo.Find(x => x.ID == kayitid);
                s.SIP_NO = txtSipNo.Text;
                s.FIRMA_ADI = txtFirmaAdi.Text;
                s.ILGILI = txtIlgili.Text;
                s.ADRES = txtAdres.Text;
                s.ULKE = txtUlke.Text;
                s.ACIKLAMA = MemoAciklama.Text;
                DialogResult cevap;
              
                cevap = MessageBox.Show("Güncellemek istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                if (cevap == DialogResult.Yes)
                {
                    repo.TUpdate(s);
                    MessageBox.Show("Güncelleme Başarılı");
                    txtSipNo.Text = s.SIP_NO;
                    txtKayitNo.Text = s.ID.ToString();
                    sipdaglistele();
                }
            }

        }

        private void btnVazgec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            sonid();
            sipdaglistele();

        }

        private void btngeri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnilk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int intIdt = db.Siparis.Min(u => u.ID);
            var deger = repo.Find(x => x.ID == intIdt);
            txtKayitNo.Text = deger.ID.ToString();
            txtSipNo.Text = deger.SIP_NO;
            txtFirmaAdi.Text = deger.FIRMA_ADI;
            txtIlgili.Text = deger.ILGILI;
            txtAdres.Text = deger.ADRES;
            txtUlke.Text = deger.ULKE;
            MemoAciklama.Text = deger.ACIKLAMA;
            sipdaglistele();
        }

        private void btnyeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtKayitNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SipListele fr = new SipListele();
            fr.ShowDialog();
        }

        private void btnileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ilkid = int.Parse(txtKayitNo.Text);
           var deger = repo.Find(x => x.ID == 2);

            txtKayitNo.Text = deger.ID.ToString();
            txtSipNo.Text = deger.SIP_NO;
            txtFirmaAdi.Text = deger.FIRMA_ADI;
            txtIlgili.Text = deger.ILGILI;
            txtAdres.Text = deger.ADRES;
            txtUlke.Text = deger.ULKE;
            MemoAciklama.Text = deger.ACIKLAMA;
            sipdaglistele();


        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
