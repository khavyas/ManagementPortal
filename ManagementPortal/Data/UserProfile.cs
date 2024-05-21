namespace ManagementPortal.Data
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? MarriageDate { get; set; }
        public string BloodGroup { get; set; }
    }
}

