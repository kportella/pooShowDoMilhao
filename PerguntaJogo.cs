namespace pooShowDoMilhao
{
    public class PerguntaJogo
    {
        public PerguntaJogo(string pergunta, string resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

        public string Pergunta { get; set; }
        public string Resposta { get; set; }

    }
}
