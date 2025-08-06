using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        ApplicationDbContext db;
        IDocumentType documentTypeService;
        public DocumentTypeController(ApplicationDbContext db, IDocumentType documentTypeService)
        {
            this.db = db;
            this.documentTypeService = documentTypeService;
        }

        [HttpGet]
        [Route("FetchDocumentTypes")]
        public IActionResult FetchDocumentTypes()
        {
            var data = documentTypeService.FetchDocumentTypes();
            return Ok(data);
        }

        [HttpPost]
        [Route("AddDocumentType")]
        public IActionResult AddDocumentTypes(AddDocumentTypeDTO document)
        {
            documentTypeService.AddDocumentType(document);
            return Ok("Document type added successfully");
        }

     }
}
