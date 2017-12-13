
using System.IO;
using TrafficAlarmPCL.Helper;
using SQLite;
using TrafficAlarmPCL.Droid;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(LocalFileHelper_Android))]

namespace TrafficAlarmPCL.Droid
{
    class LocalFileHelper_Android : ILocalFileHelper
    {
        public LocalFileHelper_Android() { }

        public SQLiteConnection GetConnection()
        {
            string dbFileName = "Alarms.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentsPath, dbFileName);
            SQLiteConnection conn;
            

            try
            {
                 return conn = new SQLiteConnection(path);

            }
            catch (Exception e)
            {
            }
            

            return null;
        }

       

    }
}