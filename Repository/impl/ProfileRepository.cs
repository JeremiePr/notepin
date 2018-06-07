using System;
using System.Collections.Generic;
using System.Linq;
using notepin.api.Models;
using notepin.api.Repository.Contract;

namespace notepin.api.Repository.Impl
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly NotepinContext _context;

        public ProfileRepository(NotepinContext context)
        {
            _context = context;
        }

        public Profile Create(Profile profile)
        {
            try
            {
                _context.Profiles.Add(profile);
                return profile;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return profile;
            }
        }

        public void Delete(int profileId)
        {
            try
            {
                var profile = _context.Profiles
                .FirstOrDefault(e => e.Id == profileId);

                if(profile != null)
                {
                    _context.Profiles.Remove(profile);
                }                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public IEnumerable<Profile> GetAll()
        {
            try
            {
                return _context.Profiles
                .OrderBy(e => e.Name)
                .ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new List<Profile>();
            }
        }

        public Profile GetById(int id)
        {
            try
            {
                return _context.Profiles
                .FirstOrDefault(e => e.Id == id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Profile Update(int profileId, Profile profile)
        {
            try
            {
                if(profileId == profile.Id)
                {
                    var item = _context.Profiles
                    .FirstOrDefault(e => e.Id == profileId);
                    if(item != null)
                    {
                        _context.Profiles.Update(profile);
                    }
                }
                return profile;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return profile;
            }
        }
    }
}