//using CharanpreeetSingh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using CharanpreeetSingh.Interface;
using CharanpreeetSingh.Entities;
//using CharanpreeetSingh.Repository;

namespace CharanpreeetSingh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfile iprofile;
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(IProfile _IProfile, ILogger<ProfileController> logger)
        {
            iprofile = _IProfile;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllProfile")]
        public IEnumerable<Profile> GetAllProfile()
        {
            var result = iprofile.GetAllProfile.ToList();
            return result;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Profile profile)
        {
            iprofile.Add(profile);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Profile profile)
        {
            iprofile.Update(profile);
            return Ok();
        }

        [HttpDelete("{id}")]
        //[Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var existingProfile = iprofile.GeProfileById(id);
            if (existingProfile != null)
            {
                iprofile.Remove(existingProfile.Id);
                return Ok();
            }
            return NotFound($"Profile Not Found with ID : {id}");
        }

        [HttpGet("{id}")]
        //[Route("GetProfileById/{id}")]
        public IActionResult GetProfileById(int id)
        {
            var existingProfile = iprofile.GeProfileById(id);
            if (existingProfile != null)
            {
                //_employee.DeleteEmployee(existingEmployee.EmpId);
                return Ok(existingProfile);
            }
            return NotFound($"Employee Not Found with ID : {id}");
        }


    }
}
