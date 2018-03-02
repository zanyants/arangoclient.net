using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArangoDB.Client
{
    public interface ICollectionPropertySetting
    {
        string CollectionName { get; }

        NamingConvention Naming { get; }
    }
}
