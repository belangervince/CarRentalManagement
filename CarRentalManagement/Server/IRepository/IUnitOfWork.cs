using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Make> Makes { get; set; }
        //IGenericRepository<Model> Models { get; set; }
        //IGenericRepository<Vehicle> Vehicles { get; set; }
    }
}
