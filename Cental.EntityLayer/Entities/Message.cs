using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Message: BaseEntity
    {
        public int MessageId { get; set; }
        public string CarType { get; set; }
        public string PickUp {  get; set; }
        public string DropOff { get; set; }
        public DateTime PickTime { get; set; }
        public DateTime DropTime { get; set; }

    }
}
