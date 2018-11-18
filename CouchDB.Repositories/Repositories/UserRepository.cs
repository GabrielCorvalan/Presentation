﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tp.Entity.Model;

namespace Presentation.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        public UserRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Users> GetAllUsers()
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Users.AsNoTracking().ToList();
            }
        }
        public Users GetUserById(int Id)
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Users.AsNoTracking().Where(s => s.Id.Equals(Id)).FirstOrDefault();
            }
        }
        public bool Delete(UserDTO user)
        {
            try
            {
                using (var ctx = new SysacadFRGPContext())
                {
                    var oUser = ctx.Users.Where(u => u.Id.Equals(user.Id)).FirstOrDefault();

                    ctx.Users.Attach(oUser);
                    oUser.Deleted = true;

                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CreateOrUpdate(UserDTO user)
        {
            try
            {
                using (var ctx = new SysacadFRGPContext())
                {
                    var oUser = ctx.Users.AsNoTracking()
                                .Where(c => c.Id == user.Id)
                                .FirstOrDefault();

                    if (oUser == null)
                    {
                        ctx.Users.Add(oUser);
                    }
                    else
                    {
                        ctx.Users.Attach(oUser);
                    }
                    oUser.Names = user.Names;
                    oUser.Email = user.Email;
                    oUser.Password = user.Password;
                    oUser.RolId = user.RolId;
                    oUser.Surnames = user.Surnames;
                    oUser.UserName = user.UserName;

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