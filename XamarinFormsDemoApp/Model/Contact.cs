using System;
using System.Collections.Generic;

namespace XamarinFormsDemoApp.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact> {
                new Contact(){
                    Name="Mosh",
                    ImageUrl="http://lorempixel.com/100/100/people/1"
                },
                new Contact(){
                    Name="John",
                    ImageUrl="http://lorempixel.com/100/100/people/3",
                    Status="Hey, let's talk!"
                },
                new Contact(){
                    Name="Bhaskar",
                    ImageUrl="http://lorempixel.com/100/100/people/2"
                },
            };

            return contacts;  
        }
    }
}
