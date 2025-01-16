using SComms.Email.Core;
using System.Collections.Generic;

namespace SComms.Email.Dtos.Requests;

public class DeleteMessageRequest : BaseIpo
{
    public List<string> Ids { get; set; }
}
