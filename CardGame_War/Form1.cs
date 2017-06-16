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

        static int player1Score = 26;   //same as player1.Count()
        static int player2Score = 26;   //same as player2.Count()

        //creates deck of 52 cards with all four suits
        public static string[] Deck()
        {
            //creates temp deck of 52 cards with each suite and value
            List<string> tempDeck = new List<string>();
            string[] suits = { "H", "D", "S", "C" };
            string[] value = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int i;
            int j;
            //suits loop
            for (i = 0; i < 4; i++)
            {
                //values loop
                for (j = 0; j < 13; j++)
                {
                    tempDeck.Add(value[j] + " " + suits[i]);
                }
            }

            //assigns tempDeck to the actual deck that will be dealt to players
            string[] deck = tempDeck.ToArray();
            return deck;
        }

        //deals cards from deck to each player
        static void DealCards(string[] deck)
        {
            int j = 0;
            int x = 0;

            int randomDraw = r.Next(0, 52); //gets a random number between 0 and 52
            
            //player 1 deck
            while (j < 26)
            {
                randomDraw = r.Next(0, deck.Count() - 1);   //gets a random number between 0 and the amount of cards left in deck
                player1.Add(deck[randomDraw]);
                j++;
                deck = deck.Where(c => c != deck[randomDraw]).ToArray();
            }

            //player 2 deck
            while (x < 26)
            {
                randomDraw = r.Next(0, deck.Count() - 1);  //minus 1 is there to prevent OutofIndexRange Error
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
            else    //logic for a loss
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
            else
            {
                player2.Clear();
                lstPlayer2Cards.Items.Clear();
                player2Score = 26;
            }

            //initializes new deck object
            string[] deck = Deck();

            //calls deal function with created deck
            DealCards(deck);

            //for loops to populate each player's list of cards.
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

            //enables Battle button if a player has won a game and it became disabled
            btnBattle.Enabled = true;
        }

        //assigns cards to the War Deck array
        private void WarBattle(string[] array)
        {
            foreach (var card in array)
            {
                warDeck.Add(card);
                lstWarCards.Items.Add(card);
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            /*
             * clicking the Battle button compares the first values in each player's list.
             */
            int p1Card = 0;
            int p2Card = 0;
            bool tF = true;  //quick way to prevent card comparison and unnecessary error

            if (player1.Count() == 0 && player2.Count() == 0)   //prevents error and informs player that they must draw cards
            {
                lblWinner.Text = "Please click Draw Cards.";
                tF = false;
            }

            if (player1Score == 52)     //player 1 wins.
            {
                btnBattle.Enabled = false;
                lblWinner.Text = "Player 1 wins the game! Click the Draw Cards button to start another game.";
                tF = false;
            }
            else if (player2Score == 52)  //player 2 wins.
            {
                btnBattle.Enabled = false;
                lblWinner.Text = "Player 2 wins the game! Click the Draw Cards button to start another game.";
                tF = false;
            }

            if (tF == true)     //ensures that the game ends before attempting to process the card value
            {
                string p1 = Regex.Match(player1.First().ToString(), @"\d+").Value;      //finds int value of card
                string p2 = Regex.Match(player2.First().ToString(), @"\d+").Value;

                if (p1 != "")    //if card is not a face card
                {
                    p1Card = Convert.ToInt32(p1);
                }
                else            //if card is face card, numeric value must be assigned
                {
                    p1 = player1.First().Split(' ')[0].ToString();      //finds the "face" within the object in order to assign value

                    switch (p1)             //assigns a numeric value for the face card
                    {
                        case "A":
                            p1Card = 14;    //ace
                            break;

                        case "K":
                            p1Card = 13;    //king
                            break;

                        case "Q":
                            p1Card = 12;    //queen
                            break;

                        case "J":
                            p1Card = 11;    //jack
                            break;
                    }
                }

                if (p2 != "")
                {
                    p2Card = Convert.ToInt32(p2);
                }
                else
                {
                    p2 = player2.First().Split(' ')[0].ToString();
                    switch (p2)
                    {
                        case "A":
                            p2Card = 14;
                            break;

                        case "K":
                            p2Card = 13;
                            break;

                        case "Q":
                            p2Card = 12;
                            break;

                        case "J":
                            p2Card = 11;
                            break;
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

                        player1Score += warDeck.Count() / 2;      //the winning player essentially only gains half of the cards in the war deck because they never truly lost their own cards
                        player2Score -= warDeck.Count() / 2;      //the losing player loses only their cards

                        foreach (var card in warDeck)
                        {
                            if(card != "")
                            { 
                                player1.Add(card);
                                lstPlayer1Cards.Items.Add(card);
                            }
                        }

                        warDeck.Clear();
                    }

                    lblWinner.Text = "Player 1 wins!";

                    //updates score labels and next dueling cards
                    lblP1Score.Text = player1Score.ToString();
                    lblP2Score.Text = player2Score.ToString();
                    lblP1Card.Text = player1.First().ToString();
                    if(player2.Count > 0)   //if the player still has cards, show the first card as the dueling card
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

                        player2Score += warDeck.Count() / 2;
                        player1Score -= warDeck.Count() / 2;

                        foreach (var card in warDeck)
                        {
                            if(card != "")
                            {
                                player2.Add(card);
                                lstPlayer2Cards.Items.Add(card);
                            }
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
                    if(player1.Count > 1)       //prevents overdrawing and erroring out
                    {
                        array[2] = player1[1].ToString();
                    }
                    if(player2.Count > 1)
                    {
                        array[3] = player2[1].ToString();
                    }

                    /* removes 2 cards from each player's deck, but not their score because this is a tie. */
                    player1 = player1.Where(p => p != player1.First()).ToList();
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player2 = player2.Where(p => p != player2.First()).ToList();
                    lstPlayer2Cards.Items.RemoveAt(0);
                    player1 = player1.Where(p => p != player1.First()).ToList();
                    lstPlayer1Cards.Items.RemoveAt(0);
                    player2 = player2.Where(p => p != player2.First()).ToList();
                    lstPlayer2Cards.Items.RemoveAt(0);

                    //sends cards to the war deck array
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
