/*******************************************************

Nom ......... : Exercice 24
Role ........ : Affichage température la plus haute
                et température la plus basse

Auteur ...... : Jérémy PATAPY
Version ..... : V1.0 du 20/10/2021

********************************************************/
using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;

namespace Exercice_24
{
    class Program
    {
        static void Main(string[] args)
        {
            float maxtemp = 0;
            float mintemp = 0;
            float température = 0;
            bool correcte = false;

            Console.WriteLine("    -------------------------\n\n      Exercice 24/Contrôle\n\n    -------------------------");

            for (int boucle = 1; boucle <= 10; boucle++){

                correcte = false;

                while (!correcte){

                    try{
                        Console.Write("  Veuillez saisir la " + boucle + " température : ");
                        température = float.Parse(Console.ReadLine());
                        correcte = true;
                    }catch (Exception ex){
                        Console.WriteLine(ex.Message);
                    }
                }

                if (mintemp == 0 || maxtemp == 0)
                {
                    maxtemp = température;
                    mintemp = température;
                }else{
                    if (température > maxtemp){
                        maxtemp = température;
                        Console.WriteLine("      Plus haut qu'une valeur précédente");
                    }
                    if (température < mintemp){
                        mintemp = température;
                        Console.WriteLine("      Plus bas qu'une valeur précédente");
                    }
                }
            }
            Console.WriteLine("\n\n La température la plus haute saisie est : " + maxtemp + "°C\n La température la plus basse saisie est : " + mintemp+"°C");
            Console.ReadLine();
        }
    }
}