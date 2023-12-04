using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Databasede olan cedvellerin model sinifleri mutleq sekilde bu classdan inhert edilmelidir
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Unique Identity
        /// </summary>
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedDate { get; set; }
        public int Deleted { get; set; }
    }
}
