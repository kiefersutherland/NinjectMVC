using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NinjectMVC.Models;

namespace NinjectMVC.DAL
{
    public class CommunicationInitializer : DropCreateDatabaseIfModelChanges<CommunicationContext>
    {
        protected override void Seed(CommunicationContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact{Name = "皇帝", EnrollmentDate = DateTime.Parse("2009-10-01")},
                  new Contact{Name = "书包", EnrollmentDate = DateTime.Parse("2009-10-01")}

            };
          contacts.ForEach(c=>context.Contacts.Add(c));
            context.SaveChanges();


            var groups = new List<Group>
            {
                new Group{GroupName = GroupName.Colleague},
                new Group{GroupName = GroupName.Family},

            };
            groups.ForEach(t => context.Groups.Add(t));
            context.SaveChanges();




            var enrollments = new List<Enrollment>
            {
                new Enrollment{ContactID = 1, GroupID = 1024},
               new Enrollment{ContactID = 2, GroupID = 1025},

            };
            enrollments.ForEach(h => context.Enrollments.Add(h));
            context.SaveChanges();


        }
    }
}