using DataAccess;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
    public partial class MyBooks : Form
    {
        private DBContext db;
        public MyBooks()
        {
            InitializeComponent();
            db = new DBContext();
            Refresh();

        }


        private void BackMyBooksButton_Click(object sender, EventArgs e)
        {
            Home backMyBooks = new Home();
            backMyBooks.Show();
            this.Hide();
        }

        private void Refresh()
        {
            BindingSource bi = new BindingSource();
            var query = from b in db.Book orderby b.ID_book  select new { b.ID_book, Title = b.book_name, Author = b.author, Start_Date = b.start_date, End_Date = b.end_date, Type = b.type, Rating = b.rating };
            bi.DataSource = query.ToList();
            MyBooksDataGridView.DataSource = bi;
            MyBooksDataGridView.Refresh();
        }


    }
}
