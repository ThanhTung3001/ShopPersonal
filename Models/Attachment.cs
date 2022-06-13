using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
