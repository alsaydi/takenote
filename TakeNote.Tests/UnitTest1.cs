using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakeNote.Model;
using System.Data.Entity;
using System.Linq;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;
namespace TakeNote.Tests
{
    [TestClass]
    public class CFDriver
    {
        [TestMethod]
        public void CreateDB()
        {
            Database.SetInitializer<TakeNoteContext>(new CreateDatabaseIfNotExists<TakeNoteContext>());
            var ctx = new TakeNoteContext();
            var sql = (ctx as IObjectContextAdapter ).ObjectContext.CreateDatabaseScript();
            var users = from u in ctx.Users select u;
            Assert.IsTrue(users.Count() == 0);          
        }
    }
}
