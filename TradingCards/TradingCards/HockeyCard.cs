using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class HockeyCard : UserControl
    {
        public HockeyCard()
        {
            InitializeComponent();
        }

        internal void SetInfo(PlayerData playerData, float averageAge, float averageWeight, float averageGoalsScored, float averageHeight)
        {
            pictureBox_PlayerPicture.Load(playerData.Photo);
            lbl_nameNumberDisplay.Text = "#" + playerData.Number.ToString() + ": " + playerData.Name;
            lbl_ageDisplay.Text = playerData.Age.ToString();
            lbl_TeamNameDisplay.Text = playerData.Team;
            lbl_positionDisplay.Text = playerData.Position.ToString();
            lbl_hometownDisplay.Text = "Hometown: " + playerData.HomeTown;
            lbl_BirthdayDisplay.Text = "Birthdate: "+ playerData.Birthdate.Year.ToString()+"-"+playerData.Birthdate.Month.ToString()+"-"+playerData.Birthdate.Day.ToString();
            lbl_weightDisplay.Text = playerData.Weight;
            lbl_heightDisplay.Text = playerData.Height;
            lbl_goalsScoredDisplay.Text = playerData.GoalsScored.ToString();

            //Set goalsscored color

            if (playerData.GoalsScored > averageGoalsScored)
            {
                //green if above average
                lbl_goalsScoredDisplay.ForeColor = Color.Green;
            }
            else if(playerData.GoalsScored< averageGoalsScored)
            {
                //red if less than average
                lbl_goalsScoredDisplay.ForeColor = Color.Red;
            }
            else
            {
                //yellow if average
                lbl_goalsScoredDisplay.ForeColor = Color.Orange;
            }

            //Set age color

            if (playerData.Age < averageAge)
            {
                //green if above average
                lbl_ageDisplay.ForeColor = Color.Green;
            }
            else if (playerData.Age > averageAge)
            {
                //red if less than average
                lbl_ageDisplay.ForeColor = Color.Red;
            }
            else
            {
                //yellow if average
                lbl_ageDisplay.ForeColor = Color.Orange;
            }

            //set weight color

            if (float.Parse(playerData.Weight) > averageWeight)
            {
                //green if above average
                lbl_weightDisplay.ForeColor = Color.Green;
            }
            else if (float.Parse(playerData.Weight) < averageWeight)
            {
                //red if less than average
                lbl_weightDisplay.ForeColor = Color.Red;
            }
            else
            {
                //yellow if average
                lbl_weightDisplay.ForeColor = Color.Orange;
            }


            //set height color

            if (float.Parse(playerData.Height) > averageHeight)
            {
                //green if above average
                lbl_heightDisplay.ForeColor = Color.Green;
            }
            else if (float.Parse(playerData.Height) < averageHeight)
            {
                //red if less than average
                lbl_heightDisplay.ForeColor = Color.Red;
            }
            else
            {
                //yellow if average
                lbl_heightDisplay.ForeColor = Color.Orange;
            }



            //Set primary and secodnary colors based on team
            Color primaryColor=Color.White;
            Color secondaryColor=Color.Black;

            switch (playerData.Team)
            {
                case "Edmonton Oilers":
                    secondaryColor = Color.FromArgb(252, 76, 0);
                    primaryColor = Color.FromArgb(4, 30, 66);
                    break;
                case "Vancouver Canucks":
                    secondaryColor = Color.FromArgb(10, 134, 61);
                    primaryColor = Color.FromArgb(0, 32, 91);
                    break;
                case "Dallas Stars":
                    secondaryColor = Color.FromArgb(143, 143, 140);
                    primaryColor = Color.FromArgb(0, 104, 71);
                    break;
                case "Boston Bruins":
                    secondaryColor = Color.FromArgb(17, 17, 17);
                    primaryColor = Color.FromArgb(252, 181, 20);
                    break;
                case "Pittsburgh Penguins":
                    secondaryColor = Color.FromArgb(207, 196, 147);
                    primaryColor = Color.FromArgb(0, 0, 0);
                    break;
                case "Seattle Kraken":
                    secondaryColor = Color.FromArgb(153, 217, 217);
                    primaryColor = Color.FromArgb(0, 22, 40);
                    break;
                case "Minnesota Wild":
                    secondaryColor = Color.FromArgb(2, 73, 48);
                    primaryColor = Color.FromArgb(175, 35, 36);
                    break;
                case "Nashville Predators":
                    secondaryColor = Color.FromArgb(4, 30, 66);
                    primaryColor = Color.FromArgb(255, 184, 28);
                    break;

                default:
                    primaryColor = Color.White;
                    secondaryColor = Color.Black;
                    break;
            }

            BackColor = secondaryColor;
            panel_Card.BackColor = primaryColor;
            lbl_nameNumberDisplay.BackColor = secondaryColor;
            lbl_nameNumberDisplay.ForeColor = primaryColor;
            lbl_TeamNameDisplay.ForeColor = secondaryColor;
            lbl_TeamNameDisplay.BackColor = primaryColor;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
