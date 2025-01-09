using System.Text;
using System.Text.RegularExpressions;

namespace NormanLib.StringManagement
{
    /// <summary>
    /// 移除字串中的空格
    /// </summary>
    public static class StringEraseSpace
    {
        /// <summary>
        /// 移除字串中所有的空格
        /// </summary>
        /// <param name="stringToBeEracedSpace">要移除所有空格的字串</param>
        /// <returns>移除所有空格後的字串</returns>
        public static string EraseSpace(this string stringToBeEracedSpace)
        {
            // @"\s+" 代表正規表達式中的空格
            stringToBeEracedSpace = Regex.Replace(stringToBeEracedSpace, @"\s+", string.Empty);

            return stringToBeEracedSpace;
        }

        /// <summary>
        /// 從特定字元開始移除字串內的空格，若 startIndex小於0 或 startIndex超出字串長度 將回傳原始字串
        /// </summary>
        /// <param name="stringToBeEracedSpace">要移除空格的字串</param>
        /// <param name="startIndex">字串開始移除空格的位置</param>
        /// <returns>移除空格後的字串</returns>
        public static string EraseSpace(this string stringToBeEracedSpace, int startIndex)
        {
            if (startIndex < 0 || stringToBeEracedSpace.Length - 1 < startIndex)
            {
                return stringToBeEracedSpace;
            }

            StringBuilder stringBuilder = new StringBuilder(stringToBeEracedSpace, stringToBeEracedSpace.Length);

            string subStringToBeEracedSpace = Regex.Replace(stringToBeEracedSpace.Substring(startIndex), @"\s+", string.Empty);

            stringBuilder.Remove(startIndex, stringToBeEracedSpace.Length - startIndex);
            stringBuilder.Append(subStringToBeEracedSpace);

            stringToBeEracedSpace = stringBuilder.ToString();

            return stringToBeEracedSpace;
        }

        /// <summary>
        /// 指定執行長度從特定字元開始移除字串內的空格，若 startIndex, length 小於0 或 startIndex超出字串長度 將回傳原始字串
        /// </summary>
        /// <param name="stringToBeEracedSpace">要移除空格的字串</param>
        /// <param name="startIndex">字串開始移除空格的位置</param>
        /// <param name="length">移除長度</param>
        /// <returns>移除空格後的字串</returns>
        public static string EraseSpace(this string stringToBeEracedSpace, int startIndex, int length)
        {
            if (startIndex < 0 || stringToBeEracedSpace.Length - 1 < startIndex || length < 0)
            {
                return stringToBeEracedSpace;
            }

            if (startIndex + length < stringToBeEracedSpace.Length)
            {
                StringBuilder stringBuilder = new StringBuilder(stringToBeEracedSpace, stringToBeEracedSpace.Length);

                string subStringToBeEracedSpace = Regex.Replace(stringToBeEracedSpace.Substring(startIndex, length), @"\s+", string.Empty);

                stringBuilder.Remove(startIndex, length);
                stringBuilder.Insert(startIndex, subStringToBeEracedSpace);

                stringToBeEracedSpace = stringBuilder.ToString();
            }
            else
            {
                stringToBeEracedSpace = stringToBeEracedSpace.EraseSpace(startIndex);
            }

            return stringToBeEracedSpace;
        }
    }
}