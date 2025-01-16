using UGame.FuseService.Email.Core;
using System.Collections.Generic;

namespace UGame.FuseService.Email.Dtos.Requests;

public class DeleteMessageRequest : BaseIpo
{
    public List<string> Ids { get; set; }
}
