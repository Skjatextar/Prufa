using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prufa3.App_Data.DataAccessLayer;
using Prufa3.Models.Interface;

namespace Prufa3.Models.Repository
{
    public class ClientRepository : IClientRepository
    {
        private SubDataContext _context;

        public IQueryable<Models.Entity.Client> GetClients()
        {
            return _context.Clients;
        }
    }
}