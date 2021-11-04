using System;

namespace exo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random R = new Random();
            int RNumSuj = 0;
            int RNumV = 0;
            int RNumComp = 0;
            int WrittenLine = 0;

            string[] sujets = new string[] 
            {
                "Un ours",
                "Un GAMER",
                "Une coquillette",
                "Un dragon",
                "L'idiot du village",
                "Tod Howard",
                "Mon envie de vivre",
                "Un furry",
                "Une anguille",
                "Ma mère",
            };

            string[] verbe = new string[]
            {
                " dévore ",
                " écrit ",
                " créé ",
                " flirt avec ",
                " souffle sur ",
                " avale ",
                " vole ",
                " kidnappe ",
                " aiguise ",
                " cuisine "
            };

            string[] complement = new string[]
            {
                "une barque",
                "une coquillette",
                "un lion",
                "le président",
                "un glock",
                "une piscine",
                "ta mère",
                "ma santé mentale",
                "une aiguille",
                "une bonne soupe maison"
            };

            void Phrase()
            {
                RNumSuj = R.Next(0, 10);
                RNumV = R.Next(0, 10);
                RNumComp = R.Next(0, 10);
                Console.WriteLine(sujets[RNumSuj] + verbe[RNumV] + complement[RNumComp]);
            }

            Console.WriteLine("Choisi le nombre de phrase a générer : ");
            string RoughAnswer = Console.ReadLine();

            try
            {
                int NumbLine = int.Parse(RoughAnswer);

                while (WrittenLine < NumbLine)
                {
                    Phrase();
                    WrittenLine = WrittenLine + 1;
                }
            }
            catch
            {
                Console.WriteLine("Oops");
            }

        }



    }
}
