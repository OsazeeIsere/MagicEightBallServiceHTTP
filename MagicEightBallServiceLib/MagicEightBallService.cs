using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService:IEightBall
    {
        //just for display purposes on the host
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question... ");
        }
      public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = {"Future uncertain","Yes","No","Hazy","Ask again latter"
            ,"Defiinitely"};

            //return  a random response
            Random r = new Random();
            return answers[r.Next(answers.Length)];

        }

    }
}
