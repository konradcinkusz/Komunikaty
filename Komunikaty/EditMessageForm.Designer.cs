namespace Komunikaty
{
    partial class EditMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMessages));
            this.MessagesListViewEdit = new System.Windows.Forms.ListView();
            this.Komunikaty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OldValueLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NewValueLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Properties = new System.Windows.Forms.GroupBox();
            this.ConfirmationRequired = new System.Windows.Forms.CheckBox();
            this.Confirmed = new System.Windows.Forms.CheckBox();
            this.Favourite = new System.Windows.Forms.CheckBox();
            this.IconGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InformationRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WarningRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Properties.SuspendLayout();
            this.IconGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessagesListViewEdit
            // 
            this.MessagesListViewEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Komunikaty,
            this.Typ,
            this.Id});
            this.MessagesListViewEdit.GridLines = true;
            this.MessagesListViewEdit.HideSelection = false;
            this.MessagesListViewEdit.Location = new System.Drawing.Point(12, 12);
            this.MessagesListViewEdit.Name = "MessagesListViewEdit";
            this.MessagesListViewEdit.Size = new System.Drawing.Size(422, 117);
            this.MessagesListViewEdit.TabIndex = 0;
            this.MessagesListViewEdit.UseCompatibleStateImageBehavior = false;
            this.MessagesListViewEdit.View = System.Windows.Forms.View.Details;
            // 
            // Komunikaty
            // 
            this.Komunikaty.Text = "Komunikaty";
            this.Komunikaty.Width = 239;
            // 
            // Typ
            // 
            this.Typ.Text = "Typ";
            this.Typ.Width = 115;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // OldValueLabel
            // 
            this.OldValueLabel.AutoSize = true;
            this.OldValueLabel.Location = new System.Drawing.Point(12, 136);
            this.OldValueLabel.Name = "OldValueLabel";
            this.OldValueLabel.Size = new System.Drawing.Size(83, 13);
            this.OldValueLabel.TabIndex = 1;
            this.OldValueLabel.Text = "Stary komunikat";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 3;
            // 
            // NewValueLabel
            // 
            this.NewValueLabel.AutoSize = true;
            this.NewValueLabel.Location = new System.Drawing.Point(238, 137);
            this.NewValueLabel.Name = "NewValueLabel";
            this.NewValueLabel.Size = new System.Drawing.Size(87, 13);
            this.NewValueLabel.TabIndex = 2;
            this.NewValueLabel.Text = "Nowa komunikat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Properties
            // 
            this.Properties.Controls.Add(this.ConfirmationRequired);
            this.Properties.Controls.Add(this.Confirmed);
            this.Properties.Controls.Add(this.Favourite);
            this.Properties.Location = new System.Drawing.Point(15, 179);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(419, 56);
            this.Properties.TabIndex = 5;
            this.Properties.TabStop = false;
            this.Properties.Text = "Właściwości";
            // 
            // ConfirmationRequired
            // 
            this.ConfirmationRequired.AutoSize = true;
            this.ConfirmationRequired.Location = new System.Drawing.Point(164, 20);
            this.ConfirmationRequired.Name = "ConfirmationRequired";
            this.ConfirmationRequired.Size = new System.Drawing.Size(144, 17);
            this.ConfirmationRequired.TabIndex = 6;
            this.ConfirmationRequired.Text = "Potwierdzone wymagane";
            this.ConfirmationRequired.UseVisualStyleBackColor = true;
            // 
            // Confirmed
            // 
            this.Confirmed.AutoSize = true;
            this.Confirmed.Location = new System.Drawing.Point(78, 19);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(90, 17);
            this.Confirmed.TabIndex = 5;
            this.Confirmed.Text = "Potwierdzone";
            this.Confirmed.UseVisualStyleBackColor = true;
            // 
            // Favourite
            // 
            this.Favourite.AutoSize = true;
            this.Favourite.Location = new System.Drawing.Point(4, 19);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(68, 17);
            this.Favourite.TabIndex = 4;
            this.Favourite.Text = "Ulubione";
            this.Favourite.UseVisualStyleBackColor = true;
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
            this.IconGroupBox.Location = new System.Drawing.Point(12, 241);
            this.IconGroupBox.Name = "IconGroupBox";
            this.IconGroupBox.Size = new System.Drawing.Size(422, 54);
            this.IconGroupBox.TabIndex = 6;
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
            this.NoneRadioButton.Location = new System.Drawing.Point(7, 20);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(47, 17);
            this.NoneRadioButton.TabIndex = 0;
            this.NoneRadioButton.Text = "Brak";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Image = global::Komunikaty.Resource.ok;
            this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkButton.Location = new System.Drawing.Point(176, 308);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(122, 41);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::Komunikaty.Resource.close;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(304, 308);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 41);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyButton.Location = new System.Drawing.Point(12, 308);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(122, 41);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Zastosuj";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // EditMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.IconGroupBox);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewValueLabel);
            this.Controls.Add(this.OldValueLabel);
            this.Controls.Add(this.MessagesListViewEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMessages";
            this.Text = "Edycja wiadomości";
            this.Properties.ResumeLayout(false);
            this.Properties.PerformLayout();
            this.IconGroupBox.ResumeLayout(false);
            this.IconGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MessagesListViewEdit;
        private System.Windows.Forms.Label OldValueLabel;
        private System.Windows.Forms.ColumnHeader Komunikaty;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NewValueLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox Properties;
        private System.Windows.Forms.GroupBox IconGroupBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton InformationRadioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton WarningRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton ErrorRadioButton;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.CheckBox Confirmed;
        private System.Windows.Forms.CheckBox Favourite;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.CheckBox ConfirmationRequired;
    }
}