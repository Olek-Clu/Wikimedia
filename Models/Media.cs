using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Media : Record
    {
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string YoutubeId { get; set; }
        public bool Shared { get; set; }  
        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}