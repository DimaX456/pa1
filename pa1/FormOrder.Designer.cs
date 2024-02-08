namespace pa1
{
    partial class FormOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCompositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPickupPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradepaDataSet = new pa1.TradepaDataSet();
            this.orderTableAdapter = new pa1.TradepaDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderCompositionDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderDeliveryDateDataGridViewTextBoxColumn,
            this.orderPickupPointDataGridViewTextBoxColumn,
            this.fIOClientDataGridViewTextBoxColumn,
            this.codeGiveDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderCompositionDataGridViewTextBoxColumn
            // 
            this.orderCompositionDataGridViewTextBoxColumn.DataPropertyName = "OrderComposition";
            this.orderCompositionDataGridViewTextBoxColumn.HeaderText = "OrderComposition";
            this.orderCompositionDataGridViewTextBoxColumn.Name = "orderCompositionDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderDeliveryDateDataGridViewTextBoxColumn
            // 
            this.orderDeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDeliveryDate";
            this.orderDeliveryDateDataGridViewTextBoxColumn.HeaderText = "OrderDeliveryDate";
            this.orderDeliveryDateDataGridViewTextBoxColumn.Name = "orderDeliveryDateDataGridViewTextBoxColumn";
            // 
            // orderPickupPointDataGridViewTextBoxColumn
            // 
            this.orderPickupPointDataGridViewTextBoxColumn.DataPropertyName = "OrderPickupPoint";
            this.orderPickupPointDataGridViewTextBoxColumn.HeaderText = "OrderPickupPoint";
            this.orderPickupPointDataGridViewTextBoxColumn.Name = "orderPickupPointDataGridViewTextBoxColumn";
            // 
            // fIOClientDataGridViewTextBoxColumn
            // 
            this.fIOClientDataGridViewTextBoxColumn.DataPropertyName = "FIOClient";
            this.fIOClientDataGridViewTextBoxColumn.HeaderText = "FIOClient";
            this.fIOClientDataGridViewTextBoxColumn.Name = "fIOClientDataGridViewTextBoxColumn";
            // 
            // codeGiveDataGridViewTextBoxColumn
            // 
            this.codeGiveDataGridViewTextBoxColumn.DataPropertyName = "CodeGive";
            this.codeGiveDataGridViewTextBoxColumn.HeaderText = "CodeGive";
            this.codeGiveDataGridViewTextBoxColumn.Name = "codeGiveDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.tradepaDataSet;
            // 
            // tradepaDataSet
            // 
            this.tradepaDataSet.DataSetName = "TradepaDataSet";
            this.tradepaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOrder";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TradepaDataSet tradepaDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private TradepaDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCompositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDeliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPickupPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
    }
}