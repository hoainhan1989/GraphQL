using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFilterChildren
{
    public class Types : ObjectType<TestParent>
    {
        protected override void Configure(IObjectTypeDescriptor<TestParent> descriptor)
        {
            descriptor.Field<Resolvers>(x => x.GetChildren(default))
                .Name("Children").UseFiltering();
        }
    }

}
