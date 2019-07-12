using Komunikaty.Interfaces;
using Komunikaty.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Komunikaty
{
    public partial class EditMessages : Form
    {
        private IMessages messagesDataAccess;
        private SendWindow mainForm = null;
        public EditMessages(Form callingForm, IMessages messagesDataAccess, string deafultMessage = "")
        {
            if(callingForm is SendWindow)
                mainForm = (SendWindow)callingForm;
            this.messagesDataAccess = messagesDataAccess;
            InitializeComponent();
            InitializeEntryData();
            if (deafultMessage != "")
            {
                int i = 0;
                MessagesListViewEdit.FocusedItem = MessagesListViewEdit.Items[0];
                foreach(var item in MessagesListViewEdit.Items)
                {
                    if (((ListViewItem)item).Text == deafultMessage)
                        break;
                    i++;
                }
                MessagesListViewEdit.Items[i].Selected = true;
                MessagesListViewEdit.Items[i].Focused = true;
                MessagesListViewEdit.Select();
                MessagesListViewEdit.HideSelection = false;
                MessagesListViewEdit.EnsureVisible(i);
                
            }
        }

        private void InitializeEntryData()
        {
            foreach (IMessage message in messagesDataAccess.GetAllMessage())
            {
                string[] row = { message.Content, new MessageTypeMapping(message.MessageType).ToString(), message.Id.ToString() };
                var listViewItem = new ListViewItem(row);
                MessagesListViewEdit.Items.Add(listViewItem);
            }
            MessagesListViewEdit.Click += MessagesListViewEdit_Click;
        }
        private void MessagesListViewEdit_Click(object sender, EventArgs e)
        {
            IMessage message;
            int messageId;
            int.TryParse(MessagesListViewEdit.SelectedItems[0].SubItems[2].Text, out messageId);
            message = messagesDataAccess.GetMessage(messageId);
            textBox1.Text = message.Content;
            Favourite.Checked = message.Favourite;
            Confirmed.Checked = message.Confirmed;
            ConfirmationRequired.Checked = message.ConfirmationRequired;
            string typeName = new MessageTypeMapping(message.MessageType).ToString();
            foreach (var control in IconGroupBox.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Text == typeName)
                    {
                        ((RadioButton)control).Checked = true;
                    }
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            IMessage message;
            int messageId;
            int.TryParse(MessagesListViewEdit.SelectedItems[0].SubItems[2].Text, out messageId);
            message = messagesDataAccess.GetMessage(messageId);

            message.ConfirmationRequired = ConfirmationRequired.Checked;
            message.Favourite = Favourite.Checked;
            message.Content = textBox2.Text.ToString();
            message.Confirmed = Confirmed.Checked;

            MessageType type = MessageType.None;
            foreach (var control in IconGroupBox.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked)
                    {
                        if (((RadioButton)control).Text == "Błąd")
                            type = MessageType.Error;
                        else if (((RadioButton)control).Text == "Ostrzeżenie")
                            type = MessageType.Warning;
                        else if (((RadioButton)control).Text == "Informacja")
                            type = MessageType.Information;
                        break;
                    }
                }
            }
            message.MessageType = type;

            messagesDataAccess.UpdateMessage(message);
            this.Controls.Clear();
            this.InitializeComponent();
            this.InitializeEntryData();
        }
        protected override void OnClosed(EventArgs e)
        {
            MessagesListViewEdit.Click -= MessagesListViewEdit_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainForm != null)
                mainForm.RefreshWindow();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainForm != null)
                mainForm.RefreshWindow();
        }
    }
}
