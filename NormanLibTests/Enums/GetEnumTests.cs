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
            string enumName = GetEnum<EnumDayofWeek>.Name();

            Trace.WriteLine(enumName);
        }

        [TestMethod()]
        public void MemberNameTest()
        {
            EnumDayofWeek enumMember = EnumDayofWeek.Monday;

            string enumMemberName = GetEnum<EnumDayofWeek>.MemberName(enumMember);
            string[] enumMemberNames = GetEnum<EnumDayofWeek>.MemberNames();
            Array enumValues = GetEnum<EnumDayofWeek>.Values();

            Trace.WriteLine(enumMemberName);

            Trace.WriteLine("---");

            foreach (var member in enumMemberNames)
            {
                Trace.WriteLine(member);
            }

            Trace.WriteLine("---");

            foreach(var value in enumValues)
            {
                Trace.WriteLine(value);
            }
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