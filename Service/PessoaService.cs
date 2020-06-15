using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PessoaService: Baseservice<PessoaVO,PessoaDAO,Pessoa,DataBaseContext,AutoMapperProfile>
    {
        
    }
}
