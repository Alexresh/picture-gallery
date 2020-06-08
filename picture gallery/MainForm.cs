using System;
using System.Windows.Forms;

namespace picture_gallery
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnShowExposForm_Click(object sender, EventArgs e)
        {
            ExposForm exposForm = new ExposForm();
            exposForm.ShowDialog();
        }

        private void btnShowPictureForm_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm();
            pictureForm.ShowDialog();
        }

        private void btnShowPurchasesForm_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }
    }
}
