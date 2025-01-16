using SComms.Email.Core;
using System.Collections.Generic;

namespace SComms.Email.Dtos.Requests;

public class ReadMessageRequest : BaseIpo
{
    public List<string> Ids { get; set; }
}
public class DetailMessageRequest : BaseIpo
{
    public string MessageId { get; set; }
}
