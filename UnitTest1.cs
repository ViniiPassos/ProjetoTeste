
namespace ProjetoTeste
{
    public class Tests
    {
        public int a, b, soma, multi, resultadoSoma, resultadoMulti;
        [SetUp]
        public void Setup()
        {
            a = 5; b = 7;

            soma = a + b;
            resultadoSoma = 12;

            Assert.That(soma, Is.EqualTo(resultadoSoma));
            Console.WriteLine("O resultado da soma é: " + resultadoSoma);

        }

        [Test]
        public void Multi()
        {
            a = 5; b = 7;

            multi = a * b;
            resultadoMulti = 35;

            Assert.That(multi, Is.EqualTo(resultadoMulti));
            Console.WriteLine("O resultado da multiplicação é: " + resultadoMulti);
        }

        [TearDown]
        public void Resultado()
        {

            if(soma != resultadoSoma)
            {
                Console.WriteLine("O valor da soma deve ser: " + soma);
                Console.WriteLine("O valor digitado foi: "+ resultadoSoma); Assert.Fail();
            }

            if (multi != resultadoMulti)
            {
                Console.WriteLine("O valor da multiplicação deve ser: " + multi);
                Console.WriteLine("O valor digitado foi: " + resultadoMulti); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Muito bem! Você respondeu corretamente!");
            }
        }
    }
}