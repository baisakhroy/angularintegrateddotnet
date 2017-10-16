using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;



namespace TodoApi.Models
{ 
     /*public class Productinformation
        {
            public int ID { get; set; }
            public int GroupID { get; set; }
            public string Name{ get; set; }
            public string Description {get; set;}
            public int Rate {get; set;}
            
        }*/

  
    public class TodoItem
    {
        
        public int GroupID { get; set; }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set;}

        public int Rate { get; set; }
        
    }
}