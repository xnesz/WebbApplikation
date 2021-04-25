using AutoMapper;
using ResturantReview.Application.Features.ModelName.Commands.CreateModel;
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
            CreateMap<Model, CreateModelResponse>();

        }


    }
}
