using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BusinessEngine
{
    public class EngineBase
    {
        protected string ConnectionString { get { return ConfigurationManager.ConnectionStrings["BookDb"].ConnectionString; } }
        protected IUnitOfWork UnitOfWork { get { return new UnitOfWork(ConnectionString); } }
    }
}
