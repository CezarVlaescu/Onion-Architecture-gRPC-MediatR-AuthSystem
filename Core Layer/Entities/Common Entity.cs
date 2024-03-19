using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Entities
{
    // Write your common entities here
    public abstract class Common_Entity
    {
        public int Id { get; set; } // the ID is necessary for DB, is unique and present for all entities

        public DateTime CreatedAt { get; set; }

    }
}
