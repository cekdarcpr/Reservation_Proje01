namespace Reservation_Proje01.CQRS.Results.DestinationResult
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
    }
}
