using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Details { get; set; }
        public string Password { get; set; }
        public bool SendEmail { get; set; }
        public string Gender { get; set; }

        public static ContactInfo GetContactInfo()
        {
            ContactInfo contact = new Models.ContactInfo();
            contact.Name = "Ronda Bergman";
            contact.Email = "ronda@theironyard.com";
            contact.PhoneNumber = "734-968-4832";
            contact.Details = "This is some very long text so I can display the way a text area control works";
            contact.Password = "myPassword";
            contact.SendEmail = true;
            contact.Gender = "Female";
            contact.Id = 156;

            return contact;
        }

        public static IEnumerable<ContactInfo> GetContactList()
        {
            List<ContactInfo> contacts = new List<ContactInfo>();
            for (int i = 0; i < 10; i++)
            {
                ContactInfo contact = new Models.ContactInfo();
                contact.Name = "Name " + i;
                contact.Email = "Email" + i + "@someplace.com";
                contact.PhoneNumber = string.Format("{0}{0}{0}-{0}{0}{0}-{0}{0}{0}{0}", i);

                contacts.Add(contact);
            }

            return contacts;
        }
    }
}