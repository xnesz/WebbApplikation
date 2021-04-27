using AutoMapper;
using ResturantReview.Domain.Infreastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Queries.GetResturantQuery
{
    public class ResturantDetailQueryHandler
    {
        //Innehåller kod för metoder, Hittar detta genom att kalla på databasen genom Repository

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
       
        private readonly IResturantRepository _resturantRepository;


        public ResturantDetailQueryHandler(IMapper mapper , IResturantRepository resturantRepository)
        {
            _mapper = mapper;
            _resturantRepository = resturantRepository;

        }

        public async Task<ResturantDetalResponse> GetResturantByID(ResturantDetailCommand getResturantCommand)
        {
         var resturant = await _resturantRepository.GetByIdAsync(getResturantCommand.ResturantID);

         var resturantResponse = _mapper.Map<ResturantDetalResponse>(resturant);

            return resturantResponse;


        }





    }
}
