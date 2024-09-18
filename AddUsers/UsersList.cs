using System;
using System.Data.Entity;
using System.Linq;

namespace AddUsers
{
    public class Users : DbContext
    {
        
        public Users()
            : base("name=Users")
        {
        }

       

        public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}