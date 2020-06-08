using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_gallery
{
    public partial class PurchaseForm : Form
    {
        List<int> nonPicId = new List<int>();
        List<int> purchId = new List<int>();
        List<int> allPicId = new List<int>();
        private PurchaseManager PurchaseManager = new PurchaseManager();
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            this.покупательTableAdapter.Fill(this.picture_galleryDataSet.Покупатель);
            this.сотрудникTableAdapter.Fill(this.picture_galleryDataSet.Сотрудник);
            this.purchased_paintingsTableAdapter.Fill(this.picture_galleryDataSet.purchased_paintings);
            fillPictureComboBox(addPicture);
            addPicture.SelectedIndex = 0;
            PictureManager pictureManager = new PictureManager();
            allPicId.Clear();
            updPictures.Items.Clear();
            foreach (var row in pictureManager.getAll())
            {
                allPicId.Add(int.Parse(row[0]));
                updPictures.Items.Add(row[1]);
            }
        }
        private void fillPictureComboBox(ComboBox box) 
        {
            nonPicId.Clear();
            box.Items.Clear();
            foreach (var row in PurchaseManager.getNonPurchasePictures())
            {
                nonPicId.Add(int.Parse(row[0]));
                box.Items.Add(row[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = addDate.Value.Date;
            var employee = addEmployee.SelectedIndex + 1;
            var buyer = addBuyer.SelectedIndex + 1;
            var pic = nonPicId[addPicture.SelectedIndex];
            PurchaseManager.Add(date, employee,buyer, pic);
        }
        private void fillList(ListBox list) 
        {
            purchId.Clear();
            list.Items.Clear();
            foreach (var row in PurchaseManager.getPurchases())
            {
                purchId.Add(int.Parse(row[0]));
                list.Items.Add(row[1]);
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updGroup.Enabled = false;
            if (e.TabPageIndex == 1) 
            {
                this.purchased_paintingsTableAdapter.Fill(this.picture_galleryDataSet.purchased_paintings);
            }
            if (e.TabPageIndex == 2) 
            {
                fillList(delList);
            }
            if (e.TabPageIndex == 3) 
            {
                fillList(updList);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (delList.SelectedIndex == -1)
            {
                MessageBox.Show("Укажите удаляемую покупку");
            }
            else 
            {
                PurchaseManager.Delete(purchId[delList.SelectedIndex]);
                fillList(delList);
            }
        }

        private void updList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updList.SelectedIndex != -1) 
            {
                updGroup.Enabled = true;
                var row = PurchaseManager.getById(purchId[updList.SelectedIndex]);
                updDate.Value = (DateTime)row[0];
                updEmployee.SelectedIndex = (int)row[1] - 1;
                updBuyer.SelectedIndex = (int)row[2] - 1;
                updPictures.SelectedIndex = allPicId.IndexOf((int)row[3]);
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if ((updList.SelectedIndex == -1) || (updEmployee.SelectedIndex == -1) || (updBuyer.SelectedIndex == -1)|| (updPictures.SelectedIndex == -1))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            var id = purchId[updList.SelectedIndex];
            var date = updDate.Value;
            var employee = updEmployee.SelectedIndex+1;
            var buyer = updBuyer.SelectedIndex + 1;
            var pic = allPicId[updPictures.SelectedIndex];
            PurchaseManager.Update(id,date,employee,buyer,pic);
            fillList(updList);
        }
    }
}
