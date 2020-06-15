using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Model;
using Projeto.Service;
using Projeto.VO;
using Projeto.DAO;

namespace Projeto.Controllers
{
    
    public class LoginsController :BaseRoute <LoginVO,LoginDAO,LoginService,Login,DataBaseContext,AutoMapperProfile>
    {
        
    }
}