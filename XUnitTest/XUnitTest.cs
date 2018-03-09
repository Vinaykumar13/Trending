using System;
using Xunit;
using Trending;
namespace XUnitTest
{

    public class XUnitTest
    {
        [Fact]
        public void Test_Trending_XUnitTest_OK()
        {
            var result = TrendingRunner.WhatsTrending(1);
            Assert.Equal("Paul Walker", result);

            result = TrendingRunner.WhatsTrending(2);
            Assert.Equal("Cory Monteith", result);

            result = TrendingRunner.WhatsTrending(2);
            Assert.Equal("Cory Monteith", result);

            result = TrendingRunner.WhatsTrending(3);
            Assert.Equal("RoyalBaby", result);

        }

        [Fact]
        public void Test_Trending_XUnitTest_FAIL()
        {
            var result = TrendingRunner.WhatsTrending(1);
            Assert.Equal("Paul Walker", result);
        }
    }
}

