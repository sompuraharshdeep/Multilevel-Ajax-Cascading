using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultilevelCascadingDropDown.Models
{
    public class CountryStateCityViewModel
    {
        public int pkCountryId { get; set; }
        public int pkStateId { get; set; }
        public int pkCityId { get; set; }
    }
}