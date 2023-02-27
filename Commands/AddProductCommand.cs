using MediatR;

namespace CqrsMediatr.Commands
{
   
        //our record has a single Product property and inherits from the IRequest interface
        public record AddProductCommand(Product Product) : IRequest<Product>;
    
}
