using System;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class ViewContactForm : Form
    {
        public ViewContactForm(Contact contact)
        {
            InitializeComponent();

            firstNameLabel.Text = contact.FirstName;
            lastNameLabel.Text = contact.LastName;
            phoneNumberLabel.Text = contact.PhoneNumber;
            emailLabel.Text = contact.Email;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
