using Chynayeu90331.Controllers;
using Chynayeu90331.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Chynayeu90331.Tests
{
    public class ProductControllerTests
    {
    
    [Theory]
        [MemberData(nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ControllerGetsProperPage(int page, int qty, int id)
        {
            // Arrange 
            var controller = new ProductController();
            var data = TestData.GetDishesList();
            controller._dishes = TestData.GetDishesList();
            var comparer = Comparer<Dish>.GetComparer((d1, d2) => d1.DishId.Equals(d2.DishId));

            // act
            var result = controller.Index(2) as ViewResult; var model = result.Model as List<Dish>;
            // assert
            Assert.Equal(2, model.Count);
            Assert.Equal(data[2], model[0], comparer);
        }
    }
}
