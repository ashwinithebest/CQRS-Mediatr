using MediatR;

namespace CqrsMediatr.Queries
{
    public class GetValuesQuery
    {
        //we create a record called GetProductsQuery,
        //which implements IRequest<IEnumerable<Product>>.
        //This simply means our request will return a list of products.


        public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
    }
}
