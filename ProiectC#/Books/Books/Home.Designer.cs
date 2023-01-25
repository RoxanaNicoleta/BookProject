namespace Books
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ProfilButton = new System.Windows.Forms.Button();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.HomeTextBox = new System.Windows.Forms.TextBox();
            this.BooksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilButton
            // 
            this.ProfilButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfilButton.Location = new System.Drawing.Point(1, 276);
            this.ProfilButton.Name = "ProfilButton";
            this.ProfilButton.Size = new System.Drawing.Size(255, 80);
            this.ProfilButton.TabIndex = 0;
            this.ProfilButton.Text = "PROFIL";
            this.ProfilButton.UseVisualStyleBackColor = true;
            this.ProfilButton.Click += new System.EventHandler(this.ProfilButton_Click);
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomePictureBox.Image")));
            this.HomePictureBox.ImageLocation = "";
            this.HomePictureBox.Location = new System.Drawing.Point(1, -2);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(255, 272);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePictureBox.TabIndex = 1;
            this.HomePictureBox.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(1, 362);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(255, 80);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(1, 448);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(255, 80);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton1.Location = new System.Drawing.Point(1, 534);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(255, 80);
            this.DeleteButton1.TabIndex = 4;
            this.DeleteButton1.Text = "DELETE";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
            // 
            // HomeTextBox
            // 
            this.HomeTextBox.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeTextBox.Location = new System.Drawing.Point(391, 387);
            this.HomeTextBox.Name = "HomeTextBox";
            this.HomeTextBox.ReadOnly = true;
            this.HomeTextBox.Size = new System.Drawing.Size(610, 55);
            this.HomeTextBox.TabIndex = 5;
            this.HomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BooksButton
            // 
            this.BooksButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BooksButton.Location = new System.Drawing.Point(1, 620);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(255, 80);
            this.BooksButton.TabIndex = 6;
            this.BooksButton.Text = "MY BOOKS";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.BooksButton);
            this.Controls.Add(this.HomeTextBox);
            this.Controls.Add(this.DeleteButton1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HomePictureBox);
            this.Controls.Add(this.ProfilButton);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ProfilButton;
        private PictureBox HomePictureBox;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton1;
        private TextBox HomeTextBox;
        private Button BooksButton;
    }
}