using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pénztárgép alkalmazás:
//Készítsen egy alkalmazást a pénztárgéphez! A program kérjen be a felhasználótól egy számot, - ha nem szám azt ne vegye 
//figyelembe – majd addig folytassa ezt és adja hozzá az összeghez, míg a felhasználó Entert nem nyom az alkalmazásban.
//Az Enter lenyomása után írja ki a teljes összeget!
//Szorgalmi:
//•	Írja ki a program a részösszegeket, minden egyes bevitelnél!
//A program megírásához szükséges ismeretek:
//•	Konzolos alkalmazás bevitel, kiíratás
//•	Vezérlési szerkezetek
//•	string és int osztály beépült metódusai

namespace Penztargep
{
    class Program
    {
               
        static void Main(string[] args)
        {
            string input = "";           
            int vegosszeg = 0;


            Console.WriteLine("Adjon meg összegeket: ");

            do
            {
                input = Console.ReadLine();
                int resz;
                int.TryParse(input, out resz); //ha inputot tudja parsolni(átalakítani int típussá) akkor belerakja resz valtozóba
                vegosszeg += resz;
                Console.WriteLine("Reszösszeg: "+ vegosszeg);

            } while (!string.IsNullOrEmpty(input)); //addig meg amig entert nem ütünk. Nem Enter gombot vizsgáljuk hanem hogy input üres e. Ha igen leáll a program

            Console.WriteLine("Végösszeg: " + vegosszeg);

            Console.ReadKey();


        }
    }
}
