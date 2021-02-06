using Examen_Final.Controllers;
using NUnit.Framework;

namespace Tests
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumeroGet()
        {

            //Arange=Preparaci�n
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();

            //Act=Ejecuci�n

            string resultado = lit.NumeroGet(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }

    
        
/*
        [Test]
        public void TestNumeroPost()    
        {

            //Arange=Preparaci�n
            string num1 = "0";
            string esperado = "Cero";

            LiteralController lit = new LiteralController();

            //Act=Ejecuci�n

            string resultado = lit.NumeroPost(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }*/

        [Test]
        public void TestNumeroGet1()
        {

            //Arange=Preparaci�n
            string num1 = "10.2";
            string esperado = "Diez punto dos";

            LiteralController lit = new LiteralController();

            //Act=Ejecuci�n

            string resultado = lit.NumeroGet(num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
    }
}