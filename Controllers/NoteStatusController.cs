using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using notepin.api.Models;
using notepin.api.Repository.Contract;

namespace notepin.api.Controllers
{
    [Route("api/[controller]")]
    public class NoteStatusController : Controller
    {
        private readonly INoteStatusRepository _noteStatusRepository;

        public NoteStatusController(INoteStatusRepository noteStatusRepository)
        {
            _noteStatusRepository = noteStatusRepository;
        }

        [HttpGet("Get")]
        public IEnumerable<NoteStatus> Get()
        {
            var data = _noteStatusRepository.GetAll();
            return data;
        }

        [HttpPost("Create")]
        public NoteStatus Create([FromBody]NoteStatus noteStatus)
        {
            var data = _noteStatusRepository.Create(noteStatus);
            return data;
        }

        [HttpPut("Update/{noteStatusId}")]
        public NoteStatus Update([FromBody]NoteStatus noteStatus, int noteStatusId)
        {
            var data = _noteStatusRepository.Update(noteStatusId, noteStatus);
            return data;
        }

        [HttpDelete("Delete/{noteStatusId}")]
        public void Delete(int noteStatusId)
        {
            _noteStatusRepository.Delete(noteStatusId);
        }
    }
}
