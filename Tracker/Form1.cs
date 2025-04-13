using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Text.Json;
using System.IO;

namespace Tracker
{
    public partial class Form1 : Form
    {
        private List<Character> characters { get; set; }

        private AddForm addForm;

        private BindingSource bs;

        public Form1()
        {
            InitializeComponent();
            characters = new List<Character>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            characters.Sort();
            bs = new BindingSource();
            bs.DataSource = characters;
            lbTracker.DataSource = bs;
            cbxSTATE.Items.Add(STATE.ALIVE);
            cbxSTATE.Items.Add(STATE.STUNNED);
            cbxSTATE.Items.Add(STATE.DEAD);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTracker_Format(object sender, ListControlConvertEventArgs e)
        {
            String ini = ((Character)e.ListItem).ini.ToString();
            String name = ((Character)e.ListItem).name;
            bool isDead = (((Character)e.ListItem).state == STATE.DEAD);

            e.Value = ini + " : " + name + (isDead ? " DEAD" : "");
        }

        private void lbTracker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem != null)
            {
                txtbxName.Text = ((Character)lbTracker.SelectedItem).name;
                cbxSTATE.SelectedItem = ((Character)lbTracker.SelectedItem).state;
                nudHP.Value = ((Character)lbTracker.SelectedItem).hp;
                nudINI.Value = ((Character)lbTracker.SelectedItem).ini;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (addForm == null)
            {
                addForm = new AddForm(characters);
                addForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
                addForm.Show();           
            }
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshList();
            addForm = null;
        }

        private void txtbxName_Leave(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem != null)
            {
                characters.ElementAt(lbTracker.SelectedIndex).name = txtbxName.Text;
                refreshList();
            }
        }

        private void cbxSTATE_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem != null)
                characters.ElementAt(lbTracker.SelectedIndex).state = (STATE)cbxSTATE.SelectedItem;
        }

        private void nudINI_ValueChanged(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem != null)
            {
                if (nudINI.Value < 0) nudINI.Value = 0;

                Character c = characters.ElementAt(lbTracker.SelectedIndex);
                c.ini = (int)nudINI.Value;

                int currIndex = characters.FindIndex(character => character.name == c.name);
                refreshList();

                lbTracker.SetSelected(currIndex, true);
            }
        }

        private void nudHP_ValueChanged(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem != null)
            {
                if (nudHP.Value < 0) nudHP.Value = 0;
                characters.ElementAt(lbTracker.SelectedIndex).hp = (int)nudHP.Value;
            }
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            if (lbTracker.SelectedItem == null) return;

            characters.Remove((Character)lbTracker.SelectedItem);
            refreshList();

            if (lbTracker.Items.Count > 0) lbTracker.SetSelected(0, true);
            else clearLabels();
        }

        private void clearLabels()
        {
            txtbxName.Text = " ";
            cbxSTATE.SelectedItem = null;
            nudHP.Value = 0;
            nudINI.Value = 0;
        }

        private void refreshList()
        {
            characters.Sort();
            bs.ResetBindings(true);
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            characters.Clear();
            bs.ResetBindings(true);
            clearLabels();
        }

        private void saveToJson(String filename)
        {
            String json = JsonSerializer.Serialize(characters);
            
            using(StreamWriter outputFile = new StreamWriter(filename + ".json"))
            {
                outputFile.WriteLine(json);
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "*.json|";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveToJson(saveFileDialog.FileName);
            }
        }

        private void loadFromJson(String filename)
        {
            characters.Clear();
            List<Character> tmp;

            using(StreamReader streamReader = new StreamReader(filename))
            {
                string json = streamReader.ReadToEnd();
                tmp = JsonSerializer.Deserialize<List<Character>>(json);
            }

            characters.AddRange(tmp);
            refreshList();
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "*.json|";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                loadFromJson(openFile.FileName);
            }
        }
    }
}
