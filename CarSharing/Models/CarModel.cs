using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CarSharing.Models
{
    [Table("Cars")]
    public class CarModel
    {
        [Key]
        public int CarId { get; set; }
      
        public string CarMark { get; set; }
        public string Model { get; set; }
      
        public string Power { get; set; }
     
        public string FuelType { get; set; }
       
        public string Price { get; set; }
     
        public bool Availability { get; set; }

    }

}
