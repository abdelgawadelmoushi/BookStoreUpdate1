using DoctorMangementSystemTask.Models;
using DoctorMangementSystemTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DoctorMangementSystemTask.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext _context = new();

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult BookAppointment()
        {
            var appointments = _context.Appointments.AsNoTracking().ToList();
            return View(appointments);
        }
        
        [HttpPost]
        public IActionResult BookAppointment(Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                var allAppointments = _context.Appointments.AsNoTracking().ToList();
                return View(allAppointments);
            }

            var existing = _context.Appointments
                .FirstOrDefault(a => a.Date == appointment.Date && a.Time == appointment.Time);

            if (existing != null)
            {
             
                var allAppointments = _context.Appointments.AsNoTracking().ToList();
                return View(allAppointments);
            }

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

           
            var appointments = _context.Appointments.AsNoTracking().ToList();
            return View();
        }
    }
}
