using Microsoft.AspNetCore.Mvc;
using Operations.Models;
using System.Diagnostics;

namespace Operations.Controllers
{
    public class HomeController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        //private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public HomeController(OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation
            //,
            //IOperationSingletonInstance singletonInstanceOperation
            )
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            //_singletonInstanceOperation = singletonInstanceOperation;
        }

        public IActionResult Index()
        {
            // ViewBag contains controller-requested services
            ViewBag.Transient = _transientOperation;
            ViewBag.Scoped = _scopedOperation;
            ViewBag.Singleton = _singletonOperation;
            //ViewBag.SingletonInstance = _singletonInstanceOperation;

            // Operation service has its own requested services
            ViewBag.Service = _operationService;
            return View();
        }
    }

    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    //public interface IOperationSingletonInstance : IOperation
    //{
    //}

    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton//, IOperationSingletonInstance
    {

        int a { get; set; }
        Guid _guid;
        public Operation() : this(Guid.NewGuid())
        {

        }

        public Operation(Guid guid)
        {
            _guid = guid;
            a = 10;
        }

        public Guid OperationId => _guid;
    }

    public class OperationService
    {
        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }
        //public IOperationSingletonInstance SingletonInstanceOperation { get; }

        public OperationService(IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation//,
            //IOperationSingletonInstance instanceOperation
            )
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            //SingletonInstanceOperation = instanceOperation;
        }
    }
}
