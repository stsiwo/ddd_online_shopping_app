using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DTO = StsOnlineShopApp.UI.DTO;
using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Config
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            // DataEntity => DTO
            CreateMap<DataEntity.Product, DTO.Product>();
            CreateMap<DataEntity.Review, DTO.Review>();
            CreateMap<DataEntity.SubImage, DTO.SubImage>();
            
        }
    }
}
