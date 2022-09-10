using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace main
{
    public partial class Menu : Form
    {
        //
        // This is the form where menu with buttons (play, help, settings, exit) and logo
        //

        // Forms
        private Form StatusForm = null;
        public Game form_game;
        public End form_end;

        // Bools
        public static bool developer_mode = false;
        public static bool SoundStatus = true;
        public static bool first_type = false;
        public static bool second_type = false;
        public static bool start_game = false;

        // Sounds
        public static SoundPlayer Sound_ButtonClick = new SoundPlayer(@"..\..\sounds\button_sound.wav");

        public Menu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        //
        // Functions
        //
        private void OpenForm(Form SelectedForm)
        {
            if (StatusForm != null)
            {
                StatusForm.Close();
            }
            StatusForm = SelectedForm;
            SelectedForm.TopLevel = false;
            SelectedForm.FormBorderStyle = FormBorderStyle.None;
            SelectedForm.Dock = DockStyle.Fill;
            PanelWindow.Controls.Add(SelectedForm);
            PanelWindow.Tag = SelectedForm;
            SelectedForm.BringToFront();
            SelectedForm.Show();
        }
        public static void SoundCheck(SoundPlayer Sound)
        {
            if (SoundStatus)
            {
                Sound.Play();
            }
        }
        //
        // Buttons
        //
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            SoundCheck(Sound_ButtonClick);
            OpenForm(new Type());
            TimerIsPlay.Start();
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            SoundCheck(Sound_ButtonClick);
            OpenForm(new Help());
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            SoundCheck(Sound_ButtonClick);
            OpenForm(new Settings());
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // Timers
        //
        private void TimerIsPlay_Tick(object sender, EventArgs e)
        {
            if (start_game)
            {
                form_game = new Game();
                form_game.form_menu = this;
                form_game.Show();
                this.Hide();
                start_game = false;
                TimerIsPlay.Stop();
            }
        }
    }
}
