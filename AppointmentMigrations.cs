using System;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

public class AppointmentMigrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public AppointmentMigrations(IContentDefinitionManager contentDefinitionManager)
    {
        _contentDefinitionManager = contentDefinitionManager;
    }

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition("BJJAppointment", builder => builder
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

        _contentDefinitionManager.AlterTypeDefinition("BJJAppointment", type => type
            .WithPart("BJJAppointment")
            .Creatable()
            .Listable()
            .Draftable()
            .Versionable()
        );


        return 1;
    }
}