using System.IO;
using System.Linq;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

    [TestFixture]
    public class LoginCommandTest
    {
        private static readonly char[] KnownGood = {Constants.Hex0Xde, Constants.Hex0Xad,
                                    Constants.Dec50, Constants.Dec48,
                                    Constants.Hex0X01,
                                    'b', 'a', 'b', Constants.Hex0X00,
                                    'c', 'a', 'r', 'd', 'i', 'n', 'a', 'l', 's', Constants.Hex0X00,
                                    Constants.Hex0Xbe, Constants.Hex0Xef};

        private static readonly int Length = KnownGood.Length;
        private readonly int[] _testCasesIndexes = Enumerable.Range(0, Length - 1).ToArray();

        [Test, TestCaseSource(nameof(_testCasesIndexes))]
        public void SentCorrectly(int index)
        {
            LoginDetail loginDetail = new LoginDetail("bab", "cardinals");
            LoginCommand cmd = new LoginCommand(loginDetail);
            StringWriter writer = new StringWriter();
            cmd.Write(writer);
            Assert.AreEqual(KnownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
        }
    }
}
