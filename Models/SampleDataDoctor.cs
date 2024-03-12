namespace ContactDoctor.Models
{
    public class SampleDataDoctor
    {
        public List<Doctor> doctors;
        public SampleDataDoctor()
        {
            doctors = new List<Doctor>
            {
            new() { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
            new() { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
            new() { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
            new() { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
            new() { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
            };
        }
    }
}
