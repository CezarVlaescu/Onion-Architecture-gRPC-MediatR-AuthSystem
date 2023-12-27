using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Entities
{
    // Define your entities for the database here
    public class Entity : Common_Entity
    {
        public string? FirstName { get; set; }  
        public string? LastName { get; set; }

        // other props 
    }
}
