using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public static class CApp
    {
        static public string UserEmail;
        static public string UserPass;

        static public CollectionCustomer colCustomer = new CollectionCustomer();
        static public CollectionTag colTag = new CollectionTag();
        static public CollectionTemplate colTemplate = new CollectionTemplate();
        static public CollectionEvent colEvent = new CollectionEvent();
        static public CollectionScheduler colScheduler = new CollectionScheduler();

    }
}
