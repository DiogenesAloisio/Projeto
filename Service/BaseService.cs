using System;
using Projeto.DAO;
using Projeto.VO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projeto.Model;
using System.Collections.Generic;

namespace Projeto.Service
{
    public abstract class Baseservice <VO,DAO, Entity,TContext, AutoMapProfile>
    where VO : BaseVO, new()
    where DAO: BaseDAO<Entity, VO, TContext, AutoMapProfile>, new ()
    where Entity : BaseEntity, new()
    where TContext : DbContext, new()
    where AutoMapProfile : Profile, new()

    {
            
        DAO dao = new DAO();
        public VO Save(VO vo)
        {
            try
            {
                if (vo.id > 0)
                {
                    dao.Save(vo);
                }
            
                return vo;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public List<VO> GetAll(int pageNumber, int pageSize, VO filter = null)
        {
            try
            {
                return dao.Select(pageNumber,pageSize,filter);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public VO GetOne(int id = 0)
        {
            try
            {
                return dao.SelectOne(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dao.Delete(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Update(VO vo)
        {
            try
            {
                return dao.Update(vo);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }
    }
}
        

  




