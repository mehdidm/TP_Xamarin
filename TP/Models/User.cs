using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Models
{
    public class User
    {
        [PrimaryKey ]
        public string UserName { get; set; }
        public string Email { get; set; }
        
        public string Password { get; set; }
        
    }
}
