namespace Books
{
    partial class Delete
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
            this.DeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.DoneDeleteButton = new System.Windows.Forms.Button();
            this.BackDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDataGridView
            // 
            this.DeleteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataGridView.Location = new System.Drawing.Point(1, 1);
            this.DeleteDataGridView.Name = "DeleteDataGridView";
            this.DeleteDataGridView.RowHeadersWidth = 51;
            this.DeleteDataGridView.RowTemplate.Height = 29;
            this.DeleteDataGridView.Size = new System.Drawing.Size(1181, 329);
            this.DeleteDataGridView.TabIndex = 0;
            // 
            // DoneDeleteButton
            // 
            this.DoneDeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoneDeleteButton.Location = new System.Drawing.Point(312, 597);
            this.DoneDeleteButton.Name = "DoneDeleteButton";
            this.DoneDeleteButton.Size = new System.Drawing.Size(120, 40);
            this.DoneDeleteButton.TabIndex = 1;
            this.DoneDeleteButton.Text = "Done";
            this.DoneDeleteButton.UseVisualStyleBackColor = true;
            this.DoneDeleteButton.Click += new System.EventHandler(this.DoneDeleteButton_Click);
            // 
            // BackDeleteButton
            // 
            this.BackDeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackDeleteButton.Location = new System.Drawing.Point(746, 597);
            this.BackDeleteButton.Name = "BackDeleteButton";
            this.BackDeleteButton.Size = new System.Drawing.Size(120, 40);
            this.BackDeleteButton.TabIndex = 2;
            this.BackDeleteButton.Text = "Back";
            this.BackDeleteButton.UseVisualStyleBackColor = true;
            this.BackDeleteButton.Click += new System.EventHandler(this.BackDeleteButton_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.BackDeleteButton);
            this.Controls.Add(this.DoneDeleteButton);
            this.Controls.Add(this.DeleteDataGridView);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DeleteDataGridView;
        private Button DoneDeleteButton;
        private Button BackDeleteButton;
    }
}