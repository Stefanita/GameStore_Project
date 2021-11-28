
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesLogin));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(607, 726);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 68);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCart
            // 
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(607, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(181, 222);
            this.btnCart.TabIndex = 1;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Location = new System.Drawing.Point(12, 726);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(166, 68);
            this.btnAddtocart.TabIndex = 2;
            this.btnAddtocart.Text = "Add To Cart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            // 
            // FormGamesLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 806);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGamesLogin";
            this.Text = "Games-Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAddtocart;
    }
}