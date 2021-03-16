using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class Perfil
    {
        public string nome { get; private set; }
        public int idade { get; private set; }
        public float altura { get; private set; }
        public int peso { get; private set; }

        public Perfil(string nome, int idade, float altura, int peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }

        public string CalcularIMC()
        {
            float IMC = peso / (altura * altura);

            if(IMC > 18.5f && IMC < 24.9f)
            {
                return "Parabéns — você está em seu peso normal!";
            }
            if (IMC > 25f && IMC < 29.9f)
            {
                return "Você está acima de seu peso (sobrepeso)";
            }
            if (IMC > 30f && IMC < 39.4f)
            {
                return "Obesidade grau I";
            }
            if (IMC > 35f)
            {
                return "Obesidade grau II.";
            }
            else
            {
                return "Obesidade grau III e IV.";
            }

        }

        public void DadosPessoais()
        {
            Console.WriteLine($"nome: {this.nome}");
            Console.WriteLine($"idade: {this.idade}");
            Console.WriteLine($"altura: {this.altura}");
            Console.WriteLine($"peso: {this.peso}");
            Console.WriteLine($"situação IMC: {CalcularIMC()} \n");
        }
    }
}
