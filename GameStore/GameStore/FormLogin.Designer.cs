
namespace GameStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(711, 390);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(167, 47);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(34, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(486, 390);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(167, 47);
            this.btnAddCart.TabIndex = 2;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(728, 36);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(167, 47);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 475);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Gmae Store-Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnCart;
    }
}