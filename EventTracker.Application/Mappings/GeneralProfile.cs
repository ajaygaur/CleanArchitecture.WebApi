using AutoMapper;
using EventTracker.Application.Features.Products.Commands.CreateProduct;
using EventTracker.Application.Features.Products.Queries.GetAllProducts;
using EventTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventTracker.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
