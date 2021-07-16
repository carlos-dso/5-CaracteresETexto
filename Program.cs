using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando o Projeto 5 Caracteres e Textos");

            // Character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia" + 2020;
            string cursosProgramação = " - .Net" +
                " - Java" +
                " - " +
                " - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramação);

            Console.ReadLine();
        }
    }
}
