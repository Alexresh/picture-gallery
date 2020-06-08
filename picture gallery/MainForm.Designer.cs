namespace picture_gallery
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowExposForm = new System.Windows.Forms.Button();
            this.btnShowPictureForm = new System.Windows.Forms.Button();
            this.btnShowPurchasesForm = new System.Windows.Forms.Button();
            this.labelExpos = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelPurchases = new System.Windows.Forms.Label();
            this.groupManager = new System.Windows.Forms.GroupBox();
            this.groupManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowExposForm
            // 
            this.btnShowExposForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowExposForm.Location = new System.Drawing.Point(17, 33);
            this.btnShowExposForm.Name = "btnShowExposForm";
            this.btnShowExposForm.Size = new System.Drawing.Size(71, 42);
            this.btnShowExposForm.TabIndex = 0;
            this.btnShowExposForm.Text = "Выставки";
            this.btnShowExposForm.UseVisualStyleBackColor = true;
            this.btnShowExposForm.Click += new System.EventHandler(this.btnShowExposForm_Click);
            // 
            // btnShowPictureForm
            // 
            this.btnShowPictureForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPictureForm.Location = new System.Drawing.Point(17, 95);
            this.btnShowPictureForm.Name = "btnShowPictureForm";
            this.btnShowPictureForm.Size = new System.Drawing.Size(71, 42);
            this.btnShowPictureForm.TabIndex = 1;
            this.btnShowPictureForm.Text = "Картины";
            this.btnShowPictureForm.UseVisualStyleBackColor = true;
            this.btnShowPictureForm.Click += new System.EventHandler(this.btnShowPictureForm_Click);
            // 
            // btnShowPurchasesForm
            // 
            this.btnShowPurchasesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPurchasesForm.Location = new System.Drawing.Point(17, 160);
            this.btnShowPurchasesForm.Name = "btnShowPurchasesForm";
            this.btnShowPurchasesForm.Size = new System.Drawing.Size(71, 42);
            this.btnShowPurchasesForm.TabIndex = 2;
            this.btnShowPurchasesForm.Text = "Покупки";
            this.btnShowPurchasesForm.UseVisualStyleBackColor = true;
            this.btnShowPurchasesForm.Click += new System.EventHandler(this.btnShowPurchasesForm_Click);
            // 
            // labelExpos
            // 
            this.labelExpos.AutoSize = true;
            this.labelExpos.Location = new System.Drawing.Point(94, 33);
            this.labelExpos.Name = "labelExpos";
            this.labelExpos.Size = new System.Drawing.Size(168, 26);
            this.labelExpos.TabIndex = 3;
            this.labelExpos.Text = "Показывает форму управления\r\nвыставками";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(94, 95);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(168, 26);
            this.labelPicture.TabIndex = 4;
            this.labelPicture.Text = "Показывает форму управления\r\nкартинами";
            // 
            // labelPurchases
            // 
            this.labelPurchases.AutoSize = true;
            this.labelPurchases.Location = new System.Drawing.Point(94, 160);
            this.labelPurchases.Name = "labelPurchases";
            this.labelPurchases.Size = new System.Drawing.Size(168, 26);
            this.labelPurchases.TabIndex = 5;
            this.labelPurchases.Text = "Показывает форму управления\r\nпокупками";
            // 
            // groupManager
            // 
            this.groupManager.Controls.Add(this.btnShowExposForm);
            this.groupManager.Controls.Add(this.labelPurchases);
            this.groupManager.Controls.Add(this.btnShowPictureForm);
            this.groupManager.Controls.Add(this.labelPicture);
            this.groupManager.Controls.Add(this.btnShowPurchasesForm);
            this.groupManager.Controls.Add(this.labelExpos);
            this.groupManager.Location = new System.Drawing.Point(12, 12);
            this.groupManager.Name = "groupManager";
            this.groupManager.Size = new System.Drawing.Size(277, 217);
            this.groupManager.TabIndex = 6;
            this.groupManager.TabStop = false;
            this.groupManager.Text = "Управление";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 239);
            this.Controls.Add(this.groupManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Картинная галерея";
            this.groupManager.ResumeLayout(false);
            this.groupManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowExposForm;
        private System.Windows.Forms.Button btnShowPictureForm;
        private System.Windows.Forms.Button btnShowPurchasesForm;
        private System.Windows.Forms.Label labelExpos;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelPurchases;
        private System.Windows.Forms.GroupBox groupManager;
    }
}

