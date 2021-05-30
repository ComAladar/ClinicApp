using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppUI.Forms
{
    public partial class AddMessageForm : Form
    {
        private string _messageName;
        private string _messageText;

        public string MessageName
        {
            get
            {
                return _messageName;
            }
            set
            {
                _messageName = value;
            }
        }

        public string MessageText
        {
            get
            {
                return _messageText;
            }
            set
            {
                _messageText = value;
            }
        }
        public AddMessageForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(richTextBoxMessage.Text))
            {
                MessageBox.Show("Заполните поле названия и текста.");
                return;
            }
            MessageName = textBoxName.Text;
            MessageText = richTextBoxMessage.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
