using AutoMapper;
using ResturantReview.Application.Features.ModelName.Commands.CreateModel;
using ResturantReview.Application.Features.Resturants.Commands.CreateResturant;
using ResturantReview.Application.Features.Resturants.Commands.UpdateResturant;
using ResturantReview.Application.Features.Resturants.Queries.GetResturantListQuery;
using ResturantReview.Application.Features.Resturants.Queries.GetResturantQuery;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ResturantReview.Application.Profiles
{
    public class MappingProfile : Profile // profile från automapper
    {
        //Här är automapper configuration:

        //CreateMap<FrånModel, TillModel>();
        // Så en riktig hade sett ut såhär:

        public MappingProfile()
        {
            // Från Model, till CreateModelResponse
            
            //from model to CreateModelResponse
            CreateMap<Resturant, CreateResturantResponse>();
          
            
            // From model to UpdateModelResponse
            CreateMap<Resturant, UpdateResturantRespone>();
           
            

            // from model to ModelDetailResponse
            CreateMap<Resturant, ResturantDetalResponse>();

            // from modelList to modelListResponse

            CreateMap<Resturant, ResturantListQueryResponse>();

        }


    }
}
