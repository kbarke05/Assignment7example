using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace Assignment7example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommAsstServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CommAsstServices.svc or CommAsstServices.svc.cs at the Solution Explorer and start debugging.
    public class CommAsstServices : ICommAsstServices
    {
        
        
        

        public List<ComService> GetServices()
        {
            CommunityServiceDb cs = new CommunityServiceDb();
            DataTable table = cs.GetServices();

            List<ComService> serv = new List<ComService>();
            foreach (DataRow row in table.Rows)
            {
                ComService c = new ComService();
                c.ServiceName = row["ServiceName"].ToString();
                c.ServiceDescription = row["ServiceDescription"].ToString();

                serv.Add(c);
               
            }
            return serv;
        }
    }
}
