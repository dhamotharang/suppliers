using System.ComponentModel;

namespace HappyTravel.SuppliersCatalog
{
    public enum Suppliers
    {
        Unknown = 0,
        Netstorming = 1,
        
        [Description("iWTX")] 
        Illusions = 2,
        
        [Description("Direct Contracts")] 
        DirectContracts = 3,
        
        [Description("RateHawk")]
        Etg = 4,
        
        [Description("Rakuten Travel Xchange")]
        Rakuten = 5,
        
        [Description("Columbus (Direct Contracts)")]
        Columbus = 6,
        
        [Description("TravelgateX (TEST)")] 
        TravelgateXTest = 7,
        
        [Description("Jumeirah Hotels")] 
        Jumeirah = 8,
        
        [Description("Darina Holidays")] 
        Darina = 9,
        
        [Description("Yalago")]
        Yalago = 10, 
        
        [Description("Paximum")]
        Paximum = 11,
        
        [Description("TravelLine OÜ")]
        TravelLine = 12,
        
        [Description("Bronevik")]
        Bronevik = 13,
        
        [Description("Amadeus Hospitality")]
        TravelClick = 14,
        
        [Description("Sodis")]
        Sodis = 15,
        
        [Description("HotelBeds")]
        HotelBeds = 16,

        [Description("Hotelbook Pro")]
        HotelbookPro = 17,
        
        [Description("BookMe Maldives")]
        BookMe = 18,
        
        [Description("Roibos")]
        Roibos = 19
    }
}