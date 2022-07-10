using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comando de saída de dados
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            // Tipos primitivos do C#
            bool bCondition;    // Representa valores lógicos: true ou false;
            char cOneCharacter; // Representa um caractere como uma unidade de código UTF-16;
            byte nByte;         // Representa um número inteiro sem sinal de 8 bits, no intervalo
                                // entre 0 a 255;
            uint nUint;         // Representa um número inteiro sem sinal de 32 bits, no intervalo
                                // entre 0 a 4.294.967.295;
            int nInt;           // Representa um número inteiro com sinal de 32 bits, no intervalo
                                // entre -2.147.483.648 a 2.147.483.647;
            long nLong;         // Representa um número inteiro com sinal de 64 bits, no intervalo
                                // entre -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807;
            ulong nULong;       // Representa um número inteiro sem sinal de 64 bits, no intervalo
                                // entre 0 a 18.446.744.073.709.551.615.
            float nFloat;       // Representa um número de ponto flutuante de 4 bytes, no intervalo
                                // entre ±1,5 x 10e−45 e ±3,4 x 10e38, com precisão aproximada          
                                // entre 6 a 9 dígitos;
            double nDouble;     // Representa um número de ponto flutuante de 8 bytes, no intervalo
                                // entre ±5.0 × 10e−324 e ±1.7e10308, com precisão aproximada 
                                // entre 15 a 17 dígitos (utilizado para cálculos de VALORES CIENTÍFICOS);
            decimal nDecimal;   // Representa um número de ponto flutuante de 16 bytes, no intervalo
                                // entre ±1.0 × 10e−28 e ±7,9228 x 10e28, com precisão aproximada 
                                // entre 28 e 29 dígitos (utilizado em VALORES MONETÁRIOS);
            string cString;     // Representa textos como uma sequencia de unidades de código UTF-16.

            Console.WriteLine('// Tipos primitivos do C#');
            Console.WriteLine('bool bCondition;    // Representa valores lógicos: true ou false;');
            Console.WriteLine('char cOneCharacter; // Representa um caractere como uma unidade de código UTF-16;');
            Console.WriteLine('byte nByte;         // Representa um número inteiro sem sinal de 8 bits, no intervalo');
            Console.WriteLine('                    // entre 0 a 255;');
            Console.WriteLine('uint nUint;         // Representa um número inteiro sem sinal de 32 bits, no intervalo');
            Console.WriteLine('                    // entre 0 a 4.294.967.295;');
            Console.WriteLine('int nInt;           // Representa um número inteiro com sinal de 32 bits, no intervalo');
            Console.WriteLine('                    // entre -2.147.483.648 a 2.147.483.647;');
            Console.WriteLine('long nLong;         // Representa um número inteiro com sinal de 64 bits, no intervalo');
            Console.WriteLine('                    // entre -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807;');
            Console.WriteLine('ulong nULong;       // Representa um número inteiro sem sinal de 64 bits, no intervalo');
            Console.WriteLine('                    // entre 0 a 18.446.744.073.709.551.615.');
            Console.WriteLine('float nFloat;       // Representa um número de ponto flutuante de 4 bytes, no intervalo');
            Console.WriteLine('                    // entre ±1,5 x 10e−45 e ±3,4 x 10e38, com precisão aproximada          ');
            Console.WriteLine('                    // entre 6 a 9 dígitos;');
            Console.WriteLine('double nDouble;     // Representa um número de ponto flutuante de 8 bytes, no intervalo');
            Console.WriteLine('                    // entre ±5.0 × 10e−324 e ±1.7e10308, com precisão aproximada ');
            Console.WriteLine('                    // entre 15 a 17 dígitos (utilizado para cálculos de VALORES CIENTÍFICOS);');
            Console.WriteLine('decimal nDecimal;   // Representa um número de ponto flutuante de 16 bytes, no intervalo');
            Console.WriteLine('                    // entre ±1.0 × 10e−28 e ±7,9228 x 10e28, com precisão aproximada ');
            Console.WriteLine('                    // entre 28 e 29 dígitos (utilizado em VALORES MONETÁRIOS);');
            Console.WriteLine('string cString;     // Representa textos como uma sequencia de unidades de código UTF-16.');

        }
    }
}
