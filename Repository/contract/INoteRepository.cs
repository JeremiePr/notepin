using System;
using System.Collections.Generic;
using notepin.api.Models;

namespace notepin.api.Repository.Contract
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAll();
        IEnumerable<Note> GetByPerson(int personId);
        Note Create(Note note);
        Note Update(int noteId, Note note);        
        void Delete(int noteId);
    }
}