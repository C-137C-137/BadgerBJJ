using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgerBJJ.AppointmentsModule.Models
{
    public class ScheduleModel : ContentPart
    {
        public DateTime AppointmentDate { get; set; }
        public int MaxParticipants { get; set; }
        public List<string> RegisteredEmails { get; set; } = new List<string>();
        public string InstructorName { get; set; }
        public string ClassType { get; set; } // e.g., "Beginner", "Advanced"
    }
}
