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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            FirstNameTextBox.Text = "Roxana-Nicoleta";
            LastNameTextBox.Text = "Arsene";
            AdressTextBox.Text = "Str.Berecheti, nr. 6A, jud. Arges";
            BirthdayDateTimePicker.Text = "20.08.2001";
            NumberTextBox.Text = "20";
        }

        private void BackProfilButton_Click(object sender, EventArgs e)
        {
            Home homeMyBooks = new Home();
            homeMyBooks.Show();
            this.Hide();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

       
    }
}
