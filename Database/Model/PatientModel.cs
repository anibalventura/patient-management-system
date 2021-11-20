using System;

namespace Database.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Identification { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Smoker { get; set; }
        public string Allergies { get; set; }
        public string Photo { get; set; }
    }
}
