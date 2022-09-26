using SonidosAnimales.Animales;
using Xunit;
using System;

    public class AnimalesTest
    {
        [Fact]
        public void PerroEmitirSonidoDevuelveGuau()
        {
            //Arrange
            string Expected = "Guau!";
            //Act
            string Actual = new Perro().EmitirSonido();
        //Assert
        Assert.Equal(Expected, Actual);


        }
    [Fact]
    public void GatoEmitirSonidoDevuelveMiuuu()
    {
        //Arrange
        string Expected = "Miuuu!";
        //Act
        string Actual = new Gato().EmitirSonido();
        //Assert
        Assert.Equal(Expected, Actual);


    }
    [Fact]
    public void ZorroEmitirSonidoDevuelveWapapaau()
    {
        //Arrange
        string Expected = "Wapapapapapa au!";
        //Act
        string Actual = new Zorro().EmitirSonido();
        //Assert
        Assert.Equal(Expected, Actual);


    }
}
