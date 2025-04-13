using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class AddForm : Form
    {
        private Form1 mainWindow;
        private List<Character> characters;

        public AddForm(List<Character> characters)
        {
            InitializeComponent();
            this.characters = characters;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbxAddName.Text))
            {
                String message = "Name field can't be empty";
                String caption = "Error in input field";

                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, button);
            }
            else
            {
                int ini = (int)nudAddINI.Value;
                int hp = (int)nudAddHP.Value;
                String name = "";

                if (characters.All(i => i.name != txtbxAddName.Text)) name = txtbxAddName.Text;
                else name = txtbxAddName.Text + "1";

                characters.Add(new Character { name = name, hp = hp, ini = ini, state = STATE.ALIVE });
                this.Close();
            }
        }
    }
}
