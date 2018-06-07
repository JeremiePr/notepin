using System;
using System.Collections.Generic;
using notepin.api.Models;

namespace notepin.api.Repository.Contract
{
    public interface INoteStatusRepository
    {
        IEnumerable<NoteStatus> GetAll();
        NoteStatus GetById(int id);
        NoteStatus Create(NoteStatus noteStatus);
        NoteStatus Update(int noteStatusId, NoteStatus noteStatus);        
        void Delete(int noteStatusId);
    }
}