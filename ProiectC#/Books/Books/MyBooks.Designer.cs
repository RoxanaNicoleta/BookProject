namespace Books
{
    partial class MyBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBooks));
            this.MyBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.BackMyBooksButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyBooksDataGridView
            // 
            this.MyBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MyBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyBooksDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyBooksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MyBooksDataGridView.Name = "MyBooksDataGridView";
            this.MyBooksDataGridView.RowHeadersWidth = 51;
            this.MyBooksDataGridView.RowTemplate.Height = 29;
            this.MyBooksDataGridView.Size = new System.Drawing.Size(1182, 431);
            this.MyBooksDataGridView.TabIndex = 0;
            // 
            // BackMyBooksButton
            // 
            this.BackMyBooksButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackMyBooksButton.Location = new System.Drawing.Point(525, 561);
            this.BackMyBooksButton.Name = "BackMyBooksButton";
            this.BackMyBooksButton.Size = new System.Drawing.Size(120, 40);
            this.BackMyBooksButton.TabIndex = 1;
            this.BackMyBooksButton.Text = "Back";
            this.BackMyBooksButton.UseVisualStyleBackColor = true;
            this.BackMyBooksButton.Click += new System.EventHandler(this.BackMyBooksButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackMyBooksButton);
            this.Controls.Add(this.MyBooksDataGridView);
            this.Name = "MyBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBooks";
            ((System.ComponentModel.ISupportInitialize)(this.MyBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView MyBooksDataGridView;
        private Button BackMyBooksButton;
        private PictureBox pictureBox1;
    }
}