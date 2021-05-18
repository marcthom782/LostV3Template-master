using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        SoundPlayer musicPlayer;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 1; }


            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
            
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 77; }
            else if (page == 4) { page = 9; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 77; }
            else if (page == 7) { page = 77; }
            else if (page == 8) { page = 77; }
            else if (page == 9) { page = 77; }
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    musicPlayer = new SoundPlayer(Properties.Resources.jungle);
                    musicPlayer.Play();

                    pictureBox1.Image = Properties.Resources.Best_Zombie_Games;

                    outputLabel.Text = "In a lab a break out of zombies .";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
                case 2:
                    musicPlayer = new SoundPlayer(Properties.Resources.brook);
                    musicPlayer.Play();

                    pictureBox1.Image = Properties.Resources.zomss;

                    outputLabel.Text = "Find a room do you wanna hide?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "Run out in the open you die play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "Zombies find that room what to do .?";
                    option1Label.Text = "Challenge";
                    option2Label.Text = "Run";
                    break;
                case 5:
                    outputLabel.Text = "Zombies is gone stay hiding or go ?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "stay back and call for help be trap and die . Play again ?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "Try to sneak out quietly to safety. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    outputLabel.Text = "challenge it and die ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "Run to live . again ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 77:
                    outputLabel.Text = "Thank you for playing ";
                    option1Label.Text = "";
                    //option2Label.Text = "";
                        

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
