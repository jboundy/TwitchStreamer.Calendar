using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwitchStreamer.Calendar.DAL.Services;

namespace TwitchStreamer.Calendar.Web.Controllers
{
    public class StreamerController : Controller
    {
        private StreamerService _service;
        public StreamerController()
        {
            _service = new StreamerService();
        }


    }
}
