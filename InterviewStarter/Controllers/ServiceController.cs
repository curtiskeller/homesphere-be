using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InterviewStarterControllers
{
    public abstract class ServiceController<T, TFactory> : Controller 
        where T : IIdentifiable
        where TFactory : Repository<T>
    {
        protected readonly TFactory factory;

    }
}
