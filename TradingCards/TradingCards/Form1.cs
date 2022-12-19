using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace TradingCards
{



    public partial class Form1 : Form
    {
        //get connection string for our database
        string dbConnectionString = ConfigurationManager.ConnectionStrings["TradingCards.Properties.Settings.CardDataConnectionString"].ConnectionString;

        List<PlayerData> playerData;

        public float averageGoalsScored;
        public float averageWeight;
        public float averageAge;
        public float averageHeight;

        public Form1()
        {
            InitializeComponent();
            //make sure our default hockey card is invisible
            hockeyCard1.Visible = false;
            //initialize our list
            playerData = new List<PlayerData>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))  //establish connection to db
            using (SqlDataAdapter clientAdapter = new SqlDataAdapter("select * from Players", myConnection))
            {
                DataTable hockeyData = new DataTable();
                myConnection.Open();
                clientAdapter.Fill(hockeyData);
                myConnection.Close();

                //sort our data by name
                hockeyData.DefaultView.Sort = "Name ASC";
                hockeyData = hockeyData.DefaultView.ToTable();

                //loop through all rows
                for (int i = 0; i < hockeyData.Rows.Count; i++)
                {
                    //These next lines get all the data from our database and put them into variables
                    int ID = (int)hockeyData.Rows[i]["ID"];
                    String Name = hockeyData.Rows[i]["Name"].ToString();
                    String Photo = hockeyData.Rows[i]["Photo"].ToString();
                    Console.WriteLine(Photo);
                    int GoalsScored = (int)hockeyData.Rows[i]["GoalsScored"];
                    int Number = (int)hockeyData.Rows[i]["Number"];
                    string Position = hockeyData.Rows[i]["Position"].ToString();
                    string Team = hockeyData.Rows[i]["Team"].ToString();
                    String HomeTown = hockeyData.Rows[i]["Hometown"].ToString();
                    DateTime Birthdate = (DateTime)hockeyData.Rows[i]["Birthdate"];
                    int Age = (int)hockeyData.Rows[i]["Age"];
                    string Height = hockeyData.Rows[i]["Height"].ToString();
                    string Weight = hockeyData.Rows[i]["Weight"].ToString();


                    //create the new playerdata object out of the variables we just got from our database.
                    PlayerData data = new PlayerData(ID, Name, Photo, GoalsScored,  Number, Position, Team, HomeTown, Birthdate, Age, Height, Weight);

                    //create a new item for our list view for displaying to the user
                    ListViewItem myItem = new ListViewItem(data.Name);

                    //This next section will add a whole bunch of data to our list view - but we dont need it anymore as it is being displayed on the actual card!
                    /* 
                    myItem.SubItems.Add(data.ID.ToString());
                    myItem.SubItems.Add(data.GoalsScored.ToString());
                    myItem.SubItems.Add(data.Number.ToString());
                    myItem.SubItems.Add(data.Position.ToString());
                    myItem.SubItems.Add(data.Team.ToString());
                    myItem.SubItems.Add(data.HomeTown.ToString());
                    myItem.SubItems.Add(data.Birthdate.ToString());
                    myItem.SubItems.Add(data.Age.ToString());
                    myItem.SubItems.Add(data.Height.ToString());
                    myItem.SubItems.Add(data.Weight.ToString());
                    */

                    //Add the player to our list view for the user to see
                    CardListView.Items.Add(myItem);
                    //finally, add the data to our list of players
                    playerData.Add(data);
                }


                float weightSum = 0;
                float goalsScoredSum = 0;
                float ageSum = 0;
                float heightSum = 0;

                //loop through all player data so we can sum up our totals to find the averages later.

                for (int i=0; i <playerData.Count; i++)
                {
                    weightSum += float.Parse(playerData[i].Weight);
                    goalsScoredSum+=playerData[i].GoalsScored;
                    ageSum += playerData[i].Age;
                    heightSum += float.Parse(playerData[i].Height);
                }

                //Find the average weight
                averageWeight = weightSum / playerData.Count;
                //find the average goals scored
                averageGoalsScored = goalsScoredSum / playerData.Count;
                //find the average age
                averageAge = ageSum / playerData.Count;
                //find average height
                averageHeight = heightSum / playerData.Count;


            }
        }

       

        private void CardListView_MouseClick(object sender, MouseEventArgs e)
        {
            //make sure the hockey card is visible
            hockeyCard1.Visible = true;

            //loop through to find the currently selected hockey card
            for (int i = 0; i < playerData.Count; i++)
            {
                if (playerData[i].Name == CardListView.SelectedItems[0].Text)
                {
                    //display the currently selected hockey card
                    hockeyCard1.SetInfo(playerData[i], averageAge, averageWeight, averageGoalsScored, averageHeight);
                    break;
                }


            }
        }
    }

}

