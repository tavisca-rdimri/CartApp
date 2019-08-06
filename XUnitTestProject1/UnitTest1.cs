using Xunit;
using CartApp;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Adding_Product_To_CartItem_And_Checking_CartItemTotal()
        {
            Product Cap = new Product("Cap", 120);
            CartItem CapCart = new CartItem(Cap, 2);
            Assert.Equal(240, CapCart.GetCartTotal());
        }
        [Fact]
        public void Adding_Different_Product_To_Cart_And_Checking_CartToTal()
        {
            Product Cap = new Product("Cap", 120);
            Product Jean = new Product("Jean", 1500);
            CartItem CapCart = new CartItem(Cap, 1);
            CartItem JeanCart = new CartItem(Jean, 2);
            Cart AmazonCart = new Cart();
            AmazonCart.AddToCart(CapCart);
            AmazonCart.AddToCart(JeanCart);
            Assert.Equal(3120, AmazonCart.GetTotal());
        }
        [Fact]
        public void Empty_Cart_should_Return_Zero()
        {
            Cart AmazonCart = new Cart();
            Assert.Equal(0, AmazonCart.GetTotal());
        }
        [Fact]
        public void Checking_Discount_On_Cart()
        {
            Product Cap = new Product("Cap", 120);
            Product Jean = new Product("Jean", 1500);
            CartItem CapCart = new CartItem(Cap, 1);
            CartItem JeanCart = new CartItem(Jean, 2);
            Cart AmazonCart = new Cart();
            AmazonCart.AddToCart(CapCart);
            AmazonCart.AddToCart(JeanCart);
            AmazonCart.GetTotal();
            Assert.Equal(1560, AmazonCart.GetTotalDiscount());
        }
    }
}
