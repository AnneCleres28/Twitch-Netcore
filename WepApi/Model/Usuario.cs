namespace WepApi.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }

        public Usuario(string nome, string sobrenome, int idade, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}
