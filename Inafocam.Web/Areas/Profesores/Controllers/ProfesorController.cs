using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.Profesores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.Profesores.Controllers
{
    [Area("Profesores"), ReturnArea("Profesores")]
    [ReturnControllador("Profesores"), ReturnController("Profesores")]
    public class ProfesorController : Controller
    {
        private readonly ITeacher _teacher;
        private readonly IContactType _contactType;
        private readonly IDocumentType _documentType;
        private readonly ICountry _country;
        private readonly ICity _city;
        private readonly IAddressType _addressType;
        private readonly IStatus _status;
        private readonly IEducationType _educationType;
        private readonly ITeacherEducation _teacherEducation;
        private readonly ITeacherFileType _teacherFileType;
        private readonly INationality _nationality;
        private readonly IMatirialStatus _matirialStatus;
        private readonly IProvince _province;
     

        public ProfesorController(ITeacher teacher, IContactType contactType, 
            IDocumentType documentType, ICountry country ,ICity city,
            IAddressType addressType, IStatus status, IEducationType educationType,
            ITeacherEducation teacherEducation, INationality nationality, IMatirialStatus matirialStatus, IProvince province
            )
        {
            _teacher = teacher;
            _contactType = contactType;
            _documentType = documentType;
            _country= country;
            _city= city;
            _addressType= addressType;
            _status = status;
            _educationType = educationType;
            _teacherEducation = teacherEducation;
            _nationality = nationality;
            _matirialStatus = matirialStatus;
            _province = province;
        }

        public IActionResult Index()
        {
            var teachers = _teacher.GetAll;

            return View(teachers);
        }  
        
        public IActionResult Crear(TeacherModel model)
        {


            //var model = CopyPropierties.Convert<Teacher, TeacherModel>(data);
            ViewBag.ContactTypes = new SelectList(_contactType.GetAll, "ContactTypeId", "ContactTypeName");
            ViewBag.DocumentType = new SelectList(_documentType.GetAll, "DocumentTypeId", "DocumentTypeName");
            ViewBag.Countries = new SelectList(_country.GetAll, "CountryId", "CountryName");
            ViewBag.Cities = new SelectList(_city.Cities, "CityId", "CityName");
            ViewBag.AddressTypes = new SelectList(_addressType.addressTypes, "AddressTypeId", "AddressTypeName");
            //ViewBag.Status = new SelectList(_status);
            ViewBag.EducationType = new SelectList(_educationType.GetAll, "EducationTypeId", "EducationTypeName");
            ViewBag.TeacherEducation = new SelectList(_teacherEducation.GetAll, "TeacherEducationId", "TeacherEducationTitle");
            ViewBag.Nationality = new SelectList(_nationality.GetAll, "NationalityId", "NationalityName");
            ViewBag.MatirialStatus = new SelectList(_matirialStatus.GetAll, "MaritalStatusId", "MaritalStatusName");
            //genre

            return View(model);
        }

        public IActionResult Editar(int id)
        {
            var data = _teacher.GetById(id);

          var model =   CopyPropierties.Convert<Teacher, TeacherModel>(data);
            ViewBag.ContactTypes = new SelectList(_contactType.GetAll, "ContactTypeId", "ContactTypeName");
            ViewBag.DocumentType = new SelectList(_documentType.GetAll, "DocumentTypeId", "DocumentTypeName");
            ViewBag.Countries = new SelectList(_country.GetAll, "CountryId", "CountryName");
            ViewBag.Cities = new SelectList(_city.Cities, "CityId", "CityName");
            ViewBag.AddressTypes = new SelectList(_addressType.addressTypes, "AddressTypeId", "AddressTypeName");
            //ViewBag.Status = new SelectList(_status);
            ViewBag.EducationType = new SelectList(_educationType.GetAll, "EducationTypeId", "EducationTypeName");
            ViewBag.TeacherEducation = new SelectList(_teacherEducation.GetAll, "TeacherEducationId", "TeacherEducationTitle");
            ViewBag.Nationality = new SelectList(_nationality.GetAll, "NationalityId", "NationalityName");
            ViewBag.MatirialStatus = new SelectList(_matirialStatus.GetAll, "MaritalStatusId", "MaritalStatusName");

            return View("Crear",model);
        }

        public IActionResult Guardar(TeacherModel model)
        {

            try
            {
                var data = CopyPropierties.Convert<TeacherModel, Teacher>(model);
                _teacher.Save(data);
            }
            catch (Exception e)
            {
                //var model = CopyPropierties.Convert<Teacher, TeacherModel>(data);
                //ViewBag.ContactTypes = new SelectList(_contactType.GetAll, "ContactTypeId", "ContactTypeName");
                //ViewBag.DocumentType = new SelectList(_documentType.GetAll, "DocumentTypeId", "DocumentTypeName");
                //ViewBag.Countries = new SelectList(_country.Country, "CountryId", "CountryName");
                //ViewBag.Cities = new SelectList(_country.Country, "CityId", "CityName");
                //ViewBag.AddressTypes = new SelectList(_addressType.addressTypes, "AddressTypeId", "AddressTypeName");
                ////ViewBag.Status = new SelectList(_status);
                //ViewBag.EducationType = new SelectList(_educationType.GetAll, "EducationTypeId", "EducationTypeName");
                //ViewBag.TeacherEducation = new SelectList(_teacherEducation.GetAll, "TeacherEducationId", "TeacherEducationTitle");
                //ViewBag.Nationality = new SelectList(_nationality.GetAll, "NationalityId", "NationalityName");
                //ViewBag.MatirialStatus = new SelectList(_matirialStatus.GetAll, "MaritalStatusId", "MaritalStatusName");

                //return View("Crear", model);
            }


            return View("Index", _teacher.GetAll);
        }

    }
}
