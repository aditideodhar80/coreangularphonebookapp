using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using CoreAngularDemo.Queries.Container;

namespace CoreAngularDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}