using UGame.FuseService.Email.Core;

namespace UGame.FuseService.Email.Dtos.Requests;

public class ReceiveTaskRewardRequest : BaseIpo
{
    public string DetailId { get; set; }
}
