using Projeto.DAO;
using Projeto.VO;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class LoginService: Baseservice<LoginVO,LoginDAO,Login,DataBaseContext,AutoMapperProfile>
    {
        
    }
}
