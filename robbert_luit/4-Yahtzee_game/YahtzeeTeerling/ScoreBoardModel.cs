using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class ScoreBoardModel
    {
        private int score = 0;
        public int Score
        {
            get {
                return score;
            }
            set {
                score = value;
            }
        }

        private int highSore;
        public int HighScore
        {
            get
            {
                return highSore;
            }
            set
            {
                highSore = value;
            }
        }

        private int currentScore;
        public int CurrentScore
        {
            get
            {
                return currentScore;
            }

            set
            {
                currentScore = value;
            }
        }
    }
}
