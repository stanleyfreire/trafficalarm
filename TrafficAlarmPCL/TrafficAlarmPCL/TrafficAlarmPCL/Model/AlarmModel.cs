using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficAlarmPCL
{
    public class AlarmModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public string Origin { get; set; }

        public string Destiny { get; set; }

        public DateTime DatePicked { get; set; }

        public TimeSpan TimePicked { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime LeavingTime { get; set; }

        public bool Type { get; set; }



    }
}
