using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Offer
    {
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
