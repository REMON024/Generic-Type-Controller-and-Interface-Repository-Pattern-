using Generic_Contrller.IService;
using Generic_Contrller.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Contrller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : GenericController<Student>
    {
        public StudentsController(IGenericService<Student> genericService):base(genericService)
        {

        }
    }
}
