using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using notepin.api.Models;
using notepin.api.Repository.Contract;

namespace notepin.api.Repository.Impl
{
    public class PersonRepository : IPersonRepository
    {
        private readonly NotepinContext _context;

        public PersonRepository(NotepinContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Persons.Add(person);
                return person;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return person;
            }
        }

        public void Delete(int personId)
        {
            try
            {
                var person = _context.Persons
                .FirstOrDefault(e => e.Id == personId);

                if(person != null)
                {
                    _context.Persons.Remove(person);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public IEnumerable<Person> GetAll()
        {
            try
            {
                return _context.Persons
                .OrderBy(e => e.FirstName)
                .OrderBy(e => e.LastName)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Person>();
            }
        }

        public Person GetByCredentials(string username, string password)
        {
            try
            {                
                return _context.Persons
                .FirstOrDefault(e => e.Username == username && e.Password == password);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Person GetById(int id)
        {
            try
            {
                return _context.Persons
                .FirstOrDefault(e => e.Id == id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public IEnumerable<Person> GetByName(string name)
        {
            try
            {
                return _context.Persons
                .Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name))
                .OrderBy(e => e.FirstName)
                .OrderBy(e => e.LastName)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Person>();
            }
        }

        public IEnumerable<Person> GetByProfile(int profileId)
        {
            try
            {
                return _context.Persons
                .Where(e => e.Profile.Id == profileId)
                .OrderBy(e => e.FirstName)
                .OrderBy(e => e.LastName)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Person>();
            }
        }

        public Person GetByUsername(string username)
        {
            try
            {
                return _context.Persons
                .FirstOrDefault(e => e.Username == username);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Person Update(int personId, Person person)
        {
            try
            {
                if(personId == person.Id)
                {
                    var item = _context.Persons
                    .FirstOrDefault(e => e.Id == personId);
                    if(item != null)
                    {
                        _context.Persons.Update(person);
                    }
                }
                return person;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return person;
            }
        }
    }
}