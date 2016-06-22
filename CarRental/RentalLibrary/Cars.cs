namespace RentalLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cars
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column("Vehicle Category", Order = 1)]
        [StringLength(1)]
        public string Vehicle_Category { get; set; }

        [Key]
        [Column("Registration Number", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Registration_Number { get; set; }
    }
}
