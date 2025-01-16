using Lobby.Common.Enum;
using TinyFx.Extensions.RabbitMQ;

namespace Lobby.Common.MQ
{
    public class UserActivityMsg : IMQMessage
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 活动编码
        /// </summary>
        public ActivityType ActivityType { get; set; }
        /// <summary>
        /// 活动是否已完成
        /// </summary>
        public bool IsEnd { get; set; }
        public MQMessageMeta MQMeta { get; set; }
    }
}
