using System;
using Xunit;
using Pangram;

namespace PangramTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("");
            Assert.Equal(false,result);
        }

        [Fact]
        public void Test2()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("the quick brown fox jumps over the lazy dog");
            Assert.Equal(true,result);
        }

        [Fact]
        public void Test3()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("a quick movement of the enemy will jeopardize five gunboats");
            Assert.Equal(false,result);
        }

        [Fact]
        public void Test4()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("five boxing wizards jump quickly at it");
            Assert.Equal(false,result);
        }

        [Fact]
        public void Test5()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("the_quick_brown_fox_jumps_over_the_lazy_dog");
            Assert.Equal(true,result);
        }

        [Fact]
        public void Test6()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("the 1 quick brown fox jumps over the 2 lazy dogs");
            Assert.Equal(true,result);
        }

        [Fact]
        public void Test7()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("7h3 qu1ck brown fox jumps ov3r 7h3 lazy dog");
            Assert.Equal(false,result);
        }

        [Fact]
        public void Test8()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("\"Five quacking Zephyrs jolt my wax bed.\"");
            Assert.Equal(true,result);
        }

        [Fact]
        public void Test9()
        {
            var controller = new CheckPangram ();
            var result = controller.checkDic("the quick brown fox jumps over with lazy FX");
            Assert.Equal(false,result);
        }
    }
}
