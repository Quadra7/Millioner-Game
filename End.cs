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
    public partial class End : Form
    {
        //
        // The form that displays the result of the game (win or lose)
        //

        // Forms
        public Game form_game;
        public Menu form_menu;

        // Sounds
        SoundPlayer win = new SoundPlayer(@"..\..\sounds\win.wav");
        SoundPlayer lose = new SoundPlayer(@"..\..\sounds\lose.wav");

        public End()
        {
            InitializeComponent();
            this.ControlBox = false;
            if (main.Game.win)
            {
                this.Text = "Win";
                main.Menu.SoundCheck(win);
                TextIsWin.Text = "Поздравляем, вы выиграли миллион рублей!";
            }
            else
            {
                this.Text = "Lose";
                main.Menu.SoundCheck(lose);
                TextIsWin.Text = "Вы проиграли! Игра окончена.";
            }
        }
        //
        // Buttons
        //
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            main.Menu.first_type = false;
            main.Menu.second_type = false;
            form_menu = new Menu();
            form_menu.form_end = this;
            form_menu.Show();
            this.Hide();
        }
    }
}
