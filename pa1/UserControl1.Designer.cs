namespace pa1
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.ProdusctStatus = new System.Windows.Forms.Label();
            this.Instock = new System.Windows.Forms.Label();
            this.DISCLABL = new System.Windows.Forms.Label();
            this.PriceLBL = new System.Windows.Forms.Label();
            this.MANUFlabel = new System.Windows.Forms.Label();
            this.Categ_LBL = new System.Windows.Forms.Label();
            this.DESC_lbl = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.buttonEdd);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonAddPhoto);
            this.panel1.Controls.Add(this.ProdusctStatus);
            this.panel1.Controls.Add(this.Instock);
            this.panel1.Controls.Add(this.DISCLABL);
            this.panel1.Controls.Add(this.PriceLBL);
            this.panel1.Controls.Add(this.MANUFlabel);
            this.panel1.Controls.Add(this.Categ_LBL);
            this.panel1.Controls.Add(this.DESC_lbl);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 294);
            this.panel1.TabIndex = 0;
            // 
            // buttonEdd
            // 
            this.buttonEdd.Location = new System.Drawing.Point(596, 178);
            this.buttonEdd.Name = "buttonEdd";
            this.buttonEdd.Size = new System.Drawing.Size(135, 52);
            this.buttonEdd.TabIndex = 12;
            this.buttonEdd.Text = "Редактировать товар";
            this.buttonEdd.UseVisualStyleBackColor = true;
            this.buttonEdd.Click += new System.EventHandler(this.buttonEdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(596, 120);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 52);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить товар";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(596, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 52);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить в заказ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Location = new System.Drawing.Point(596, 4);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(135, 52);
            this.buttonAddPhoto.TabIndex = 9;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // ProdusctStatus
            // 
            this.ProdusctStatus.AutoSize = true;
            this.ProdusctStatus.Location = new System.Drawing.Point(308, 264);
            this.ProdusctStatus.Name = "ProdusctStatus";
            this.ProdusctStatus.Size = new System.Drawing.Size(54, 13);
            this.ProdusctStatus.TabIndex = 8;
            this.ProdusctStatus.Text = "Актуален";
            // 
            // Instock
            // 
            this.Instock.AutoSize = true;
            this.Instock.Location = new System.Drawing.Point(308, 233);
            this.Instock.Name = "Instock";
            this.Instock.Size = new System.Drawing.Size(35, 13);
            this.Instock.TabIndex = 7;
            this.Instock.Text = "label6";
            // 
            // DISCLABL
            // 
            this.DISCLABL.AutoSize = true;
            this.DISCLABL.Location = new System.Drawing.Point(309, 200);
            this.DISCLABL.Name = "DISCLABL";
            this.DISCLABL.Size = new System.Drawing.Size(35, 13);
            this.DISCLABL.TabIndex = 6;
            this.DISCLABL.Text = "label5";
            // 
            // PriceLBL
            // 
            this.PriceLBL.AutoSize = true;
            this.PriceLBL.Location = new System.Drawing.Point(308, 168);
            this.PriceLBL.Name = "PriceLBL";
            this.PriceLBL.Size = new System.Drawing.Size(35, 13);
            this.PriceLBL.TabIndex = 5;
            this.PriceLBL.Text = "label4";
            // 
            // MANUFlabel
            // 
            this.MANUFlabel.AutoSize = true;
            this.MANUFlabel.Location = new System.Drawing.Point(309, 133);
            this.MANUFlabel.Name = "MANUFlabel";
            this.MANUFlabel.Size = new System.Drawing.Size(35, 13);
            this.MANUFlabel.TabIndex = 4;
            this.MANUFlabel.Text = "label3";
            // 
            // Categ_LBL
            // 
            this.Categ_LBL.AutoSize = true;
            this.Categ_LBL.Location = new System.Drawing.Point(308, 95);
            this.Categ_LBL.Name = "Categ_LBL";
            this.Categ_LBL.Size = new System.Drawing.Size(35, 13);
            this.Categ_LBL.TabIndex = 3;
            this.Categ_LBL.Text = "label1";
            // 
            // DESC_lbl
            // 
            this.DESC_lbl.AutoSize = true;
            this.DESC_lbl.Location = new System.Drawing.Point(309, 58);
            this.DESC_lbl.Name = "DESC_lbl";
            this.DESC_lbl.Size = new System.Drawing.Size(35, 13);
            this.DESC_lbl.TabIndex = 2;
            this.DESC_lbl.Text = "label2";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(308, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pa1.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(741, 297);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Label ProdusctStatus;
        private System.Windows.Forms.Label Instock;
        private System.Windows.Forms.Label DISCLABL;
        private System.Windows.Forms.Label PriceLBL;
        private System.Windows.Forms.Label MANUFlabel;
        private System.Windows.Forms.Label Categ_LBL;
        private System.Windows.Forms.Label DESC_lbl;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
