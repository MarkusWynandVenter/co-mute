﻿using CoMute.Web.Models;
using CoMute.Web.Models.DAL;
using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class CreateController : ApiController
    {
        public HttpResponseMessage Post(CarpoolCreationRequest request)
        {
            CarpoolsTable table = new CarpoolsTable();
            table.Origin = request.Origin;
            table.Destination = request.Destination;
            table.DaysAvailable = request.DaysAvailable;
            table.AvailableSeats = request.AvailableSeats;
            table.Notes = request.TheNotes;
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
    }
}