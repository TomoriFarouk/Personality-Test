﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class ApplicationUser:IdentityUser
	{
		public string FirstName { get; set; }
		public string lastName { get; set; }
		public string Address { get; set; }
		public DateTime Dob { get; set; }
	}
}
