using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTimer
{
    class CurrentGradeHolder
    {
        /**
         * 此class是用來存儲上一次的遊玩紀錄(登入後才開始使用，程式關閉時會跟著消失)
         */ 
        private static double currScore;
        private static string currScramble;

        public void inCurrScore(double time)
        {
            currScore = time;
        }

        public void inCurrScramble(string scramble)
        {
            currScramble = scramble;
        }

        public double getCurrScore()
        {
            return currScore;
        }

        public string getCurrScramble()
        {
            return currScramble;
        }
    }
}
