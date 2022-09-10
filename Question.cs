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
    public partial class Question : Form
    {
        //
        // A form with which the user can add his questions to the game
        //

        // Text
        StreamWriter text;
        List<string> ask_first = new List<string>();
        List<string> ask_second = new List<string>();

        public Question()
        {
            InitializeComponent();
            ask_first.AddRange(File.ReadAllLines(@"..\..\docs\FirstTypeQuestions.txt"));
            ask_second.AddRange(File.ReadAllLines(@"..\..\docs\SecondTypeQuestions.txt"));
        }
        //
        // Buttons
        //
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (NumericType.Value == 1)
            {
                text = new StreamWriter(@"..\..\docs\FirstTypeQuestions.txt");
                for (int i = 0; i < ask_first.Count; i++)
                {
                    text.WriteLine($"{ask_first[i]}");
                }
            }
            else
            {
                text = new StreamWriter(@"..\..\docs\SecondTypeQuestions.txt");
                for (int i = 0; i < ask_second.Count; i++)
                {
                    text.WriteLine($"{ask_second[i]}");
                }
            }
            string question = TextBoxQuestion.Text;
            text.WriteLine($"{question}");
            string first_answer = TextBoxFirstAnswer.Text;
            text.WriteLine($"{first_answer}");
            string second_answer = TextBoxSecondAnswer.Text;
            text.WriteLine($"{second_answer}");
            string third_answer = TextBoxThirdAnswer.Text;
            text.WriteLine($"{third_answer}");
            string fourth_answer = TextBoxFourthAnswer.Text;
            text.WriteLine($"{fourth_answer}");
            string correct_answer = Convert.ToString(NumericCorrectAnswer.Value - 1);
            text.WriteLine($"{correct_answer}");
            text.Close();
            this.Close();
        }
    }
}
