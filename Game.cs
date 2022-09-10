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
using System.IO;

namespace main
{
    public partial class Game : Form
    {
        //
        // This is the main form where the algorithm of the game is written
        //

        // Random class and variables that are set randomly
        Random rnd = new Random();
        int random_question_id;

        // Forms
        public Menu form_menu;
        public End form_end;

        // Buttons with answers
        const int value_questions = 4;
        RichTextBox[] bt = new RichTextBox[value_questions];
        int[] button_location_X = { 12, 330, 12, 330 };
        int[] button_location_Y = { 317, 317, 394, 394 };

        // Button which player clicked
        RichTextBox clicked_button;

        // Question which was on document (Questions.txt)
        List<string> ask_first = new List<string>();
        List<string> ask_second = new List<string>();
        int correct_answer;

        // Plaque with prizes
        const int value = 15;
        Label[] tab_money = new Label[value];
        int tab_money_X = 685;
        int tab_money_Y = 25;
        string[] money = { "1. 100", "2. 200", "3. 300", "4. 500", "5. 1 000", "6. 2 000", "7. 4000", "8. 8 000", "9. 16 000",
            "10. 32 000", "11. 64 00", "12. 125 000", "13. 250 000", "14. 500 000", "15. 1 000 000" };

        // Variables that are needed for timers
        int time_show = 0;
        bool timer_win = false;
        bool timer_lose = false;

        // Buttons that help the player during the game
        Image fifty_fifty_end = new Bitmap(@"..\..\sprites\50-50_end.jpg");
        Image call_end = new Bitmap(@"..\..\sprites\call_end.jpg");
        Image people_end = new Bitmap(@"..\..\sprites\people_end.jpg");
        int think_to_call = 0;
        int[] temp_button = new int[2];

        // Variables that are needed to determine the end of the game
        public static bool win = false;
        public static bool lose = false;

        // Sounds
        SoundPlayer correct = new SoundPlayer(@"..\..\sounds\true.wav");
        SoundPlayer wrong = new SoundPlayer(@"..\..\sounds\false.wav");

        SoundPlayer fifty_fifty_sound = new SoundPlayer(@"..\..\sounds\50-50_sound.wav");
        SoundPlayer call = new SoundPlayer(@"..\..\sounds\call.wav");
        SoundPlayer people_sound = new SoundPlayer(@"..\..\sounds\people_sound.wav");

        // Player's score
        int score = 0;

        public Game()
        {
            InitializeComponent();
            this.ControlBox = false;
            ask_first.AddRange(File.ReadAllLines(@"..\..\docs\FirstTypeQuestions.txt"));
            ask_second.AddRange(File.ReadAllLines(@"..\..\docs\SecondTypeQuestions.txt"));
            win = false;
            lose = false;
        }
        //
        // Forms
        //
        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < value; i++)
            {
                // Make label
                tab_money[i] = new Label();
                // Label settings
                tab_money[i].BackColor = Color.Yellow;
                tab_money[i].Width = 200;
                tab_money[i].Height = 30;
                // Label location
                tab_money[i].Left = tab_money_X;
                tab_money[i].Top = 80 + tab_money_Y * i;
                // Label font
                tab_money[i].BorderStyle = BorderStyle.None;
                tab_money[i].Font = new Font("Comic Sans MS", 18, FontStyle.Bold, GraphicsUnit.Point);
                tab_money[i].ForeColor = Color.Black;
                // Label text
                tab_money[i].Text = money[value - i - 1];
                this.Controls.Add(tab_money[i]);
            }
            for (int i = 0; i < value_questions; i++)
            {
                // Make button
                bt[i] = new RichTextBox();
                bt[i].Cursor = Cursors.Default;
                bt[i].ReadOnly = false;
                // Button settings
                bt[i].BackColor = Color.Black;
                bt[i].Width = 300;
                bt[i].Height = 55;
                // Button locatiom
                bt[i].Top = button_location_Y[i];
                bt[i].Left = button_location_X[i];
                // Button font
                bt[i].BackColor = Color.Black;
                bt[i].Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                //bt[i].TextAlign = ContentAlignment.MiddleLeft;
                bt[i].ForeColor = Color.White;
                bt[i].Click += new EventHandler(bt_click);
                Controls.Add(bt[i]);
            }
            PictureLogo.SendToBack();
            bt_new_answers();
        }
        //
        // Functions
        //
        public void bt_new_answers() //Need to make a random
        {
            // Groupbox (belongs to the "Hall help" function)
            GroupBoxPeople.Visible = false;
            // Belongs to the "Call friend" function
            PictureCallingMan.Visible = false;
            TextCorrectAnswer.Visible = false;
            // It is necessary that all buttons are displayed after the "50/50" function
            for (int i = 0; i < value_questions; i++)
            {
                bt[i].Visible = true;
            }
            // Show question and answers
            if (main.Menu.first_type)
            {
                do
                {
                    random_question_id = rnd.Next(0, ask_first.Count);
                } while ((random_question_id % 6) != 0);
                TextBoxQuestion.Text = ask_first[random_question_id];
                for (int i = 1; i < value_questions + 1; i++)
                {
                    bt[i - 1].Text = $"{i}) {ask_first[random_question_id + i]}";
                }
                correct_answer = Convert.ToInt16(ask_first[random_question_id + 5]);
                bt[correct_answer].Tag = "correct";
            }
            else
            {
                do
                {
                    random_question_id = rnd.Next(0, ask_second.Count);
                } while ((random_question_id % 6) != 0);
                TextBoxQuestion.Text = ask_second[random_question_id];
                for (int i = 1; i < value_questions + 1; i++)
                {
                    bt[i - 1].Text = $"{i}) {ask_second[random_question_id + i]}";
                }
                correct_answer = Convert.ToInt16(ask_second[random_question_id + 5]);
                bt[correct_answer].Tag = "correct";
            }
        }
        public void delete_list() //Need to make a random
        {
            // Deletes the question that the player answered
            if (main.Menu.first_type)
            {
                ask_first.RemoveRange(random_question_id, 6);
            }
            else
            {
                ask_second.RemoveRange(random_question_id, 6);
            }
            bt_new_answers();
        }
        public void bt_click(object sender, EventArgs e)
        {
            clicked_button = sender as RichTextBox;
            if (Convert.ToString(clicked_button.Tag) == "correct")
            {
                timer_win = true;
                score++;
                clicked_button.Tag = "";
            }
            else
            {
                timer_lose = true;
            }
            show_answer_color.Start();
        }
        //
        // Buttons
        //
        private void ButtonFiftyFifty_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(fifty_fifty_sound);

            for (int i = 0; i < 2; i++)
            {
                int j = 0;
                do
                {
                    j = rnd.Next(0, 4);
                } while (Convert.ToString(bt[j].Tag) == "correct");
                temp_button[i] = j;
            }
            do
            {
                temp_button[1] = rnd.Next(0, 4);
                if (Convert.ToString(bt[temp_button[1]].Tag) == "correct")
                {
                    do
                    {
                        temp_button[1] = rnd.Next(0, 4);
                    } while (Convert.ToString(bt[temp_button[1]].Tag) == "correct");
                }
            } while (temp_button[1] == temp_button[0]);
            for (int i = 0; i < 2; i++)
            {
                bt[temp_button[i]].Visible = false;
            }
            ButtonFiftyFifty.Image = fifty_fifty_end;
            ButtonFiftyFifty.Enabled = false;
        }
        private void ButtonCall_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(call);
            PictureCallingMan.Visible = true;
            TextCorrectAnswer.Visible = true;
            human_thinking.Start();
            TextCorrectAnswer.Text = $"Я думаю, правильный ответ...\nЭто  ";
            ButtonCall.Image = call_end;
            ButtonCall.Enabled = false;
        }
        private void ButtonPeople_Click(object sender, EventArgs e)
        {
            main.Menu.SoundCheck(people_sound);
            GroupBoxPeople.Visible = true;
            switch (correct_answer)
            {
                case 0:
                    {
                        ProgressBarFirstAnswer.Value = 50;
                        TextFirstAnswerPercent.Text = "50%";
                        ProgressBarSecondAnswer.Value = 10;
                        TextSecondAnswerPercent.Text = "10%";
                        ProgressBarThirdAnswer.Value = 30;
                        TextThirdAnswerPercent.Text = "30%";
                        ProgressBarFourthAnswer.Value = 20;
                        TextFourthAnswerPercent.Text = "20%";
                        break;
                    }
                case 1:
                    {
                        ProgressBarFirstAnswer.Value = 20;
                        TextFirstAnswerPercent.Text = "20%";
                        ProgressBarSecondAnswer.Value = 50;
                        TextSecondAnswerPercent.Text = "50%";
                        ProgressBarThirdAnswer.Value = 10;
                        TextThirdAnswerPercent.Text = "10%";
                        ProgressBarFourthAnswer.Value = 30;
                        TextFourthAnswerPercent.Text = "30%";
                        break;
                    }
                case 2:
                    {
                        ProgressBarFirstAnswer.Value = 30;
                        TextFirstAnswerPercent.Text = "30%";
                        ProgressBarSecondAnswer.Value = 20;
                        TextSecondAnswerPercent.Text = "20%";
                        ProgressBarThirdAnswer.Value = 50;
                        TextThirdAnswerPercent.Text = "50%";
                        ProgressBarFourthAnswer.Value = 10;
                        TextFourthAnswerPercent.Text = "10%";
                        break;
                    }
                case 3:
                    {
                        ProgressBarFirstAnswer.Value = 10;
                        TextFirstAnswerPercent.Text = "10%";
                        ProgressBarSecondAnswer.Value = 30;
                        TextSecondAnswerPercent.Text = "30%";
                        ProgressBarThirdAnswer.Value = 20;
                        TextFourthAnswerPercent.Text = "20%";
                        ProgressBarFourthAnswer.Value = 50;
                        TextFourthAnswerPercent.Text = "50%";
                        break;
                    }
            }
            ButtonPeople.Image = people_end;
            ButtonPeople.Enabled = false;
        }
        //
        // Timers
        //
        private void show_answer_color_Tick(object sender, EventArgs e)
        {
            if (timer_win)
            {
                if (time_show == 0)
                {
                    main.Menu.SoundCheck(correct);
                }
                clicked_button.BackColor = Color.Green;
                if (score > 0)
                {
                    for (int i = 0; i < score; i++)
                    {
                        tab_money[value - i - 1].BackColor = Color.Green;
                    }
                }
                time_show++;
                if (time_show == 3)
                {
                    if (score == 15)
                    {
                        win = true;
                        form_end = new End();
                        form_end.form_game = this;
                        form_end.Show();
                        this.Hide();
                        show_answer_color.Stop();
                    }
                    else
                    {
                        time_show = 0;
                        clicked_button.BackColor = Color.Black;
                        timer_win = false;
                        delete_list();
                        show_answer_color.Stop();
                    }
                }
            }
            else if (timer_lose)
            {
                if (time_show == 0)
                {
                    main.Menu.SoundCheck(wrong);
                }
                lose = true;
                clicked_button.BackColor = Color.Red;
                tab_money[value - 1 - score].BackColor = Color.Red;
                time_show++;
                if (time_show == 3)
                {
                    time_show = 0;
                    clicked_button.BackColor = Color.Black;
                    timer_lose = false;
                    form_end = new End();
                    form_end.form_game = this;
                    form_end.Show();
                    this.Hide();
                    show_answer_color.Stop();
                }
            }
        }
        private void human_thinking_Tick(object sender, EventArgs e)
        {
            think_to_call++;
            if (think_to_call == 2)
            {
                TextCorrectAnswer.Text = $"Я думаю, правильный ответ...\nЭто вариант номер {correct_answer + 1}";
                human_thinking.Stop();
            }
        }
    }
}
