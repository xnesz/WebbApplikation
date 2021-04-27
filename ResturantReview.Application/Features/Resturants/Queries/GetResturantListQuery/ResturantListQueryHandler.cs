using AutoMapper;
using ResturantReview.Domain.Infreastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Queries.GetResturantListQuery
{
    public class ResturantListQueryHandler
    {
        private readonly IMapper _mapper;

        private readonly IResturantRepository _resturantRepository;

        public ResturantListQueryHandler(IMapper mapper, IResturantRepository resturantRepository)
        {
            _mapper = mapper;
            _resturantRepository = resturantRepository;
        }

        public async Task<List <ResturantListQueryResponse>> GetResturantList()
        {
          var listOfResturant = await _resturantRepository.ListAllAsync();

         var listOfResturantResponse = _mapper.Map <List <ResturantListQueryResponse>>(listOfResturant);

            return listOfResturantResponse;
        }

    }
}