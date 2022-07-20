using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Generator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreationMode_Click(object sender, EventArgs e)
        {
            //opens character generator and hides main form
            GeneratorForm generatorForm = new GeneratorForm();
            generatorForm.Show();
            this.Hide();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //opens form with instructions and hides main form
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
