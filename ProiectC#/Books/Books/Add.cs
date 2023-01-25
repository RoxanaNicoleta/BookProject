using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Add : Form
    {
        private DbContext db;
        public Add()
        {
            InitializeComponent();
            db = new DBContext();
        }

        private void BackAddButton_Click(object sender, EventArgs e)
        {
            Home backAdd = new Home();
            backAdd.Show();
            this.Hide();
        }

        private void DoneAddButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(TitleAddTextBox.Text))
                {
                    MessageBox.Show("The title field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(AuthorAddTextBox.Text))
                {
                    MessageBox.Show("The author field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(TypeAddTextBox.Text))
                {
                    MessageBox.Show("The type field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(RatingAddTextBox.Text))
                {
                    MessageBox.Show("The rating field must not be empty.", "Error");
                }
                else
                {
                    string message = "Do you want to add this book?";
                    string title1 = "Add";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title1, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string title = TitleAddTextBox.Text;
                        string author = AuthorAddTextBox.Text;
                        var startDate = StartDateAddDateTimePicker.Value;
                        var endDate = EndDateAddDateTimePicker.Value;
                        string type = TypeAddTextBox.Text;
                        string rating = RatingAddTextBox.Text;
                        var BookAdd = new Book() { book_name = title, author = author, start_date = startDate.ToString(), end_date = endDate.ToString(), type = type, rating = rating };
                        db.Add(BookAdd);
                        db.SaveChanges();

                    }
                    else
                    {

                    }
                }

            }catch(Exception ex) { MessageBox.Show(ex.Message); };
        }
        
        
    }
}
