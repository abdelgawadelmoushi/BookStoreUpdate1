using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


    namespace DoctorMangementSystemTask.Models
    {
   
        public class Appointment
        {
            public int Id { get; set; }
            public string PatientName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string? Department { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; }
            public string? Notes { get; set; }
        }
    }



