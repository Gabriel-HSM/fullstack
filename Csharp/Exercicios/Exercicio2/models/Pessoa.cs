using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2.models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }
        private string _nome;
        private int _Idade;
        
        public string Nome
        {
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _Idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("A idade não pode ser menor que zero");
                }
                _Idade = value;
            }
        }



        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}