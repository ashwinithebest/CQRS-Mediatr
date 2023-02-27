using MediatR;

namespace CqrsMediatr.Queries
{
      public record GetProductByIdQuery(int id) : IRequest<Product>;
    
}
