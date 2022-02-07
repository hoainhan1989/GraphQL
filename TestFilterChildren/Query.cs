using HotChocolate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFilterChildren
{
    public class Query
    {
        [UseFiltering]
        public async Task<List<TestParent>> GetParent()
        {
            return new List<TestParent> { new TestParent { EntityId = "1" }, new TestParent { EntityId = "2" } };
        }
    }
}
