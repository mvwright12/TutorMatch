using System;
using System.Collections.Generic;
using TutorMatch.API.Models;

namespace TutorMatch.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string StudentTutor { get; set; }
        public string Gender { get; set; }
        public string Year { get; set; }
        public string Introduction { get; set; }
        public string Subjects { get; set; }
        public string Availability { get; set; }
        public string RateRange { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}