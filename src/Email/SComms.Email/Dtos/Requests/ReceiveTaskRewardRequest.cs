using SComms.Email.Core;

namespace SComms.Email.Dtos.Requests;

public class ReceiveTaskRewardRequest : BaseIpo
{
    public string DetailId { get; set; }
}
