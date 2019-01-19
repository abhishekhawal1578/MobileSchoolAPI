﻿using MobileSchoolAPI.Models;
using MobileSchoolAPI.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileSchoolAPI.BusinessLayer
{
    public class InstituteBusiness
    {
        public object GetInstituteName(GetUserId Obj)
        {
            SchoolMainContext db = new ConcreateContext().GetContext(Obj.UserId, Obj.PASSWORD);
            if (db == null)
            { 
                return new Results { IsSuccess = false,  Message= "Invalid User" } ; 
            }
            else
            {
                var result = db.ViewGetInstituteNames.FirstOrDefault();
                return new ResultBirth { IsSuccess = true, Result = result };
            }
        }
    }
}