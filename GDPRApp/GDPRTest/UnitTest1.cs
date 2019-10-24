using GDPRApp.Controllers;
using GDPRApp.Model;
using GDPRApp.Service;
using NUnit.Framework;
using Shouldly;
using System;

namespace Tests
{
    public class Tests
    {
        private InformRepository _informRepository;
        private RegUser _regUser;

        [SetUp]
        public void Setup()
        {


            _regUser = new RegUser()
            {
                FirstName = "12",
                LastName = "Pavardenis",
                CompanySize = "11-100 employees",
                Email = "info@gmail.com",
                CompanyType = "Agency",
                Country = "Lithuania",
                Company = "Company",
                Message = "Message message"
            };
            
            _informRepository = new InformRepository();
        }

        [Test]
        public void SlouldWriteValidationMessage()
        {
            Should.Throw<Exception>(() =>
            {
                _informRepository.Create(_regUser);
            });
        }
    }
}