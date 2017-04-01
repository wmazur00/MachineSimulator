using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineSimulator
{
    public partial class ModalPopupForm : Form
    {
        public ModalPopupForm()
        {
            InitializeComponent();
        }

        public void ShowDialog()
        {
            this.Show();
        }

        public string GetValue()
        {
            return textBox_ValueInput.Text;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
