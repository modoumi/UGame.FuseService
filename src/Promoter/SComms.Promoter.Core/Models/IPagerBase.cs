namespace SComms.Promoter.Core.Models
{
    public interface IPagerBase
    {
        int PageIndex { get; set; }

        int PageSize { get; set; }

        long Total { get; set; }
    }
}
