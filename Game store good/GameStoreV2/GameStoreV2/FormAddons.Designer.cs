
namespace GameStoreV2
{
    partial class FormAddons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddons));
            this.btnBack = new System.Windows.Forms.Button();
            this.gameStoreV2DataSet1 = new GameStoreV2.GameStoreV2DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dlcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dlcTableAdapter = new GameStoreV2.GameStoreV2DataSetTableAdapters.DlcTableAdapter();
            this.dlcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partenersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(615, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gameStoreV2DataSet1
            // 
            this.gameStoreV2DataSet1.DataSetName = "GameStoreV2DataSet";
            this.gameStoreV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dlcNameDataGridViewTextBoxColumn,
            this.gameNameDataGridViewTextBoxColumn,
            this.partenersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dlcBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // dlcBindingSource
            // 
            this.dlcBindingSource.DataMember = "Dlc";
            this.dlcBindingSource.DataSource = this.gameStoreV2DataSet1;
            // 
            // dlcTableAdapter
            // 
            this.dlcTableAdapter.ClearBeforeFill = true;
            // 
            // dlcNameDataGridViewTextBoxColumn
            // 
            this.dlcNameDataGridViewTextBoxColumn.DataPropertyName = "Dlc_Name";
            this.dlcNameDataGridViewTextBoxColumn.HeaderText = "Dlc_Name";
            this.dlcNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dlcNameDataGridViewTextBoxColumn.Name = "dlcNameDataGridViewTextBoxColumn";
            this.dlcNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dlcNameDataGridViewTextBoxColumn.Width = 125;
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
            // partenersDataGridViewTextBoxColumn
            // 
            this.partenersDataGridViewTextBoxColumn.DataPropertyName = "Parteners";
            this.partenersDataGridViewTextBoxColumn.HeaderText = "Parteners";
            this.partenersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partenersDataGridViewTextBoxColumn.Name = "partenersDataGridViewTextBoxColumn";
            this.partenersDataGridViewTextBoxColumn.ReadOnly = true;
            this.partenersDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(41, 379);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(153, 47);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart ";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // FormAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddons";
            this.Text = "Addons";
            this.Load += new System.EventHandler(this.FormAddons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private GameStoreV2DataSet gameStoreV2DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dlcBindingSource;
        private GameStoreV2DataSetTableAdapters.DlcTableAdapter dlcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partenersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddToCart;
    }
}