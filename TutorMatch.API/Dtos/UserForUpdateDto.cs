namespace TutorMatch.API.Dtos
{
    public class UserForUpdateDto
    {
        public string Introduction { get; set; }
        public string Subjects { get; set; }
        public string Availability { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string RateRange { get; set; }
        public string StudentTutor { get; set; }
        public string Year { get; set; }
        public string Gender { get; set; }
    }
}