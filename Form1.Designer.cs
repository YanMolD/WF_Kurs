namespace WF_Kurs
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(327, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(491, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxName.Size = new System.Drawing.Size(155, 26);
            this.textBoxName.TabIndex = 1;
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
            this.textBoxDate.Text = "DD.MM.YYYY";
            this.textBoxDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxDate_MouseClick);
            this.textBoxDate.TextChanged += new System.EventHandler(this.TextBoxDate_TextChanged);
            // 
            // textBoxNewNum
            // 
            this.textBoxNewNum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNewNum.Location = new System.Drawing.Point(491, 76);
            this.textBoxNewNum.Name = "textBoxNewNum";
            this.textBoxNewNum.ReadOnly = true;
            this.textBoxNewNum.Size = new System.Drawing.Size(155, 26);
            this.textBoxNewNum.TabIndex = 11;
            this.textBoxNewNum.Text = "Добавить номер...";
            this.textBoxNewNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxNewNum_MouseClick);
            this.textBoxNewNum.TextChanged += new System.EventHandler(this.TextBoxNewNum_TextChanged);
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNewEmail.Location = new System.Drawing.Point(783, 45);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.ReadOnly = true;
            this.textBoxNewEmail.Size = new System.Drawing.Size(155, 26);
            this.textBoxNewEmail.TabIndex = 12;
            this.textBoxNewEmail.Text = "Добавить Email...";
            this.textBoxNewEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxNewEmail_MouseClick);
            this.textBoxNewEmail.TextChanged += new System.EventHandler(this.TextBoxNewEmail_TextChanged);
            // 
            // buttonAdd
            // 
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
            this.buttonAcceptAdd.Location = new System.Drawing.Point(183, 229);
            this.buttonAcceptAdd.Name = "buttonAcceptAdd";
            this.buttonAcceptAdd.Size = new System.Drawing.Size(157, 39);
            this.buttonAcceptAdd.TabIndex = 17;
            this.buttonAcceptAdd.Text = "Подтвердить";
            this.buttonAcceptAdd.UseVisualStyleBackColor = true;
            this.buttonAcceptAdd.Visible = false;
            this.buttonAcceptAdd.Click += new System.EventHandler(this.ButtonAcceptAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 610);
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
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

