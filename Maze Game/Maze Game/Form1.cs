using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class FormMaze : Form
    {
        public FormMaze()
        {
            InitializeComponent();
        }

        bool game = false;
        int g = 0;

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Txt_MouseEnter(object sender, EventArgs e)
        {
            if (game == true)
            {
                if (g == 1)
                {
                    MessageBox.Show("You Lose", "Notice", MessageBoxButtons.OK);
                }
                game = false;
                g = 0;
            }
        }

        private void TxtFinish_MouseEnter(object sender, EventArgs e)
        {
            if (game == true)
            {
                if (g == 1)
                {
                    MessageBox.Show("You Win", "Notice", MessageBoxButtons.OK);
                }
                game = false;
                g = 0;
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = true;
        }

        private void StartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            game = true;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = false;
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = false;
        }
        void EXIT()
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Do you want to close the program ?", "Exit",MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EXIT();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXIT();
        }

        private void TxtStart_MouseEnter(object sender, EventArgs e)
        {
            g = 1;
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this game After starting the game, you have to move\n\nmouse from the first arrow to the second arrow in the\n\nwhite path without hitting the black obstacles to win", "Help");
        }

        private void PersianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در این بازی پس از استارت کردن شما باید موس را از سوی\n\nفلش اول و در مسیر سفید رنگ بدون برخورد به مانع های\n\nسیاه رنگ تا فلش دوم به حرکت در بیاورید تا برنده شوید", "Help");
        }

        private void FormMaze_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by hoseyn mohamadpor", "Welcome");
        }

        private void FormMaze_Load(object sender, EventArgs e)
        {

        }
    }
}
