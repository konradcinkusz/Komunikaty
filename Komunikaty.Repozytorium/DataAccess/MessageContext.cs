using System.Data.Entity;

namespace Komunikaty.Repozytorium.DataAccess
{
    public class MessageContext : DbContext
    {
        public MessageContext() :base("KomunikatyDb")
        {

        }
        public DbSet<Message> Messages { get; set; }
        
    }
}
