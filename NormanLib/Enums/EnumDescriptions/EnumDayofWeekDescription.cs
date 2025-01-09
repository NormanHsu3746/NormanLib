namespace NormanLib.Enums.EnumDescriptions
{
    /// <summary>
    /// EnumDayofWeek中文說明
    /// </summary>
    public static class EnumDayofWeekDescription
    {
        /// <summary>
        /// EnumDayofWeek中文說明
        /// </summary>
        public static Dictionary<EnumDayofWeek, string> EnumDayofWeekDescriptionDictionary = new Dictionary<EnumDayofWeek, string>()
        {
            {EnumDayofWeek.None, "無" },
            {EnumDayofWeek.Monday, "星期一" },
            {EnumDayofWeek.Tuesday, "星期二" },
            {EnumDayofWeek.Wednesday, "星期三" },
            {EnumDayofWeek.Thursday, "星期四" },
            {EnumDayofWeek.Friday, "星期五" },
            {EnumDayofWeek.Saturday, "星期六" },
            {EnumDayofWeek.Sunday, "星期天" },
            {EnumDayofWeek.Weekday, "平日" },
            {EnumDayofWeek.Weekend, "周末" },
            {EnumDayofWeek.All, "一周"},
        };

        /// <summary>
        /// 取得EnumDayofWeek列舉值的中文說明
        /// </summary>
        /// <param name="dayofWeek">EnumDayofWeek的列舉值</param>
        /// <returns>EnumDayofWeek列舉值的中文說明</returns>
        public static string GetEnumDayofWeekDescription(EnumDayofWeek dayofWeek)
        {
            if (EnumDayofWeekDescriptionDictionary.TryGetValue(dayofWeek, out string? description))
            {
                if (description is not null)
                {
                    return description;
                }
                else
                {
                    return $"尚未設定此列舉值 EnumDayofWeek.{dayofWeek.ToString()} 的說明";
                }
            }
            else
            {
                return "Unknown";
            }
        }
    }
}