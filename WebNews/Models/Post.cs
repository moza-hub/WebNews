using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebNews.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostImg { get; set; }
        public string PostUrl { get; set; }

        [ForeignKey("Category")]
        public int CateId { get; set; }
        public Category Category { get; set; }
    }
}