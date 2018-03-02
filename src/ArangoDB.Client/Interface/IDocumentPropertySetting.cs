using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArangoDB.Client
{
    public interface IDocumentPropertySetting
    {
        string PropertyName { get; }

        bool IgnoreProperty { get; }

        NamingConvention Naming { get; }

        IdentifierType Identifier { get; }
    }

    public enum IdentifierType
    {
        None = 0,
        Key = 1,
        Handle = 2,
        Revision = 3,
        EdgeFrom = 4,
        EdgeTo = 5
    }

    public enum NamingConvention
    {
        UnChanged = 0,
        ToCamelCase = 1
    }
}
