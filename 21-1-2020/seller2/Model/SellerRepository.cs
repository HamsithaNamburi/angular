using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seller2.Model
{
    public class SellerRepository:ISellerRepository
    {
        private List<myseller> slist;
        public SellerRepository()
        {
            
            slist = new List<myseller>
            {
                new myseller(1, "jhon", "dfsf", "asdfsdf", "dfdsf", "sdfdsf", "fdsf", "dfgf"),
                new myseller(2, "dsa", "dsfd", "asdfrds", "fdsf", "fdfd", "dfdsf", "fdsffg"),
                new myseller(3, "sdfd", "sfds", "fsd", "sdfd", "fgg", "fgfdg", "fsdgds")
            };
        }
        public myseller GetMyseller(int s_id)
        {
            myseller s = slist.FirstOrDefault(e => e.s_id == s_id);
            return s;
        }
        public List<myseller> display()
        {
            return slist;
        }
    }
}
