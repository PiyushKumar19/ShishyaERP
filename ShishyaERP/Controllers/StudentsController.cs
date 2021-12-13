using Microsoft.AspNetCore.Mvc;
using ShishyaERP.Models;
using ShishyaERP.Models.InterfacesAndCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsCRUD stu;

        public StudentsController(IStudentsCRUD studentsCRUD)
        {
            this.stu = studentsCRUD;
        }
        public IActionResult Detail(int Id)
        {
            Students s = stu.getIdStu(Id);
            return View(s);
        }
        public IActionResult AllDetails()
        {
            var data = stu.getDataStu();
            return View(data);
        }
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Students model)
        {
            if (ModelState.IsValid)
            {
                Students u = new Students()
                {
                    studentName = model.studentName,
                    fatherName = model.fatherName,
                    motherName = model.motherName,
                    age = model.age,
                    gender = model.gender,
                    bloodGroup = model.bloodGroup,
                    dob = model.dob,
                    address = model.address,
                    city = model.city
                };
                stu.addStu(u);
                return RedirectToAction("AllDetails", new { Id = u.studentId });
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            stu.deleteStu(Id);
            return RedirectToAction("AllDetail");
        }
        [HttpGet]
        public ViewResult EditStudent(int Id)
        {
            Students su = stu.getIdStu(Id);
            return View(su);
        }
        [HttpPost]
        public IActionResult EditStudent(Students model)
        {
            if (ModelState.IsValid)
            {
                Students u = stu.getIdStu(model.studentId);
                u.studentName = model.studentName;
                u.fatherName = model.fatherName;
                u.motherName = model.motherName;
                u.age = model.age;
                u.gender = model.gender;
                u.bloodGroup = model.bloodGroup;
                u.dob = model.dob;
                u.address = model.address;
                u.city = model.city;

                Students stuup = stu.updateStudent(u);
                return RedirectToAction("AllDetails");
            }
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
