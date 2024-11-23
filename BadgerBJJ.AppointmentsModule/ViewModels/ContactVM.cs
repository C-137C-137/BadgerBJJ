using BadgerBJJ.AppointmentsModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgerBJJ.AppointmentsModule.ViewModels
{
    public class ContactVM : ContactModel
    {
        ContactModel contact = new ContactModel();

        public string DefineNumberOfMembers()
        {
            contact.Address = "1191 Üllői út 1.";
            return Address;
        }

    }
}
