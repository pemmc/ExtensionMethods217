using System;

//using ExtensionMethods217.Extensions;

namespace ExtensionMethods217
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //meu ano e mes de aniversario e horas de nascimento
            DateTime dt = new DateTime(1971, 08, 13, 22, 00, 00);


            Console.WriteLine(dt.ElapsedTime());

            //o dia de hoje e as horas agora sao (26 de outubro de 2020, 19h06min q estou fazendo o exercício
            dt = new DateTime(2020, 10, 26, 11, 30, 00);

            Console.WriteLine(dt.ElapsedTime());
            */

            string mensagem = "Olá, estendendo a minha classe string, com o meu método";

            Console.WriteLine(mensagem.Cut(10));

            
        }
    }
}
