using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            Console.WriteLine("Bem vindo ao jogo de perguntas e respostas!");
            Console.WriteLine("Você terá que responder a pergunta abaixo, mas terá uma dica para te ajudar!");
            Console.WriteLine("Vamos começar!");
            // Definindo a pergunta, resposta e dica
            Console.WriteLine("_________________________________________________________________________________");
            p.Texto = "Qual é o maior site de pesquisas?";
            p.Resposta = "http://www.google.com.br";
            p.Dica = "Ele também é conhecido como Pai dos burros online!";

            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("Tente adivinhar a pergunta: ");
            Console.WriteLine("Pergunta:"+p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("_________________________________________________________________________________");
            Console.Write("Digite a resposta: ");
            string resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("_________________________________________________________________________________");
                Console.WriteLine("Resposta correta!");
            }
            else
            {
                Console.WriteLine("_________________________________________________________________________________");
                Console.WriteLine("Que pena!!!!! Voçê errou!");
                Console.WriteLine("Resposta errada! A resposta correta é: " + p.Resposta);

            }
            Console.ReadKey();

        }
    }
}
