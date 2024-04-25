﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection Services)
        {

            Services.AddScoped<ICommentService, CommentManager>();
            Services.AddScoped<ICommentDal, EfCommentDal>();

            Services.AddScoped<IDestinationService, DestinationManger>();
            Services.AddScoped<IDestinaitonDal, EfDestinationDal>();

            Services.AddScoped<IAppUserService, AppUserManager>();
            Services.AddScoped<IAppUserDal, EfAppUserDal>();

            Services.AddScoped<IReservationService, ReservationManager>();
            Services.AddScoped<IReservationDal, EfReservationDal>();

            Services.AddScoped<IGuideService, GuideManager>();
            Services.AddScoped<IGuideDal, EfGuideDal>();

            Services.AddScoped<IExcelService, ExcelManager>();
            Services.AddScoped<IPdfService, PdfManager>();

        }
    }
}
