using ResturantReview.Domain.Infreastructure;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.DeleteResturant
{
    public class DeleteResturantHandler
    {
        private readonly IResturantRepository _resturantRepository;

        public DeleteResturantHandler(IResturantRepository resturantRepository)
        {
            _resturantRepository = resturantRepository;
        }


        public async Task<string> DeleteResturant(DeleteResturantCommand deleteResturantCommand)
        {

            var resturantToBeDeleted = await _resturantRepository.GetResturantByName(deleteResturantCommand.ResturantName);
          await  _resturantRepository.DeleteAsync(resturantToBeDeleted);

            return resturantToBeDeleted.ResturantName;
        }

    }
}
