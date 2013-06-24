﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
        public DateTimeOffset? LastLogin { get; set; }
        //public bool? MustChangePassword { get; set; }
        public List<Post> Posts { get; set; }
    }
    
}
