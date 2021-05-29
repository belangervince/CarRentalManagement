namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public virtual Colour Colour { get; set; }
        public int ColourId { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public virtual Booking RentalRecords { get; set; }
    }
}
