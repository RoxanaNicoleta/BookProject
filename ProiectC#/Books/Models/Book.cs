using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        [Key]
        public int ID_book { get; set; }
        public string book_name { get; set; }
        public string author { get; set; }  
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string type  { get; set; }
        public string rating { get; set; }
       
    
    }
}
