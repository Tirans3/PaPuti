using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaPuti.Models
{
    public class TransCar
    {
        public string TownFrom { get; set; }
        public string Townto { get; set; }

        public string Model { get; set; }
        public int Place { get; set; }

        public string CarOwnerPhone { get; set; }
        public string CarOwnerName { get; set; }
        public string CarOwnerEmail { get; set; }

        public DateTime? From { get; set; }
        public DateTime? Clock { get; set; }

    }
}
