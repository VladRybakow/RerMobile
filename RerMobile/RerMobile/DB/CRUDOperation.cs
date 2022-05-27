using System;
using SQLite;
using RerMobile.Models;
using System.Collections.Generic;
using System.Text;

namespace RerMobile.DB
{
    public class CRUDOperation
    {
        readonly SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Project>();
            db.CreateTable<User>();
        }
        public IEnumerable<Project> GetProjects()
        {
            return db.Table<Project>();
        }
        public IEnumerable<User> GetClient()
        {
            return db.Table<User>();
        }
        public Project GetProjectItem(int id)
        {
            return db.Get<Project>(id);
        }
        public int DelProj(int id) { return db.Delete<Project>(id); }
        public int SaveItem(Project projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

        public int SaveClient(User projectModel)
        {
            return db.Insert(projectModel);
        }
    }
}
