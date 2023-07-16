using System;
using System.Collections.Generic;
using System.Text;

namespace Quest06
{
    class TextService
    {
        public string GetAddress(string city, string street, string house, string apart)
        {
            string result = $"Город {city}, улица {street}, дом {house}, квартира {apart}";
            return result;
        }
    }
}
