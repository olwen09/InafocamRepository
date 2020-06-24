using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Inafocam.core.Utilidades;
using Inafocam.Web.Areas.InstitucionFomadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inafocam.Web.Areas.InstitucionFomadora.Controllers
{

    [Area("InstitucionFomadora"), ReturnArea("InstitucionFomadora")]
    [ReturnControllador("Institucion Fomadora"), ReturnController("InstitucionFomadora")]
    public class InstitucionFomadoraController : Controller
    {
        private readonly IUniversity _university;
        private readonly IStatus _status;
        private readonly IAddressType _addressType;
        private readonly ICountry _country;
        private readonly IProvince _province;
        private readonly ICity _city;

        public InstitucionFomadoraController(IUniversity university,
                  IStatus status,
                  IAddressType addressType,
                  ICountry country,
                  IProvince province,
                  ICity city)
        {
            _university =university;
            _status = status;
            _addressType = addressType;
            _country = country;
            _province = province;
            _city = city;

            
        }

        public IActionResult Index()
        {

            var universities = _university.Universities;

            return View(universities);
        }


        public IActionResult Crear()
        {

            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            ViewBag.AddressType = new SelectList(_addressType.addressTypes, "AddressTypeId", "AddressTypeName");
            ViewBag.Country  = new SelectList(_country.GetAll, "CountryId", "CountryName");
            ViewBag.Province  = new SelectList(_province.Provinces, "ProvinceId", "ProvinceName");
            ViewBag.City  = new SelectList(_city.Cities, "CityId", "CityName");
            return View();
        }

       public IActionResult Editar(int id)
        {
         
            var university = _university.GetById(id);

            var universityModel = CopyPropierties.Convert<University, UniversityModel>(university);


            ViewBag.Status = new SelectList(_status.Status, "StatusId", "StatusName");
            ViewBag.AddressType = new SelectList(_addressType.addressTypes, "AddressTypeId", "AddressTypeName");
            ViewBag.Country = new SelectList(_country.GetAll, "CountryId", "CountryName");
            ViewBag.Province = new SelectList(_province.Provinces, "ProvinceId", "ProvinceName");
            ViewBag.City = new SelectList(_city.Cities, "CityId", "CityName");

            return View("Crear", universityModel);

        }

        [HttpPost]
        public IActionResult GuardarUniverity(UniversityModel model)
        {

            var university = CopyPropierties.Convert<UniversityModel, University>(model);
            try
            {
               

               

                _university.Save(university);
            }
            catch(Exception e)
            {
                return View("Index", _university.Universities);
            }

            return View("Index", _university.Universities);
        }
    }
}
