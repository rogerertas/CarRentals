namespace RentalLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        [Column("Booking Number", Order = 0)]
        public int Booking_Number { get; set; }

        [Key]
        [Column("Registration Number", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Registration_Number { get; set; }

        [Key]
        [Column("Time Of Rental", Order = 2)]
        public DateTime Time_Of_Rental { get; set; }

        [Key]
        [Column("Vehicle Category", Order = 3)]
        [StringLength(1)]
        public string Vehicle_Category { get; set; }

        [Key]
        [Column("Customer BirthDate", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_BirthDate { get; set; }

        [Key]
        [Column("Current Milage", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Current_Milage { get; set; }
    }
}
