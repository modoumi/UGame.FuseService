namespace UGame.FuseService.Marquee.Models.Dtos;

public class SCMarqueeDto
{
    public string MessageContent { get; set; }

    public string AppId { get; set; }

    public string AppName { get; set; }

    public string AppIcon { get; set; }

    public bool IsSupportBonus { get; set; }

    public decimal WinAmount { get; set; }

    public string UserNameOrMobile { get; set; }

}
