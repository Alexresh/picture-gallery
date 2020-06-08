using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace picture_gallery
{
    public partial class ExposForm : Form
    {
        private List<string[]> currentRows;
        readonly ExposManager exposManager = new ExposManager();
        public ExposForm()
        {
            InitializeComponent();
        }

        private void ExposForm_Load(object sender, EventArgs e)
        {
            this.exposViewTableAdapter.Fill(this.picture_galleryDataSet.exposView);
        }

        private void ExposTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updateGroupBox.Enabled = false;
            if (e.TabPageIndex == 0)
            {
                this.exposViewTableAdapter.Fill(this.picture_galleryDataSet.exposView);
            }
            else
            if (e.TabPageIndex == 1)
            {
                addDirComboBox.Items.Clear();
                addDirComboBox.Items.Add("Без направления");
                foreach (var row in exposManager.GetDir())
                {
                    addDirComboBox.Items.Add(row);
                }
                addDirComboBox.SelectedIndex = 0;
            }
            else
            if (e.TabPageIndex == 2) 
            {
                fillListBox(updateListBox);
            }else
            if (e.TabPageIndex == 3)
            {
                fillListBox(delListBox);
            }
        }
        private void fillListBox(ListBox list) 
        {
            list.Items.Clear();
            currentRows = exposManager.GetAll();
            foreach (var row in currentRows)
            {
                list.Items.Add(row[1]);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addDirComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите направление", "Информация", MessageBoxButtons.OK);
            }
            else
            {
                exposManager.Add(addDate.Value.Date, addDirComboBox.SelectedIndex, decimal.ToInt32(addMaxPicNumber.Value));
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста укажите какую-нибудь выставку");
            }
            else 
            {
                exposManager.Delete(int.Parse(currentRows[delListBox.SelectedIndex][0]));
                fillListBox(delListBox);
            }
        }

        private void updateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateListBox.SelectedIndex != -1) 
            {
                updateDirComboBox.Items.Clear();
                updateDirComboBox.Items.Add("Без направления");
                foreach (var row in exposManager.GetDir())
                {
                    updateDirComboBox.Items.Add(row);
                }
                object[] rowData = exposManager.getById(int.Parse(currentRows[updateListBox.SelectedIndex][0]));
                updateDatePicker.Value = (DateTime)rowData[0];
                if (rowData[1] == null)
                {
                    updateDirComboBox.SelectedIndex = 0;
                }
                else 
                {
                    updateDirComboBox.SelectedIndex = (int)rowData[1];
                }
                updateMaxPic.Value = (int)rowData[2];
                updateGroupBox.Enabled = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updateDirComboBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Пожалуйста укажите какое-нибудь направление");
                return;
            }
            int id = int.Parse(currentRows[updateListBox.SelectedIndex][0]);
            DateTime date = updateDatePicker.Value;
            int dir = updateDirComboBox.SelectedIndex;
            int maxPic = (int)updateMaxPic.Value;
            exposManager.Update(id,date,dir,maxPic);
            fillListBox(updateListBox);
            updateGroupBox.Enabled = false;
        }
    }
}
