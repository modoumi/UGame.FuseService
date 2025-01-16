using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.FuseService.Banner.Common
{
    /// <summary>
    /// sc_banner.ShowDay
    /// </summary>
    public enum BannerShowDayEnum
    {
        /// <summary>
        /// 预留值，不参与规则计算
        /// </summary>
        None = 0,

        /// <summary>
        /// 当天首次显示
        /// </summary>
        First = 1,

        /// <summary>
        /// 当天非首次显示
        /// </summary>
        NotFirst = 2

    }
}
