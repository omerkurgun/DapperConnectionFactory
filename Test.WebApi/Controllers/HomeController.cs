using DapperFactory.Application.Interfaces;
using DapperFactory.Domain.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDapperFactory _mysqlFactory;
        private readonly IDapperFactory _postgreSQLFactory;
        private readonly IDapperMethods _dapperMethods;

        public HomeController(IEnumerable<IDapperFactory> dbFactory, IDapperMethods dapperMethods, ILogger<HomeController> logger)
        {
            _logger = logger;
            _mysqlFactory = dbFactory.First(x => x._dbType == DBType.MySQL && x._connName == "AnaMakine");
            _postgreSQLFactory = dbFactory.First(x => x._dbType == DBType.PostgreSQL && x._connName == "AnaMakine");
            _dapperMethods = dapperMethods;
        }

        public IActionResult Index()
        {
            _dapperMethods.SetConnection(_mysqlFactory.GetConnection());

            var mysqlResult = _dapperMethods.Query<string>("SELECT TCKN FROM MUSTERILER");

            _dapperMethods.SetConnection(_postgreSQLFactory.GetConnection());

            var postgreSqlResult = _dapperMethods.Query<string>("SELECT TCKN FROM MUSTERILER");

            return View();
        }

    }
}
