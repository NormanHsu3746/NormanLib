using NormanLib.Enums.Time;
using System.Diagnostics;

namespace NormanLib.Enums.Tests
{
    [TestClass()]
    public class GetEnumTests
    {
        [TestMethod()]
        public void NameTest()
        {
            string enumName = GetEnum<EnumDayofWeek>.Name;

            Trace.WriteLine(enumName);
        }

        [TestMethod()]
        public void MemberNameTest()
        {
            EnumDayofWeek enumMember = EnumDayofWeek.Monday;

            string enumMemberName = GetEnum<EnumDayofWeek>.MemberName(enumMember);

            Trace.WriteLine(enumMemberName);
        }

        [TestMethod()]
        public void MemberDescriptionTest()
        {
            EnumDayofWeek enumMember = EnumDayofWeek.All;

            string enumMemberDescription = GetEnum<EnumDayofWeek>.MemberDescription(enumMember);

            Trace.WriteLine(enumMemberDescription);
        }
    }
}