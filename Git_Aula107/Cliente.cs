namespace Git_Aula107
{
    class Cliente
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Cliente(int codigo, string nome, string cpf)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"Codigo: {Codigo}\nNome: {Nome}\nCPF: {Cpf}";
        }
    }
}
