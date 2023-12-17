using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHouse.Application.Dtos.User
{
    public class LoginDto
    {
        public string? PhoneNumberOrEmail { get; set; }
        public string? Password { get; set; }
    }
}
