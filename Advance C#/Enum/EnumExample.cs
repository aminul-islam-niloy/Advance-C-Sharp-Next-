using Advance_C_.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Enum
{
     enum EnumExample
    {
        OrderPlace ,
        OrderConfirm,
        Packing,
        Delivery,
        Recived

    }

    enum month
    {
        january,
        february,
        march,
        april,
        may,
        june,
        july
    }

    enum button : byte
    {
        OFF,
        ON
    }
}



        // extra 
        // enum example in c#

        // EnumExample example = new EnumExample();

        //  Console.WriteLine((int)EnumExample.Delivery);
        //  Console.WriteLine(EnumExample.OrderConfirm);
        //  Console.WriteLine((int)EnumExample.OrderConfirm);

        //int enumStatus = 1;
        //if (enumStatus == (int)EnumExample.OrderPlace)
        //{

        //}
        //else if (enumStatus == (int)EnumExample.OrderConfirm)
        //{
        //    Console.WriteLine("Order confirmed");
        //}
        //else
        //{

        //}

        //Console.WriteLine($"order Status is :  {enumStatus}");