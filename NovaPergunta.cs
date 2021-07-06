namespace pooShowDoMilhao
{
    public class NovaPergunta : PerguntaJogo
    {
        public NovaPergunta(string pergunta, string resposta, string dica) : base(pergunta, resposta)
        {
            this.Dica = dica;
        }

        public string Dica { get; set; }
    }
}
