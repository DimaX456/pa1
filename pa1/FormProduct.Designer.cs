namespace pa1
{
    partial class FormProduct
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
            System.Windows.Forms.Label productPhotoLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label productDiscountAmountLabel;
            System.Windows.Forms.Label productCategoryLabel;
            System.Windows.Forms.Label productStatusLabel;
            System.Windows.Forms.Label productManufacturerLabel;
            System.Windows.Forms.Label productMaxSizeDiscountAmountLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productUnitLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productArticleNumberLabel;
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVozra = new System.Windows.Forms.RadioButton();
            this.radioButtonUbiv = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaxSizeDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradepaDataSet = new pa1.TradepaDataSet();
            this.productTableAdapter = new pa1.TradepaDataSetTableAdapters.ProductTableAdapter();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.productPhotoTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.productDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productStatusTextBox = new System.Windows.Forms.TextBox();
            this.productManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productMaxSizeDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.productUnitTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productArticleNumberTextBox = new System.Windows.Forms.TextBox();
            productPhotoLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            productDiscountAmountLabel = new System.Windows.Forms.Label();
            productCategoryLabel = new System.Windows.Forms.Label();
            productStatusLabel = new System.Windows.Forms.Label();
            productManufacturerLabel = new System.Windows.Forms.Label();
            productMaxSizeDiscountAmountLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productUnitLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productArticleNumberLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Всего товаров:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(566, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(222, 36);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "Назад на главную форму";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(566, 360);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(222, 36);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(566, 318);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(222, 36);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(566, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(222, 36);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(566, 234);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(222, 36);
            this.buttonChange.TabIndex = 24;
            this.buttonChange.Text = "Редактировать запись";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(566, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 55);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтрация";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFind);
            this.groupBox2.Location = new System.Drawing.Point(566, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 50);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(7, 20);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(209, 20);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVozra);
            this.groupBox1.Controls.Add(this.radioButtonUbiv);
            this.groupBox1.Location = new System.Drawing.Point(566, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 65);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по стоимости товара";
            // 
            // radioButtonVozra
            // 
            this.radioButtonVozra.AutoSize = true;
            this.radioButtonVozra.Location = new System.Drawing.Point(7, 43);
            this.radioButtonVozra.Name = "radioButtonVozra";
            this.radioButtonVozra.Size = new System.Drawing.Size(109, 17);
            this.radioButtonVozra.TabIndex = 1;
            this.radioButtonVozra.TabStop = true;
            this.radioButtonVozra.Text = "По возрастанию";
            this.radioButtonVozra.UseVisualStyleBackColor = true;
            // 
            // radioButtonUbiv
            // 
            this.radioButtonUbiv.AutoSize = true;
            this.radioButtonUbiv.Location = new System.Drawing.Point(7, 20);
            this.radioButtonUbiv.Name = "radioButtonUbiv";
            this.radioButtonUbiv.Size = new System.Drawing.Size(93, 17);
            this.radioButtonUbiv.TabIndex = 0;
            this.radioButtonUbiv.TabStop = true;
            this.radioButtonUbiv.Text = "По убыванию";
            this.radioButtonUbiv.UseVisualStyleBackColor = true;
            this.radioButtonUbiv.CheckedChanged += new System.EventHandler(this.radioButtonUbiv_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productMaxSizeDiscountAmountDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 434);
            this.dataGridView1.TabIndex = 20;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productUnitDataGridViewTextBoxColumn
            // 
            this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.HeaderText = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            // 
            // productMaxSizeDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productMaxSizeDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductMaxSizeDiscountAmount";
            this.productMaxSizeDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductMaxSizeDiscountAmount";
            this.productMaxSizeDiscountAmountDataGridViewTextBoxColumn.Name = "productMaxSizeDiscountAmountDataGridViewTextBoxColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productPhotoDataGridViewTextBoxColumn
            // 
            this.productPhotoDataGridViewTextBoxColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.HeaderText = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.Name = "productPhotoDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.tradepaDataSet;
            // 
            // tradepaDataSet
            // 
            this.tradepaDataSet.DataSetName = "TradepaDataSet";
            this.tradepaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(566, 195);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(222, 35);
            this.buttonFilter.TabIndex = 30;
            this.buttonFilter.Text = "Фильровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(productPhotoLabel);
            this.groupBox4.Controls.Add(this.productPhotoTextBox);
            this.groupBox4.Controls.Add(productDescriptionLabel);
            this.groupBox4.Controls.Add(this.productDescriptionTextBox);
            this.groupBox4.Controls.Add(productQuantityInStockLabel);
            this.groupBox4.Controls.Add(this.productQuantityInStockTextBox);
            this.groupBox4.Controls.Add(productDiscountAmountLabel);
            this.groupBox4.Controls.Add(this.productDiscountAmountTextBox);
            this.groupBox4.Controls.Add(productCategoryLabel);
            this.groupBox4.Controls.Add(this.productCategoryTextBox);
            this.groupBox4.Controls.Add(productStatusLabel);
            this.groupBox4.Controls.Add(this.productStatusTextBox);
            this.groupBox4.Controls.Add(productManufacturerLabel);
            this.groupBox4.Controls.Add(this.productManufacturerTextBox);
            this.groupBox4.Controls.Add(productMaxSizeDiscountAmountLabel);
            this.groupBox4.Controls.Add(this.productMaxSizeDiscountAmountTextBox);
            this.groupBox4.Controls.Add(productCostLabel);
            this.groupBox4.Controls.Add(this.productCostTextBox);
            this.groupBox4.Controls.Add(productUnitLabel);
            this.groupBox4.Controls.Add(this.productUnitTextBox);
            this.groupBox4.Controls.Add(productNameLabel);
            this.groupBox4.Controls.Add(this.productNameTextBox);
            this.groupBox4.Controls.Add(productArticleNumberLabel);
            this.groupBox4.Controls.Add(this.productArticleNumberTextBox);
            this.groupBox4.Location = new System.Drawing.Point(795, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 425);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактирование";
            // 
            // productPhotoLabel
            // 
            productPhotoLabel.AutoSize = true;
            productPhotoLabel.Location = new System.Drawing.Point(8, 359);
            productPhotoLabel.Name = "productPhotoLabel";
            productPhotoLabel.Size = new System.Drawing.Size(78, 13);
            productPhotoLabel.TabIndex = 71;
            productPhotoLabel.Text = "Product Photo:";
            // 
            // productPhotoTextBox
            // 
            this.productPhotoTextBox.Location = new System.Drawing.Point(189, 356);
            this.productPhotoTextBox.Name = "productPhotoTextBox";
            this.productPhotoTextBox.Size = new System.Drawing.Size(259, 20);
            this.productPhotoTextBox.TabIndex = 72;
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(6, 328);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            productDescriptionLabel.TabIndex = 69;
            productDescriptionLabel.Text = "Product Description:";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(189, 325);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(259, 20);
            this.productDescriptionTextBox.TabIndex = 70;
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(6, 296);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(132, 13);
            productQuantityInStockLabel.TabIndex = 67;
            productQuantityInStockLabel.Text = "Product Quantity In Stock:";
            // 
            // productQuantityInStockTextBox
            // 
            this.productQuantityInStockTextBox.Location = new System.Drawing.Point(189, 289);
            this.productQuantityInStockTextBox.Name = "productQuantityInStockTextBox";
            this.productQuantityInStockTextBox.Size = new System.Drawing.Size(259, 20);
            this.productQuantityInStockTextBox.TabIndex = 68;
            // 
            // productDiscountAmountLabel
            // 
            productDiscountAmountLabel.AutoSize = true;
            productDiscountAmountLabel.Location = new System.Drawing.Point(6, 263);
            productDiscountAmountLabel.Name = "productDiscountAmountLabel";
            productDiscountAmountLabel.Size = new System.Drawing.Size(131, 13);
            productDiscountAmountLabel.TabIndex = 65;
            productDiscountAmountLabel.Text = "Product Discount Amount:";
            // 
            // productDiscountAmountTextBox
            // 
            this.productDiscountAmountTextBox.Location = new System.Drawing.Point(189, 260);
            this.productDiscountAmountTextBox.Name = "productDiscountAmountTextBox";
            this.productDiscountAmountTextBox.Size = new System.Drawing.Size(259, 20);
            this.productDiscountAmountTextBox.TabIndex = 66;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new System.Drawing.Point(6, 233);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new System.Drawing.Size(92, 13);
            productCategoryLabel.TabIndex = 63;
            productCategoryLabel.Text = "Product Category:";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(189, 233);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(259, 20);
            this.productCategoryTextBox.TabIndex = 64;
            // 
            // productStatusLabel
            // 
            productStatusLabel.AutoSize = true;
            productStatusLabel.Location = new System.Drawing.Point(6, 204);
            productStatusLabel.Name = "productStatusLabel";
            productStatusLabel.Size = new System.Drawing.Size(80, 13);
            productStatusLabel.TabIndex = 61;
            productStatusLabel.Text = "Product Status:";
            // 
            // productStatusTextBox
            // 
            this.productStatusTextBox.Location = new System.Drawing.Point(189, 204);
            this.productStatusTextBox.Name = "productStatusTextBox";
            this.productStatusTextBox.Size = new System.Drawing.Size(259, 20);
            this.productStatusTextBox.TabIndex = 62;
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Location = new System.Drawing.Point(6, 177);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new System.Drawing.Size(113, 13);
            productManufacturerLabel.TabIndex = 59;
            productManufacturerLabel.Text = "Product Manufacturer:";
            // 
            // productManufacturerTextBox
            // 
            this.productManufacturerTextBox.Location = new System.Drawing.Point(189, 174);
            this.productManufacturerTextBox.Name = "productManufacturerTextBox";
            this.productManufacturerTextBox.Size = new System.Drawing.Size(259, 20);
            this.productManufacturerTextBox.TabIndex = 60;
            // 
            // productMaxSizeDiscountAmountLabel
            // 
            productMaxSizeDiscountAmountLabel.AutoSize = true;
            productMaxSizeDiscountAmountLabel.Location = new System.Drawing.Point(6, 148);
            productMaxSizeDiscountAmountLabel.Name = "productMaxSizeDiscountAmountLabel";
            productMaxSizeDiscountAmountLabel.Size = new System.Drawing.Size(177, 13);
            productMaxSizeDiscountAmountLabel.TabIndex = 57;
            productMaxSizeDiscountAmountLabel.Text = "Product Max Size Discount Amount:";
            // 
            // productMaxSizeDiscountAmountTextBox
            // 
            this.productMaxSizeDiscountAmountTextBox.Location = new System.Drawing.Point(189, 145);
            this.productMaxSizeDiscountAmountTextBox.Name = "productMaxSizeDiscountAmountTextBox";
            this.productMaxSizeDiscountAmountTextBox.Size = new System.Drawing.Size(259, 20);
            this.productMaxSizeDiscountAmountTextBox.TabIndex = 58;
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(6, 116);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(71, 13);
            productCostLabel.TabIndex = 55;
            productCostLabel.Text = "Product Cost:";
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.Location = new System.Drawing.Point(189, 113);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(259, 20);
            this.productCostTextBox.TabIndex = 56;
            // 
            // productUnitLabel
            // 
            productUnitLabel.AutoSize = true;
            productUnitLabel.Location = new System.Drawing.Point(6, 83);
            productUnitLabel.Name = "productUnitLabel";
            productUnitLabel.Size = new System.Drawing.Size(69, 13);
            productUnitLabel.TabIndex = 53;
            productUnitLabel.Text = "Product Unit:";
            // 
            // productUnitTextBox
            // 
            this.productUnitTextBox.Location = new System.Drawing.Point(189, 83);
            this.productUnitTextBox.Name = "productUnitTextBox";
            this.productUnitTextBox.Size = new System.Drawing.Size(259, 20);
            this.productUnitTextBox.TabIndex = 54;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(6, 54);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 51;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(189, 54);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.productNameTextBox.TabIndex = 52;
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Location = new System.Drawing.Point(6, 26);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(119, 13);
            productArticleNumberLabel.TabIndex = 49;
            productArticleNumberLabel.Text = "Product Article Number:";
            // 
            // productArticleNumberTextBox
            // 
            this.productArticleNumberTextBox.Location = new System.Drawing.Point(189, 23);
            this.productArticleNumberTextBox.Name = "productArticleNumberTextBox";
            this.productArticleNumberTextBox.Size = new System.Drawing.Size(259, 20);
            this.productArticleNumberTextBox.TabIndex = 50;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 464);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonVozra;
        private System.Windows.Forms.RadioButton radioButtonUbiv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TradepaDataSet tradepaDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private TradepaDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMaxSizeDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox productPhotoTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productQuantityInStockTextBox;
        private System.Windows.Forms.TextBox productDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.TextBox productStatusTextBox;
        private System.Windows.Forms.TextBox productManufacturerTextBox;
        private System.Windows.Forms.TextBox productMaxSizeDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
        private System.Windows.Forms.TextBox productUnitTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productArticleNumberTextBox;
    }
}