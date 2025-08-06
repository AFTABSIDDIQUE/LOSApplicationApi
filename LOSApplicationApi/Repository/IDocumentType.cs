using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IDocumentType
    {
        void AddDocumentType(AddDocumentTypeDTO documentType);
        List<FetchDocumentTypeDTO> FetchDocumentTypes();
    }
}
