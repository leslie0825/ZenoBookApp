using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public class GetBooksDTO
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
