namespace ActivityFinderApp.Models
{
    public class Event
    {
        public int Id { get; set; }  // Primary Key
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public int MaxParticipants { get; set; }
        public int CurrentParticipants { get; set; }
        public string Type { get; set; }  // E.g., party, sports, theater, etc.
    }
}
