using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Settings : Form
    {
        //
        // Form with game settings
        //

        // Forms
        public Question form_q;

        public Settings()
        {
            InitializeComponent();
            if (main.Menu.SoundStatus)
            {
                CheckIsSounds.Checked = true;
            }
            else
            {
                CheckIsSounds.Checked = false;
            }
            if (main.Menu.developer_mode)
            {
                CheckIsDeveloperMode.Checked = true;
                ButtonQuestions.Visible = true;
            }
            else
            {
                CheckIsDeveloperMode.Checked = false;
                ButtonQuestions.Visible = false;
            }
        }
        //
        // Buttons
        //
        private void ButtonQuestions_Click(object sender, EventArgs e)
        {
            form_q = new Question();
            form_q.Show();
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(main.Menu.Sound_ButtonClick);
            this.Close();
        }
        //
        // CheckBoxes
        //
        private void CheckIsSounds_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIsSounds.Checked)
            {
                main.Menu.SoundStatus = true;
                CheckIsSounds.Text = "On";
            }
            else
            {
                main.Menu.SoundStatus = false;
                CheckIsSounds.Text = "Off";
            }
        }
        private void CheckIsDeveloperMode_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIsDeveloperMode.Checked)
            {
                main.Menu.developer_mode = true;
                ButtonQuestions.Visible = true;
                CheckIsDeveloperMode.Text = "On";
            }
            else
            {
                main.Menu.developer_mode = false;
                ButtonQuestions.Visible = false;
                CheckIsDeveloperMode.Text = "Off";
            }
        }
    }
}
