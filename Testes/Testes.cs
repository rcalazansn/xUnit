using Dominio;
using Xunit;

namespace Testes
{
    public class Testes
    {
        [Theory]
        [InlineData(1000, Expediencia.Nenuma)]
        [InlineData(2000, Expediencia.Junior)]
        [InlineData(3000, Expediencia.Pleno)]
        [InlineData(4000, Expediencia.Senio)]
        public void Deve_ser_salario_exeperiencia
            (
                decimal salario, 
                Expediencia experiencia
            )
        {
            var pessoa = new Pessoa(1, "Rodrigo", experiencia);
            decimal salarioPessoa = pessoa.CalcularSalario();

            Assert.Equal(salario, salarioPessoa);
            Assert.Equal(salario, salarioPessoa);
            Assert.Equal(salario, salarioPessoa);
            Assert.Equal(salario, salarioPessoa);
        }

        [Fact]
        public void Deve_ser_sem_experiencia()
        {
            var pessoa = new Pessoa(1, "Rodrigo", Expediencia.Nenuma);
            decimal salario = pessoa.CalcularSalario();

            Assert.Equal(1000, salario);
        }

        [Fact]
        public void Deve_ser_junior()
        {
            var pessoa = new Pessoa(1, "Rodrigo", Expediencia.Junior);
            decimal salario = pessoa.CalcularSalario();

            Assert.Equal(2000, salario);
        }

        [Fact]
        public void Deve_ser_pleno()
        {
            var pessoa = new Pessoa(1, "Rodrigo", Expediencia.Pleno);
            decimal salario = pessoa.CalcularSalario();

            Assert.Equal(3000, salario);
        }

        [Fact]
        public void Deve_ser_senior()
        {
            var pessoa = new Pessoa(1, "Rodrigo", Expediencia.Senio);
            decimal salario = pessoa.CalcularSalario();

            Assert.Equal(4000, salario);
        }
    }
}
