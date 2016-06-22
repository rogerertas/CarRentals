namespace RentalLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnCar")]
    public partial class ReturnCar
    {
        [Key]
        [Column("Booking Number", Order = 0)]
        public int Booking_Number { get; set; }

        [Key]
        [Column("Registration Number", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Registration_Number { get; set; }

        [Key]
        [Column("Time Of Return", Order = 2)]
        public DateTime Time_Of_Return { get; set; }
    }
}
