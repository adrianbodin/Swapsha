using System;
using System.Collections.Generic;
using System.Linq;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Contacts.Seed;

public class ContactSeed
{
    public static List<Contact> Seed(List<CustomUser> users)
    {
        var contacts = new List<Contact>();
        var random = new Random();

        // Shuffle the list of users
        var shuffledUsers = users.OrderBy(u => random.Next()).ToList();

        foreach (var user in users)
        {
            // Select 5 random users to be contacts, excluding the current user and users who already have a contact with the current user
            var randomContacts = shuffledUsers
                .Where(u => u.Id != user.Id && !contacts.Any(c => (c.User1Id == user.Id && c.User2Id == u.Id) || (c.User1Id == u.Id && c.User2Id == user.Id)))
                .Take(4)
                .ToList();

            foreach (var contact in randomContacts)
            {
                contacts.Add(new Contact
                {
                    User1Id = user.Id,
                    User2Id = contact.Id
                });

                contacts.Add(new Contact
                {
                    User1Id = contact.Id,
                    User2Id = user.Id
                });
            }

            // Rotate the shuffled list to ensure a different set of contacts for the next user
            var firstUser = shuffledUsers[0];
            shuffledUsers.RemoveAt(0);
            shuffledUsers.Add(firstUser);
        }

        return contacts;
    }
}