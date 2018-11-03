﻿using MobileSchoolAPI.BusinessLayer;
using MobileSchoolAPI.Models;
using MobileSchoolAPI.ParamModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileSchoolAPI.Controllers
{
    public class DivisionListController : ApiController
    {
        SchoolContext db = new SchoolContext();
        [HttpPost]
        public object getStdDivList([FromBody]ParamDIVISIONLIST objdiv)
        {
            GetDivisionInfoBusiness obj = new GetDivisionInfoBusiness();
			return new DivisionListByUserResult() { IsSuccess = "true", DivisionList = obj.GetDivision(objdiv) };
		}
        public object ViewDivision([FromBody]PARAMSTD objstd)
        {
            GETHOMEWORK objhome = new GETHOMEWORK();
            // return objhome.GetStandard(objstd);
            return new DivisionListResult() { IsSuccess = "true", DivisionListByUser = objhome.GetStandard(objstd) };


        }

    }
}