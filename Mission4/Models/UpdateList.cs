﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class UpdateList
    {
        [Required]
        public string Category { get; set; }
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public Boolean Edited { get; set; }
        public string LentTo { get; set; }
        [Range(0,25)]
        public string Notes { get; set; }


}
}
