using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace TestApp.DAL
{
    public class TestDB : DbContext
    {
        // Your context has been configured to use a 'TestDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestApp.DAL.TestDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TestDB' 
        // connection string in the application configuration file.
        public TestDB()
            : base("name=TestDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<UserEntity> Users { get; set; }
    }

    public class UserEntity
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string DOB { get; set; }
        public string Address { get; set; }
    }
}