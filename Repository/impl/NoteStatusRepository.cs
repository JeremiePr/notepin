using System;
using System.Collections.Generic;
using System.Linq;
using notepin.api.Models;
using notepin.api.Repository.Contract;

namespace notepin.api.Repository.Impl
{
    public class NoteStatusRepository : INoteStatusRepository
    {
        private readonly NotepinContext _context;

        public NoteStatusRepository(NotepinContext context)
        {
            _context = context;
        }

        public NoteStatus Create(NoteStatus noteStatus)
        {
            try
            {
                _context.NoteStatutes.Add(noteStatus);
                return noteStatus;          
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return noteStatus;
            }
        }

        public void Delete(int noteStatusId)
        {
            try
            {
                var item = _context.NoteStatutes
                .FirstOrDefault(e => e.Id == noteStatusId);
                if(item != null)
                {
                    _context.NoteStatutes.Remove(item);
                }             
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public IEnumerable<NoteStatus> GetAll()
        {
            try
            {
                return _context.NoteStatutes
                .OrderBy(e => e.Name)
                .ToList();               
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<NoteStatus>();
            }
        }

        public NoteStatus GetById(int id)
        {
            try
            {
                return _context.NoteStatutes
                .FirstOrDefault(e => e.Id == id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public NoteStatus Update(int noteStatusId, NoteStatus noteStatus)
        {
            try
            {
                if(noteStatusId == noteStatus.Id)
                {
                    var item = _context.NoteStatutes
                    .FirstOrDefault(e => e.Id == noteStatusId);
                    if(item != null)
                    {
                        _context.NoteStatutes.Update(noteStatus);
                    } 
                }
                return noteStatus;     
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return noteStatus;
            }
        }
    }
}