using DataAccess;
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
    public partial class Edit : Form
    {
        private DBContext db;
        public Edit()
        {
            InitializeComponent();
            db = new DBContext();
        }

        private void BackEditButton_Click(object sender, EventArgs e)
        {
            Home backEdit = new Home();
            backEdit.Show();
            this.Hide();
        }

        private void DoneEditButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(TitleEditTextBox.Text))
                {
                    MessageBox.Show("The title field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(AuthorEditTextBox.Text))
                {
                    MessageBox.Show("The author field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(TypeEditTextBox.Text))
                {
                    MessageBox.Show("The type field must not be empty.", "Error");
                }
                else if (string.IsNullOrEmpty(RatingEditTextBox.Text))
                {
                    MessageBox.Show("The rating field must not be empty.", "Error");
                }
                else
                {
                    string message = "Do you want to edit this book?";
                    string title = "Edit";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string id = IdEditTextBox.Text;
                        var Object = db.Book.FirstOrDefault(x => x.ID_book == Int32.Parse(id));
                        Object.book_name = TitleEditTextBox.Text;
                        Object.author = AuthorEditTextBox.Text;
                        Object.start_date = StartDateEditDateTimePicker.Text;
                        Object.end_date = EndDateEditDateTimePicker.Text;
                        Object.type = TypeEditTextBox.Text;
                        Object.rating = RatingEditTextBox.Text;
                        db.Update(Object);
                        db.SaveChanges();


                    }
                    else
                    {

                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Book GetId(string id)
        {
                Book? t = null;
                try
                {
                    t = db.Book.Find(Int32.Parse(id));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return t;
 
        }

        private void OkEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id =IdEditTextBox.Text;
                var Object = GetId(id);
                var Object1 = db.Book.FirstOrDefault(x => x.ID_book == Int32.Parse(id));
                if (Object1 != null)
                {
                    TitleEditTextBox.Text = Object.book_name;
                    AuthorEditTextBox.Text = Object.author;
                    StartDateEditDateTimePicker.Text = Object.start_date;
                    EndDateEditDateTimePicker.Text = Object.end_date;
                    TypeEditTextBox.Text = Object.type;
                    RatingEditTextBox.Text = Object.rating;
                }
                else
                {
                    MessageBox.Show("ID doesn't exist. Add a valid ID.", "Error");
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
