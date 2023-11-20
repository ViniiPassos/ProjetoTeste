namespace ProjetoTeste
{
    public class TestCase
    {
        public int a, b, soma, multi, resultadoSoma, resultadoMulti;

        [TestCase(4, 5, 9)]
        public void SomaEntreDoisNumeros(int x, int y, int resultado)
        {

            soma = x + y;

            Assert.That(soma, Is.EqualTo(resultado));
        }
    }
}
