using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame_War
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random r = new Random();
        static List<string> player1 = new List<string>();  //using lists because of the dynamic nature of game. there is no need to set fixed amount of array elements.
        static List<string> player2 = new List<string>();

        static List<string> warDeck = new List<string>();

        static int player1Score = 26;
        static int player2Score = 26;

        public static string[] Deck()
        {
            //creates temp deck of 52 cards with each suite and value
            List<string> tempDeck = new List<string>();
            string[] suite = { "H", "D", "S", "C" };
            string[] value = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int i;
            int j;
            //suite loop
            for (i = 0; i < 4; i++)
            {
                //values loop
                for (j = 0; j < 13; j++)
                {
                    tempDeck.Add(value[j] + " " + suite[i]);
                }
            }

            string[] deck = tempDeck.ToArray();
            return deck;
        }

        static void DealCards(string[] deck)
        {
            int j = 0;
            int x = 0;

            int randomDraw = r.Next(0, 52); //gets a random number between 0 and 52

            while (j < 26)
            {
                randomDraw = r.Next(0, deck.Count() - 1);
                player1.Add(deck[randomDraw]);
                j++;
                deck = deck.Where(c => c != deck[randomDraw]).ToArray();
            }

            while (x < 26)
            {
                randomDraw = r.Next(0, deck.Count() - 1);
                player2.Add(deck[randomDraw]);
                x++;
                deck = deck.Where(c => c != deck[randomDraw]).ToArray();
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //resets player decks and score for a new game
            if(lstPlayer1Cards.Items.Count > 1 && player1.Count > 1)
            {
                player1.Clear();
                lstPlayer1Cards.Items.Clear();
                player1Score = 26;
            }
            if (lstPlayer2Cards.Items.Count > 1 && player2.Count > 1)
            {
                player2.Clear();
                lstPlayer2Cards.Items.Clear();
                player2Score = 26;
            }

            //initializes new deck object
            string[] deck = Deck();

            //calls dealer function
            DealCards(deck);

            //for loops to populate each player's list of cards
            for(int i = 0; i < 26; i++)
            { 
                lstPlayer1Cards.Items.Add(player1[i].ToString());
            }

            for (int i = 0; i < 26; i++)
            {
                lstPlayer2Cards.Items.Add(player2[i].ToString());
            }

            //sets scores to 26
            lblP1Score.Text = player1Score.ToString();
            lblP2Score.Text = player2Score.ToString();

            //first cards for each deck
            lblP1Card.Text = player1.First().ToString();
            lblP2Card.Text = player2.First().ToString();

            //clears out label text
            lblWinner.Text = "";
        }

        private void WarBattle(string[] array)
        {
            int i = 0;
            foreach (var card in array)
            {
                warDeck.Add(array[i]);
                lstWarCards.Items.Add(array[i]);
                i++; 
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            int p1Card = 0;
            int p2Card = 0;
            bool tF = true;

            if (player1.Count() == 52 || player2.Count() == 52)
            {
                btnBattle.Enabled = false;
                tF = false;
            }

            if (player1.Count() == 0 && player2.Count() == 0)
            {
                lblWinner.Text = "Please click Draw Cards.";
                tF = false;
            }

            if (player1Score == 52)
            {
                lblWinner.Text = "Player 1 wins the game! Click the Draw Cards button to start another game.";
                tF = false;

            }
            else if (player2Score == 52)
            {
                lblWinner.Text = "Player 2 wins the game! Click the Draw Cards button to start another game.";
                tF = false;
            }

            if (tF == true)
            {
                string p1 = Regex.Match(player1.First().ToString(), @"\d+").Value;      //finds int value of card
                string p2 = Regex.Match(player2.First().ToString(), @"\d+").Value;

                if (p1 != "")    //if card is not a face card
                {
                    p1Card = Convert.ToInt32(p1);
                }
                else            //if card is face card, numeric value must be assigned
                {
                    p1 = player1.First().Split(' ')[0].ToString();      //finds the letter within the object in order to assign value
                    if (p1 == "A")
                    {
                        p1Card = 14;
                    }
                    else if (p1 == "K")
                    {
                        p1Card = 13;
                    }
                    else if (p1 == "Q")
                    {
                        p1Card = 12;
                    }
                    else
                    {
                        p1Card = 11;
                    }
                }

                if (p2 != "")
                {
                    p2Card = Convert.ToInt32(p2);
                }
                else
                {
                    p2 = player2.First().Split(' ')[0].ToString();
                    if (p2 == "A")
                    {
                        p2Card = 14;
                    }
                    else if (p2 == "K")
                    {
                        p2Card = 13;
                    }
                    else if (p2 == "Q")
                    {
                        p2Card = 12;
                    }
                    else
                    {
                        p2Card = 11;
                    }
                }

                if (p1Card > p2Card)        //player1 wins the card
                {
                    //adds p2 card to p1 list and 1 to score
                    player1.Add(player2.First());
                    player1Score++;

                    //adds new card to p1 listbox
                    int i = player1.IndexOf(player1.Last());
                    lstPlayer1Cards.Items.Add(player1[i]);

                    //removes first card and places at the last index of array
                    string temp = player1[0];
                    player1.Remove(player1[0]);
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player1.Add(temp);
                    lstPlayer1Cards.Items.Add(temp);


                    //removes p2 card from p2 list and subtracts one from p2 score
                    player2 = player2.Where(p => p != player2.First()).ToList();
                    lstPlayer2Cards.Items.RemoveAt(0);
                    player2Score--;

                    //if player wins the war battle, the war deck is assigned to them
                    if (warDeck.Count > 0)
                    {
                        lstWarCards.Items.Clear();

                        player1Score += warDeck.Count() / 2;
                        player2Score -= warDeck.Count() / 2;

                        int x = 0;
                        foreach (var card in warDeck)
                        {
                            if(card != "")
                            { 
                                player1.Add(warDeck[x]);
                                lstPlayer1Cards.Items.Add(warDeck[x]);
                            }
                            x++;
                        }

                        warDeck.Clear();
                    }

                    lblWinner.Text = "Player 1 wins!";

                    //updates score labels and next dueling cards
                    lblP1Score.Text = player1Score.ToString();
                    lblP2Score.Text = player2Score.ToString();
                    lblP1Card.Text = player1.First().ToString();
                    if(player2.Count > 0)
                    { 
                        lblP2Card.Text = player2.First().ToString();
                    }
                    else
                    {
                        lblP2Card.Text = "No more cards!";
                    }
                }
                else if (p2Card > p1Card)           //player2 wins card
                {
                    //adds p1 card to p2 list and 1 to score
                    player2.Add(player1.First());
                    player2Score++;

                    //adds new card to p2 listbox
                    int i = player2.IndexOf(player2.Last());
                    lstPlayer2Cards.Items.Add(player2[i]);

                    //removes first card and places at the last index of array
                    string temp = player2[0];
                    player2.Remove(player2[0]);
                    lstPlayer2Cards.Items.RemoveAt(0);
                    player2.Add(temp);
                    lstPlayer2Cards.Items.Add(temp);

                    //removes p1 card from p1 list and subtracts one from p1 score
                    player1 = player1.Where(p => p != player1.First()).ToList();
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player1Score--;

                    if (warDeck.Count > 0)
                    {
                        //clear war cards listbox
                        lstWarCards.Items.Clear();

                        //subtracts one from the count because technically the card(s) was never lost
                        player2Score += warDeck.Count() / 2;
                        player1Score -= warDeck.Count() / 2;

                        int x = 0;
                        foreach (var card in warDeck)
                        {
                            if(card != "")
                            {
                                player2.Add(warDeck[x]);
                                lstPlayer2Cards.Items.Add(warDeck[x]);
                            }
                            x++;
                        }

                        warDeck.Clear();
                    }

                    lblWinner.Text = "Player 2 wins!";

                    //updates score labels and next dueling cards
                    lblP2Score.Text = player2Score.ToString();
                    lblP1Score.Text = player1Score.ToString();
                    lblP2Card.Text = player2.First().ToString();
                    if (player1.Count > 0)
                    {
                        lblP1Card.Text = player1.First().ToString();
                    }
                    else
                    {
                        lblP1Card.Text = "No more cards!";
                    }
                }
                else
                {
                    //moves cards aside until a winner is declared
                    string[] array = new string[4];
                    array[0] = player1.First().ToString();
                    array[1] = player2.First().ToString();
                    if(player1.Count > 1)
                    {
                        array[2] = player1[1].ToString();
                    }
                    if(player2.Count > 1)
                    {
                        array[3] = player2[1].ToString();
                    }

                    //removes cards from each player's deck to avoid duplicates
                    player1 = player1.Where(p => p != player1.First()).ToList();
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player2 = player2.Where(p => p != player2.First()).ToList();
                    lstPlayer2Cards.Items.RemoveAt(0);
                    player1 = player1.Where(p => p != player1.First()).ToList();
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player2 = player2.Where(p => p != player2.First()).ToList();
                    lstPlayer2Cards.Items.RemoveAt(0);

                    WarBattle(array);


                    //updates next dueling cards
                    lblP1Card.Text = player1.First().ToString();
                    lblP2Card.Text = player2.First().ToString();

                    lblWinner.Text = "This means war!";
                }
            }
        }
    }
}
