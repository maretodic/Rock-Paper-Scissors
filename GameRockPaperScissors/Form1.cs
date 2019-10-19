using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _playerScore, _pcScore;
        private void scissors_btn_Click(object sender, EventArgs e)
        {
            playRound(1);
        }

        private void paper_btn_Click(object sender, EventArgs e)
        {
            playRound(2);
        }

        private void rock_btn_Click(object sender, EventArgs e)
        {
            playRound(3);
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            _pcScore = default;
            _playerScore = default;
            pc_score_label.Text = _pcScore.ToString();
            player_score_label.Text = _playerScore.ToString();
            result_label.Text = "RESULT";
            player_choice_label.Text = "YOU";
            pc_choice_label.Text = "PC";
        }

        private void playRound(int playerSelection)
        {
            Random rnd = new Random();
            int random = rnd.Next(100, 4000);
            int pcSelection = (random % 3) + 1;
            SetSelection(player_choice_label, playerSelection);
            SetSelection(pc_choice_label, pcSelection);

            if (playerSelection == pcSelection)
            {
                result_label.Text = "DRAW";
                return;
            }

            switch (playerSelection)
            {
                case 1:
                    UpdateScore(pcSelection == 2);
                    break;
                case 2:
                    UpdateScore(pcSelection == 3);
                    break;
                case 3:
                    UpdateScore(pcSelection == 1);
                    break;
            }
        }

        private void UpdateScore(bool playerWin)
        {
            if (playerWin)
            {
                _playerScore++;
                player_score_label.Text = _playerScore.ToString();
                result_label.Text = "WIN";
            }
            else
            {
                _pcScore++;
                pc_score_label.Text = _pcScore.ToString();
                result_label.Text = "LOSE";
            }
        }

        private void SetSelection(Label lb, int num)
        {
            lb.Text = (num == 1) ? "Scissors" : (num == 2) ? "Paper" : "Rock";
        }

    }
}
