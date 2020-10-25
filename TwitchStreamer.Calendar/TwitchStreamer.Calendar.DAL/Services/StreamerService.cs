using System;
using System.Collections.Generic;
using System.Text;
using TwitchStreamer.Calendar.DAL.Models;

namespace TwitchStreamer.Calendar.DAL.Services
{
    public class StreamerService
    {
        public void Add(int id, string description)
        {
            var streamer = new Streamer
            {
                Id = id,
                Description = description
            };

            if(streamer.Id == 0)
            {
                //true logic goes here
            }
            else
            {
                //do false logic here
            }
        }
    }
}
