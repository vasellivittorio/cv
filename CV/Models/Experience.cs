using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}