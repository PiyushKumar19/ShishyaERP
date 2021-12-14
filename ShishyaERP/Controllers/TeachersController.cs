using Microsoft.AspNetCore.Mvc;
using ShishyaERP.Models;
using ShishyaERP.Models.InterfacesAndCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishyaERP.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeachersCRUD te;

        public TeachersController(ITeachersCRUD teachersCRUD)
        {
            this.te = teachersCRUD;
        }
        public IActionResult Detail(int Id)
        {
            Teachers t = te.getIdTeach(Id);
            return View(t);
        }
        public IActionResult AllDetails()
        {
            var data = te.getDataTeach();
            return View(data);
        }
        [HttpGet]
        public IActionResult CreateTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeacher(Teachers model)
        {
            if(ModelState.IsValid)
            {
                Teachers t = new Teachers()
                {
                    teacherName = model.teacherName,
                    teacherAge = model.teacherAge,
                    teacherGender = model.teacherGender,
                    bgroup = model.bgroup,
                    teacherNo = model.teacherNo,
                    graduatedIn = model.graduatedIn,
                    subject = model.subject,
                    teacherAddress = model.teacherAddress,
                    teachCity = model.teachCity
                };
                te.addTeach(t);
                return RedirectToAction("AllDetails");
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            te.deleteTeach(Id);
            return RedirectToAction("AllDetails");
        }
        [HttpGet]
        public ViewResult EditTeacher(int Id)
        {
            Teachers t = te.getIdTeach(Id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditTeacher(Teachers model)
        {
            if(ModelState.IsValid)
            {
                Teachers t = te.getIdTeach(model.teacherId);
                t.teacherName = model.teacherName;
                t.teacherAge = model.teacherAge;
                t.teacherGender = model.teacherGender;
                t.bgroup = model.bgroup;
                t.graduatedIn = model.graduatedIn;
                t.subject = model.subject;
                t.teacherAddress = model.teacherAddress;
                t.teachCity = model.teachCity;

                Teachers teachup = te.updateTeacher(t);
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
