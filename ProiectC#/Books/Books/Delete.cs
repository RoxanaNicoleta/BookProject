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
    public partial class Delete : Form
    {
        private DBContext db;
        public Delete()
        {
            InitializeComponent();
            db = new DBContext();
            Refresh();
        }

        private void BackDeleteButton_Click(object sender, EventArgs e)
        {
            Home backDelete = new Home();
            backDelete.Show();
            this.Hide();
        }

        private Book getId()
        {
            Book? t=null;
            try
            {
                t = db.Book.Find((int)DeleteDataGridView.SelectedCells[0].Value);
               
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
            return t;
        }

        private void Refresh()
        {
            try
            {
                BindingSource bi = new BindingSource();
                var query = from b in db.Book orderby b.ID_book select new { b.ID_book, Title = b.book_name, Author = b.author, Start_Date = b.start_date, End_Date = b.end_date, Type = b.type, Rating = b.rating };
                bi.DataSource = query.ToList();
                DeleteDataGridView.DataSource = bi;
                DeleteDataGridView.Refresh();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DoneDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getId().ID_book;
                var Object = db.Book.FirstOrDefault(x => x.ID_book == id);
                string message = "Do you want to delete this book?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    db.Remove(Object);
                    db.SaveChanges();


                }
                else
                {

                }

                Refresh();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
