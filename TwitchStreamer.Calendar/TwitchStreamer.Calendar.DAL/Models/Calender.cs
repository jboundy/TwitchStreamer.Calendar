﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchStreamer.Calendar.DAL.Models
{
    class Calender
    {
        public DayOfWeek DayOfWeek { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}
