namespace pa1
{
    partial class FormPUP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tradepaDataSet = new pa1.TradepaDataSet();
            this.pickUpPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickUpPointTableAdapter = new pa1.TradepaDataSetTableAdapters.PickUpPointTableAdapter();
            this.idPickUpPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailIndexPUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityPUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetPUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberHousePUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPickUpPointDataGridViewTextBoxColumn,
            this.mailIndexPUPDataGridViewTextBoxColumn,
            this.cityPUPDataGridViewTextBoxColumn,
            this.streetPUPDataGridViewTextBoxColumn,
            this.numberHousePUPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pickUpPointBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // tradepaDataSet
            // 
            this.tradepaDataSet.DataSetName = "TradepaDataSet";
            this.tradepaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pickUpPointBindingSource
            // 
            this.pickUpPointBindingSource.DataMember = "PickUpPoint";
            this.pickUpPointBindingSource.DataSource = this.tradepaDataSet;
            // 
            // pickUpPointTableAdapter
            // 
            this.pickUpPointTableAdapter.ClearBeforeFill = true;
            // 
            // idPickUpPointDataGridViewTextBoxColumn
            // 
            this.idPickUpPointDataGridViewTextBoxColumn.DataPropertyName = "id_PickUpPoint";
            this.idPickUpPointDataGridViewTextBoxColumn.HeaderText = "id_PickUpPoint";
            this.idPickUpPointDataGridViewTextBoxColumn.Name = "idPickUpPointDataGridViewTextBoxColumn";
            // 
            // mailIndexPUPDataGridViewTextBoxColumn
            // 
            this.mailIndexPUPDataGridViewTextBoxColumn.DataPropertyName = "MailIndex_PUP";
            this.mailIndexPUPDataGridViewTextBoxColumn.HeaderText = "MailIndex_PUP";
            this.mailIndexPUPDataGridViewTextBoxColumn.Name = "mailIndexPUPDataGridViewTextBoxColumn";
            // 
            // cityPUPDataGridViewTextBoxColumn
            // 
            this.cityPUPDataGridViewTextBoxColumn.DataPropertyName = "City_PUP";
            this.cityPUPDataGridViewTextBoxColumn.HeaderText = "City_PUP";
            this.cityPUPDataGridViewTextBoxColumn.Name = "cityPUPDataGridViewTextBoxColumn";
            // 
            // streetPUPDataGridViewTextBoxColumn
            // 
            this.streetPUPDataGridViewTextBoxColumn.DataPropertyName = "Street_PUP";
            this.streetPUPDataGridViewTextBoxColumn.HeaderText = "Street_PUP";
            this.streetPUPDataGridViewTextBoxColumn.Name = "streetPUPDataGridViewTextBoxColumn";
            // 
            // numberHousePUPDataGridViewTextBoxColumn
            // 
            this.numberHousePUPDataGridViewTextBoxColumn.DataPropertyName = "NumberHouse_PUP";
            this.numberHousePUPDataGridViewTextBoxColumn.HeaderText = "NumberHouse_PUP";
            this.numberHousePUPDataGridViewTextBoxColumn.Name = "numberHousePUPDataGridViewTextBoxColumn";
            // 
            // FormPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPUP";
            this.Text = "FormPUP";
            this.Load += new System.EventHandler(this.FormPUP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradepaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TradepaDataSet tradepaDataSet;
        private System.Windows.Forms.BindingSource pickUpPointBindingSource;
        private TradepaDataSetTableAdapters.PickUpPointTableAdapter pickUpPointTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPickUpPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIndexPUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityPUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetPUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberHousePUPDataGridViewTextBoxColumn;
    }
}