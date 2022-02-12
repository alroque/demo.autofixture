using AutoFixture;
using Xunit;

namespace demo.autofixture
{
    public class AutofixtureDemoTest
    {
        [Fact]
        public void CrearProductoConAutofixture()
        {
            var fixture = new Fixture();
            var producto = fixture.Create<Producto>();
            var productos = fixture.CreateMany<Producto>();

            Assert.NotNull(producto);
            Assert.NotNull(productos);
        }
    }
}