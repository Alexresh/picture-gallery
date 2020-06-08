namespace picture_gallery
{
    partial class ExposForm
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
            this.ExposTabs = new System.Windows.Forms.TabControl();
            this.selectPage = new System.Windows.Forms.TabPage();
            this.ExposDataGrid = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exposViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picture_galleryDataSet = new picture_gallery.picture_galleryDataSet();
            this.addPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.addMaxPicNumber = new System.Windows.Forms.NumericUpDown();
            this.addDirComboBox = new System.Windows.Forms.ComboBox();
            this.addDate = new System.Windows.Forms.DateTimePicker();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.updateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.updateDirComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateMaxPic = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updateListBox = new System.Windows.Forms.ListBox();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.delListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exposViewTableAdapter = new picture_gallery.picture_galleryDataSetTableAdapters.exposViewTableAdapter();
            this.tableAdapterManager = new picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager();
            this.updateBtn = new System.Windows.Forms.Button();
            this.ExposTabs.SuspendLayout();
            this.selectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExposDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).BeginInit();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMaxPicNumber)).BeginInit();
            this.updatePage.SuspendLayout();
            this.updateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateMaxPic)).BeginInit();
            this.deletePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExposTabs
            // 
            this.ExposTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExposTabs.Controls.Add(this.selectPage);
            this.ExposTabs.Controls.Add(this.addPage);
            this.ExposTabs.Controls.Add(this.updatePage);
            this.ExposTabs.Controls.Add(this.deletePage);
            this.ExposTabs.Location = new System.Drawing.Point(12, 12);
            this.ExposTabs.Name = "ExposTabs";
            this.ExposTabs.SelectedIndex = 0;
            this.ExposTabs.Size = new System.Drawing.Size(658, 369);
            this.ExposTabs.TabIndex = 1;
            this.ExposTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ExposTabs_Selecting);
            // 
            // selectPage
            // 
            this.selectPage.Controls.Add(this.ExposDataGrid);
            this.selectPage.Location = new System.Drawing.Point(4, 22);
            this.selectPage.Name = "selectPage";
            this.selectPage.Padding = new System.Windows.Forms.Padding(3);
            this.selectPage.Size = new System.Drawing.Size(650, 343);
            this.selectPage.TabIndex = 0;
            this.selectPage.Text = "Просмотр";
            this.selectPage.UseVisualStyleBackColor = true;
            // 
            // ExposDataGrid
            // 
            this.ExposDataGrid.AllowUserToAddRows = false;
            this.ExposDataGrid.AllowUserToDeleteRows = false;
            this.ExposDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExposDataGrid.AutoGenerateColumns = false;
            this.ExposDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExposDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.направлениеDataGridViewTextBoxColumn,
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn});
            this.ExposDataGrid.DataSource = this.exposViewBindingSource;
            this.ExposDataGrid.Location = new System.Drawing.Point(6, 6);
            this.ExposDataGrid.Name = "ExposDataGrid";
            this.ExposDataGrid.ReadOnly = true;
            this.ExposDataGrid.Size = new System.Drawing.Size(638, 331);
            this.ExposDataGrid.TabIndex = 2;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            this.направлениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // максимальноеКоличествоКартинDataGridViewTextBoxColumn
            // 
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn.DataPropertyName = "Максимальное количество картин";
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn.HeaderText = "Максимальное количество картин";
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn.Name = "максимальноеКоличествоКартинDataGridViewTextBoxColumn";
            this.максимальноеКоличествоКартинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exposViewBindingSource
            // 
            this.exposViewBindingSource.DataMember = "exposView";
            this.exposViewBindingSource.DataSource = this.picture_galleryDataSet;
            // 
            // picture_galleryDataSet
            // 
            this.picture_galleryDataSet.DataSetName = "picture_galleryDataSet";
            this.picture_galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.addMaxPicNumber);
            this.addPage.Controls.Add(this.addDirComboBox);
            this.addPage.Controls.Add(this.addDate);
            this.addPage.Location = new System.Drawing.Point(4, 22);
            this.addPage.Name = "addPage";
            this.addPage.Size = new System.Drawing.Size(650, 343);
            this.addPage.TabIndex = 2;
            this.addPage.Text = "Добавление";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(17, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 30);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addMaxPicNumber
            // 
            this.addMaxPicNumber.Location = new System.Drawing.Point(295, 15);
            this.addMaxPicNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addMaxPicNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addMaxPicNumber.Name = "addMaxPicNumber";
            this.addMaxPicNumber.Size = new System.Drawing.Size(51, 20);
            this.addMaxPicNumber.TabIndex = 2;
            this.addMaxPicNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addDirComboBox
            // 
            this.addDirComboBox.FormattingEnabled = true;
            this.addDirComboBox.Location = new System.Drawing.Point(168, 14);
            this.addDirComboBox.Name = "addDirComboBox";
            this.addDirComboBox.Size = new System.Drawing.Size(121, 21);
            this.addDirComboBox.TabIndex = 1;
            // 
            // addDate
            // 
            this.addDate.Location = new System.Drawing.Point(17, 15);
            this.addDate.Name = "addDate";
            this.addDate.Size = new System.Drawing.Size(145, 20);
            this.addDate.TabIndex = 0;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.updateGroupBox);
            this.updatePage.Controls.Add(this.updateListBox);
            this.updatePage.Location = new System.Drawing.Point(4, 22);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(650, 343);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Обновление";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.updateBtn);
            this.updateGroupBox.Controls.Add(this.updateDatePicker);
            this.updateGroupBox.Controls.Add(this.label4);
            this.updateGroupBox.Controls.Add(this.updateDirComboBox);
            this.updateGroupBox.Controls.Add(this.label3);
            this.updateGroupBox.Controls.Add(this.updateMaxPic);
            this.updateGroupBox.Controls.Add(this.label2);
            this.updateGroupBox.Enabled = false;
            this.updateGroupBox.Location = new System.Drawing.Point(437, 6);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(207, 203);
            this.updateGroupBox.TabIndex = 8;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Обновление";
            // 
            // updateDatePicker
            // 
            this.updateDatePicker.Location = new System.Drawing.Point(19, 31);
            this.updateDatePicker.Name = "updateDatePicker";
            this.updateDatePicker.Size = new System.Drawing.Size(182, 20);
            this.updateDatePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Макс. количесто картин:";
            // 
            // updateDirComboBox
            // 
            this.updateDirComboBox.FormattingEnabled = true;
            this.updateDirComboBox.Location = new System.Drawing.Point(19, 86);
            this.updateDirComboBox.Name = "updateDirComboBox";
            this.updateDirComboBox.Size = new System.Drawing.Size(121, 21);
            this.updateDirComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Направление:";
            // 
            // updateMaxPic
            // 
            this.updateMaxPic.Location = new System.Drawing.Point(19, 139);
            this.updateMaxPic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updateMaxPic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updateMaxPic.Name = "updateMaxPic";
            this.updateMaxPic.Size = new System.Drawing.Size(51, 20);
            this.updateMaxPic.TabIndex = 4;
            this.updateMaxPic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата проведения:";
            // 
            // updateListBox
            // 
            this.updateListBox.FormattingEnabled = true;
            this.updateListBox.HorizontalScrollbar = true;
            this.updateListBox.Location = new System.Drawing.Point(6, 6);
            this.updateListBox.Name = "updateListBox";
            this.updateListBox.Size = new System.Drawing.Size(425, 329);
            this.updateListBox.TabIndex = 0;
            this.updateListBox.SelectedIndexChanged += new System.EventHandler(this.updateListBox_SelectedIndexChanged);
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.delListBox);
            this.deletePage.Controls.Add(this.label1);
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Location = new System.Drawing.Point(4, 22);
            this.deletePage.Name = "deletePage";
            this.deletePage.Size = new System.Drawing.Size(650, 343);
            this.deletePage.TabIndex = 3;
            this.deletePage.Text = "Удаление";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // delListBox
            // 
            this.delListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delListBox.FormattingEnabled = true;
            this.delListBox.HorizontalScrollbar = true;
            this.delListBox.ItemHeight = 18;
            this.delListBox.Location = new System.Drawing.Point(3, 3);
            this.delListBox.Name = "delListBox";
            this.delListBox.Size = new System.Drawing.Size(477, 328);
            this.delListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удаляет выбранную выставку";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(574, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(73, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exposViewTableAdapter
            // 
            this.exposViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = picture_gallery.picture_galleryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторTableAdapter = null;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.КартинаTableAdapter = null;
            this.tableAdapterManager.НаправлениеTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.СтатусTableAdapter = null;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(19, 170);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(121, 23);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Обновить данные";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ExposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 393);
            this.Controls.Add(this.ExposTabs);
            this.Name = "ExposForm";
            this.ShowIcon = false;
            this.Text = "Выставки";
            this.Load += new System.EventHandler(this.ExposForm_Load);
            this.ExposTabs.ResumeLayout(false);
            this.selectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExposDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_galleryDataSet)).EndInit();
            this.addPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMaxPicNumber)).EndInit();
            this.updatePage.ResumeLayout(false);
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateMaxPic)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ExposTabs;
        private System.Windows.Forms.TabPage selectPage;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.DataGridView ExposDataGrid;
        private System.Windows.Forms.DateTimePicker addDate;
        private System.Windows.Forms.ComboBox addDirComboBox;
        private System.Windows.Forms.NumericUpDown addMaxPicNumber;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox delListBox;
        private picture_galleryDataSet picture_galleryDataSet;
        private System.Windows.Forms.BindingSource exposViewBindingSource;
        private picture_galleryDataSetTableAdapters.exposViewTableAdapter exposViewTableAdapter;
        private picture_galleryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максимальноеКоличествоКартинDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updateMaxPic;
        private System.Windows.Forms.ComboBox updateDirComboBox;
        private System.Windows.Forms.DateTimePicker updateDatePicker;
        private System.Windows.Forms.ListBox updateListBox;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.Button updateBtn;
    }
}