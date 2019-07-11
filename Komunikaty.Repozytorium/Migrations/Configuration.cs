namespace Komunikaty.Repozytorium.Migrations
{
    using Komunikaty.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Komunikaty.Repozytorium.DataAccess.MessageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Komunikaty.Repozytorium.DataAccess.MessageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            List<Message> messages = new List<Message>();

            messages.Add(new Message
            {
                Id = 1,
                MessageType = MessageType.Warning,
                Content = "Test sprawdzaj¹cy z matematyki nie odbêdzie siê"
            });
            messages.Add(new Message
            {
                Id = 2,
                MessageType = MessageType.Error,
                Content = "Z powodu braku zasilania odwo³ane lekcje",
                ConfirmationRequired = true,
                Confirmed = false
            });
            messages.Add(new Message
            {
                Id = 3,
                MessageType = MessageType.Information,
                Content = "Lekcjê skrócone o 15 minut",
                ConfirmationRequired = true,
                Confirmed = false
            });
            messages.Add(new Message
            {
                Id = 4,
                MessageType = MessageType.None,
                Content = "Komunikat testowy",
            });
            messages.Add(new Message
            {
                Id = 5,
                MessageType = MessageType.None,
                Content = "Dziœ dzieñ nauczyciela",
                Favourite = true
            });
            messages.ForEach(m => context.Set<Message>().AddOrUpdate(m));
            context.SaveChanges();
        }
    }
}
