using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProperties
{
    public class Address
    {
        public string Country { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string this[string part]
        {
            get
            {
                if (string.Equals(part, nameof(Country), StringComparison.OrdinalIgnoreCase))
                {
                    return Country;
                }
                else if (string.Equals(part, nameof(State), StringComparison.OrdinalIgnoreCase))
                {
                    return State;
                }
                else if (string.Equals(part, nameof(City), StringComparison.OrdinalIgnoreCase))
                {
                    return City;
                }

                return string.Empty;
            }
        }

        public string this[AddressPart partIndex]
        {
            get
            {
                switch(partIndex)
                {
                    case AddressPart.Country:
                        return Country;

                    case AddressPart.State:
                        return State;

                    case AddressPart.City:
                        return City;

                    default:
                        return string.Empty;
                }
            }
        }

    }
}
