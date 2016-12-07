using System;
using System.Linq;

namespace Travel_Agency
{
    [Serializable]
    struct Offer
    {
        public int OfferNumber { get; private set; }
        public string TravelDestination { get; set; }
        public string Feeding { get; set; }
        public int Price { get; set; }
        public int TravelTime { get; set; }
        public string HotelRanking { get; set; }

        public Offer(string travelDestination, string feeding, int price, int travelTime, string hotelRanking, ILogger loggerBox, ILogger loggerFile, int offerNumber = 0)
        {
            TravelDestination = travelDestination;
            Feeding = feeding;
            Price = price;
            TravelTime = travelTime;
            HotelRanking = hotelRanking;
            if (offerNumber == 0)
            {
                OfferNumber = Program.allOffers.OrderByDescending(x => x.Key).FirstOrDefault().Key + 1;
            }
            else
            {
                OfferNumber = offerNumber;
            }
            if (loggerBox != null)
                loggerBox.WriteToLog(this, DateTime.Now, "Created offer");
            if (loggerFile != null)
                loggerFile.WriteToLog(this, DateTime.Now, "Created offer");
        }

        public override string ToString()
        {
            return "Offer number: " + OfferNumber.ToString() + Environment.NewLine + "Travel destination: " + TravelDestination + Environment.NewLine + "Feeding: " + Feeding + Environment.NewLine + "Price per person: €" + Price.ToString() + Environment.NewLine + "Travel time: " + TravelTime.ToString() + " days" + Environment.NewLine + "Hotel ranking: " + HotelRanking;
        }
    } 
}
