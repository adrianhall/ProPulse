namespace ProPulse.DataModel.Entities;

public class Attachment
{
    public Guid Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string BlobUri { get; set; } = string.Empty;
    public DateTime UploadedAt { get; set; }
    public string UploadedById { get; set; } = string.Empty;
}
