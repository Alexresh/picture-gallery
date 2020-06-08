namespace picture_gallery
{
    partial class PictureForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picture_galleryDataSet = new picture_gallery.picture_galleryDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addExpos = new System.Windows.Forms.ComboBox();
            this.addGenre = new System.Windows.Forms.ComboBox();
            this.жанрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDirect = new System.Windows.Forms.ComboBox();
            this.addAutor = new System.Windows.Forms.ComboBox();
            this.авторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMoney = new System.Windows.Forms.NumericUpDown();
            this.addPicName = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.delList = new System.Windows.Forms.ListBox();
            this.picturesTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.PicturesTableAdapter();
            this.авторTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.АвторTableAdapter();
            this.tableAdapterManager = new picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager();
            this.жанрTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.ЖанрTableAdapter();
            this.сотрудникTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.СотрудникTableAdapter();
            this.updListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.updEmployee = new System.Windows.Forms.ComboBox();
            this.updExpos = new System.Windows.Forms.ComboBox();
            this.updGenre = new System.Windows.Forms.ComboBox();
            this.updDir = new System.Windows.Forms.ComboBox();
            this.updAutor = new System.Windows.Forms.ComboBox();
            this.updPrice = new System.Windows.Forms.NumericUpDown();
            this.updName = new System.Windows.Forms.TextBox();
            this.updateGroup = new System.Windows.Forms.GroupBox();
            this.updBtn = new System.Windows.Forms.Button();
            this.pictureTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMoney)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).BeginInit();
            this.updateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureTabs
            // 
            this.pictureTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTabs.Controls.Add(this.tabPage1);
            this.pictureTabs.Controls.Add(this.tabPage2);
            this.pictureTabs.Controls.Add(this.tabPage3);
            this.pictureTabs.Controls.Add(this.tabPage4);
            this.pictureTabs.Location = new System.Drawing.Point(12, 12);
            this.pictureTabs.Name = "pictureTabs";
            this.pictureTabs.SelectedIndex = 0;
            this.pictureTabs.Size = new System.Drawing.Size(746, 324);
            this.pictureTabs.TabIndex = 0;
            this.pictureTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.pictureTabs_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.направлениеDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.датаВыставкиDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.picturesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(726, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            this.направлениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыставкиDataGridViewTextBoxColumn
            // 
            this.датаВыставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата выставки";
            this.датаВыставкиDataGridViewTextBoxColumn.HeaderText = "Дата выставки";
            this.датаВыставкиDataGridViewTextBoxColumn.Name = "датаВыставкиDataGridViewTextBoxColumn";
            this.датаВыставкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "Pictures";
            this.picturesBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // picture_galleryDataSet
            // 
            this.picture_galleryDataSet.DataSetName = "picture_galleryDataSet";
            this.picture_galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.addEmployee);
            this.tabPage2.Controls.Add(this.addExpos);
            this.tabPage2.Controls.Add(this.addGenre);
            this.tabPage2.Controls.Add(this.addDirect);
            this.tabPage2.Controls.Add(this.addAutor);
            this.tabPage2.Controls.Add(this.addMoney);
            this.tabPage2.Controls.Add(this.addPicName);
            this.tabPage2.Controls.Add(this.addBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сотрудник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Направление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // addEmployee
            // 
            this.addEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "ФИО", true));
            this.addEmployee.DataSource = this.сотрудникBindingSource;
            this.addEmployee.DisplayMember = "ФИО";
            this.addEmployee.FormattingEnabled = true;
            this.addEmployee.Location = new System.Drawing.Point(527, 74);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(201, 21);
            this.addEmployee.TabIndex = 7;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // addExpos
            // 
            this.addExpos.FormattingEnabled = true;
            this.addExpos.Location = new System.Drawing.Point(263, 74);
            this.addExpos.Name = "addExpos";
            this.addExpos.Size = new System.Drawing.Size(258, 21);
            this.addExpos.TabIndex = 6;
            // 
            // addGenre
            // 
            this.addGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрBindingSource, "Название", true));
            this.addGenre.DataSource = this.жанрBindingSource;
            this.addGenre.DisplayMember = "Название";
            this.addGenre.FormattingEnabled = true;
            this.addGenre.Location = new System.Drawing.Point(136, 74);
            this.addGenre.Name = "addGenre";
            this.addGenre.Size = new System.Drawing.Size(121, 21);
            this.addGenre.TabIndex = 5;
            // 
            // жанрBindingSource
            // 
            this.жанрBindingSource.DataMember = "Жанр";
            this.жанрBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // addDirect
            // 
            this.addDirect.FormattingEnabled = true;
            this.addDirect.Location = new System.Drawing.Point(9, 74);
            this.addDirect.Name = "addDirect";
            this.addDirect.Size = new System.Drawing.Size(121, 21);
            this.addDirect.TabIndex = 4;
            // 
            // addAutor
            // 
            this.addAutor.DataSource = this.авторBindingSource;
            this.addAutor.DisplayMember = "ФИО";
            this.addAutor.FormattingEnabled = true;
            this.addAutor.Location = new System.Drawing.Point(329, 23);
            this.addAutor.Name = "addAutor";
            this.addAutor.Size = new System.Drawing.Size(192, 21);
            this.addAutor.TabIndex = 3;
            // 
            // авторBindingSource
            // 
            this.авторBindingSource.DataMember = "Автор";
            this.авторBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // addMoney
            // 
            this.addMoney.Location = new System.Drawing.Point(203, 23);
            this.addMoney.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(120, 20);
            this.addMoney.TabIndex = 2;
            // 
            // addPicName
            // 
            this.addPicName.Location = new System.Drawing.Point(9, 22);
            this.addPicName.Name = "addPicName";
            this.addPicName.Size = new System.Drawing.Size(188, 20);
            this.addPicName.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(9, 101);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 31);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.updateGroup);
            this.tabPage3.Controls.Add(this.updListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(738, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Обновление";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.delBtn);
            this.tabPage4.Controls.Add(this.delList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(738, 298);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удаление";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Удалить \r\nвыбранную картину";
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(595, 37);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // delList
            // 
            this.delList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delList.FormattingEnabled = true;
            this.delList.Location = new System.Drawing.Point(3, 8);
            this.delList.Name = "delList";
            this.delList.Size = new System.Drawing.Size(586, 290);
            this.delList.TabIndex = 0;
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // авторTableAdapter
            // 
            this.авторTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторTableAdapter = this.авторTableAdapter;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = this.жанрTableAdapter;
            this.tableAdapterManager.КартинаTableAdapter = null;
            this.tableAdapterManager.НаправлениеTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.СтатусTableAdapter = null;
            // 
            // жанрTableAdapter
            // 
            this.жанрTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // updListBox
            // 
            this.updListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updListBox.FormattingEnabled = true;
            this.updListBox.Location = new System.Drawing.Point(6, 6);
            this.updListBox.Name = "updListBox";
            this.updListBox.Size = new System.Drawing.Size(352, 277);
            this.updListBox.TabIndex = 0;
            this.updListBox.SelectedIndexChanged += new System.EventHandler(this.updListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Сотрудник";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Выставка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Жанр";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Направление";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Автор";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Цена";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Название";
            // 
            // updEmployee
            // 
            this.updEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "ФИО", true));
            this.updEmployee.DataSource = this.сотрудникBindingSource;
            this.updEmployee.DisplayMember = "ФИО";
            this.updEmployee.FormattingEnabled = true;
            this.updEmployee.Location = new System.Drawing.Point(103, 174);
            this.updEmployee.Name = "updEmployee";
            this.updEmployee.Size = new System.Drawing.Size(258, 21);
            this.updEmployee.TabIndex = 22;
            // 
            // updExpos
            // 
            this.updExpos.FormattingEnabled = true;
            this.updExpos.Location = new System.Drawing.Point(103, 147);
            this.updExpos.Name = "updExpos";
            this.updExpos.Size = new System.Drawing.Size(258, 21);
            this.updExpos.TabIndex = 21;
            // 
            // updGenre
            // 
            this.updGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрBindingSource, "Название", true));
            this.updGenre.DataSource = this.жанрBindingSource;
            this.updGenre.DisplayMember = "Название";
            this.updGenre.FormattingEnabled = true;
            this.updGenre.Location = new System.Drawing.Point(103, 119);
            this.updGenre.Name = "updGenre";
            this.updGenre.Size = new System.Drawing.Size(258, 21);
            this.updGenre.TabIndex = 20;
            // 
            // updDir
            // 
            this.updDir.FormattingEnabled = true;
            this.updDir.Location = new System.Drawing.Point(103, 92);
            this.updDir.Name = "updDir";
            this.updDir.Size = new System.Drawing.Size(258, 21);
            this.updDir.TabIndex = 19;
            // 
            // updAutor
            // 
            this.updAutor.DataSource = this.авторBindingSource;
            this.updAutor.DisplayMember = "ФИО";
            this.updAutor.FormattingEnabled = true;
            this.updAutor.Location = new System.Drawing.Point(103, 65);
            this.updAutor.Name = "updAutor";
            this.updAutor.Size = new System.Drawing.Size(258, 21);
            this.updAutor.TabIndex = 18;
            // 
            // updPrice
            // 
            this.updPrice.Location = new System.Drawing.Point(103, 39);
            this.updPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updPrice.Name = "updPrice";
            this.updPrice.Size = new System.Drawing.Size(258, 20);
            this.updPrice.TabIndex = 17;
            // 
            // updName
            // 
            this.updName.Location = new System.Drawing.Point(103, 13);
            this.updName.Name = "updName";
            this.updName.Size = new System.Drawing.Size(258, 20);
            this.updName.TabIndex = 16;
            // 
            // updateGroup
            // 
            this.updateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateGroup.Controls.Add(this.updBtn);
            this.updateGroup.Controls.Add(this.label15);
            this.updateGroup.Controls.Add(this.label9);
            this.updateGroup.Controls.Add(this.updName);
            this.updateGroup.Controls.Add(this.label10);
            this.updateGroup.Controls.Add(this.updPrice);
            this.updateGroup.Controls.Add(this.label11);
            this.updateGroup.Controls.Add(this.updAutor);
            this.updateGroup.Controls.Add(this.label12);
            this.updateGroup.Controls.Add(this.updDir);
            this.updateGroup.Controls.Add(this.label13);
            this.updateGroup.Controls.Add(this.updGenre);
            this.updateGroup.Controls.Add(this.label14);
            this.updateGroup.Controls.Add(this.updExpos);
            this.updateGroup.Controls.Add(this.updEmployee);
            this.updateGroup.Location = new System.Drawing.Point(364, 6);
            this.updateGroup.Name = "updateGroup";
            this.updateGroup.Size = new System.Drawing.Size(368, 241);
            this.updateGroup.TabIndex = 30;
            this.updateGroup.TabStop = false;
            this.updateGroup.Text = "Обновление";
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(268, 201);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(94, 33);
            this.updBtn.TabIndex = 31;
            this.updBtn.Text = "Обновить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 348);
            this.Controls.Add(this.pictureTabs);
            this.Name = "PictureForm";
            this.ShowIcon = false;
            this.Text = "Картины";
            this.Load += new System.EventHandler(this.PictureForm_Load);
            this.pictureTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMoney)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).EndInit();
            this.updateGroup.ResumeLayout(false);
            this.updateGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pictureTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private picture_galleryDataSet picture_galleryDataSet;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private picture_galleryDataSetTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addEmployee;
        private System.Windows.Forms.ComboBox addExpos;
        private System.Windows.Forms.ComboBox addGenre;
        private System.Windows.Forms.ComboBox addDirect;
        private System.Windows.Forms.ComboBox addAutor;
        private System.Windows.Forms.NumericUpDown addMoney;
        private System.Windows.Forms.TextBox addPicName;
        private System.Windows.Forms.Button addBtn;
        private picture_galleryDataSetTableAdapters.АвторTableAdapter авторTableAdapter;
        private picture_galleryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource авторBindingSource;
        private picture_galleryDataSetTableAdapters.ЖанрTableAdapter жанрTableAdapter;
        private System.Windows.Forms.BindingSource жанрBindingSource;
        private picture_galleryDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.ListBox delList;
        private System.Windows.Forms.ListBox updListBox;
        private System.Windows.Forms.GroupBox updateGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown updPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox updAutor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox updDir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox updGenre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox updExpos;
        private System.Windows.Forms.ComboBox updEmployee;
        private System.Windows.Forms.Button updBtn;
    }
}