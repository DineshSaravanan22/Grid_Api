using System.ComponentModel.DataAnnotations;

namespace Angular_Grid_Api_Task2022.Entities
{
    public class AgGrid
    {
        [Key]
        
        public int Id { get; set; }
        public string Yard { get; set; }
        public string LinerName { get; set; }
        public  string ReferenceNumber { get; set; }
        public string Type { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingValidity { get; set; }
        public string ReleaceTo { get; set; }
        public string VesselCarrier { get; set; }
        public string VesselName { get; set; }
        public string VoyageNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string LoadingPort { get; set; }
        public string DischargePort { get; set; }
        public string Distination  { get; set; }
        public string Status { get; set; }
        public string OutContract { get; set; }
        public int BLNumber { get; set; }
        public string Remarks { get; set; }
    }
}
