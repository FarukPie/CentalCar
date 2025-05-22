using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Login :BaseEntity
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }

    }
}
