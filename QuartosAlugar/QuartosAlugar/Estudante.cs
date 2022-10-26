namespace QuartosAlugar
{
    class Estudante
    {
        //Atributos
        public string Nome { get; set; }
        public string Email { get; set; }


        //Construtor
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
