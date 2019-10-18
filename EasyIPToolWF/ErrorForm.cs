using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIPToolWF
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string UserMessage, string DevMessage, string Title)
        {
            this.InitializeComponent();
            this.Text = Title;
            this.aTextBoxUserMessage.Text = UserMessage;
            this.aTextBoxDeveloperMessage.Text = DevMessage;
        }
    }
}
