﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_category")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_code")]
        public string CategoryCode { get; set; }
        [Column("category_name")]
        public String CategoryName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        public CategoryEntity() { }
    }
}
