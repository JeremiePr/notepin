using System;
using System.Collections.Generic;
using System.Linq;
using notepin.api.Models;
using notepin.api.Repository.Contract;

namespace notepin.api.Repository.Impl
{
    public class NoteRepository : INoteRepository
    {
        private readonly NotepinContext _context;

        public NoteRepository(NotepinContext context)
        {
            _context = context;
        }

        public Note Create(Note note)
        {
            try
            {
                _context.Notes.Add(note);
                return note;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return note;
            }
        }

        public void Delete(int noteId)
        {
            try
            {
                var note = _context.Notes
                .FirstOrDefault(e => e.Id == noteId);

                if(note != null)
                {
                    _context.Notes.Remove(note);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public IEnumerable<Note> GetAll()
        {
            try
            {
                return _context.Notes
                .OrderByDescending(e => e.NoteDate)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Note>();
            }
        }

        public Note GetById(int id)
        {
            try
            {
                return _context.Notes
                .FirstOrDefault(e => e.Id == id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public IEnumerable<Note> GetByParams(int personId, string title, DateTime? dateFrom, DateTime? dateTo, string statusCode, int page)
        {
            var nbPerPage = 10;
            try
            {
                var notes = _context.Notes
                .Where(e => e.PersonId == personId)
                .Where(e => e.Title.Contains(title))
                .Where(e => !dateFrom.HasValue || e.NoteDate > dateFrom)
                .Where(e => !dateTo.HasValue || e.NoteDate < dateTo)
                .Where(e => string.IsNullOrWhiteSpace(statusCode) || e.NoteStatus.Code == statusCode);
                
                if(page > 0) {
                    notes = notes
                    .Skip(nbPerPage * (page - 1))
                    .Take(nbPerPage);
                }

                return notes
                .OrderByDescending(e => e.NoteDate)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Note>();
            }
        }

        public Note Update(int noteId, Note note)
        {
            try
            {
                if(noteId == note.Id)
                {
                    var item = _context.Notes
                    .FirstOrDefault(e => e.Id == noteId);
                    if(item != null)
                    {
                        _context.Notes.Update(note);
                    }
                }
                return note;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return note;
            }
        }
    }
}