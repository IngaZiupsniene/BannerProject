using GDPRApp.IService;
using GDPRApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDPRApp.Service
{
    public class InformRepository: IInformRepository
    {
       
        public RegUser Create(RegUser regUser)
        {
            var informUser = new RegUser()
            {
                FirstName = regUser.FirstName,
                LastName = regUser.LastName,
                CompanySize = regUser.CompanySize,
                Email = regUser.Email,
                CompanyType = regUser.CompanyType,
                Country = regUser.Country,
                Company = regUser.Company,
                Message = regUser.Message
            };
            return informUser;
        }       
    }
}
