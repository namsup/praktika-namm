using Microsoft.EntityFrameworkCore;
using MoscowTrafficRestriction.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoscowTrafficRestriction.InfrastructureServices.Gateways.Database
{
    public class TrafficRestrictionContext : DbContext
    {
        public DbSet<TrafficRestriction> TrafficRestrictions { get; set; }

        public TrafficRestrictionContext(DbContextOptions<TrafficRestrictionContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrafficRestriction>().HasData(
               new
               {
                   Id = 1L,
                   NameOfManagingOrg = "Товарищество собственников жилья «Рождественский бульвар дом 5-7 » 7702560790 2015",
                   Year = "2015",
                   INN = "7702560790",
                   IssuedPrescriptions="1",
                   ViolationsAmount = "3",
                   ProtocolsComposed = "0",
                   EventsExecuted = "0",
                   EventsNotExecutedInTime="0",
                   ProtocolsComposedForFailure="0",
                   SumOfFine="0",
                   global_id= "639913050",

               },
                        new
                        {
                            Id = 2L,
                            NameOfManagingOrg = "ООО «Управляющая компания» Шишкин Лес» 5074046552 2015",
                            Year = "2015",
                            INN = "5074046552",
                            IssuedPrescriptions = "219",
                            ViolationsAmount = "617",
                            ProtocolsComposed = "60",
                            EventsExecuted = "0",
                            EventsNotExecutedInTime = "0",
                            ProtocolsComposedForFailure = "1",
                            SumOfFine = "1998",
                            global_id = "639913054",

                        },
                        new
                        {
                            Id = 3L,
                            NameOfManagingOrg = "Жилищно Строительный Кооператив «Фаза» 7737023041 2015",
                            Year = "2015",
                            INN = "7737023041",
                            IssuedPrescriptions = "7",
                            ViolationsAmount = "5",
                            ProtocolsComposed = "1",
                            EventsExecuted = "0",
                            EventsNotExecutedInTime = "0",
                            ProtocolsComposedForFailure = "0",
                            SumOfFine = "40",
                            global_id = "639913083",

                        },
                        new
                        {
                            Id = 4L,
                            NameOfManagingOrg = "ФГУП «Управление служебными и жилыми зданиями» РАМН 7712019533 2015",
                            Year = "2015",
                            INN = "7712019533",
                            IssuedPrescriptions = "0",
                            ViolationsAmount = "2",
                            ProtocolsComposed = "0",
                            EventsExecuted = "0",
                            EventsNotExecutedInTime = "0",
                            ProtocolsComposedForFailure = "0",
                            SumOfFine = "0",
                            global_id = "639913137",
                        });;
        }
    }
}
