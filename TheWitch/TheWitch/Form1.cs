using NBCC.CardGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Author: Erica Moisei
* Date: June 3/2019
* Card Game: The Witch
* Notes: OOP Project
*/

namespace TheWitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GameLogic game = new GameLogic();
        private Hand hand1;
        private Hand hand2;
        private Deck deck;
        private int score1 = 0;
        private int score2 = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTurnLabel.Visible = false;
            grpGameOver.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            UpgradeScore();
        }

        #region Methods

        /// <summary>
        /// Shows label who's tunr it is
        /// </summary>
        private void ShowTurnLabel()
        {
            string player = game.ComputerTurn ? lblPlayer1.Text : lblPlayer2.Text;
            lblTurnLabel.Text = $"{player}'s Turn";
           
            Task.Factory.StartNew(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblTurnLabel.Visible = true;

                });

                Thread.Sleep(1500);
                this.Invoke((MethodInvoker)delegate
                {
                    lblTurnLabel.Visible = false;
                });
            });
        }
        
        /// <summary>
        /// Game count Label
        /// </summary>
        private void ShowGameNumber()
        {
            int number = score1 + score2 + 1;
            lblTurnLabel.Text = "".PadRight(6) + $"Game {number}"; ;

            Task.Factory.StartNew(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblTurnLabel.Visible = true;

                });

                Thread.Sleep(1900);
                this.Invoke((MethodInvoker)delegate
                {
                    lblTurnLabel.Visible = false;
                });
            });
        }

        /// <summary>
        /// Refreshes the score in the label
        /// </summary>
        private void UpgradeScore()
        {
            lblScore.Text = $"{lblPlayer1.Text} {score1}/{score2} {lblPlayer2.Text}";
        }

        /// <summary>
        /// Switch the active player and change the panel access
        /// </summary>
        private void SwithPlayer()
        {
            game.ComputerTurn = !game.ComputerTurn;
            StartTurn();
        }

        /// <summary>
        /// Shows the turn player and then gives the access to cards
        /// </summary>
        private void StartTurn()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(200);
                this.Invoke((MethodInvoker)delegate
                {
                    ShowTurnLabel();
                });

                Thread.Sleep(2000);
                this.Invoke((MethodInvoker)delegate
                {
                    PanelAccess();
                });
            });
        }

        /// <summary>
        /// Make opponent player's panel enabled when it is not Computer Turn
        /// </summary>
        private void PanelAccess()
        {
            try
            {
                panel1.Enabled = !game.ComputerTurn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Creates and shuffles new deck
        /// </summary>
        private void SetUp()
        {
            try
            {
                deck = new Deck();
                game.RemoveQueen(deck);
                deck.Shuffle();
                panel1.Controls.Clear();
                panel2.Controls.Clear();
                picCard.Image = null;
                picPair.Image = null;
                picPlay.Visible = false;
                
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(500);
                    this.Invoke((MethodInvoker)delegate
                    {
                        ShowGameNumber();
                    });

                    Thread.Sleep(2200);
                    this.Invoke((MethodInvoker)delegate
                    {
                        DealHands();
                    });
                });
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Starting the game, dealing 2 hands and filtering them from the pairs
        /// </summary>
        private void DealHands()
        {
            try
            {
                List<Hand> hands = deck.DealTwoHands();
                hand1 = hands[0]; // Dealing hands
                hand2 = hands[1];
                game.FilterPairs(hand1); // Taking out all pair cards
                game.FilterPairs(hand2);
                ShowHand(panel1, hand1);
                ShowHand(panel2, hand2);
                
                // Deciding the first turn player
                game.ComputerTurn = hand1.Count < hand2.Count ? true : false;
                StartTurn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Add the hand's card pictures in the panel, shows the back of the cards for computer player
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="hand"></param>
        private void ShowHand(Panel panel, Hand hand)
        {
            Card aCard;
            PictureBox aPic;
            panel.Controls.Clear();

            for (int i = 0; i < hand.Count; i++)
            {
                aCard = hand[i];

                if (panel == panel2)
                {
                    aPic = new PictureBox()
                    {
                        Image = Image.FromFile($@"Images\{aCard.FaceValue.ToString()}{aCard.Suit}.png"),
                        Text = aCard.FaceValue.ToString(),
                        Width = 107,
                        Height = 165,
                        Left = 108 * i,
                        Tag = aCard,
                    };
                }
                else
                {
                    aPic = new PictureBox()
                    {
                        Image = Image.FromFile(@"Images\cardback.jpg"),
                        Text = aCard.FaceValue.ToString(),
                        Width = 107,
                        Height = 165,
                        Left = 108 * i,
                        Tag = aCard,
                    };
                }
                
                aPic.Click -= PictureBox_Click;
                aPic.Click += PictureBox_Click;
                panel.Controls.Add(aPic);
            }
        }
       
        /// <summary>
        /// Automatic play card scenario
        /// Places the choden card in the middle, then it's pair and deletes them
        /// Checks if the game is still on, otherwhise finishes the game
        /// </summary>
        /// <param name="picToDelete"></param>
        private void PlayTheCard(PictureBox picToDelete)
        {
            Card card = (Card)picToDelete.Tag; // Chosen card
            Panel opponentP = (Panel)picToDelete.Parent; // Defining opponent Panel
            Panel myP = opponentP == panel1 ? panel2 : panel1; // Defining my Panel
            Hand opponentHand = opponentP == panel1 ? hand1 : hand2;  // Defining opponent hand
            Hand myHand = opponentHand == hand1 ? hand2 : hand1; // Defining my hand

            // Play chosen card
            opponentHand.RemoveCard(card);
            picToDelete.Image = null;
            picCard.Image = Image.FromFile($@"Images\{card.FaceValue}{card.Suit}.png");

            panel1.Enabled = false;

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2200);

                this.Invoke((MethodInvoker)delegate
                {
                    if (game.IsWitch(card))
                    {
                        picCard.Image = null; // Remove from the middle
                        myHand.AddCard((Card)picToDelete.Tag); // Place with in My Hand
                        myHand.ShuffleHand(); // Changes the placement of the witch
                        ShowHand(opponentP, opponentHand);
                        ShowHand(myP, myHand);
                    }
                    else // Find pair, remove it from my hand and display it in the middle
                    {
                        Card pair = game.PairChosenCard(myHand, card);
                        PictureBox pairPic = GetPictureBox(myP, pair);
                        pairPic.Image = null;
                        picPair.Image = Image.FromFile($@"Images\{pair.FaceValue.ToString()}{pair.Suit}.png");
                    }
                });
                Thread.Sleep(2600);

            }).ContinueWith(delegate
            {
                if (!game.IsWitch(card))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        picCard.Image = null;
                        picPair.Image = null;
                        ShowHand(opponentP, opponentHand);
                        ShowHand(myP, myHand);
                    });
                }
                this.Invoke((MethodInvoker)delegate
                {
                    if (hand1.Count == 0 || hand2.Count == 0)
                    {
                        GameOver();
                        return;
                    }
                    SwithPlayer();
                });

            });
        }

        /// <summary>
        /// Computer play, picks card by generating random index
        /// </summary>
        private void ComputerTurn()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1800);
                this.Invoke((MethodInvoker)delegate
                {
                    Random rGen = new Random();
                    int randomIndex = rGen.Next(0, hand2.Count);
                    Card card = hand2[randomIndex];
                    PlayTheCard(GetPictureBox(panel2, card));
                });
            });
        }

        /// <summary>
        /// Finds and displays the looser, refreshes score
        /// </summary>
        private void GameOver()
        {
            bool theWitch = hand2.Count == 1 ? true : false;
            
            if (!theWitch) score2 += 1;
            else score1 += 1;
            UpgradeScore();
            
            string looser = theWitch ? lblPlayer2.Text : lblPlayer1.Text;
            lblLooser.Text = $"{looser} is the Witch!";
            grpGameOver.Visible = true; // Makes group box visible to start another game
        }

        /// <summary>
        /// Get pecture box by tag using the card when it is Computer turn
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private PictureBox GetPictureBox(Panel p, Card card)
        {
            foreach (PictureBox pBox in p.Controls)
            {
                if (pBox.Tag == card)
                {
                    return pBox;
                }
            }
            return null;
        }

        #endregion

        #region Events

        /// <summary>
        /// Starts a new game, setting up the deck and deal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPlayAgain_Click(object sender, EventArgs e)
        {
            game.IsComputerTurn -= Computer_Turn;
            game.IsComputerTurn += Computer_Turn;
            grpGameOver.Visible = false;
            SetUp();
        }

        /// <summary>
        /// Preparing the deck and deal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPlay_Click(object sender, EventArgs e)
        {
            game.IsComputerTurn -= Computer_Turn;
            game.IsComputerTurn += Computer_Turn;
            SetUp();
        }
        
        /// <summary>
        /// Playing the card, taking the pari out from another had if not a Witch
        /// If a Witch, placing it into another player's hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picToDelete = (PictureBox)sender; // Defining PictureBpx that was clicked
            PlayTheCard(picToDelete);
        }
        
        /// <summary>
        /// Event for computer turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Computer_Turn(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);

                this.Invoke((MethodInvoker)delegate
                {
                    ComputerTurn(); // makes the turn
                });
            });
        }

        #endregion

    }
}
