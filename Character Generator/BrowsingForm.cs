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
    public partial class BrowsingForm : Form
    {
        DatabaseControl databaseControl = new DatabaseControl();

        public BrowsingForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //closes this form and reopens main form
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this character?", "Are you sure?", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                //delete character
            }

            else

            {
                return;
            }

        }

        private void buttonGetRandom_Click(object sender, EventArgs e)
        {
            CharacterModel character = databaseControl.GetCharacter();

            textBoxLifePhase.Text = databaseControl.TraitFromId(character.LifePhaseId, "LifePhase");
            textBoxTrait.Text = databaseControl.TraitFromId(character.MainTraitId, "MainTrait");
            textBoxStrength.Text = databaseControl.TraitFromId(character.MainStrengthId, "MainStrength");
            textBoxFlaw.Text = databaseControl.TraitFromId(character.MainFlawId, "MainFlaw");
            textBoxGoal.Text = databaseControl.TraitFromId(character.GoalId, "Goal");
            textBoxSecret.Text = databaseControl.TraitFromId(character.SecretId, "Secret");

            
        }
    }
}
