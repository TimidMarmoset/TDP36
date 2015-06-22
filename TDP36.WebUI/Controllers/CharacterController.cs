using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDP36.Domain.Abstract;
using TDP36.Domain.Entities;

namespace TDP36.WebUI.Controllers
{
    public class CharacterController : Controller
    {   
        private ICharacterRepository repository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            this.repository = characterRepository;
        }

        public ViewResult Create()
        {
            return View(repository.Characters);
        }
    }
}