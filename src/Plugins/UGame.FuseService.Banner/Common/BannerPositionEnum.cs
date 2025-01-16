using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.FuseService.Banner.Common
{
    /// <summary>
    /// sc_banner.position
    /// </summary>
    public enum BannerPositionEnum
    {
        /// <summary>
        /// 首页推荐
        /// </summary>
        IndexRecommend = 1,
        /// <summary>
        /// 首页头部
        /// </summary>
        IndexHead = 2,
        /// <summary>
        /// 首页左侧菜单
        /// </summary>
        IndexMenu = 3,
        /// <summary>
        /// 个人中心
        /// </summary>
        Center = 4,
        /// <summary>
        /// 充值页banner
        /// </summary>
        Pay = 5,
        /// <summary>
        /// 首页浮动窗口
        /// </summary>
        IndexFloatingWindow = 6,
        /// <summary>
        /// 首页弹框
        /// </summary>
        IndexPopupBox = 7,
        /// <summary>
        /// 注册页面banner
        /// </summary>
        RegisterBanner = 8,
        /// <summary>
        /// 绑定手机号弹框
        /// </summary>
        BindMobile = 9
    }
}
