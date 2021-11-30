
namespace GameStoreV2
{
    partial class FormGamesLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesLogin));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStoreV2DataSet = new GameStoreV2.GameStoreV2DataSet();
            this.gamesTableAdapter = new GameStoreV2.GameStoreV2DataSetTableAdapters.GamesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(655, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 68);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(607, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(214, 125);
            this.btnCart.TabIndex = 1;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Location = new System.Drawing.Point(23, 428);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(166, 68);
            this.btnAddtocart.TabIndex = 2;
            this.btnAddtocart.Text = "Add To Cart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            this.btnAddtocart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddtocart_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameNameDataGridViewTextBoxColumn,
            this.releasedateDataGridViewTextBoxColumn,
            this.starsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 227);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddtocart_MouseClick);
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
            // releasedateDataGridViewTextBoxColumn
            // 
            this.releasedateDataGridViewTextBoxColumn.DataPropertyName = "release_date";
            this.releasedateDataGridViewTextBoxColumn.HeaderText = "release_date";
            this.releasedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releasedateDataGridViewTextBoxColumn.Name = "releasedateDataGridViewTextBoxColumn";
            this.releasedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.releasedateDataGridViewTextBoxColumn.Width = 125;
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
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.gameStoreV2DataSet;
            // 
            // gameStoreV2DataSet
            // 
            this.gameStoreV2DataSet.DataSetName = "GameStoreV2DataSet";
            this.gameStoreV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Addons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGamesLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGamesLogin";
            this.Text = "Games-Login";
            this.Load += new System.EventHandler(this.FormGamesLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreV2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GameStoreV2DataSet gameStoreV2DataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameStoreV2DataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}