﻿namespace SignalRApi.DAL
{
    public enum ECity
    {
        İstanbul = 1,
        Edirne  = 2,
        Ankara = 3,
        Çanakkale = 4,
        Antalya = 5,
        Bursa = 6
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
