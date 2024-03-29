﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.EntityFramework.DTOs
{
    [Table("tblUsers")]
    public class UserDTO
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Login { get; set; }
        [Required, StringLength(40)]
        public string Email { get; set; }
        [Required, StringLength(40)]
        public string Password { get; set; }
        [StringLength(255)]
        public string? Photo { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
