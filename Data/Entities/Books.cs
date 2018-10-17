using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Books
    {
        public int Id { get;set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
    }
}
