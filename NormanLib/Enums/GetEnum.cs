using System.ComponentModel;
using System.Reflection;

namespace NormanLib.Enums
{
    /// <summary>
    /// 取得列舉
    /// </summary>
    public static class GetEnum<T> where T : Enum
    {
        /// <summary>
        /// 列舉名稱
        /// </summary>
        /// <returns></returns>
        public static string Name() => typeof(T).Name;

        /// <summary>
        /// 取得列舉成員名稱
        /// </summary>
        /// <param name="enumMember">列舉成員</param>
        /// <returns>列舉成員名稱</returns>
        public static string MemberName(T enumMember) => Enum.GetName(typeof(T), enumMember) ?? "Unknown";

        /// <summary>
        /// 列舉成員陣列
        /// </summary>
        /// <returns></returns>
        public static Array Values() => typeof(T).GetEnumValues();

        /// <summary>
        /// 列舉成員陣列
        /// </summary>
        /// <returns></returns>
        public static string[] MemberNames() => typeof(T).GetEnumNames();

        /// <summary>
        /// 取得列舉成員說明
        /// </summary>
        /// <param name="enumMember">列舉成員</param>
        /// <returns>列舉成員說明</returns>
        public static string MemberDescription(T enumMember)
        {
            Type enumMemberType = typeof(T);
            string enumMemberName = enumMember.ToString();
            FieldInfo? enumfield = enumMemberType.GetField(enumMemberName);

            if (enumfield is null)
            {
                return $"Unknown Enum {enumMemberType.Name} Member";
            }
            else
            {
                if (enumfield.GetCustomAttribute(typeof(DescriptionAttribute)) is DescriptionAttribute enumDescription)
                {
                    return enumDescription.Description;
                }
                else
                {
                    return $"Lack of description: {enumMemberType.Name}.{enumMemberName}.";
                }
            }
        }
    }
}