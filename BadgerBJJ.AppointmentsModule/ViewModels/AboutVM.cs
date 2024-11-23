using BadgerBJJ.AppointmentsModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgerBJJ.AppointmentsModule.ViewModels
{
    public class AboutVM : AboutModel
    {
        AboutModel about = new AboutModel();

        public int DefineNumberOfMembers()
        {
            about.NumberOfMembers = 50;
            return NumberOfMembers;
        }
    }
}
