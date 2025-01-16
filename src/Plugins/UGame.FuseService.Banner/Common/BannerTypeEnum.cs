using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.FuseService.Banner.Common
{
    /// <summary>
    /// sc_banner.BannerType
    /// </summary>
    public enum BannerTypeEnum
    {
        /// <summary>
        /// 游客
        /// </summary>
        Visitor = 1,
        /// <summary>
        /// 注册用户
        /// </summary>
        Register = 2,
        /// <summary>
        /// 注册用户未充值
        /// </summary>
        RegisterNoPay = 3,
        /// <summary>
        /// 注册用户已充值
        /// </summary>
        RegisterPayed = 4
    }
}
