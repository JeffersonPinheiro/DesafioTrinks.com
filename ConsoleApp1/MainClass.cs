using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioTrinks
{
    public class MainClass : NumberProcess
    {
        public static void Main(string[] args)
        {
            NumberProcess NrFeliz = new NumberProcess();
            int numero;
            Console.WriteLine("DESAFIO TRINKS.COM\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Digite um Número e saiba se ele é Feliz ou Sortudo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            var ResultFeliz = NrFeliz.NumeroFeliz(numero);
            var ResultSortudo = NrFeliz.NumeroSortudo(numero);

            if(ResultFeliz==true && ResultSortudo == true)
            {
                Console.WriteLine("O Número digitado é Feliz e Sortudo!");
            }
            else if(ResultFeliz == true && ResultSortudo == false)
            {
                Console.WriteLine("O Número digitado é Feliz e Não-Sortudo!");
            }
            else if(ResultFeliz == false && ResultSortudo == true)
            {
                Console.WriteLine("O Número digitado não é Feliz mas é Sortudo!");
            }
            else
            {
                Console.WriteLine("O Número digitado não é Feliz e não é Sortudo");
            }
            Console.ReadKey();
        }

    }
}
