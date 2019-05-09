namespace Dominio
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, Expediencia expediencia)
        {
            Id = id;
            Nome = nome;
            Expediencia = expediencia;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Expediencia Expediencia { get; private set; }

        public decimal CalcularSalario()
        {
            decimal _salario = 1000;

            switch (Expediencia)
            {
                case Expediencia.Junior:
                    _salario *= 2;
                    break;
                case Expediencia.Pleno:
                    _salario *= 3;
                    break;
                case Expediencia.Senio:
                    _salario *= 4;
                    break;
            }

            return _salario;
        }
    }

    public enum Expediencia
    {
        Nenuma,
        Junior,
        Pleno,
        Senio
    }
}
