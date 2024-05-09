using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
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

            Services.AddScoped<IContactUsService, ContactUsManager>();
            Services.AddScoped<IContactUsDal, EfContactUsDal>();

            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }
        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
