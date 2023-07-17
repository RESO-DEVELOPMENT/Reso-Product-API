namespace Pos_System.API.Payload.Request.Collections
{
    public class UpdateCollectionInformationRequest
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? PicUrl { get; set; }
        public string? Description { get; set; }
        public List<Guid>? ProductIds { get; set; }

        public Guid? brandId { get; set; }

        public void TrimString()
        {
            Name = Name?.Trim();
            Code = Code?.Trim();
            Description = Description?.Trim();

        }
    }
}
