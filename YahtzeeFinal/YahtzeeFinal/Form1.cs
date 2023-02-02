using System.Threading.Channels;
using System.Threading;

namespace YahtzeeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayerL_Click(object sender, EventArgs e)
        {

        }
        int totalSumz = 0;
        int count = 0;
        int player = 1;
        Game Player1 = new Game();
        Game Player2 = new Game();
        Random rnd = new Random();
        int[] diceResult = new int[5];
        int[] Player1List = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
        int[] Player2List = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] Actual = new int[7] { 0, 0, 0, 0, 0, 0,0};
        int[] LowerActual= new int[7] {0,0,0,0,0,0,0};
        int[] Actual2 = new int[6] { 0, 0, 0, 0, 0, 0 };
        int[] LowerActual2 = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int show = 0;
        int show2 = 0;
        int show3 = 0;
        int show4 = 0;
        int show5 = 0;
        int show6 = 0;
        int show7= 0;
        int show8 = 0;
        int show9 = 0;
        int show10 = 0;
        int show11 = 0;
        int show12 = 0;
        int show13 = 0;
        int show14 = 0;
        int GameSum;
        int player1score = 0;
            int player2score=0;
        int[] test = new int[5] { 1, 5, 2, 1, 6 };

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }


        public int[] Player1Score()
        {
            Player1.Roll(diceResult);
            show = Player1.ThreeOfAKind(diceResult);
            show2 = Player1.FourOfAKind(diceResult);
            show3 = Player1.Fule(diceResult);
            show4 = Player1.Yahtzee(diceResult);
            show5 = Player1.Chance(diceResult);
            show6 = Player1.SmallS(diceResult);
            show7 = Player1.LargeS(diceResult);
            UpdateTOAK();
            if (AcesL.Enabled)
            {
                Player1List[0] = Player1.Aces(diceResult);
            }
            if (TwosL.Enabled)
            {
                Player1List[1] = Player1.Twos(diceResult);

            }
            if (ThreeL.Enabled)
            {
                Player1List[2] = Player1.Threes(diceResult);
            }
            if (FoursL.Enabled)
            {
                Player1List[3] = Player1.Fours(diceResult);
            }
            if (FivesL.Enabled)
            {
                Player1List[4] = Player1.Fives(diceResult);
            }
            if (SixesL.Enabled)
            {
                Player1List[5] = Player1.Sixes(diceResult);
            }


            if (ThreeofKL.Enabled)
            {
                Player1List[6] = Player1.ThreeOfAKind(diceResult);
            }
            if (FourOfAKL.Enabled)
            {
                Player1List[7] = Player1.FourOfAKind(diceResult);

            }
            if (fullHL.Enabled)
            {
                Player1List[8] = Player1.Fule(diceResult);
            }
            if (YahtzeeL.Enabled)
            {
                Player1List[9] = Player1.Yahtzee(diceResult);
            }
            if (ChanceL.Enabled)
            {
                Player1List[10] = Player1.Chance(diceResult);
            }
            if (SmallSL.Enabled)
            {
                Player1List[11] = Player1.SmallS(diceResult);
            }
            if (largeSL.Enabled)
            {
                Player1List[12] = Player1.LargeS(diceResult);
            }


            if (AcesL.Enabled)
            {
                AcesL.Text = Player1.Aces(diceResult).ToString();
            }
            if (TwosL.Enabled)
            {
                TwosL.Text = Player1.Twos(diceResult).ToString();
            }
            if (ThreeL.Enabled)
            {
                ThreeL.Text = Player1.Threes(diceResult).ToString();
            }
            if (FoursL.Enabled)
            {
                FoursL.Text = Player1.Fours(diceResult).ToString();
            }
            if (FivesL.Enabled)
            {
                FivesL.Text = Player1.Fives(diceResult).ToString();
            }
            if (SixesL.Enabled)
            {
                SixesL.Text = Player1.Sixes(diceResult).ToString();
            }


            return Player1List;
        }
        public int[] Player2Score()
        {
            Player2.Roll(diceResult);
            show8 = Player2.ThreeOfAKind(diceResult);
            show9 = Player2.FourOfAKind(diceResult);
            show10 = Player2.Fule(diceResult);
            show11 = Player2.Yahtzee(diceResult);
            show12 = Player2.Chance(diceResult);
            show13 = Player2.SmallS(diceResult);
            show14 = Player2.LargeS(diceResult);
            UpdateTOAK2();
            if (AcesL2.Enabled)
            {
                Player2List[0] = Player2.Aces(diceResult);
            }
            if (TwosL2.Enabled)
            {
                Player2List[1] = Player2.Twos(diceResult);

            }
            if (ThreesL2.Enabled)
            {
                Player2List[2] = Player2.Threes(diceResult);
            }
            if (FoursL2.Enabled)
            {
                Player2List[3] = Player2.Fours(diceResult);
            }
            if (FivesL2.Enabled)
            {
                Player2List[4] = Player2.Fives(diceResult);
            }
            if (SixesL2.Enabled)
            {
                Player2List[5] = Player2.Sixes(diceResult);
            }

            if (ThreeofKL2.Enabled)
            {
                Player2List[6] = Player2.ThreeOfAKind(diceResult);
            }
            if (FourOfAKL2.Enabled)
            {
                Player2List[7] = Player2.FourOfAKind(diceResult);

            }
            if (fullHL2.Enabled)
            {
                Player2List[8] = Player2.Fule(diceResult);
            }
            if (YahtzeeL2.Enabled)
            {
                Player2List[12] = Player2.Yahtzee(diceResult);
            }
            if (ChanceL2.Enabled)
            {
                Player2List[9] = Player2.Chance(diceResult);
            }
            if (SmallSL2.Enabled)
            {
                Player2List[10] = Player2.SmallS(diceResult);
            }
            if (largeSL2.Enabled)
            {
                Player2List[11] = Player2.LargeS(diceResult);
            }



            if (AcesL2.Enabled)
            {
                AcesL2.Text = Player2.Aces(diceResult).ToString();
            }
            if (TwosL2.Enabled)
            {
                TwosL2.Text = Player2.Twos(diceResult).ToString();
            }
            if (ThreesL2.Enabled)
            {
                ThreesL2.Text = Player2.Threes(diceResult).ToString();
            }
            if (FoursL2.Enabled)
            {
                FoursL2.Text = Player2.Fours(diceResult).ToString();
            }
            if (FivesL2.Enabled)
            {
                FivesL2.Text = Player2.Fives(diceResult).ToString();
            }
            if (SixesL2.Enabled)
            {
                SixesL2.Text = Player2.Sixes(diceResult).ToString();
            }


            return Player2List;
        }
        public void UpdateTOAK()

        {

            if (ThreeofKL.Enabled)
            {
                ThreeofKL.Text = show.ToString();
                
            }
            
           
            ThreeofKL.Update();
            if (FourOfAKL.Enabled)
            {
                FourOfAKL.Text = show2.ToString();
                
            }
            
            
            FourOfAKL.Update();
            if (fullHL.Enabled)
            {
                fullHL.Text = show3.ToString();

            }
            
            
            fullHL.Update();
            if (YahtzeeL.Enabled)
            {
                YahtzeeL.Text = show4.ToString();

            }
          
            
            YahtzeeL.Update();
            if (ChanceL.Enabled)
            {
                ChanceL.Text = show5.ToString();
                
            }
           
            
            ChanceL.Update();
            if (SmallSL.Enabled)
            {
                SmallSL.Text = show6.ToString();
               
            }
            
            
            SmallSL.Update();
            if (largeSL.Enabled)
            {
                largeSL.Text = show7.ToString();
                
            }
            
            
            largeSL.Update();   








        }
        public void UpdateTOAK2()

        {
            if (ThreeofKL2.Enabled)
            {
                ThreeofKL2.Text = show8.ToString();
            }
            
            ThreeofKL2.Update();
            if(FourOfAKL2.Enabled)
            {

                FourOfAKL2.Text = show9.ToString();
            }
            
            FourOfAKL2.Update();
            if (fullHL2.Enabled)
            {
                fullHL2.Text = show10.ToString();
            }
           
            fullHL2.Update();
            if (YahtzeeL2.Enabled)
            {
                YahtzeeL2.Text = show11.ToString();
            }
            
            YahtzeeL2.Update();
            if (ChanceL2.Enabled)
            {
                ChanceL2.Text = show12.ToString();
            }
            
            ChanceL2.Update();
            if(SmallSL2.Enabled)
            {
                SmallSL2.Text = show13.ToString();
            }
            
            SmallSL2.Update();
            if (largeSL2.Enabled)
            {
                largeSL2.Text = show14.ToString();
            }
           
            largeSL2.Update();








        }

       
        public void players()
        {
            button1.Enabled = true;
            count = 0;

            if (player == 1)
            {



                playerL.Text = "Player 2";
                player = 2;

            }
            else if (player == 2)
            {

                playerL.Text = "Player 1";
                player = 1;

            }
        }

        public void clear()
        {
            dice1L.Text = String.Empty;
            dice2L.Text = String.Empty;
            dice3L.Text = String.Empty;
            dice4L.Text = String.Empty;
            dice5L.Text = String.Empty;
            hold1.Checked = false;
            hold2.Checked = false;
            hold3.Checked = false;
            hold4.Checked = false;
            hold5.Checked = false;

        }

        private void Player1Label()
        {
            if (AcesL.Enabled)
            {
                AcesL.Text = "";
            }
            if (TwosL.Enabled)
            {
                TwosL.Text = "";
            }
            if (ThreeL.Enabled)
            {
                ThreeL.Text = "";
            }
            if (FoursL.Enabled)
            {
                FoursL.Text = "";
            }
            if (FivesL.Enabled)
            {
                FivesL.Text = "";
            }
            if (SixesL.Enabled)
            {
                SixesL.Text = "";
            }
            if (ThreeofKL.Enabled)
            {
                ThreeofKL.Text = "";
            }
            if (ChanceL.Enabled)
            {
                ChanceL.Text = "";
            }
            if (YahtzeeL.Enabled)
            {
                YahtzeeL.Text = "";

            }
            if (SmallSL.Enabled)
            {
                SmallSL.Text = "";
            }
            if (FourOfAKL.Enabled)
            {
                FourOfAKL.Text = "";
            }
            if (YahtzeeL.Enabled)
            {
                YahtzeeL.Text = "";

            }
            if (fullHL.Enabled)
            {
                fullHL.Text = "";
            }
            if (largeSL.Enabled)
            {
                largeSL.Text = "";
            }
            button1.Enabled = false;
        }
        private void Player2Label()
        {
            if (AcesL2.Enabled)
            {
                AcesL2.Text = "";
            }
            if (TwosL2.Enabled)
            {
                TwosL2.Text = "";
            }
            if (ThreesL2.Enabled)
            {
                ThreesL2.Text = "";
            }
            if (FoursL2.Enabled)
            {
                FoursL2.Text = "";
            }
            if (FivesL2.Enabled)
            {
                FivesL2.Text = "";
            }
            if (SixesL2.Enabled)
            {
                SixesL2.Text = "";
            }
            if (ThreeofKL2.Enabled)
            {
                ThreeofKL2.Text = "";
            }
            if (ChanceL2.Enabled)
            {
                ChanceL2.Text = "";
            }
            if (YahtzeeL2.Enabled)
            {
                YahtzeeL2.Text = "";

            }
            if (SmallSL2.Enabled)
            {
                SmallSL2.Text = "";
            }
            if (FourOfAKL2.Enabled)
            {
                FourOfAKL2.Text = "";
            }
            if (YahtzeeL2.Enabled)
            {
                YahtzeeL2.Text = "";

            }
            if (fullHL2.Enabled)
            {
                fullHL2.Text = "";
            }
            if (largeSL2.Enabled)
            {
                largeSL2.Text = "";
            }
            button1.Enabled = false;
        }
        private void AcesL_Click(object sender, EventArgs e)
        {
            
            

        }

        private void TwosL_Click(object sender, EventArgs e)
        {
            
            

        }

        private void ThreeL_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FoursL_Click(object sender, EventArgs e)
        {
           
        }

        private void FivesL_Click(object sender, EventArgs e)
        {
            
        }

        private void SixesL_Click(object sender, EventArgs e)
        {
           
        }

        

        
        private void TwosL_Click_1(object sender, EventArgs e)
        {
            Actual[1] = Player1List[1];
            TwosL.Enabled = false;
            Player1Label();
            gameSums.Text =Player1.GameScore(Actual).ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void YahtzeeL_Click(object sender, EventArgs e)
        {
            LowerActual[5] = Player1List[9];
            YahtzeeL.Enabled = false;
            Player1Label();

            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            count++;
            for (int i = 0; i < 5; i++)
            {
                if (!hold1.Checked)
                {
                    diceResult[0] = rnd.Next(1, 7);
                    dice1L.Text = diceResult[0].ToString();
                }
                if (!hold2.Checked)
                {
                    diceResult[1] = rnd.Next(1, 7);
                    dice2L.Text = diceResult[1].ToString();
                }
                if (!hold3.Checked)
                {
                    diceResult[2] = rnd.Next(1, 7);
                    dice3L.Text = diceResult[2].ToString();
                }
                if (!hold4.Checked)
                {
                    diceResult[3] = rnd.Next(1, 7);
                    dice4L.Text = diceResult[3].ToString();
                }
                if (!hold5.Checked)
                {
                    diceResult[4] = rnd.Next(1, 7);
                    dice5L.Text = diceResult[4].ToString();
                }
            }
            if (player == 1)
            {
                Player1Score();

            }
            else if (player == 2)
            {
                Player2Score();
            }

            if (count == 3)
            {
                button1.Enabled = false;

            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            players();
            if(!AcesL.Enabled && !AcesL2.Enabled && !ThreeL.Enabled && !ThreesL2.Enabled && !FoursL.Enabled && !FoursL2.Enabled && !FivesL.Enabled && !FivesL2.Enabled &&!SixesL.Enabled && !SixesL2.Enabled && !FourOfAKL2.Enabled && !FourOfAKL.Enabled && !ThreeofKL.Enabled && !ThreeofKL2.Enabled && !fullHL.Enabled && !fullHL2.Enabled && !ChanceL.Enabled &&  !ChanceL2.Enabled && !largeSL.Enabled && !largeSL2.Enabled && !SmallSL.Enabled && !SmallSL2.Enabled && !YahtzeeL.Enabled && !YahtzeeL2.Enabled)
            {
                player1score = Player1.TotalPlayer1Score(LowerActual, Actual);
                player2score = Player2.TotalPlayer1Score(LowerActual2, Actual2);


                if (player1score> player2score){
                    label16.Text = "Player 1 Wins!";
                }
                else
                {
                    label16.Text = "Player 2 Wins!";
                }
            }
            
            clear();
        }

        private void AcesL_Click_1(object sender, EventArgs e)
        {
            Actual[0] = Player1List[0];
            AcesL.Enabled = false;
            Player1Label();
            gameSums.Text = Player1.GameScore(Actual).ToString();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void ThreeL_Click_1(object sender, EventArgs e)
        {
            Actual[2] = Player1List[2];
            ThreeL.Enabled = false;
            Player1Label();
            gameSums.Text = Player1.GameScore(Actual).ToString();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void FoursL_Click_1(object sender, EventArgs e)
        {
            Actual[3] = Player1List[3];
            FoursL.Enabled = false;
            Player1Label();
            gameSums.Text = Player1.GameScore(Actual).ToString();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void FivesL_Click_1(object sender, EventArgs e)
        {
            Actual[4] = Player1List[4];
            
            FivesL.Enabled = false;
            Player1Label();
            gameSums.Text = Player1.GameScore(Actual).ToString();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void SixesL_Click_1(object sender, EventArgs e)
        {
            Actual[5] = Player1List[5];
            SixesL.Enabled = false;
            Player1Label();
            gameSums.Text =  Player1.GameScore(Actual).ToString();
            totalSum.Text=Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void ThreeofKL_Click(object sender, EventArgs e)
        {
            LowerActual[0] = Player1List[6];
           
            
            ThreeofKL.Enabled = false;
            Player1Label();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();


        }

        private void FourOfAKL_Click(object sender, EventArgs e)
        {
            LowerActual[1] = Player1List[7];
            FourOfAKL.Enabled = false;
            Player1Label();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();

        }

        private void fullHL_Click(object sender, EventArgs e)
        {
            LowerActual[2] = Player1List[8];
            fullHL.Enabled = false;
            Player1Label();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();

        }

        private void ChanceL_Click(object sender, EventArgs e)
        {
            LowerActual[3] = Player1List[10];
            ChanceL.Enabled = false;
            Player1Label();

            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();
        }

        private void SmallSL_Click(object sender, EventArgs e)
        {
            LowerActual[4] = Player1List[11];
            SmallSL.Enabled = false;
            Player1Label();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();
        }

        private void largeSL_Click(object sender, EventArgs e)
        {
            LowerActual[6] = Player1List[12];
            largeSL.Enabled = false;
            Player1Label();
            totalSum.Text = Player1.TotalPlayer1Score(LowerActual, Actual).ToString();
        }

        private void AcesL2_Click(object sender, EventArgs e)
        {
            Actual2[0] = Player2List[0];
            AcesL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void TwosL2_Click(object sender, EventArgs e)
        {
            Actual2[1] = Player2List[1];
            TwosL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void ThreesL2_Click(object sender, EventArgs e)
        {
            Actual2[2] = Player2List[2];
            ThreesL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void FoursL2_Click(object sender, EventArgs e)
        {
            Actual2[3] = Player2List[3];
            FoursL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void FivesL2_Click(object sender, EventArgs e)
        {
            Actual2[4] = Player2List[4];
            FivesL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString(); ;
        }

        private void SixesL2_Click(object sender, EventArgs e)
        {
            Actual2[5] = Player2List[5];
            SixesL2.Enabled = false;
            Player2Label();
            player2Sum.Text = Player2.GameScore(Actual2).ToString();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void ThreeofKL2_Click(object sender, EventArgs e)
        {
           LowerActual2[0] = Player2List[6];
            ThreeofKL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void FourOfAKL2_Click(object sender, EventArgs e)
        {
            LowerActual2[1] = Player2List[7];
            FourOfAKL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void fullHL2_Click(object sender, EventArgs e)
        {
            LowerActual2[2] = Player2List[8];
            fullHL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void ChanceL2_Click(object sender, EventArgs e)
        {
            LowerActual2[3] = Player2List[9];
            ChanceL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void SmallSL2_Click(object sender, EventArgs e)
        {
            LowerActual2[4] = Player2List[10];
            SmallSL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void largeSL2_Click(object sender, EventArgs e)
        {
            LowerActual2[5] = Player2List[11];
            largeSL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void YahtzeeL2_Click(object sender, EventArgs e)
        {
            LowerActual2[6] = Player2List[12];
            YahtzeeL2.Enabled = false;
            Player2Label();
            player2To.Text = Player2.TotalPlayer1Score(LowerActual2, Actual2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerL.Text = "Player 1";
            player = 1;

            AcesL.Enabled=true;
               
                AcesL2.Enabled= true;

            TwosL.Enabled= true;
            TwosL2.Enabled= true;

            ThreeL.Enabled = true;


            ThreesL2.Enabled = true;


            FoursL.Enabled = true;


            FoursL2.Enabled = true;


            FivesL.Enabled = true;

            FivesL2.Enabled = true;


            SixesL.Enabled = true;


            SixesL2.Enabled = true;
                
                FourOfAKL2.Enabled=true;


            FourOfAKL.Enabled = true;

            ThreeofKL.Enabled = true;

            ThreeofKL2.Enabled = true;

            fullHL.Enabled = true;

            fullHL2.Enabled = true;

            ChanceL.Enabled = true;

            ChanceL2.Enabled = true;

            largeSL.Enabled = true;

            largeSL2.Enabled = true;

            SmallSL.Enabled = true;

            SmallSL2.Enabled = true;

            YahtzeeL.Enabled = true;

            YahtzeeL2.Enabled = true;
            Player1Label();
            Player2Label();
            clear();
            diceResult = new int[5];
            Player1List = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player2List = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Actual = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            LowerActual = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            Actual2 = new int[6] { 0, 0, 0, 0, 0, 0 };
            LowerActual2 = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            button1.Enabled = true;
            label16.Text=String.Empty;
            totalSum.Text=String.Empty; 
            player2To.Text=String.Empty;
            gameSums.Text=String.Empty;
            player2Sum.Text= String.Empty;


        }
    }
}