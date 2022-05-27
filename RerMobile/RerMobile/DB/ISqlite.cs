using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace RerMobile.DB
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
