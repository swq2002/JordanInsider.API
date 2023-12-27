﻿using System;
using System.Collections.Generic;

namespace JordanInsider.Core.Models
{
    public partial class Review
    {
        public decimal Reviewid { get; set; }
        public decimal? Touristsiteid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Rating { get; set; }
        public string? Reviewtxt { get; set; }

        public virtual Touristsite? Touristsite { get; set; }
        public virtual User? User { get; set; }
    }
}