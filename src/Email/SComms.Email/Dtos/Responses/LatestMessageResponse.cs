using System.Collections.Generic;

namespace SComms.Email.Dtos.Responses;

public class LatestMessageResponse
{
    public List<ReadingTagMapDto> Maps { get; set; }
    public List<LatestMessageDto> Messages { get; set; }
}
public class ReadingTagMapDto
{
    public int DisplayTag { get; set; }
    public int Count { get; set; }
}
public class LatestMessageDto
{
    public string MessageId { get; set; }
    public string SenderId { get; set; }
    public int DisplayTag { get; set; }
    public string TemplateID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Status { get; set; }
    public string RecDate { get; set; }

    public int AmountType { get; set; }
    public decimal RewardAmount { get; set; }
    public string SourceId { get; set; }
    public int ReceiveStatus { get; set; }
}
