
namespace Erpv1.Pazarlama
{
    partial class SipListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SiparisListeleGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.SiparisListeleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SiparisListeleGrid
            // 
            this.SiparisListeleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiparisListeleGrid.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.SiparisListeleGrid.Location = new System.Drawing.Point(0, 0);
            this.SiparisListeleGrid.MainView = this.gridView1;
            this.SiparisListeleGrid.Name = "SiparisListeleGrid";
            this.SiparisListeleGrid.Size = new System.Drawing.Size(981, 511);
            this.SiparisListeleGrid.TabIndex = 0;
            this.SiparisListeleGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.SiparisListeleGrid;
            this.gridView1.Name = "gridView1";
            // 
            // SipListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 511);
            this.Controls.Add(this.SiparisListeleGrid);
            this.Name = "SipListele";
            this.Text = "SipListele";
            this.Load += new System.EventHandler(this.SipListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SiparisListeleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl SiparisListeleGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}