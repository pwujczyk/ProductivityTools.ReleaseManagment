using ProductivityTools.ReleaseManagment.Configuration;
using System;
using System.Reflection;

namespace ProductivityTools.ReleaseManagment.DbUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config();
            Console.WriteLine("Start DBUp");

            var databaseName = config.DatabaseName;
            var serverName = config.ServerName;
            var assembly = Assembly.GetExecutingAssembly();

            var dbUp = new ProductivityTools.DBUp("adm");
            dbUp.PerformUpdate(serverName, databaseName, assembly,true);        
        }
    }
}
