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
    public partial class Type : Form
    {
        //
        // A form that defines the type of questions in the game
        //

        // Forms
        public Game form_game;

        // Sounds
        SoundPlayer wrong_sound = new SoundPlayer(@"..\..\sounds\wrong_sound.wav");

        public Type()
        {
            InitializeComponent();
            PictureFirstWall.SendToBack();
            PictureSecondWall.SendToBack();
            ButtonFirstType.Image = new Bitmap(@"..\..\sprites\FirstType.jpg");
            ButtonSecondType.Image = new Bitmap(@"..\..\sprites\SecondType.jpg");
        }
        //
        // Buttons
        //
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!main.Menu.first_type && !main.Menu.second_type)
            {
                TextError.Visible = true;
                main.Menu.SoundCheck(wrong_sound);
            }
            else
            {
                main.Menu.SoundCheck(main.Menu.Sound_ButtonClick);
                main.Menu.start_game = true;
            }
        }
        private void ButtonFirstType_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(main.Menu.Sound_ButtonClick);
            main.Menu.first_type = true;
            main.Menu.second_type = false;
            PictureFirstWall.Visible = true;
            PictureSecondWall.Visible = false;
        }
        private void ButtonSecondType_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(main.Menu.Sound_ButtonClick);
            main.Menu.second_type = true;
            main.Menu.first_type = false;
            PictureSecondWall.Visible = true;
            PictureFirstWall.Visible = false;
        }
    }
}
