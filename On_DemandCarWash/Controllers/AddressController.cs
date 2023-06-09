﻿using Microsoft.AspNetCore.Mvc;
using On_DemandCarWash.Model;
using On_DemandCarWash.Services;
//using On_DemandCarWash.Services;

namespace On_DemandCarWash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private AddressService addressService;
        public AddressController(AddressService _addressService)
        {
            addressService = _addressService;
        }
        [HttpGet("GetAllAddress")]
        public IActionResult GetAllAddress()
        {
            return Ok(addressService.GetAllAddress());
        }
        [HttpGet("GetAddress")]
        public IActionResult GetAddress(int id)
        {
            return Ok(addressService.GetAddress(id));
        }
        [HttpPost("AddAddress")]
        public IActionResult AddAddress(Address address)
        {
            return Ok(addressService.AddAddress(address));
        }
        [HttpPut("UpdateAddress")]
        public IActionResult UpdateAddress(Address address)
        {
            return Ok(addressService.UpdateAddress(address));
        }
        [HttpDelete("DeleteAddress")]
        public IActionResult DeleteAddress(int id)
        {
            return Ok(addressService.DeleteAddress(id));
        }
    }
}
