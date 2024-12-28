using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveExpireHelathProducts.Response;
namespace RemoveExpireHelathProducts.Interfaces
{
    public interface IRemoveExpiredData
    {
        Task<List<HelathProducts>> Removedata(int monthtoexpire);
        DataTable Removeexpire(int monthtoexpire);
    }
}
