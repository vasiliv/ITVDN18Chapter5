﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models {
    public class SubscribeModel {
        [Required]
        public string Email { get; set; }
    }
}