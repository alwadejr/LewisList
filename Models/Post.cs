﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LewisList.Models
{
    public class Post
    {

        [Key]
        public int PostId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Author { get; set; }

        [DefaultValue("0")]
        public int Category { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public string Price { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Telephone { get; set; }

        //Attempt to write Category value 
        public Post()
        {
            this.Category = 0;
        }
    }


}