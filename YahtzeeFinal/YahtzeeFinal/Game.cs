using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeFinal
{
    public class Game
    {
        Random rnd = new Random();
        public int[] dice;
        public int[] dice1 = new int[5];
        public int[] dice2 = new int[5];
        public int[] dice3 = new int[5];
        public int[] dice4 = new int[5];
        public int[] dice5 = new int[5];
        public int sumofAces = 0;
        public int sumofTwos = 0;
        public int sumofThrees = 0;
        public int sumofFours = 0;
        public int sumofFives = 0;
        public int sumofSixes = 0;
        int countNum1 = 0;
        int countNum2 = 0;
        int countNum3 = 0;
        int countNum4 = 0;
        int countNum5 = 0;
        int countNum6 = 0;
        int sumofAll = 0;
        int sumofAl1 = 0;
        int sumofAl2 = 0;
        int sumofAl3 = 0;
        int sumofAl4 = 0;
        int sumofAl5 = 0;
        public int[] countNum = new int[6];
        
        int sumofAl6 = 0;
        int totalS = 0;
        int GameSum = 0;

        public Game()
        {
            dice = new int[] { 0, 0, 0, 0, 0, 0 };
        }
        public int[] Roll(int[] dice2)
        {
            for (int i = 0; i < 5; i++)
            {
                if (dice2[i] != 0)
                {
                    dice[i] = dice2[i];
                }
            }
            return dice;
        }
        public int Aces(int[] dice)

        {
            sumofAces = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 1)
                {
                    sumofAces += dice[i];

                }

            }
            return sumofAces;
        }
        public int Twos(int[] dice)

        {
            sumofTwos = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 2)
                {
                    sumofTwos += dice[i];

                }

            }
            return sumofTwos;
        }
        public int Threes(int[] dice)

        {
            sumofThrees = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 3)
                {
                    sumofThrees += dice[i];

                }

            }
            return sumofThrees;
        }
        public int Fours(int[] dice)

        {
            sumofFours = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 4)
                {
                    sumofFours += dice[i];

                }

            }
            return sumofFours;
        }
        public int Fives(int[] dice)

        {
            sumofFives = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 5)
                {
                    sumofFives += dice[i];

                }

            }
            return sumofFives;
        }
        public int Sixes(int[] dice)

        {
            sumofSixes = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 6)
                {
                    sumofSixes += dice[i];

                }

            }
            return sumofSixes;
        }
        public int ThreeOfAKind(int[] diceL)
        {
            sumofAll = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (diceL[i] == 1)
                {
                    countNum1++;
                }
                else if (diceL[i] == 2)
                {
                    countNum2++;
                }
                else if (diceL[i] == 3)
                {
                    countNum3++;
                }
                else if (diceL[i] == 4)
                {
                    countNum4++;

                }
                else if (diceL[i] == 5)
                {
                    countNum5++;
                }
                else if (diceL[i] == 6)
                {
                    countNum6++;
                }


            }
            if (countNum1 == 3)
            {
                sumofAll = 3;
            }
            else if (countNum2 == 3)
            {
                sumofAll = 6;
            }
            else if (countNum3 == 3)
            {
                sumofAll = 9;
            }
            else if (countNum4 == 3)
            {
                sumofAll = 12;

            }
            else if (countNum5 == 3)
            {
                sumofAll = 15;
            }
            else if (countNum6 == 3)
            {
                sumofAll = 18;
            }
            else
            {
                sumofAll = 0;
            }
            return sumofAll;
        }
        public int FourOfAKind(int[] dicez)
        {
            sumofAl1 = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dicez[i] == 1)
                {
                    countNum1++;
                }
                else if (dicez[i] == 2)
                {
                    countNum2++;
                }
                else if (dicez[i] == 3)
                {
                    countNum3++;
                }
                else if (dicez[i] == 4)
                {
                    countNum4++;

                }
                else if (dicez[i] == 5)
                {
                    countNum5++;
                }
                else if (dicez[i] == 6)
                {
                    countNum6++;
                }


            }
            if (countNum1 == 4)
            {
                sumofAl1 = 4;
            }
            else if (countNum2 == 4)
            {
                sumofAl1 = 8;
            }
            else if (countNum3 == 4)
            {
                sumofAl1 = 12;
            }
            else if (countNum4 == 4)
            {
                sumofAl1 = 16;

            }
            else if (countNum5 == 4)
            {
                sumofAl1 = 20;
            }
            else if (countNum6 == 4)
            {
                sumofAl1 = 24;
            }
            else
            {
                sumofAl1 = 0;
            }
            return sumofAl1;
        }
        public int Yahtzee(int[] dicez)
        {
            sumofAl2 = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dicez[i] == 1)
                {
                    countNum1++;
                }
                else if (dicez[i] == 2)
                {
                    countNum2++;
                }
                else if (dicez[i] == 3)
                {
                    countNum3++;
                }
                else if (dicez[i] == 4)
                {
                    countNum4++;

                }
                else if (dicez[i] == 5)
                {
                    countNum5++;
                }
                else if (dicez[i] == 6)
                {
                    countNum6++;
                }


            }
            if (countNum1 == 5)
            {
                sumofAl2 = 50;
            }
            else if (countNum2 == 5)
            {
                sumofAl2 = 50;
            }
            else if (countNum3 == 5)
            {
                sumofAl2 = 50;
            }
            else if (countNum4 == 5)
            {
                sumofAl2 = 50;

            }
            else if (countNum5 == 5)
            {
                sumofAl2 = 50;
            }
            else if (countNum6 == 5)
            {
                sumofAl2 = 50;
            }
            else
            {
                sumofAl2 = 0;
            }
            return sumofAl2;
        }
        public int Fule(int[] dicez)
        {
            sumofAl3 = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dicez[i] == 1)
                {
                    countNum1++;
                }
                else if (dicez[i] == 2)
                {
                    countNum2++;
                }
                else if (dicez[i] == 3)
                {
                    countNum3++;
                }
                else if (dicez[i] == 4)
                {
                    countNum4++;

                }
                else if (dicez[i] == 5)
                {
                    countNum5++;
                }
                else if (dicez[i] == 6)
                {
                    countNum6++;
                }


            }
            countNum[0] = countNum1;
            countNum[1] = countNum2;
            countNum[2] = countNum3;
            countNum[3] = countNum4;
            countNum[4] = countNum5;
            countNum[5] = countNum6;
            
            if (countNum1 == 3 || countNum2 == 3 || countNum3 == 3 || countNum4 == 3 || countNum5 == 3 || countNum6 == 3)
            {
                if(countNum1==2||countNum2==2|| countNum3==2|| countNum4 == 2 || countNum5 == 2 || countNum6 == 2)
                {
                    sumofAl3 = 25;
                }
                else
                {
                    sumofAl3 = 0;
                }


            }
            else
            {
                sumofAl3 = 0;
            }


            return sumofAl3;
        }
        public int Chance(int[] dicez)

        {
            sumofAl4 = 0;

            for (int i = 0; i < 5; i++)
            {
                sumofAl4 += dicez[i];
            }
            return sumofAl4;
        }
        public int SmallS(int[] dicez)
        {
            sumofAl5 = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dicez[i] == 1)
                {
                    countNum1++;
                }
                else if (dicez[i] == 2)
                {
                    countNum2++;
                }
                else if (dicez[i] == 3)
                {
                    countNum3++;
                }
                else if (dicez[i] == 4)
                {
                    countNum4++;

                }
                else if (dicez[i] == 5)
                {
                    countNum5++;
                }
                else if (dicez[i] == 6)
                {
                    countNum6++;
                }


            }
            if (countNum1 == 1 && countNum2 == 1 && countNum3 == 1 && countNum4 == 1)
            {
                sumofAl5 = 30;
            }
            else if (countNum2 == 1 && countNum3 == 1 && countNum4 == 1 && countNum5 == 1)
            {
                sumofAl5 = 30;
            }
            else if (countNum3 == 1 && countNum4 == 1 && countNum5 == 1 && countNum6 == 1)
            {
                sumofAl5 = 30;
            }


            return sumofAl5;
        }
        public int LargeS(int[] dicez)
        {
            sumofAl6 = 0;
            countNum1 = 0;
            countNum2 = 0;
            countNum3 = 0;
            countNum4 = 0;
            countNum5 = 0;
            countNum6 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dicez[i] == 1)
                {
                    countNum1++;
                }
                else if (dicez[i] == 2)
                {
                    countNum2++;
                }
                else if (dicez[i] == 3)
                {
                    countNum3++;
                }
                else if (dicez[i] == 4)
                {
                    countNum4++;

                }
                else if (dicez[i] == 5)
                {
                    countNum5++;
                }
                else if (dicez[i] == 6)
                {
                    countNum6++;
                }


            }
            if (countNum1 == 1 && countNum2 == 1 && countNum3 == 1 && countNum4 == 1 && countNum5 == 1)
            {
                sumofAl6 = 40;
            }
            else if (countNum2 == 1 && countNum3 == 1 && countNum4 == 1 && countNum5 == 1 && countNum6 == 1)
            {
                sumofAl6 = 40;
            }
            


            return sumofAl6;
        }
        public int TotalPlayer1Score(int[] lower, int[] Upper)
        {
            totalS = (GameScore(lower) + GameScore(Upper));
            return totalS;
        }
        public int GameScore(int[] list)

        {
            GameSum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                GameSum += list[i];


            }



            return GameSum;
        }
    }
}
