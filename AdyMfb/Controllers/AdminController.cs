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


        [HttpPost]
        public async Task<IActionResult> UpdateAdmin()
        {
            var Admin = await _repository.GetAllAdmin();
            return Ok(Admin);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, string value)
        {
            var Admin = await _repository.GetAllAdmin();
            return Ok(Admin);
        }


    }
}
