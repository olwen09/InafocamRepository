using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andamios.Web.Helpers;
using Inafocam.core.Interfaces;
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

        public InstitucionFomadoraController(IUniversity university,
                  IStatus status,
                  IAddressType addressType,
                  ICountry country)
        {
            _university =university;
            _status = status;
            _addressType = addressType;
            _country = country;

            
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
            ViewBag.Country  = new SelectList(_country.Country, "CountryId", "CountryName");
            return View();
        }
    }
}
