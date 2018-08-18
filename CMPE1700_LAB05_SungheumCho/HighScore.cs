using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1700_LAB05_SungheumCho
{
    public partial class HighScore : Form
    {
        string name;
        public HighScore()
        {
            InitializeComponent();
        }

        //returning the name user type in the textbox
        public string GetUserName
        {
            get { return name; }
        }

        //when user press ok, the name is stored and transfer to main form
        private void UI_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            name = UI_tbxName.Text;
        }

        private void UI_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
