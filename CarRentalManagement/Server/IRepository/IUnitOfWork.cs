using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; set; }
        IGenericRepository<Vehicle> Vehicles { get; set; }
        IGenericRepository<Colour> Colours { get; set; }
        IGenericRepository<Booking> Bookings { get; set; }
        IGenericRepository<Customer> Customers { get; set; }
    }
}
