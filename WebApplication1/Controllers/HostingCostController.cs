using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            //fortnight = 14 days. and 1 fornight would be charge for $5.50.
            //since #of days < 14 days still count as 1 fortnight. We should use the days of staying divide 14days + 1(as 1 fortnight)
            //int is for whole number, since we only need the days. We use int to eliminate decimal.
            int fortnight = (int)(id / 14 + 1); 
            //as previous comment, 1 fortnight would charge for $5.50, so we use fortnight mutiples $5.50.
            float subtotal = (float)(fortnight * 5.50);
            //tax is 0.13. Thus, subtoal mutiples 0.13. And float keeps the decimal, hence use float instead of int.
            float tax = (float)(subtotal * 0.13); 
            //same as tax. Since we need to keep the decimal, we use float instead of int. And toal = subtotal + tax.
            float total = (float)(subtotal + tax);

            return fortnight + " fortnight at $5.50/FN = $" + subtotal + " CAD, "
                + "HST 13% = $" + Math.Round(tax, 2) + " CAD, "//flort stores 6 to 7 decimal digits. We only need two decimal digit,
                + "Total = $" + Math.Round(total, 2) + " CAD.";//hence use math.round(X,2)to round the decimal to two digits.
        }
    }
}
