using System;
using System.Collections.Generic;
using System.Linq;
using Swapsha.Api.Features.Contacts.Models;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Contacts.Seed;

public static class ContactRequestSeed
{
    public static List<ContactRequest> Seed(List<CustomUser> users, List<Contact> contacts)
    {
        var contactRequests = new List<ContactRequest>();
        var random = new Random();

        // Shuffle the list of users
        var shuffledUsers = users.OrderBy(u => random.Next()).ToList();

        foreach (var user in users)
        {
            // Select 5 random users to send requests to, excluding the current user
            var randomReceivers = shuffledUsers.Where(u => u.Id != user.Id).Take(3).ToList();

            foreach (var receiver in randomReceivers)
            {
                // Check if a contact already exists between the two users
                var existingContact = contacts.FirstOrDefault(c =>
                    (c.User1Id == user.Id && c.User2Id == receiver.Id) ||
                    (c.User1Id == receiver.Id && c.User2Id == user.Id));

                var status = existingContact != null ? ContactRequestStatus.Accepted : ContactRequestStatus.Pending;

                contactRequests.Add(new ContactRequest
                {
                    ContactRequestId = Guid.NewGuid().ToString(),
                    SenderId = user.Id,
                    ReceiverId = receiver.Id,
                    Status = status
                });
            }

            // Rotate the shuffled list to ensure a different set of receivers for the next user
            var firstUser = shuffledUsers[0];
            shuffledUsers.RemoveAt(0);
            shuffledUsers.Add(firstUser);
        }

        return contactRequests;
    }
}