using Projeto.Model;
using Projeto.Service;
using Projeto.DAO;
using Projeto.VO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

 public abstract class BaseRoute <VO,DAO,Service, Entity,TContext, AutoMapProfile>: ControllerBase
    where VO : BaseVO, new()
    where DAO : BaseDAO<Entity, VO, TContext, AutoMapProfile>, new ()
    where Entity : BaseEntity, new()
    where TContext : DataBaseContext, new()
    where AutoMapProfile : Profile, new()
    where Service: Baseservice <VO,DAO, Entity,TContext, AutoMapProfile>,new()
    {


        Service service = new Service();
        //exemplo de chamada do postman
        //https://localhost:5002/api/pessoas/1/100?nome=Rodrigo
        [HttpGet("{pageNumber}/{pageSize}/")]
        // GET api/<controller>
        public List<VO> Get(int pageNumber = 1, int pageSize = 100, [FromQuery] VO filter = null)
        {
            return service.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public VO Get(int id)
        {
            return service.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] VO vo)
        {
            try
            {
                service.Save(vo);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }

        }

        [HttpPut]
        public ActionResult Put([FromBody] VO vo)
        {
            if(vo.id > 0)
            {
                try 
                { 
                    service.Update(vo);
                    return Ok();
                }
                catch
                {
                    return StatusCode(400, "Coloque o erro correto e uma msg");
                }
                    
            }
            else
            {
                return StatusCode(400, "Coloque o erro correto e uma msg");
            }
               
        }

        // DELETE api/<controller>/5
        //para testar fica assim https://localhost:5001/api/pessoas/1 onde 1 é o id que vc quer apagar
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if(service.Delete(id))
                    return Ok();
                else
                    return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

    }

}




