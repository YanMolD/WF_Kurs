namespace WF_Kurs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxNewNum = new System.Windows.Forms.TextBox();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAcceptCh = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAcceptAdd = new System.Windows.Forms.Button();
            this.buttonVCard = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.buttonAddNumber = new System.Windows.Forms.Button();
            this.buttonAddEmail = new System.Windows.Forms.Button();
            this.buttonCancelAddNum = new System.Windows.Forms.Button();
            this.buttonCancelAddEm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 20;
            this.listBoxContacts.Location = new System.Drawing.Point(13, 13);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.ScrollAlwaysVisible = true;
            this.listBoxContacts.Size = new System.Drawing.Size(327, 164);
            this.listBoxContacts.TabIndex = 0;
            this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.ListBoxContacts_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(491, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxName.Size = new System.Drawing.Size(155, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(491, 42);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.ReadOnly = true;
            this.textBoxAdress.Size = new System.Drawing.Size(155, 26);
            this.textBoxAdress.TabIndex = 2;
            this.textBoxAdress.TextChanged += new System.EventHandler(this.TextBoxAdress_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(347, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(114, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя контакта";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(347, 45);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(140, 20);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Домашний адрес";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(347, 79);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(132, 20);
            this.labelNum.TabIndex = 6;
            this.labelNum.Text = "Список номеров";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(649, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(128, 20);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Дата рождения";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(649, 45);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(127, 20);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Список Email\'ов";
            // 
            // textBoxDate
            // 
            this.textBoxDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDate.Location = new System.Drawing.Point(783, 10);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(155, 26);
            this.textBoxDate.TabIndex = 9;
            this.textBoxDate.Text = "YYYY-DD-MM";
            this.textBoxDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxDate_MouseClick);
            this.textBoxDate.TextChanged += new System.EventHandler(this.TextBoxDate_TextChanged);
            // 
            // textBoxNewNum
            // 
            this.textBoxNewNum.Location = new System.Drawing.Point(491, 184);
            this.textBoxNewNum.Name = "textBoxNewNum";
            this.textBoxNewNum.ReadOnly = true;
            this.textBoxNewNum.Size = new System.Drawing.Size(155, 26);
            this.textBoxNewNum.TabIndex = 11;
            this.textBoxNewNum.Text = "Добавить номер...";
            this.textBoxNewNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxNewNum_MouseClick);
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.Location = new System.Drawing.Point(783, 155);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.ReadOnly = true;
            this.textBoxNewEmail.Size = new System.Drawing.Size(155, 26);
            this.textBoxNewEmail.TabIndex = 12;
            this.textBoxNewEmail.Text = "Добавить Email...";
            this.textBoxNewEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxNewEmail_MouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(13, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(164, 39);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить контакт";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(13, 229);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(164, 39);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить контакт";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonAcceptCh
            // 
            this.buttonAcceptCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAcceptCh.Location = new System.Drawing.Point(183, 229);
            this.buttonAcceptCh.Name = "buttonAcceptCh";
            this.buttonAcceptCh.Size = new System.Drawing.Size(157, 39);
            this.buttonAcceptCh.TabIndex = 15;
            this.buttonAcceptCh.Text = "Подтвердить";
            this.buttonAcceptCh.UseVisualStyleBackColor = true;
            this.buttonAcceptCh.Visible = false;
            this.buttonAcceptCh.Click += new System.EventHandler(this.ButtonAcceptCh_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(183, 184);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(157, 39);
            this.buttonChange.TabIndex = 16;
            this.buttonChange.Text = "Редактировать";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // buttonAcceptAdd
            // 
            this.buttonAcceptAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAcceptAdd.Location = new System.Drawing.Point(183, 229);
            this.buttonAcceptAdd.Name = "buttonAcceptAdd";
            this.buttonAcceptAdd.Size = new System.Drawing.Size(157, 39);
            this.buttonAcceptAdd.TabIndex = 17;
            this.buttonAcceptAdd.Text = "Подтвердить";
            this.buttonAcceptAdd.UseVisualStyleBackColor = true;
            this.buttonAcceptAdd.Visible = false;
            this.buttonAcceptAdd.Click += new System.EventHandler(this.ButtonAcceptAdd_Click);
            // 
            // buttonVCard
            // 
            this.buttonVCard.Location = new System.Drawing.Point(13, 274);
            this.buttonVCard.Name = "buttonVCard";
            this.buttonVCard.Size = new System.Drawing.Size(327, 39);
            this.buttonVCard.TabIndex = 18;
            this.buttonVCard.Text = "Экспортировать контакт";
            this.buttonVCard.UseVisualStyleBackColor = true;
            this.buttonVCard.Click += new System.EventHandler(this.ButtonVCard_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.HorizontalScrollbar = true;
            this.listBoxNumbers.ItemHeight = 20;
            this.listBoxNumbers.Location = new System.Drawing.Point(491, 74);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(155, 104);
            this.listBoxNumbers.TabIndex = 19;
            this.listBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.ListBoxNumbers_SelectedIndexChanged);
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.HorizontalScrollbar = true;
            this.listBoxEmails.ItemHeight = 20;
            this.listBoxEmails.Location = new System.Drawing.Point(783, 45);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(155, 104);
            this.listBoxEmails.TabIndex = 20;
            this.listBoxEmails.SelectedIndexChanged += new System.EventHandler(this.ListBoxEmails_SelectedIndexChanged);
            // 
            // buttonAddNumber
            // 
            this.buttonAddNumber.Location = new System.Drawing.Point(489, 216);
            this.buttonAddNumber.Name = "buttonAddNumber";
            this.buttonAddNumber.Size = new System.Drawing.Size(160, 37);
            this.buttonAddNumber.TabIndex = 21;
            this.buttonAddNumber.Text = "Подтвердить";
            this.buttonAddNumber.UseVisualStyleBackColor = true;
            this.buttonAddNumber.Click += new System.EventHandler(this.ButtonAddNum_Click);
            // 
            // buttonAddEmail
            // 
            this.buttonAddEmail.Location = new System.Drawing.Point(778, 187);
            this.buttonAddEmail.Name = "buttonAddEmail";
            this.buttonAddEmail.Size = new System.Drawing.Size(160, 37);
            this.buttonAddEmail.TabIndex = 22;
            this.buttonAddEmail.Text = "Подтвердить";
            this.buttonAddEmail.UseVisualStyleBackColor = true;
            this.buttonAddEmail.Click += new System.EventHandler(this.ButtonAddEm_Click);
            // 
            // buttonCancelAddNum
            // 
            this.buttonCancelAddNum.Location = new System.Drawing.Point(489, 259);
            this.buttonCancelAddNum.Name = "buttonCancelAddNum";
            this.buttonCancelAddNum.Size = new System.Drawing.Size(160, 37);
            this.buttonCancelAddNum.TabIndex = 23;
            this.buttonCancelAddNum.Text = "Отмена";
            this.buttonCancelAddNum.UseVisualStyleBackColor = true;
            this.buttonCancelAddNum.Visible = false;
            this.buttonCancelAddNum.Click += new System.EventHandler(this.ButtonCancelAddNum_Click);
            // 
            // buttonCancelAddEm
            // 
            this.buttonCancelAddEm.Location = new System.Drawing.Point(778, 230);
            this.buttonCancelAddEm.Name = "buttonCancelAddEm";
            this.buttonCancelAddEm.Size = new System.Drawing.Size(160, 37);
            this.buttonCancelAddEm.TabIndex = 24;
            this.buttonCancelAddEm.Text = "Отмена";
            this.buttonCancelAddEm.UseVisualStyleBackColor = true;
            this.buttonCancelAddEm.Visible = false;
            this.buttonCancelAddEm.Click += new System.EventHandler(this.ButtonCancelAddEm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 610);
            this.Controls.Add(this.buttonCancelAddEm);
            this.Controls.Add(this.buttonCancelAddNum);
            this.Controls.Add(this.buttonAddEmail);
            this.Controls.Add(this.buttonAddNumber);
            this.Controls.Add(this.listBoxEmails);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.buttonVCard);
            this.Controls.Add(this.buttonAcceptAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAcceptCh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewEmail);
            this.Controls.Add(this.textBoxNewNum);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxContacts);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxNewNum;
        private System.Windows.Forms.TextBox textBoxNewEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAcceptCh;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAcceptAdd;
        private System.Windows.Forms.Button buttonVCard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.Button buttonAddNumber;
        private System.Windows.Forms.Button buttonAddEmail;
        private System.Windows.Forms.Button buttonCancelAddNum;
        private System.Windows.Forms.Button buttonCancelAddEm;
    }
}

