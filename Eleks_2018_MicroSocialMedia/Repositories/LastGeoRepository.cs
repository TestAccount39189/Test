﻿using Eleks_2018_MicroSocialMedia.Data;
using Eleks_2018_MicroSocialMedia.Repositories.Interfaces;
using Eleks_2018_MicroSocialMedia.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eleks_2018_MicroSocialMedia.Repositories
{
    public class LastGeoRepository
        : BaseRepository<LastGeolocation, int>,
          ILastGeoRepository
    {
        public LastGeoRepository(MSMContext context)
            : base(context) { }
    }
}
