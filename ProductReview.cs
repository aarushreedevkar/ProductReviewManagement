﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementlinq
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
