
namespace GameStoreV2
{
    partial class FormCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStoreV2DataSet = new GameStoreV2.GameStoreV2DataSet();
            this.cartTableAdapter = new GameStoreV2.GameStoreV2DataSetTableAdapters.CartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(623, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 61);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(12, 377);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(146, 61);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(632, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(146, 61);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(314, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 61);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameNameDataGridViewTextBoxColumn,
            this.relasedateDataGridViewTextBoxColumn,
            this.starsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 247);
            this.dataGridView1.TabIndex = 3;
            // 
            // gameNameDataGridViewTextBoxColumn
            // 
            this.gameNameDataGridViewTextBoxColumn.DataPropertyName = "Game_Name";
            this.gameNameDataGridViewTextBoxColumn.HeaderText = "Game_Name";
            this.gameNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameNameDataGridViewTextBoxColumn.Name = "gameNameDataGridViewTextBoxColumn";
            this.gameNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gameNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // relasedateDataGridViewTextBoxColumn
            // 
            this.relasedateDataGridViewTextBoxColumn.DataPropertyName = "relase_date";
            this.relasedateDataGridViewTextBoxColumn.HeaderText = "relase_date";
            this.relasedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.relasedateDataGridViewTextBoxColumn.Name = "relasedateDataGridViewTextBoxColumn";
            this.relasedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.relasedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // starsDataGridViewTextBoxColumn
            // 
            this.starsDataGridViewTextBoxColumn.DataPropertyName = "Stars";
            this.starsDataGridViewTextBoxColumn.HeaderText = "Stars";
            this.starsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starsDataGridViewTextBoxColumn.Name = "starsDataGridViewTextBoxColumn";
            this.starsDataGridViewTextBoxColumn.ReadOnly = true;
            this.starsDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.gameStoreV2DataSet;
            // 
            // gameStoreV2DataSet
            // 
            this.gameStoreV2DataSet.DataSetName = "GameStoreV2DataSet";
            this.gameStoreV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GameStoreV2DataSet gameStoreV2DataSet;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private GameStoreV2DataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starsDataGridViewTextBoxColumn;
    }
}