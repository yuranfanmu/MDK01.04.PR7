using System;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class AddEditContactForm : Form
    {
        public Contact NewContact { get; private set; }

        public AddEditContactForm(Contact existingContact = null)
        {
            InitializeComponent();

            if (existingContact != null)
            {
                firstNameTextBox.Text = existingContact.FirstName;
                lastNameTextBox.Text = existingContact.LastName;
                phoneNumberTextBox.Text = existingContact.PhoneNumber;
                emailTextBox.Text = existingContact.Email;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Создаем новый контакт с данными из формы
            NewContact = new Contact
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Email = emailTextBox.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddEditContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
