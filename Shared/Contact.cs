using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingChat.Shared
{
    public class Contact {

        public int ContactId { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}

        public Contact(){

        }

        public Contact(int contactId, string firstName, string lastName)
        {
            this.ContactId = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        
        public Contact(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}