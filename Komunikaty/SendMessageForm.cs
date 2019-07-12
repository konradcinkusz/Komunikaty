using Komunikaty.Interfaces;
using Komunikaty.ViewModels;
using System;
using System.Windows.Forms;

namespace Komunikaty
{
    /// <summary>
    /// Okno wysyłania wiadomości
    /// </summary>
    public partial class SendWindow : Form
    {
        private IMessages messagesDataAccess;
        private IReceiver receiver;

        private void InitializeEntryData()
        {
            foreach (IMessage message in messagesDataAccess.GetAllMessage())
            {
                string[] row = { message.Content, new MessageTypeMapping(message.MessageType).ToString(), message.Id.ToString() };
                var listViewItem = new ListViewItem(row);
                MessagesListView.Items.Add(listViewItem);
                if (message.Favourite)
                {
                    contextMenuStrip.Items.Add(message.Content, null, onTextClick);
                }
            }
        }
        public SendWindow(IMessages messagesDataAccess, IReceiver receiver)
        {
            InitializeComponent();
            this.receiver = receiver;
            this.messagesDataAccess = messagesDataAccess;
            InitializeEntryData();

        }
        private void onTextClick(object sender, EventArgs e)
        {
            MessageTextBox.Text = string.Empty;
            MessageTextBox.Text = sender.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try //Niestety muszę opakować w try, ponieważ nie przewidziałem niektórych wyjątków
            {
                IMessage message = new ViewModels.Message(messagesDataAccess.GetLastId());
                if (MessagesTabs.SelectedTab.Name == "EnterMessages")
                {
                    message.ConfirmationRequired = ConfirmationCheckBox.Checked;
                    message.Favourite = AddToFavourite.Checked;
                    message.Content = MessageTextBox.Text.ToString();

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
                }
                else
                {
                    int messageId;
                    int.TryParse(MessagesListView.SelectedItems[0].SubItems[2].Text, out messageId);
                    message = messagesDataAccess.GetMessage(messageId);
                    message.ConfirmationRequired = ConfirmationCheckBox.Checked;
                }
                if (Save.Checked)
                {
                    messagesDataAccess.SaveMessage(message);
                }

                receiver.SendMessage(message);
                RefreshWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wysłać komunikatu!" + ex.ToString());
            }
        }

        public void RefreshWindow()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.InitializeEntryData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditMessages form = new EditMessages(this, messagesDataAccess, MessagesListView.SelectedItems[0].SubItems[0].Text);

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Musisz wybrać wiadomość z listy!");
            }
        }
    }
}
