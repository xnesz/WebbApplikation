using AutoMapper;
using ResturantReview.Domain.Infreastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.UpdateResturant
{
   public class UpdateResturantHandler
    {
        private readonly IResturantRepository _resturantRepository;
        private readonly IMapper _mapper;
        public UpdateResturantHandler(IMapper mapper, IResturantRepository resturantRepository)
        {
            _resturantRepository = resturantRepository;
            _mapper = mapper;
        }

        public async Task<UpdateResturantRespone> UpdateResturant(UpdateResturantCommand updateResturantCommand)
        {
           var resturantToBeUpdated = await _resturantRepository.GetResturantByName(updateResturantCommand.ResturantName);

            
            resturantToBeUpdated.ResturantName = updateResturantCommand.ResturantName;
            resturantToBeUpdated.Category = updateResturantCommand.Category;
            resturantToBeUpdated.ResturantLink = updateResturantCommand.ResturantLink;
            resturantToBeUpdated.GoogleMapsPhoto = updateResturantCommand.GoogleMapsPhoto;
            resturantToBeUpdated.StreetPhoto = updateResturantCommand.StreetPhoto;

          await  _resturantRepository.UpdateAsync(resturantToBeUpdated);

            var updateResturantResponse = _mapper.Map<UpdateResturantRespone>(resturantToBeUpdated);

            return updateResturantResponse;


        }

    }
}
