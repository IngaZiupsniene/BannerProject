using GDPRApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDPRApp.IService
{
    public interface IInformRepository
    {
        RegUser Create(RegUser regUser);
    }
}
