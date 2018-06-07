using System;
using System.Collections.Generic;
using notepin.api.Models;

namespace notepin.api.Repository.Contract
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        IEnumerable<Person> GetByName(string name);
        Person GetByUsername(string username);
        Person GetByCredentials(string username, string password);    
        IEnumerable<Person> GetByProfile(int profileId);
        Person Create(Person person);
        Person Update(int personId, Person person);
        void Delete(int personId);    
    }
}