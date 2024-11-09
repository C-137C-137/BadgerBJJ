using OrchardCore.ContentManagement;

public class BJJAppointment : ContentPart
{
    public DateTime AppointmentDate { get; set; }
    public int MaxParticipants { get; set; }
    public List<string> RegisteredEmails { get; set; } = new List<string>();
    public string InstructorName { get; set; }
    public string ClassType { get; set; }
}