using System.ComponentModel;

namespace NormanLib.Enums.Time
{
    /// <summary>
    /// 季節
    /// </summary>
    [Flags]
    public enum EnumSeason
    {
        /// <summary>
        /// 無
        /// </summary>
        [Description("無")]
        None = 0,

        /// <summary>
        /// 春
        /// </summary>
        [Description("春")]
        Spring = EnumMonth.March | EnumMonth.April | EnumMonth.May,

        /// <summary>
        /// 夏
        /// </summary>
        [Description("夏")]
        Summer = EnumMonth.June | EnumMonth.July | EnumMonth.August,

        /// <summary>
        /// 秋
        /// </summary>
        [Description("秋")]
        Autumn = EnumMonth.September | EnumMonth.Octobor | EnumMonth.November,

        /// <summary>
        /// 冬
        /// </summary>
        [Description("冬")]
        Winter = EnumMonth.December | EnumMonth.January | EnumMonth.February,

        /// <summary>
        /// 四季
        /// </summary>
        [Description("四季")]
        All = Spring | Summer | Autumn | Winter,
    }
}