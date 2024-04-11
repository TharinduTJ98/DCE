﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEWebAPI.Common.Models.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int OrderStatus { get; set; }
        public int OrderType { get; set; }
        public Guid OrderBy { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime? ShippedOn { get; set; }
        public bool IsActive { get; set; }

        // Navigation property
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
