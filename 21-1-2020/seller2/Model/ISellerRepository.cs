using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seller2.Model
{
 public   interface ISellerRepository
    {
        myseller GetMyseller(int s_id);
        List<myseller> display();
    }
}
