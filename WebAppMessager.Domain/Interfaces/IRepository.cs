using WebAppMessager.Business.Models;

namespace WebAppMessager.Business.Interfaces {
    public interface IRepository<T> where T : Entity { 
        virtual int Count { get => 0; }
    }
}
