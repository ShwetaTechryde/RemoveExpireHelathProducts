using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveExpireHelathProducts.Response
{
    public class HelathProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public DateTime Expireydate { get; set; }
    }
}
