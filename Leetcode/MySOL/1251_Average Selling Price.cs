using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MySOL
{
    internal class _1251_Average_Selling_Price
    {
        //select p.product_id , ifnull(round(sum(p.price* u.units)/sum(units),2),0) as average_price
        //from Prices as p
        //left join UnitsSold as u
        //on p.product_id = u.product_id
        //and u.purchase_date between p.start_date and p.end_date
        //group by p.product_id;
    }
}
