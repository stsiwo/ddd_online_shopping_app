using System;
using Xunit;
using StsOnlineShopApp.Domain.UserAggregate;
using Xunit.Abstractions;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace UnitTesting
{
    public class UserTest : Test
    {
        private readonly User TestUser;

        private readonly ProductId TestProductId;
        public UserTest(ITestOutputHelper output) : base(output)
        {
            this.TestUser = new User();
            this.TestProductId = new ProductId();
        } 
        [Fact]
        public void shouldNewuserIsGuestAtDefault()
        {
            // make sure id, date also are assigned properly
            this.output.WriteLine(this.TestUser.UserId.ToString());
            this.output.WriteLine(this.TestUser.CreationDate.ToString());
            this.output.WriteLine(this.TestUser.UserType.ToString());

            Assert.Equal(UserTypeEnum.Guest.ToString(), this.TestUser.UserType.ToString());
        }

        [Fact]
        public void shouldInitialCartSizeIsZero()
        {
            Assert.Equal("0", this.TestUser.GetSizeOfCart().ToString());
        }

        [Fact]
        public void shouldCartSizeIsOneAfterAddProduct()
        {
            this.TestUser.AddProductToCart(this.TestProductId);

            Assert.Equal("1", this.TestUser.GetSizeOfCart().ToString());
            Assert.Contains(this.TestProductId, this.TestUser.GetProductsInCart());
        }
        
        [Fact]
        public void shouldCartSizeIsZeroAfterREmoveProduct()
        {
            this.TestUser.RemoveProductFromCart(this.TestProductId);

            Assert.Equal("0", this.TestUser.GetSizeOfCart().ToString());
        }
    }
}
