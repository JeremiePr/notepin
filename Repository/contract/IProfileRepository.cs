using System;
using System.Collections.Generic;
using notepin.api.Models;

namespace notepin.api.Repository.Contract
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> GetAll();
        Profile GetById(int id);
        Profile Create(Profile profile);
        Profile Update(int profileId, Profile profile);        
        void Delete(int profileId);
    }
}