using MediatR;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommand : IRequest<CreatedCategoryResponse>
{
    public string Name { get; set; }
    public Guid? PostId { get; set; }
}