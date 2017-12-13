using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using TrafficAlarmPCL.Helper;

namespace TrafficAlarmPCL.Database
{
    public class AlarmDatabase
    {

        static object locker = new object();

        SQLiteConnection database;

        public AlarmDatabase()
        {
            database = DependencyService.Get<ILocalFileHelper>().GetConnection();
            database.CreateTable<AlarmModel>();
        }

        public List<AlarmModel> GetAlarms()
        {
            lock (locker)
            {
                if(database.Table<AlarmModel>().Count() == 0)
                {
                    return null;
                } else
                {
                    return database.Table<AlarmModel>().ToList();
                }
            }
        }        

        public int SaveAlarm(AlarmModel alarm)
        {
            lock (locker)
            {
                if (alarm.Id != 0)
                {
                    return database.Update(alarm);
                }
                else
                {
                    return database.Insert(alarm);
                }
            }

            
        }

        public int DeleteAlarm(AlarmModel alarm)
        {
            lock(locker)
            {
                return database.Delete(alarm);
            }
            
        }

    }
}
