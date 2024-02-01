namespace pa1
{
    partial class FormChange
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
            System.Windows.Forms.Label productArticleNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChange));
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productUnitLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productMaxSizeDiscountAmountLabel;
            System.Windows.Forms.Label productManufacturerLabel;
            System.Windows.Forms.Label productStatusLabel;
            System.Windows.Forms.Label productCategoryLabel;
            System.Windows.Forms.Label productDiscountAmountLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productPhotoLabel;
            this.tradepaDataSet = new pa1.TradepaDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new pa1.TradepaDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new pa1.TradepaDataSetTableAdapters.TableAdapterManager();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productArticleNumberTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productUnitTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.productMaxSizeDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productStatusTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPhotoTextBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            productArticleNumberLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productUnitLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productMaxSizeDiscountAmountLabel = new System.Windows.Forms.Label();
            productManufacturerLabel = new System.Windows.Forms.Label();
            productStatusLabel = new System.Windows.Forms.Label();
            productCategoryLabel = new System.Windows.Forms.Label();
            productDiscountAmountLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productPhotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tradepaDataSet
            // 
            this.tradepaDataSet.DataSetName = "TradepaDataSet";
            this.tradepaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.tradepaDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickUpPointTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pa1.TradepaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(310, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Location = new System.Drawing.Point(15, 61);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(119, 13);
            productArticleNumberLabel.TabIndex = 1;
            productArticleNumberLabel.Text = "Product Article Number:";
            // 
            // productArticleNumberTextBox
            // 
            this.productArticleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductArticleNumber", true));
            this.productArticleNumberTextBox.Location = new System.Drawing.Point(140, 58);
            this.productArticleNumberTextBox.Name = "productArticleNumberTextBox";
            this.productArticleNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.productArticleNumberTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 96);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(96, 93);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 4;
            // 
            // productUnitLabel
            // 
            productUnitLabel.AutoSize = true;
            productUnitLabel.Location = new System.Drawing.Point(12, 128);
            productUnitLabel.Name = "productUnitLabel";
            productUnitLabel.Size = new System.Drawing.Size(69, 13);
            productUnitLabel.TabIndex = 5;
            productUnitLabel.Text = "Product Unit:";
            // 
            // productUnitTextBox
            // 
            this.productUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductUnit", true));
            this.productUnitTextBox.Location = new System.Drawing.Point(87, 125);
            this.productUnitTextBox.Name = "productUnitTextBox";
            this.productUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.productUnitTextBox.TabIndex = 6;
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(18, 167);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(71, 13);
            productCostLabel.TabIndex = 7;
            productCostLabel.Text = "Product Cost:";
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCost", true));
            this.productCostTextBox.Location = new System.Drawing.Point(95, 164);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCostTextBox.TabIndex = 8;
            // 
            // productMaxSizeDiscountAmountLabel
            // 
            productMaxSizeDiscountAmountLabel.AutoSize = true;
            productMaxSizeDiscountAmountLabel.Location = new System.Drawing.Point(17, 206);
            productMaxSizeDiscountAmountLabel.Name = "productMaxSizeDiscountAmountLabel";
            productMaxSizeDiscountAmountLabel.Size = new System.Drawing.Size(177, 13);
            productMaxSizeDiscountAmountLabel.TabIndex = 9;
            productMaxSizeDiscountAmountLabel.Text = "Product Max Size Discount Amount:";
            // 
            // productMaxSizeDiscountAmountTextBox
            // 
            this.productMaxSizeDiscountAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductMaxSizeDiscountAmount", true));
            this.productMaxSizeDiscountAmountTextBox.Location = new System.Drawing.Point(200, 203);
            this.productMaxSizeDiscountAmountTextBox.Name = "productMaxSizeDiscountAmountTextBox";
            this.productMaxSizeDiscountAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.productMaxSizeDiscountAmountTextBox.TabIndex = 10;
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Location = new System.Drawing.Point(19, 243);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new System.Drawing.Size(113, 13);
            productManufacturerLabel.TabIndex = 11;
            productManufacturerLabel.Text = "Product Manufacturer:";
            // 
            // productManufacturerTextBox
            // 
            this.productManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductManufacturer", true));
            this.productManufacturerTextBox.Location = new System.Drawing.Point(138, 240);
            this.productManufacturerTextBox.Name = "productManufacturerTextBox";
            this.productManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.productManufacturerTextBox.TabIndex = 12;
            // 
            // productStatusLabel
            // 
            productStatusLabel.AutoSize = true;
            productStatusLabel.Location = new System.Drawing.Point(20, 275);
            productStatusLabel.Name = "productStatusLabel";
            productStatusLabel.Size = new System.Drawing.Size(80, 13);
            productStatusLabel.TabIndex = 13;
            productStatusLabel.Text = "Product Status:";
            // 
            // productStatusTextBox
            // 
            this.productStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductStatus", true));
            this.productStatusTextBox.Location = new System.Drawing.Point(106, 272);
            this.productStatusTextBox.Name = "productStatusTextBox";
            this.productStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.productStatusTextBox.TabIndex = 14;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new System.Drawing.Point(16, 306);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new System.Drawing.Size(92, 13);
            productCategoryLabel.TabIndex = 15;
            productCategoryLabel.Text = "Product Category:";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCategory", true));
            this.productCategoryTextBox.Location = new System.Drawing.Point(114, 303);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCategoryTextBox.TabIndex = 16;
            // 
            // productDiscountAmountLabel
            // 
            productDiscountAmountLabel.AutoSize = true;
            productDiscountAmountLabel.Location = new System.Drawing.Point(13, 339);
            productDiscountAmountLabel.Name = "productDiscountAmountLabel";
            productDiscountAmountLabel.Size = new System.Drawing.Size(131, 13);
            productDiscountAmountLabel.TabIndex = 17;
            productDiscountAmountLabel.Text = "Product Discount Amount:";
            // 
            // productDiscountAmountTextBox
            // 
            this.productDiscountAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDiscountAmount", true));
            this.productDiscountAmountTextBox.Location = new System.Drawing.Point(150, 336);
            this.productDiscountAmountTextBox.Name = "productDiscountAmountTextBox";
            this.productDiscountAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.productDiscountAmountTextBox.TabIndex = 18;
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(10, 368);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(132, 13);
            productQuantityInStockLabel.TabIndex = 19;
            productQuantityInStockLabel.Text = "Product Quantity In Stock:";
            // 
            // productQuantityInStockTextBox
            // 
            this.productQuantityInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductQuantityInStock", true));
            this.productQuantityInStockTextBox.Location = new System.Drawing.Point(148, 365);
            this.productQuantityInStockTextBox.Name = "productQuantityInStockTextBox";
            this.productQuantityInStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.productQuantityInStockTextBox.TabIndex = 20;
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(10, 399);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            productDescriptionLabel.TabIndex = 21;
            productDescriptionLabel.Text = "Product Description:";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDescription", true));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(119, 396);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.productDescriptionTextBox.TabIndex = 22;
            // 
            // productPhotoLabel
            // 
            productPhotoLabel.AutoSize = true;
            productPhotoLabel.Location = new System.Drawing.Point(7, 427);
            productPhotoLabel.Name = "productPhotoLabel";
            productPhotoLabel.Size = new System.Drawing.Size(78, 13);
            productPhotoLabel.TabIndex = 23;
            productPhotoLabel.Text = "Product Photo:";
            // 
            // productPhotoTextBox
            // 
            this.productPhotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductPhoto", true));
            this.productPhotoTextBox.Location = new System.Drawing.Point(91, 424);
            this.productPhotoTextBox.Name = "productPhotoTextBox";
            this.productPhotoTextBox.Size = new System.Drawing.Size(100, 20);
            this.productPhotoTextBox.TabIndex = 24;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(8, 518);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(289, 28);
            this.buttonClear.TabIndex = 52;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(10, 471);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(287, 40);
            this.buttonSave.TabIndex = 51;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 560);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(productPhotoLabel);
            this.Controls.Add(this.productPhotoTextBox);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(this.productQuantityInStockTextBox);
            this.Controls.Add(productDiscountAmountLabel);
            this.Controls.Add(this.productDiscountAmountTextBox);
            this.Controls.Add(productCategoryLabel);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(productStatusLabel);
            this.Controls.Add(this.productStatusTextBox);
            this.Controls.Add(productManufacturerLabel);
            this.Controls.Add(this.productManufacturerTextBox);
            this.Controls.Add(productMaxSizeDiscountAmountLabel);
            this.Controls.Add(this.productMaxSizeDiscountAmountTextBox);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.productCostTextBox);
            this.Controls.Add(productUnitLabel);
            this.Controls.Add(this.productUnitTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productArticleNumberLabel);
            this.Controls.Add(this.productArticleNumberTextBox);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "FormChange";
            this.Text = "FormChange";
            this.Load += new System.EventHandler(this.FormChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TradepaDataSet tradepaDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private TradepaDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private TradepaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productArticleNumberTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productUnitTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
        private System.Windows.Forms.TextBox productMaxSizeDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productManufacturerTextBox;
        private System.Windows.Forms.TextBox productStatusTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.TextBox productDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productQuantityInStockTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productPhotoTextBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}