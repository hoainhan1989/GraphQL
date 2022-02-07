using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFilterChildren
{
    public class Resolvers
    {
        public TestChildren GetChildren([Parent] TestParent parent)
        {
            return new TestChildren { EntityId = parent.EntityId};
        }
    }

    public class TestParent
    {
        public string EntityId { get; set; }
    }

    public class TestChildren
    {
        public string EntityId { get; set; }
    }
}
