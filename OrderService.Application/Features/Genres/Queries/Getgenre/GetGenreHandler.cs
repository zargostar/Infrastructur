using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using OrderService.Application.Contracts;
using OrderService.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Genres.Queries.Getgenre
{
    public class GetGenreHandler : IRequestHandler<GetGenreQuery, GenreDto>
    {
        private readonly IMediator _mediator;
        private readonly IMapper mapper;
        private readonly IGenreRepository genreRepository;
        private readonly IMemoryCache memoryCache;

        public GetGenreHandler(IMediator mediator, IGenreRepository genreRepository, IMapper mapper, IMemoryCache memoryCache)
        {
            _mediator = mediator;
            this.genreRepository = genreRepository;
            this.mapper = mapper;
            this.memoryCache = memoryCache;
        }

        public async Task<GenreDto> Handle(GetGenreQuery request, CancellationToken cancellationToken)
        {
            var mcatch= memoryCache.Get<GenreDto>(request.Id);
            if (mcatch != null)
            {
                return mcatch;
            }
            else
            {
                var genre = await genreRepository.GetByIdAsync(request.Id);
                if (genre == null) {
                    throw new ClientErrorMessage("یافت نشد");
                }
                var res= mapper.Map<GenreDto>(genre);
                var cOption = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromHours(1)) ;
                memoryCache.Set<GenreDto>(request.Id, res, cOption);
                return res;

            }
          

        }
    }
}
