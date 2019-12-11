﻿using AutoMapper;
using DFC.FindACourseClient.AutoMapperProfiles;

namespace DFC.FindACourseClient.UnitTests.ClientHandlers
{
    public static class AutomapperSingleton
    {
        private static IMapper mapper;

        public static IMapper Mapper
        {
            get
            {
                if (mapper == null)
                {
                    // Auto Mapper Configurations
                    var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new FindACourseProfile()); });
                    IMapper createdMapper = mappingConfig.CreateMapper();
                    mapper = createdMapper;
                }

                return mapper;
            }
        }
    }
}