using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Product
    {
        public Product()
        {
            Attachments = new HashSet<Attachment>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Link { get; set; }
        public int? Price { get; set; }
        public string Description { get; set; }
        public int? Vote { get; set; }
        public int? Quanlity { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
