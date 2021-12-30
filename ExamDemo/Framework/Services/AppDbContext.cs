using ExamDemo.BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System.IO;

namespace ExamDemo.Framework.Services
{
    public class AppDbContext : DataContext
    {
        static AppDbContext()
        {
            System.Data.Entity.Database.SetInitializer<AppDbContext>(null);
        }

        public AppDbContext(string connString)
            : base(connString)
        {
        }
        public DbSet<Exams> Exams { get; set; }

    }


    public class DataSettingsManager
    {
        private const string _dataSettingsFilePath = "App_Data/dataSettings.json";
        public virtual DataSettings LoadSettings()
        {
            var text = File.ReadAllText(_dataSettingsFilePath);
            if (string.IsNullOrEmpty(text))
                return new DataSettings();

            //get data settings from the JSON file  
            DataSettings settings = JsonConvert.DeserializeObject<DataSettings>(text);
            return settings;
        }

    }

    public class DataSettings
    {
        public string DataConnectionString { get; set; }
    }

}
