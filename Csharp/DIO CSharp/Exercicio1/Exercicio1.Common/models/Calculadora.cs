using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Common.models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            System.Console.WriteLine($"{x}^{y} = {potencia}");

        }

        public void Seno(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double seno = Math.Sin(radiando);
            System.Console.WriteLine($"Seno de {angulo}º = {seno}");
        }

        public void Cosseno(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiando);
            System.Console.WriteLine($"Cosseno de {angulo}º = {cosseno}");
        }

        public void Tangente(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiando);
            System.Console.WriteLine($"Tangente de {angulo}º = {tangente}");
        }

        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            System.Console.WriteLine($"Raiz quadrada de {numero} = {raiz}");
        }
    }
}