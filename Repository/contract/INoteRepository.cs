using System;
using System.Collections.Generic;
using notepin.api.Models;

namespace notepin.api.Repository.Contract
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAll();
        Note GetById(int id);
        IEnumerable<Note> GetByParams(int personId, string title, DateTime? dateFrom, DateTime? dateTo, string statusCode, int page);
        Note Create(Note note);
        Note Update(int noteId, Note note);
        void Delete(int noteId);
    }
}