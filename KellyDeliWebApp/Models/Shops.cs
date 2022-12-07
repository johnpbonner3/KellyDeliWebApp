using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellyDeliWebApp.Models
{
    public class Shops
    {
        public string generated { set; get; }

        public string shopNumber { set; get; }

        public IList<ShopsData> shops { get; set; }
    }
}
