﻿using Microsoft.AspNetCore.Http;
using OrderServise.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Application.Models.userDtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        //public List<IFormFile>? Files { get; set;}

    }
    public class CreateUserTestDto
    {
       // [Required(ErrorMessage = "این فیلد اجباری است")]
        public string? FirstName { get; set; }
  
        //public List<IFormFile>? Files { get; set;}

    }
}
