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
    [Route("api/[controller]")]
    [ApiController]
    public class PerfisRecursosController :BaseRoute <PerfilRecursoVO,PerfilRecursoDAO,PerfilRecursoService,PerfilRecurso,DataBaseContext,AutoMapperProfile>
    {
        
    }

        
}
