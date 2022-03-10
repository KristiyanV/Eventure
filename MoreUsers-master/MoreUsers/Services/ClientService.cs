using MoreUsers.Abstraction;
using MoreUsers.Data;
using MoreUsers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreUsers.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext context;

        public ClientService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool CreateClient(string fisrtName, string lastName, string phone, string address, string userId)
        {
            if (context.Employees.Any(p => p.UserId == userId))
            {
                throw new InvalidOperationException("Client already exist.");
            }

            Client client = new Client
            {
                FirstName = fisrtName,
                LastName = lastName,
                Phone = phone,
                Address = address,
                UserId = userId
            };

            context.Clients.Add(client);

            return context.SaveChanges() != 0;
        }

        public Client GetClient(string id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public string GetFullName(string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
