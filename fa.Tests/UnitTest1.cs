using Microsoft.VisualStudio.TestTools.UnitTesting;
using fans;
using System.Linq;

namespace fa.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // FA1: ровно один '0' и хотя бы одна '1'
        [TestMethod] public void FA1_Accept_10() => Assert.IsTrue(new FA1().Run("10".ToCharArray()));
        [TestMethod] public void FA1_Accept_01() => Assert.IsTrue(new FA1().Run("01".ToCharArray()));
        [TestMethod] public void FA1_Accept_110() => Assert.IsTrue(new FA1().Run("110".ToCharArray()));
        [TestMethod] public void FA1_Accept_101() => Assert.IsTrue(new FA1().Run("101".ToCharArray()));
        [TestMethod] public void FA1_Reject_0() => Assert.IsFalse(new FA1().Run("0".ToCharArray()));
        [TestMethod] public void FA1_Reject_1() => Assert.IsFalse(new FA1().Run("1".ToCharArray()));
        [TestMethod] public void FA1_Reject_00() => Assert.IsFalse(new FA1().Run("00".ToCharArray()));
        [TestMethod] public void FA1_Reject_111() => Assert.IsFalse(new FA1().Run("111".ToCharArray()));
        [TestMethod] public void FA1_Reject_001() => Assert.IsFalse(new FA1().Run("001".ToCharArray()));
        [TestMethod] public void FA1_Empty() => Assert.IsFalse(new FA1().Run("".ToCharArray()));

        // FA2: нечётное кол-во '0' И нечётное кол-во '1'
        [TestMethod] public void FA2_Accept_01() => Assert.IsTrue(new FA2().Run("01".ToCharArray()));
        [TestMethod] public void FA2_Accept_10() => Assert.IsTrue(new FA2().Run("10".ToCharArray()));
        [TestMethod] public void FA2_Accept_000111() => Assert.IsTrue(new FA2().Run("000111".ToCharArray()));
        [TestMethod] public void FA2_Accept_0111() => Assert.IsTrue(new FA2().Run("0111".ToCharArray()));
        [TestMethod] public void FA2_Accept_0001() => Assert.IsTrue(new FA2().Run("0001".ToCharArray()));
        [TestMethod] public void FA2_Accept_0000011111() => Assert.IsTrue(new FA2().Run("0000011111".ToCharArray()));
        [TestMethod] public void FA2_Reject_0() => Assert.IsFalse(new FA2().Run("0".ToCharArray()));
        [TestMethod] public void FA2_Reject_1() => Assert.IsFalse(new FA2().Run("1".ToCharArray()));
        [TestMethod] public void FA2_Reject_00() => Assert.IsFalse(new FA2().Run("00".ToCharArray()));
        [TestMethod] public void FA2_Reject_11() => Assert.IsFalse(new FA2().Run("11".ToCharArray()));
        [TestMethod] public void FA2_Reject_0011() => Assert.IsFalse(new FA2().Run("0011".ToCharArray()));
        [TestMethod] public void FA2_Reject_011() => Assert.IsFalse(new FA2().Run("011".ToCharArray()));
        [TestMethod] public void FA2_Reject_001() => Assert.IsFalse(new FA2().Run("001".ToCharArray()));
        [TestMethod] public void FA2_Empty() => Assert.IsFalse(new FA2().Run("".ToCharArray()));

        // FA3: содержит "11"
        [TestMethod] public void FA3_Accept_11() => Assert.IsTrue(new FA3().Run("11".ToCharArray()));
        [TestMethod] public void FA3_Accept_0110() => Assert.IsTrue(new FA3().Run("0110".ToCharArray()));
        [TestMethod] public void FA3_Accept_111() => Assert.IsTrue(new FA3().Run("111".ToCharArray()));
        [TestMethod] public void FA3_Accept_001100() => Assert.IsTrue(new FA3().Run("001100".ToCharArray()));
        [TestMethod] public void FA3_Reject_0() => Assert.IsFalse(new FA3().Run("0".ToCharArray()));
        [TestMethod] public void FA3_Reject_1() => Assert.IsFalse(new FA3().Run("1".ToCharArray()));
        [TestMethod] public void FA3_Reject_101() => Assert.IsFalse(new FA3().Run("101".ToCharArray()));
        [TestMethod] public void FA3_Reject_010() => Assert.IsFalse(new FA3().Run("010".ToCharArray()));
        [TestMethod] public void FA3_Empty() => Assert.IsFalse(new FA3().Run("".ToCharArray()));
    }
}
