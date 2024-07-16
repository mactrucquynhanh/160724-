using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1

{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Chuong trinh doan so ====");

            Random random = new Random();

            int targetNumber = random.Next(100, 999);

            string targetString = targetNumber.ToString();



            int attemtp = 1, MAX_GUESS = 7;

            string guess, feedback = "";

            while (feedback != "+++" && attemtp <= MAX_GUESS)

            {

                Console.Write(" LAN DOAN THU {0} : ", attemtp);

                do

                {

                    guess = Console.ReadLine();

                }

                while (guess.Length != 3);

                feedback = GetFeedback(targetString, guess);

                Console.WriteLine(" phan hoi tu may tinh : {0}", feedback);

                attemtp++;

            }

            Console.WriteLine(" NGUOI CHOI DA DOAN {0} LAM. /n==> Tro choi ket thuc!", attemtp - 1);

            if (attemtp > MAX_GUESS)

                Console.WriteLine(" NGUOI CHOI DA THUA CUOC !. /N==> So can doan la: {0}", targetNumber);

            else

                Console.WriteLine(" NGƯỜI CHƠI ĐÃ THẮNG CUỘC !", attemtp);

            Console.ReadLine();



        }

        static string GetFeedback(string target, string guess)

        {

            string feedback = "";

            for (int i = 0; i < target.Length; i++)

            {

                if (target[i] == guess[i])

                    feedback += "+";

                else if (target.Contains(guess[i].ToString()))

                    feedback += "?";

            }

            return feedback;

        }
    }
}

