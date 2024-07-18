using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
{
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);
        
        return new CreatedCategoryResponse();
    }
}