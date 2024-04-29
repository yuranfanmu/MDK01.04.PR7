using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация списка контактов
            PopulateContactsListView();
        }

        private void PopulateContactsListView()
        {
            contactsListView.Items.Clear();

            foreach (var contact in contacts)
            {
                ListViewItem item = new ListViewItem(contact.FirstName);
                item.SubItems.Add(contact.LastName);
                item.SubItems.Add(contact.PhoneNumber);
                item.SubItems.Add(contact.Email);
                item.Tag = contact; // Сохраняем контакт в свойстве Tag для последующего доступа

                contactsListView.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Открываем форму для добавления нового контакта
            AddEditContactForm addForm = new AddEditContactForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(addForm.NewContact);
                PopulateContactsListView();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (contactsListView.SelectedItems.Count > 0)
            {
                Contact selectedContact = (Contact)contactsListView.SelectedItems[0].Tag;
                AddEditContactForm editForm = new AddEditContactForm(selectedContact);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем контакт в списке
                    int index = contacts.IndexOf(selectedContact);
                    contacts[index] = editForm.NewContact;
                    PopulateContactsListView();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contactsListView.SelectedItems.Count > 0)
            {
                Contact selectedContact = (Contact)contactsListView.SelectedItems[0].Tag;
                contacts.Remove(selectedContact);
                PopulateContactsListView();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (contactsListView.SelectedItems.Count > 0)
            {
                Contact selectedContact = (Contact)contactsListView.SelectedItems[0].Tag;
                ViewContactForm viewForm = new ViewContactForm(selectedContact);
                viewForm.ShowDialog();
            }
        }
    }

    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}