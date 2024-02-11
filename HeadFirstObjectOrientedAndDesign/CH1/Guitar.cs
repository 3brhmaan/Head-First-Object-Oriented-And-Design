using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.CH1
{
    public class Guitar
    {
        string serialNumber { get; set; }
        double price { get; set; }
        GuitarSpec spec { get; set; }

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public String getSerialNumber() =>
            serialNumber;
        public double getPrice() =>
            price;
        public void setPrice(double newPrice) =>
            this.price = newPrice;
        public GuitarSpec getSpec() =>
            this.spec;
    }
}
