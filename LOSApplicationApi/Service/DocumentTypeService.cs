using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class DocumentTypeService : IDocumentType
    {
        ApplicationDbContext db;
        IMapper mapper;
        public DocumentTypeService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddDocumentType(AddDocumentTypeDTO documentType)
        {
            var details = mapper.Map<Model.DocumentType>(documentType);
            db.DocumentTypes.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchDocumentTypeDTO> FetchDocumentTypes()
        {
            var details = db.DocumentTypes.ToList();
            var mappedDetails = mapper.Map<List<DTO.FetchDocumentTypeDTO>>(details);
            return mappedDetails;
        }
    }
}
