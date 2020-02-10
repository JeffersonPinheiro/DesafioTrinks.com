using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTrinks
{
    public class NumberProcess
    {
        public bool NumeroFeliz(int n)
        {            
            int obj = n * n;            
            string Conversao = obj.ToString();
            char[] NrFeliz = Conversao.ToCharArray();

            int soma = 0;
            int inteiro = 0;
            int quadrado = 0;
            List<int> QuFeliz = new List<int>();

            while (soma != 1)
            {
                for (int i = 0; i < NrFeliz.Length; i++)
                {
                    inteiro = Convert.ToInt32(NrFeliz[i].ToString());
                    quadrado = inteiro * inteiro;
                    if (quadrado != 0)
                    {
                        QuFeliz.Add(quadrado);
                        soma = QuFeliz.Sum();
                        if (soma != QuFeliz[0])
                        {
                            string conv = soma.ToString();
                            NrFeliz = conv.ToCharArray();
                        }
                        if (soma == 1)
                        {
                            Console.WriteLine(soma);
                        }                    
                    }
                }
                QuFeliz.Clear();
            }
            if (soma == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NumeroSortudo(int n)
        {
            int[] NrSortudo01 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            var ListaNrSortudo01 = NrSortudo01.ToList();
            for (int i = 0; i < ListaNrSortudo01.Count; i++)
            {
                
                if (ListaNrSortudo01[i] % 2 == 0)
                {
                    ListaNrSortudo01.RemoveAt(i);
                }
            }
            var NovaLista01 = ListaNrSortudo01;
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Lista 1");
            Console.WriteLine("------------------------\n");
            foreach (var item in NovaLista01)
            {
                Console.WriteLine(item);
            }


            var ListaNrSortudo02 = ListaNrSortudo01;
            for (int i = 0; i < ListaNrSortudo02.Count; i++)
            {

                if (ListaNrSortudo02[i] % 3 == 0)
                {
                    ListaNrSortudo02.RemoveAt(i);
                }
            }
            var NovaLista02 = ListaNrSortudo02;
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Lista 2");
            Console.WriteLine("------------------------\n");
            foreach (var item in NovaLista02)
            {
                Console.WriteLine(item);
            }

            var ListaNrSortudo03 = ListaNrSortudo02;
            for (int i = 0; i < ListaNrSortudo03.Count; i++)
            {

                if (ListaNrSortudo03[i] % 7 == 0)
                {
                    ListaNrSortudo03.RemoveAt(i);
                }
            }
            var NovaLista03 = ListaNrSortudo03;
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Lista 3");
            Console.WriteLine("------------------------\n");
            foreach (var item in NovaLista03)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < NovaLista01.Count; i++)
            {
                if(i == n)
                {
                    return true;   
                }
            }
            return false;
        }
    }
}
