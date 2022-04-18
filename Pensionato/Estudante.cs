namespace Pensionato
{
    internal class Estudante
    {
        string Nome { get; set; }
        string Email { get; set; }

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
