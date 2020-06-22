namespace picture_gallery
{
    partial class PurchaseForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.addBuyer = new System.Windows.Forms.ComboBox();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picture_galleryDataSet = new picture_gallery.picture_galleryDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addDate = new System.Windows.Forms.DateTimePicker();
            this.addPicture = new System.Windows.Forms.ComboBox();
            this.addEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.картинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchased_paintingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delBtn = new System.Windows.Forms.Button();
            this.delList = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.updGroup = new System.Windows.Forms.GroupBox();
            this.updBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.updDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.updEmployee = new System.Windows.Forms.ComboBox();
            this.updPictures = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updBuyer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updList = new System.Windows.Forms.ListBox();
            this.purchased_paintingsTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.purchased_paintingsTableAdapter();
            this.tableAdapterManager = new picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager();
            this.buyerTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.ПокупательTableAdapter();
            this.employeeTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.СотрудникTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchased_paintingsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.updGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.addBuyer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addDate);
            this.tabPage1.Controls.Add(this.addPicture);
            this.tabPage1.Controls.Add(this.addEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Покупатель";
            // 
            // addBuyer
            // 
            this.addBuyer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "ФИО", true));
            this.addBuyer.DataSource = this.buyerBindingSource;
            this.addBuyer.DisplayMember = "ФИО";
            this.addBuyer.FormattingEnabled = true;
            this.addBuyer.Location = new System.Drawing.Point(6, 86);
            this.addBuyer.Name = "addBuyer";
            this.addBuyer.Size = new System.Drawing.Size(233, 21);
            this.addBuyer.TabIndex = 7;
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Покупатель";
            this.buyerBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // picture_galleryDataSet
            // 
            this.picture_galleryDataSet.DataSetName = "picture_galleryDataSet";
            this.picture_galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить покупку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Картина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сотрудник";
            // 
            // addDate
            // 
            this.addDate.Location = new System.Drawing.Point(6, 35);
            this.addDate.Name = "addDate";
            this.addDate.Size = new System.Drawing.Size(233, 20);
            this.addDate.TabIndex = 2;
            // 
            // addPicture
            // 
            this.addPicture.FormattingEnabled = true;
            this.addPicture.Location = new System.Drawing.Point(245, 86);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(345, 21);
            this.addPicture.TabIndex = 1;
            // 
            // addEmployee
            // 
            this.addEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ФИО", true));
            this.addEmployee.DataSource = this.employeeBindingSource;
            this.addEmployee.DisplayMember = "ФИО";
            this.addEmployee.FormattingEnabled = true;
            this.addEmployee.Location = new System.Drawing.Point(245, 34);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(345, 21);
            this.addEmployee.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Сотрудник";
            this.employeeBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотреть";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.общаяЦенаDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.покупательDataGridViewTextBoxColumn,
            this.картинаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchased_paintingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // общаяЦенаDataGridViewTextBoxColumn
            // 
            this.общаяЦенаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.общаяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Общая цена";
            this.общаяЦенаDataGridViewTextBoxColumn.HeaderText = "Общая цена";
            this.общаяЦенаDataGridViewTextBoxColumn.Name = "общаяЦенаDataGridViewTextBoxColumn";
            this.общаяЦенаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // покупательDataGridViewTextBoxColumn
            // 
            this.покупательDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.покупательDataGridViewTextBoxColumn.DataPropertyName = "Покупатель";
            this.покупательDataGridViewTextBoxColumn.HeaderText = "Покупатель";
            this.покупательDataGridViewTextBoxColumn.Name = "покупательDataGridViewTextBoxColumn";
            this.покупательDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // картинаDataGridViewTextBoxColumn
            // 
            this.картинаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.картинаDataGridViewTextBoxColumn.DataPropertyName = "Картина";
            this.картинаDataGridViewTextBoxColumn.HeaderText = "Картина";
            this.картинаDataGridViewTextBoxColumn.Name = "картинаDataGridViewTextBoxColumn";
            this.картинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchased_paintingsBindingSource
            // 
            this.purchased_paintingsBindingSource.DataMember = "purchased_paintings";
            this.purchased_paintingsBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delBtn);
            this.tabPage3.Controls.Add(this.delList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(618, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(482, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(109, 38);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Удалить покупку";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // delList
            // 
            this.delList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delList.FormattingEnabled = true;
            this.delList.Location = new System.Drawing.Point(3, 3);
            this.delList.Name = "delList";
            this.delList.Size = new System.Drawing.Size(472, 394);
            this.delList.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.updGroup);
            this.tabPage4.Controls.Add(this.updList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(618, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Обновить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // updGroup
            // 
            this.updGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updGroup.Controls.Add(this.updBtn);
            this.updGroup.Controls.Add(this.label8);
            this.updGroup.Controls.Add(this.updDate);
            this.updGroup.Controls.Add(this.label7);
            this.updGroup.Controls.Add(this.updEmployee);
            this.updGroup.Controls.Add(this.updPictures);
            this.updGroup.Controls.Add(this.label5);
            this.updGroup.Controls.Add(this.updBuyer);
            this.updGroup.Controls.Add(this.label6);
            this.updGroup.Enabled = false;
            this.updGroup.Location = new System.Drawing.Point(346, 3);
            this.updGroup.Name = "updGroup";
            this.updGroup.Size = new System.Drawing.Size(269, 218);
            this.updGroup.TabIndex = 8;
            this.updGroup.TabStop = false;
            this.updGroup.Text = "Обновление";
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(6, 189);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 9;
            this.updBtn.Text = "Обновить";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Дата";
            // 
            // updDate
            // 
            this.updDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updDate.Location = new System.Drawing.Point(6, 42);
            this.updDate.Name = "updDate";
            this.updDate.Size = new System.Drawing.Size(257, 20);
            this.updDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Картина";
            // 
            // updEmployee
            // 
            this.updEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updEmployee.DataSource = this.employeeBindingSource;
            this.updEmployee.DisplayMember = "ФИО";
            this.updEmployee.FormattingEnabled = true;
            this.updEmployee.Location = new System.Drawing.Point(6, 81);
            this.updEmployee.Name = "updEmployee";
            this.updEmployee.Size = new System.Drawing.Size(257, 21);
            this.updEmployee.TabIndex = 2;
            // 
            // updPictures
            // 
            this.updPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updPictures.FormattingEnabled = true;
            this.updPictures.Location = new System.Drawing.Point(6, 161);
            this.updPictures.Name = "updPictures";
            this.updPictures.Size = new System.Drawing.Size(257, 21);
            this.updPictures.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Сотрудник";
            // 
            // updBuyer
            // 
            this.updBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updBuyer.DataSource = this.buyerBindingSource;
            this.updBuyer.DisplayMember = "ФИО";
            this.updBuyer.FormattingEnabled = true;
            this.updBuyer.Location = new System.Drawing.Point(6, 121);
            this.updBuyer.Name = "updBuyer";
            this.updBuyer.Size = new System.Drawing.Size(257, 21);
            this.updBuyer.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Покупатель";
            // 
            // updList
            // 
            this.updList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updList.FormattingEnabled = true;
            this.updList.Location = new System.Drawing.Point(3, 3);
            this.updList.Name = "updList";
            this.updList.Size = new System.Drawing.Size(337, 394);
            this.updList.TabIndex = 0;
            this.updList.SelectedIndexChanged += new System.EventHandler(this.updList_SelectedIndexChanged);
            // 
            // purchased_paintingsTableAdapter
            // 
            this.purchased_paintingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторTableAdapter = null;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.КартинаTableAdapter = null;
            this.tableAdapterManager.НаправлениеTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = this.buyerTableAdapter;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.СтатусTableAdapter = null;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PurchaseForm";
            this.ShowIcon = false;
            this.Text = "Покупки";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchased_paintingsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.updGroup.ResumeLayout(false);
            this.updGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private picture_galleryDataSet picture_galleryDataSet;
        private System.Windows.Forms.BindingSource purchased_paintingsBindingSource;
        private picture_galleryDataSetTableAdapters.purchased_paintingsTableAdapter purchased_paintingsTableAdapter;
        private picture_galleryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn покупательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn картинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker addDate;
        private System.Windows.Forms.ComboBox addPicture;
        private System.Windows.Forms.ComboBox addEmployee;
        private picture_galleryDataSetTableAdapters.СотрудникTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addBuyer;
        private picture_galleryDataSetTableAdapters.ПокупательTableAdapter buyerTableAdapter;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private System.Windows.Forms.ListBox delList;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.GroupBox updGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker updDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox updEmployee;
        private System.Windows.Forms.ComboBox updPictures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox updBuyer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox updList;
        private System.Windows.Forms.Button updBtn;
    }
}