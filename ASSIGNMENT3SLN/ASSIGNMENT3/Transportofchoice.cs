using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT3
{
    internal class Transportofchoice
    {
        public string FormOfTransport;
        public int FrequencyOfTravel;
        public bool TravelingToWork;
        
        public Transportofchoice(string formoftransport, int frequencyoftravel, bool travelingToWork)
        {
            FormOfTransport = formoftransport;  
            FrequencyOfTravel = frequencyoftravel;
            TravelingToWork = travelingToWork;
        }

        public string FormOfTransportation()
        {
            return FormOfTransport;
        }
        public bool WorkTravel()
        {
            return TravelingToWork = !TravelingToWork;

        }





    } 
}