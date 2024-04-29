namespace ContactManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactsListView
            // 
            this.contactsListView.HideSelection = false;
            this.contactsListView.Location = new System.Drawing.Point(12, 12);
            this.contactsListView.Name = "contactsListView";
            this.contactsListView.Size = new System.Drawing.Size(435, 372);
            this.contactsListView.TabIndex = 5;
            this.contactsListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(466, 62);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(187, 44);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(466, 112);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 44);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(466, 162);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(187, 44);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "Просмотреть";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 404);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactsListView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер контактов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView contactsListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewButton;
    }
}

