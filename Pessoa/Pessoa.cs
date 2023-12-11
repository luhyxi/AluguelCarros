namespace Usuarios
{
    public class Pessoa
    {
        public int IdPessoa { get; private set; }
        public string nome { get; set; }

        public Pessoa(string nome)
        {
            IdPessoa = GerarId();
            this.nome = nome;
        }
        
        // Contador de IDs PRECISA SER STATIC!!!!!
        private static int contadorId = 0;

        private static int GerarId() => contadorId++;

        public string MudarNome(string novoNome) => nome = novoNome;
    }
}
