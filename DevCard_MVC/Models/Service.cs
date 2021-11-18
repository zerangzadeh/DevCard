using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }

        public Service(int id, string serviceName)
        {
            Id = id;
            ServiceName = serviceName;
        }
    }
}
