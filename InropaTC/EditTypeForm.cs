using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InropaTC
{
    public partial class EditTypeForm : Form
    {
        public EditTypeClass ETC = new EditTypeClass();
        public EditTypeForm(string type)
        {
            ETC.OldName = type;
            InitializeComponent();
        }

        private void EditTypeForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Edit {ETC.OldName}";
            textBox1.Text = ETC.OldName;
        }

        private void EditTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ETC.NewName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}