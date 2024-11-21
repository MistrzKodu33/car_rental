using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class TestController : _MyApiController
    {
        public string Index()
        {
            return "Test api";
        }
    }
}
