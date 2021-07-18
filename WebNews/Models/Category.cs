using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNews.Models
{
    public class Category
    {
        [Key]
        public int CateId { get; set; }
        public string CateName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}