﻿using EntityLayer.AdminDetails;
using EntityLayer.DataAccess;
using EntityLayer.IAdminRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _repository;

        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAdmin()
        {


            var Admin = await _repository.GetAllAdmin();
            return Ok(Admin);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAdmin(int id)
        {
<<<<<<< HEAD

=======
>>>>>>> 739e9637555c9aa1c46f1925834bce97ee9a46d1
            var Admin = await _repository.GetOneAdmin(id);
            return Ok(Admin);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateAdmin(Admin newAdminData)
        {
            await _repository.Add(newAdminData);
            await _repository.SaveAllChangesAsync();
<<<<<<< HEAD

=======
>>>>>>> 739e9637555c9aa1c46f1925834bce97ee9a46d1
            return Ok(newAdminData);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, string value)
        {
            var Admin = await _repository.GetAllAdmin();
            return Ok(Admin);
        }


<<<<<<< HEAD
=======
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }


>>>>>>> 739e9637555c9aa1c46f1925834bce97ee9a46d1
    }
}
