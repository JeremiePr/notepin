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
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        [HttpGet("Get")]
        public IEnumerable<Profile> Get()
        {
            var data = _profileRepository.GetAll();
            return data;
        }

        [HttpGet("Get/{id}")]
        public Profile GetById(int id)
        {
            var data = _profileRepository.GetById(id);
            return data;
        }

        [HttpPost("Create")]
        public Profile Create([FromBody]Profile profile)
        {
            var data = _profileRepository.Create(profile);
            return data;
        }

        [HttpPut("Update/{profileId}")]
        public Profile Update([FromBody]Profile profile, int profileId)
        {
            var data = _profileRepository.Update(profileId, profile);
            return data;
        }

        [HttpDelete("Delete/{profileId}")]
        public void Delete(int profileId)
        {
            _profileRepository.Delete(profileId);
        }
    }
}
