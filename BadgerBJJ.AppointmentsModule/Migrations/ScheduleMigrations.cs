using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgerBJJ.AppointmentsModule.Migrations
{
    public class ScheduleMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public ScheduleMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinitionAsync("BJJAppointment", builder => builder
                .Attachable()
                .WithField("AppointmentDate", field => field
                    .OfType("DateTime")
                    .WithDisplayName("Appointment Date"))
                .WithField("MaxParticipants", field => field
                    .OfType("Number")
                    .WithDisplayName("Maximum Participants"))
                .WithField("InstructorName", field => field
                    .OfType("Text")
                    .WithDisplayName("Instructor Name"))
                .WithField("ClassType", field => field
                    .OfType("Text")
                    .WithDisplayName("Class Type"))
            );

            _contentDefinitionManager.AlterTypeDefinitionAsync("BJJAppointment", type => type
                .WithPart("BJJAppointments")
                .Creatable()
                .Listable()
                .Draftable()
                .Versionable()
            );

            return 1;
        }


    }
}
