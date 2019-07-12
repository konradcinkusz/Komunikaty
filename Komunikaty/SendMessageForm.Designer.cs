namespace Komunikaty
{
    partial class SendWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendWindow));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ChooseMessages = new System.Windows.Forms.TabPage();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.Komunikat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditMessageButton = new System.Windows.Forms.Button();
            this.ChooseMessageList = new System.Windows.Forms.Label();
            this.ConfirmationListCheckBox = new System.Windows.Forms.CheckBox();
            this.EnterMessages = new System.Windows.Forms.TabPage();
            this.IconGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InformationRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WarningRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.CheckBox();
            this.AddToFavourite = new System.Windows.Forms.CheckBox();
            this.ConfirmationCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.MessagesTabs = new System.Windows.Forms.TabControl();
            this.ChooseMessages.SuspendLayout();
            this.EnterMessages.SuspendLayout();
            this.IconGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MessagesTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::Komunikaty.Resource.close;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(325, 194);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 41);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::Komunikaty.Resource.ok;
            this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkButton.Location = new System.Drawing.Point(197, 194);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(122, 41);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ChooseMessages
            // 
            this.ChooseMessages.Controls.Add(this.MessagesListView);
            this.ChooseMessages.Controls.Add(this.EditMessageButton);
            this.ChooseMessages.Controls.Add(this.ChooseMessageList);
            this.ChooseMessages.Controls.Add(this.ConfirmationListCheckBox);
            this.ChooseMessages.Location = new System.Drawing.Point(4, 22);
            this.ChooseMessages.Name = "ChooseMessages";
            this.ChooseMessages.Padding = new System.Windows.Forms.Padding(3);
            this.ChooseMessages.Size = new System.Drawing.Size(437, 150);
            this.ChooseMessages.TabIndex = 1;
            this.ChooseMessages.Text = "Wybierz komunikat";
            this.ChooseMessages.UseVisualStyleBackColor = true;
            // 
            // MessagesListView
            // 
            this.MessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Komunikat,
            this.Typ,
            this.Id});
            this.MessagesListView.GridLines = true;
            this.MessagesListView.HideSelection = false;
            this.MessagesListView.Location = new System.Drawing.Point(9, 25);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(422, 74);
            this.MessagesListView.TabIndex = 6;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Details;
            // 
            // Komunikat
            // 
            this.Komunikat.Text = "Komunikat";
            this.Komunikat.Width = 256;
            // 
            // Typ
            // 
            this.Typ.Text = "Typ";
            this.Typ.Width = 122;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 38;
            // 
            // EditMessageButton
            // 
            this.EditMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditMessageButton.Image = global::Komunikaty.Resource.edit;
            this.EditMessageButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.EditMessageButton.Location = new System.Drawing.Point(181, 105);
            this.EditMessageButton.Name = "EditMessageButton";
            this.EditMessageButton.Size = new System.Drawing.Size(250, 42);
            this.EditMessageButton.TabIndex = 5;
            this.EditMessageButton.Text = "Edytuj wiadomość";
            this.EditMessageButton.UseVisualStyleBackColor = true;
            this.EditMessageButton.Click += new System.EventHandler(this.EditMessageButton_Click);
            // 
            // ChooseMessageList
            // 
            this.ChooseMessageList.AutoSize = true;
            this.ChooseMessageList.Location = new System.Drawing.Point(6, 6);
            this.ChooseMessageList.Name = "ChooseMessageList";
            this.ChooseMessageList.Size = new System.Drawing.Size(76, 13);
            this.ChooseMessageList.TabIndex = 4;
            this.ChooseMessageList.Text = "Wybierz z listy:";
            // 
            // ConfirmationListCheckBox
            // 
            this.ConfirmationListCheckBox.AutoSize = true;
            this.ConfirmationListCheckBox.Location = new System.Drawing.Point(6, 105);
            this.ConfirmationListCheckBox.Name = "ConfirmationListCheckBox";
            this.ConfirmationListCheckBox.Size = new System.Drawing.Size(138, 17);
            this.ConfirmationListCheckBox.TabIndex = 3;
            this.ConfirmationListCheckBox.Text = "Wymagaj potwierdzenia";
            this.ConfirmationListCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnterMessages
            // 
            this.EnterMessages.Controls.Add(this.IconGroupBox);
            this.EnterMessages.Controls.Add(this.Save);
            this.EnterMessages.Controls.Add(this.AddToFavourite);
            this.EnterMessages.Controls.Add(this.ConfirmationCheckBox);
            this.EnterMessages.Controls.Add(this.MessageTextBox);
            this.EnterMessages.Controls.Add(this.Message);
            this.EnterMessages.Location = new System.Drawing.Point(4, 22);
            this.EnterMessages.Name = "EnterMessages";
            this.EnterMessages.Padding = new System.Windows.Forms.Padding(3);
            this.EnterMessages.Size = new System.Drawing.Size(437, 150);
            this.EnterMessages.TabIndex = 0;
            this.EnterMessages.Text = "Wprowadź komunikat";
            this.EnterMessages.UseVisualStyleBackColor = true;
            // 
            // IconGroupBox
            // 
            this.IconGroupBox.Controls.Add(this.pictureBox3);
            this.IconGroupBox.Controls.Add(this.InformationRadioButton);
            this.IconGroupBox.Controls.Add(this.pictureBox2);
            this.IconGroupBox.Controls.Add(this.WarningRadioButton);
            this.IconGroupBox.Controls.Add(this.pictureBox1);
            this.IconGroupBox.Controls.Add(this.ErrorRadioButton);
            this.IconGroupBox.Controls.Add(this.NoneRadioButton);
            this.IconGroupBox.Location = new System.Drawing.Point(9, 90);
            this.IconGroupBox.Name = "IconGroupBox";
            this.IconGroupBox.Size = new System.Drawing.Size(422, 54);
            this.IconGroupBox.TabIndex = 5;
            this.IconGroupBox.TabStop = false;
            this.IconGroupBox.Text = "Wybierz typ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Komunikaty.Resource.information;
            this.pictureBox3.Location = new System.Drawing.Point(362, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 38);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // InformationRadioButton
            // 
            this.InformationRadioButton.AutoSize = true;
            this.InformationRadioButton.Location = new System.Drawing.Point(282, 19);
            this.InformationRadioButton.Name = "InformationRadioButton";
            this.InformationRadioButton.Size = new System.Drawing.Size(74, 17);
            this.InformationRadioButton.TabIndex = 5;
            this.InformationRadioButton.Text = "Informacja";
            this.InformationRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Komunikaty.Resource.warning;
            this.pictureBox2.Location = new System.Drawing.Point(242, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // WarningRadioButton
            // 
            this.WarningRadioButton.AutoSize = true;
            this.WarningRadioButton.Location = new System.Drawing.Point(156, 20);
            this.WarningRadioButton.Name = "WarningRadioButton";
            this.WarningRadioButton.Size = new System.Drawing.Size(80, 17);
            this.WarningRadioButton.TabIndex = 3;
            this.WarningRadioButton.Text = "Ostrzeżenie";
            this.WarningRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Komunikaty.Resource.error;
            this.pictureBox1.Location = new System.Drawing.Point(115, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorRadioButton
            // 
            this.ErrorRadioButton.AutoSize = true;
            this.ErrorRadioButton.Location = new System.Drawing.Point(61, 20);
            this.ErrorRadioButton.Name = "ErrorRadioButton";
            this.ErrorRadioButton.Size = new System.Drawing.Size(48, 17);
            this.ErrorRadioButton.TabIndex = 1;
            this.ErrorRadioButton.Text = "Błąd";
            this.ErrorRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Checked = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(7, 20);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(47, 17);
            this.NoneRadioButton.TabIndex = 0;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "Brak";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Location = new System.Drawing.Point(154, 46);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(57, 17);
            this.Save.TabIndex = 4;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // AddToFavourite
            // 
            this.AddToFavourite.AutoSize = true;
            this.AddToFavourite.Location = new System.Drawing.Point(217, 46);
            this.AddToFavourite.Name = "AddToFavourite";
            this.AddToFavourite.Size = new System.Drawing.Size(123, 17);
            this.AddToFavourite.TabIndex = 3;
            this.AddToFavourite.Text = "Dodaj do ulubionych";
            this.AddToFavourite.UseVisualStyleBackColor = true;
            // 
            // ConfirmationCheckBox
            // 
            this.ConfirmationCheckBox.AutoSize = true;
            this.ConfirmationCheckBox.Location = new System.Drawing.Point(10, 46);
            this.ConfirmationCheckBox.Name = "ConfirmationCheckBox";
            this.ConfirmationCheckBox.Size = new System.Drawing.Size(138, 17);
            this.ConfirmationCheckBox.TabIndex = 2;
            this.ConfirmationCheckBox.Text = "Wymagaj potwierdzenia";
            this.ConfirmationCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.MessageTextBox.Location = new System.Drawing.Point(7, 20);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(424, 20);
            this.MessageTextBox.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(6, 3);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(57, 13);
            this.Message.TabIndex = 0;
            this.Message.Text = "Komunikat";
            // 
            // MessagesTabs
            // 
            this.MessagesTabs.Controls.Add(this.EnterMessages);
            this.MessagesTabs.Controls.Add(this.ChooseMessages);
            this.MessagesTabs.Location = new System.Drawing.Point(12, 12);
            this.MessagesTabs.Name = "MessagesTabs";
            this.MessagesTabs.SelectedIndex = 0;
            this.MessagesTabs.Size = new System.Drawing.Size(445, 176);
            this.MessagesTabs.TabIndex = 0;
            // 
            // SendWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 247);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MessagesTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendWindow";
            this.Text = "Komunikat do wysłania";
            this.ChooseMessages.ResumeLayout(false);
            this.ChooseMessages.PerformLayout();
            this.EnterMessages.ResumeLayout(false);
            this.EnterMessages.PerformLayout();
            this.IconGroupBox.ResumeLayout(false);
            this.IconGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MessagesTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.TabPage ChooseMessages;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.ColumnHeader Komunikat;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button EditMessageButton;
        private System.Windows.Forms.Label ChooseMessageList;
        private System.Windows.Forms.CheckBox ConfirmationListCheckBox;
        private System.Windows.Forms.TabPage EnterMessages;
        private System.Windows.Forms.GroupBox IconGroupBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton InformationRadioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton WarningRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton ErrorRadioButton;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.CheckBox Save;
        private System.Windows.Forms.CheckBox AddToFavourite;
        private System.Windows.Forms.CheckBox ConfirmationCheckBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TabControl MessagesTabs;
    }
}

