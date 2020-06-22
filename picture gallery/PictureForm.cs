using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace picture_gallery
{
    public partial class PictureForm : Form
    {
        private List<int> exposId = new List<int>();
        private List<int> picId = new List<int>();
        private PictureManager PictureManager = new PictureManager();
        public PictureForm()
        {
            InitializeComponent();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            this.picturesTableAdapter.Fill(this.picture_galleryDataSet.Pictures);
            fillElements();
        }
        private void fillElements()
        {
            this.employeeTableAdapter.Fill(this.picture_galleryDataSet.Сотрудник);
            this.GenreTableAdapter.Fill(this.picture_galleryDataSet.Жанр);
            addDirect.Items.Add("Без направления");
            updDir.Items.Add("Без направления");
            updExpos.Items.Add("Нет выставки");
            addDirect.SelectedIndex = 0;
            updDir.SelectedIndex = 0;
            foreach (var row in PictureManager.getDirections())
            {
                addDirect.Items.Add(row);
                updDir.Items.Add(row);
            }
            foreach (var row in PictureManager.getExpos())
            {
                addExpos.Items.Add(row[1]);
                updExpos.Items.Add(row[1]);
                exposId.Add(int.Parse(row[0]));
            }
            addExpos.SelectedIndex = 0;
            updExpos.SelectedIndex = 0;
            this.autorTableAdapter.Fill(this.picture_galleryDataSet.Автор);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String picName = addPicName.Text.Trim();
            if ((picName == "")||(addAutor.SelectedIndex==-1)||(addDirect.SelectedIndex==-1)||(addEmployee.SelectedIndex==-1)||(addGenre.SelectedIndex==-1))
            {
                MessageBox.Show("Пожалуйста, заполните данные");
                return;
            }
            decimal money = addMoney.Value;
            int autor = addAutor.SelectedIndex + 1;
            int direct = addDirect.SelectedIndex;
            int genre = addGenre.SelectedIndex + 1;
            int expos = exposId[addExpos.SelectedIndex];
            int employee = addEmployee.SelectedIndex + 1;
            PictureManager.Add(picName, money, autor, direct, genre, expos, employee);
        }

        private void pictureTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updateGroup.Enabled = false;
            if (e.TabPageIndex == 0)
            {
                this.picturesTableAdapter.Fill(this.picture_galleryDataSet.Pictures);
            }
            if (e.TabPageIndex == 2)
            {
                fillListBox(updListBox);
            }
            if (e.TabPageIndex == 3)
            {
                fillListBox(delList);
            }
        }
        private void fillListBox(ListBox list)
        {
            list.Items.Clear();
            picId.Clear();
            foreach (var row in PictureManager.getAll())
            {
                picId.Add(int.Parse(row[0]));
                list.Items.Add(row[1]);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (delList.SelectedIndex == -1) 
            {
                MessageBox.Show("Пожалуйста, выберите картину");
                return;
            }
            PictureManager.Delete(picId[delList.SelectedIndex]);
            fillListBox(delList);
        }

        private void updListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updListBox.SelectedIndex != -1)
            {
                updateGroup.Enabled = true;
                var row = PictureManager.getById(picId[updListBox.SelectedIndex]);
                updName.Text = row[0].ToString();
                updPrice.Value = (decimal)row[1];
                updAutor.SelectedIndex = (int)row[2] - 1;
                if (row[3] == DBNull.Value)
                {
                    updDir.SelectedIndex = 0;
                }
                else
                {
                    updDir.SelectedIndex = (int)row[3];
                }
                updGenre.SelectedIndex = (int)row[4]-1;
                if (row[5] == DBNull.Value)
                {
                    updExpos.SelectedIndex = 0;
                }
                else
                {
                    updExpos.SelectedIndex = (int)row[5];
                }
                updEmployee.SelectedIndex = (int)row[6]-1;
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if ((updAutor.SelectedIndex == -1) || (updDir.SelectedIndex == -1) || (updEmployee.SelectedIndex == -1) || (updExpos.SelectedIndex == -1) || (updGenre.SelectedIndex == -1)) 
            {
                MessageBox.Show("Пожалуйста заполните данные");
                return;
            }
            var name = updName.Text;
            var price = updPrice.Value;
            var autor = updAutor.SelectedIndex+1;
            var dir = updDir.SelectedIndex;
            var genre = updGenre.SelectedIndex+1;
            var expos = updExpos.SelectedIndex;
            var employee = updEmployee.SelectedIndex+1;
            PictureManager.Update(picId[updListBox.SelectedIndex],name,price,autor,dir,genre,expos,employee);
            fillListBox(updListBox);
            updateGroup.Enabled = false;
        }
    }
}
