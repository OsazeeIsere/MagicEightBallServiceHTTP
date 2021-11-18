using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Location of the proxy
using MagicEightBallServiceClient.ServiceReference1;
namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ask the magic 8 ball \n");
            using(EightBallClient ball=new EightBallClient ())
            {
                Console.Write("Your Question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine( "8-Ball says: {0}",answer);
            }
            Console.ReadLine();

        }
    }
}
