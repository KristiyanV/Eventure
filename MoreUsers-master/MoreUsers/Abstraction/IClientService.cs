using MoreUsers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreUsers.Abstraction
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client GetClient(string id);
        public bool Remove(string id);
        public string GetFullName(string id);
        public bool CreateClient(string fisrtName, string lastName, string phone, string address, string userId);
    }
}
