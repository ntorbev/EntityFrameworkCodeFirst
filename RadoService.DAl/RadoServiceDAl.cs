using System.Collections.Generic;
using System.Linq;


namespace RadoService.DAl
{
    public static class RadoServiceDAL
    {
        public static List<Client> GetAllClients()
        { 
            RadoServiseEntities db=new RadoServiseEntities();
            List<Client> clients=db.Client.ToList();
            return clients;
        
        }
    }
}
