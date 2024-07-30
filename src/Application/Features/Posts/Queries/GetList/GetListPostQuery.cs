using MediatR;

namespace Application.Features.Posts.Queries.GetList;

public class GetListPostQuery : IRequest<IEnumerable<GetListPostDto>>
{
}