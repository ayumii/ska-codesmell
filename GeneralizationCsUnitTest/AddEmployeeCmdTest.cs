using System.IO;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture]
    public class AddEmployeeCmdTest
	{
		[TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(18)]
        [TestCase(19)]
        [TestCase(20)]
        [TestCase(21)]
        [TestCase(22)]
        [TestCase(23)]
        [TestCase(24)]
        [TestCase(25)]
        [TestCase(26)]
        [TestCase(27)]
        [TestCase(28)]
        [TestCase(29)]
        [TestCase(30)]
        [TestCase(31)]
        [TestCase(32)]
        [TestCase(33)]
        [TestCase(34)]
        [TestCase(35)]
        [TestCase(36)]
        [TestCase(37)]
        [TestCase(38)]
        [TestCase(39)]
        [TestCase(40)]
        [TestCase(41)]
        [TestCase(42)]
        [TestCase(43)]
        [TestCase(44)]
        [TestCase(45)]
        [TestCase(46)]
        [TestCase(47)]
        [TestCase(48)]
        [TestCase(49)]
        [TestCase(50)]
        [TestCase(51)]
        [TestCase(52)]
        public void SentCorrectly(int index) {
            char[] knownGood = {(char)Constants.HEX_0xde, (char)Constants.HEX_0xad,
                                (char)Constants.DEC_53, (char)Constants.DEC_50,
                                (char)Constants.HEX_0x02,
                                'F', 'r', 'e', 'd', ' ', 'B', 'r', 'o', 'o', 'k', 's', (char)Constants.HEX_0x00,
                                '1', '2', '3', ' ', 'M', 'y', ' ', 'H', 'o', 'u', 's', 'e', (char)Constants.HEX_0x00,
                                'S', 'p', 'r', 'i', 'n', 'g', 'f', 'i', 'e', 'l', 'd', (char)Constants.HEX_0x00,
                                'I', 'L', (char)Constants.HEX_0x00,
                                '7', '2', '0', '0', '0', (char)Constants.HEX_0x00,
                                (char)Constants.HEX_0xbe, (char)Constants.HEX_0xef}; 

            EmployeeDetail employeeDetail = new EmployeeDetail("Fred Brooks", "123 My House", "Springfield", "IL", "72000");
			AddEmployeeCmd cmd = new AddEmployeeCmd(employeeDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(knownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);            
        }
	}
}
