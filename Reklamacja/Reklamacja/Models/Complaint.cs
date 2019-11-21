using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reklamacja.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProductId { get; set; }
        public string ShopId { get; set; }
        public string Description { get; set; }
    }
}