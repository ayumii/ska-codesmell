using System.IO;
using System.Linq;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

    [TestFixture]
    public class AddEmployeeCmdTest
    {
        private static readonly char[] KnownGood = {Constants.Hex0Xde, Constants.Hex0Xad,
                                Constants.Dec53, Constants.Dec50,
                                Constants.Hex0X02,
                                'F', 'r', 'e', 'd', ' ', 'B', 'r', 'o', 'o', 'k', 's', Constants.Hex0X00,
                                '1', '2', '3', ' ', 'M', 'y', ' ', 'H', 'o', 'u', 's', 'e', Constants.Hex0X00,
                                'S', 'p', 'r', 'i', 'n', 'g', 'f', 'i', 'e', 'l', 'd', Constants.Hex0X00,
                                'I', 'L', Constants.Hex0X00,
                                '7', '2', '0', '0', '0', Constants.Hex0X00,
                                Constants.Hex0Xbe, Constants.Hex0Xef};

        private static readonly int Length = KnownGood.Length;
        private readonly int[] _testCasesIndexes = Enumerable.Range(0, Length - 1).ToArray();

        [Test, TestCaseSource(nameof(_testCasesIndexes))]
        public void SentCorrectly(int index)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail("Fred Brooks", "123 My House", "Springfield", "IL", "72000");
            AddEmployeeCmd cmd = new AddEmployeeCmd(employeeDetail);
            StringWriter writer = new StringWriter();
            cmd.Write(writer);
            Assert.AreEqual(KnownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
        }
    }
}
