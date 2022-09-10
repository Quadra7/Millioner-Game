using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace main
{
    public partial class Help : Form
    {
        //
        // A form that explains the rules of the game
        //

        // Text
        string line;

        public Help()
        {
            InitializeComponent();
            RichTextBoxRules.Text = "";
            StreamReader text = new StreamReader(@"..\..\docs\Rules.txt");
            line = text.ReadToEnd();
            while (line != null)
            {
                RichTextBoxRules.Text += line;
                line = text.ReadLine();
            }
            text.Close();
        }
        //
        // Buttons
        //
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(main.Menu.Sound_ButtonClick);
            this.Close();
        }
    }
}
