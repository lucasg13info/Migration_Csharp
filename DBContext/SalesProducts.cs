﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationStudy.DBContext
{
    public class SalesProducts
    {
        [Key]
        public int Id { get; set; }
        [Column("ProductName", TypeName="Varchar(200)")]
        public string ProductName { get; set; }
        public int Qty { get; set; }

        public int SalesCount { get; set; }

    }
}
