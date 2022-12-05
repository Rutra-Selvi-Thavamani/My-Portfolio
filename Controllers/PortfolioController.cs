using Rutra_Thavamani_Selvi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rutra_Thavamani_Selvi.Controllers
{
    [RoutePrefix("Portfolio")]
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewBag.Index = "Rutra Thavamani Selvi";
            return View();
        }
        public ActionResult Education()
        {
            ViewBag.Education = "Education Details ";

            List<Education> details = new List<Education>()
            {
                new Education{ Collegename = "Saraswathi Vidya Niketan High School",
                Location = "Hyderabad", Year = 2017, Specialization="Maths, Science, Social", Aggregate = 9.5},
                new Education{ Collegename = "Sri Chaitanya Junior Kalasal", Location = "Hyderabad",
                Year = 2019, Specialization="MPC(Mathematics, Phyiscs, Chemistry", Aggregate = 9.8},
                new Education{Collegename = "Raja Bahadur Venkata Rama Reddy Women's College", Location="Hyderabad", 
                Year=2022,  Specialization="Bachelor of Science(Computer Science)", Aggregate=9.5}
            };
            return View(details);
        }
        public ActionResult Skills()
        {
            ViewBag.Skills = "My Skills Page";
            List<Skills> skills = new List<Skills>()
            {
                new Skills {PrimarySkills = "HTML, CSS, JAVASCRIPT, REACTJS, ", SecondarySkills="JAVA , PYTHON, SQL, DJANGO, MONGODB",
                TechnicalSkills="C, C++, JAVA, PYTHON, JAVASCRIPT, DBMS, SQL, REACTJS", KeySkills="FLEXIBLE AND ADAPTABLE, SELF-MOTIVATED, PROBLEM-SOLVING, ACTIVE-LISTENING, CRTIICAL THINKING"}
            };
            return View(skills);
        }


        
        public ActionResult Experience()
        {
            ViewBag.Experience = "My Experiences";
            List<Experience> experience = new List<Experience>()
            {
                new Experience {CompanyName = "Gyansys InfoTech", Location="Bengaluru", Designation="Software Engineer Trainee", Year=2022, Salary=4.5,
                Description="Initially Joined into SAP ABAP training . Later Shifted to Microsoft of REACTJS training. Now Currently undergoing into the trianing of ASP.Net"}
            };
            return View(experience);
        }
        public ActionResult Hobbies()
        {
            ViewBag.Hobbies = "My Hobbies";
            List<Hobbies> hobbies = new List<Hobbies>()
            {
                new Hobbies {PersonalInterest = "Learning Languages, Photography, Art, Reading, Gardening,  Mindfulness",
                RegularHobbies="Doing Yoga, Meditation, Pencil Art, Listening to Music, Solving Sudoko Game"}
            };
            return View(hobbies);
        }
        [HttpGet]
        public ActionResult Contact(int id, string name)
        {
          ViewBag.Id = id;
            ViewBag.Name = name;
            return View("Contact");
        }
        
        [HttpPost]
        public ActionResult Feedback()
        {
          
            return View("Feedback");
        }

        
        public ActionResult Register(RegisterModel register)
        {
            string name = register.Name;
            int dob = register.DOB;
            string qualification = register.Qualification;
            string school = register.School;
            string college = register.College;
            string stream = register.Stream;

            return View( );
        }
      
        public ActionResult BasicDetails()
        {
            return View("BasicDetails");
        }
    }
}