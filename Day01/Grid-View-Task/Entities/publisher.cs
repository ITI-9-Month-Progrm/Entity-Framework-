﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Grid_View_Task.Entities
{
    public partial class publisher
    {
        public publisher()
        {
            titles = new HashSet<title>();
        }

        [Key]
        [StringLength(4)]
        public string pub_id { get; set; }
        [StringLength(40)]
        public string pub_name { get; set; }
        [StringLength(20)]
        public string city { get; set; }
        [StringLength(2)]
        public string state { get; set; }
        [StringLength(30)]
        public string country { get; set; }

        [InverseProperty(nameof(title.pub))]
        public virtual ICollection<title> titles { get; set; }
    }
}