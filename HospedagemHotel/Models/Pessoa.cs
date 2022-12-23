namespace HospedagemHotel.Models
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string? Sobrenome { get; private set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome, string? sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome deve ser preenchido.");
        }
    }
}