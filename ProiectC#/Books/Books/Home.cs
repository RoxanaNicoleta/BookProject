using DataAccess;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Books
{
    public partial class Home : Form
    {
        private DBContext db;
        public Home()
        {
            InitializeComponent();
            db = new DBContext();
            BindingSource bi = new BindingSource();
            var query = from b in db.Book orderby b.ID_book select new { b.ID_book };
            bi.DataSource = query.ToList();

            if (bi.Count == 1)
            {
                HomeTextBox.Text = "You have read a book so far. Keep going!";
            }
            else
            {
                HomeTextBox.Text = "You have read " + bi.Count + " books so far. Keep going!";
            }

        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            MyBooks myBooks = new MyBooks();
            myBooks.Show();
            this.Hide();
            // MessageBox.Show("da");
        }



        private void ProfilButton_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Hide();

        }




       
    }
}