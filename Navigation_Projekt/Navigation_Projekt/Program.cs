using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Projekt
{
    class Program
    { 
        static char Menü()
        {           
            Console.WriteLine("");
            Console.WriteLine(" 1. Favoriten aufrufen");
            Console.WriteLine("");
            Console.WriteLine(" 2. Favoriten verwalten");
            Console.WriteLine("");
            Console.WriteLine(" 3. Neue Route starten");
            Console.WriteLine("");
            Console.WriteLine(" 4. Programm beenden");
            char x = Console.ReadKey(true).KeyChar;
            return x;
        }

        static char FavoritenMenü()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("a) Favorit löschen");
            Console.WriteLine("");
            Console.WriteLine("b) Favorit hinzufügen");
            Console.WriteLine("");
            Console.WriteLine("x: Programm beenden");
            char z = Console.ReadKey(true).KeyChar;
            return z;
        }
        static void MenüOberfläche(int breite, int höhe, ConsoleColor hintergrund)
        {
            Console.SetWindowSize(breite, höhe);
            Console.SetBufferSize(breite, höhe);
            Console.BackgroundColor = hintergrund;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
        }

        static char Error()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("----------------Eingabe ist ungültig....?---------------");
            Console.WriteLine("--------------------------------------------------------");
            System.Threading.Thread.Sleep(4000);
            Environment.Exit(0);
            char y = Console.ReadKey(true).KeyChar;
            return y;
        }
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Navigation";
            int Breite = 150;
            int Höhe = 40;
            MenüOberfläche(Breite, Höhe, ConsoleColor.DarkRed);

            char antwort = 'y';
            char auswahl1;
            char auswahl2;
            

            do
            {
                Console.Clear();
                auswahl1 = Menü();
                switch (auswahl1)
                {
                    case '1':
                        {

                            break;
                        }
                    case '2':
                        {

                            auswahl2 = FavoritenMenü();
                            switch (auswahl2)
                                {
                                   case 'a':
                                     {
                                        
                                        break;
                                     }
                                    case 'b':
                                     {

                                         break;
                                     }
                                    case 'x':
                                     {
                                         Environment.Exit(0);
                                         break;
                                     }
                                    default:
                                     {
                                         auswahl2 = Error();
                                         break;
                                     }
                                }
                            break;
                        }
                    case '3':
                        {

                            break;
                        }
                    case '4':
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            auswahl1 = Error();
                            break;
                        }
                }
            }
            while (antwort != '5');









            Console.ReadKey();

        }
    }
}
