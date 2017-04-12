using System;
using System.Collections.Generic;

namespace Vulcan.DataAccess.ORMapping.MSSql
{
    
    [Serializable]
    public class MSSqlEntity : BaseEntity
    {
        private static MSSqlSQLBuilder _builder = new MSSqlSQLBuilder();

        protected override ISQLBuilder SQLBuilder
        {
            get { return _builder; }
        }
    }
}