using System;
using System.Collections.Generic;

namespace pooShowDoMilhao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NovaPergunta> listPergunta = new List<NovaPergunta>(gerarPerguntas());
            NovaPergunta pergunta = escolherPergunta(listPergunta);

            Console.WriteLine("Pergunta: " + pergunta.Pergunta);

            Quiz(pergunta);
        }

        static List<NovaPergunta> gerarPerguntas()
        {
            string pergunta = "Pergunta A";
            string resposta = "A";
            string dica = "Dica A";
            List<NovaPergunta> listPergunta = new List<NovaPergunta>();
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta B";
            resposta = "B";
            dica = "Dica B";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta C";
            resposta = "C";
            dica = "Dica C";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta D";
            resposta = "D";
            dica = "Dica D";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta E";
            resposta = "E";
            dica = "Dica E";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta F";
            resposta = "F";
            dica = "Dica F";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta G";
            resposta = "G";
            dica = "Dica G";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta H";
            resposta = "H";
            dica = "Dica H";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta I";
            resposta = "I";
            dica = "Dica I";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            pergunta = "Pergunta J";
            resposta = "J";
            dica = "Dica J";
            listPergunta.Add(new NovaPergunta(pergunta, resposta, dica));

            return listPergunta;
        }

        static NovaPergunta escolherPergunta(List<NovaPergunta> list)
        {
            return list[new Random().Next(0, list.Count)];
        }

        static void Quiz(NovaPergunta pergunta)
        {
            bool flag = true;
            int count = 0;

            while (flag)
            {
                if (count >= 1)
                {
                    Console.WriteLine(pergunta.Dica);
                }
                string resposta = Console.ReadLine();
                if (resposta.Equals(pergunta.Resposta))
                {
                    Console.WriteLine("Acertou!");
                    flag = false;
                }
                else
                {
                    count++;
                }
                if (count == 3)
                {
                    Console.WriteLine("Perdeu!");
                    flag = false;
                }
            }
        }
    }
}
