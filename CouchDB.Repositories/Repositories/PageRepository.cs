using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Tp.Entity.Model;

namespace Presentation.Repositories.Repositories
{
    public class PageRepository : IPageRepository
    {
        private readonly IMapper _mapper;
        public PageRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Pages> GetAllPages()
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Pages.AsNoTracking().Where(p => !p.Deleted).ToList();
            }
        }
        public Pages GetPageById(int Id)
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Pages.AsNoTracking().Where(s => s.Id.Equals(Id)).FirstOrDefault();
            }
        }
        public bool Delete(PageDTO page)
        {
            try
            {
                using (var ctx = new SysacadFRGPContext())
                {
                    var oPage = ctx.Pages.Where(u => u.Id.Equals(page.Id)).FirstOrDefault();

                    ctx.Pages.Attach(oPage);
                    oPage.Deleted = true;

                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CreateOrUpdate(PageDTO page)
        {
            try
            {
                using (var ctx = new SysacadFRGPContext())
                {
                    var oPage = ctx.Pages.AsNoTracking()
                                .Where(c => c.Id == page.Id)
                                .FirstOrDefault();

                    if (oPage == null)
                    {
                        ctx.Pages.Add(oPage);
                    }
                    else
                    {
                        ctx.Pages.Attach(oPage);
                    }
                    oPage.PageUrl = page.PageUrl;
                    oPage.Tittle = page.Tittle;
                    oPage.Description = page.Description;
                    oPage.Deleted = false;

                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
