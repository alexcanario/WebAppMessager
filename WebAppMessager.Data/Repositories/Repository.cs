using Microsoft.Extensions.Configuration;

using WebAppMessager.Business.Interfaces;
using WebAppMessager.Business.Models;

namespace WebAppMessager.Data.Repositories {
    public abstract class Repository<T> : IRepository<T> where T : Entity {
        protected readonly string ConnectionString;

        protected Repository(IConfiguration configuration) {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected virtual int Count => 0;
    }
}
