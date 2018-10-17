using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public class InsertBookDTO
    {
        public string BookName { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
    }
}
