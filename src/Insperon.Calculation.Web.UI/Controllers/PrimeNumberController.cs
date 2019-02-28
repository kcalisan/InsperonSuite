using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insperon.Calculation.Core.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Insperon.Calculation.Web.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberIndexSearchService primeNumberIndexSearchService;
        private readonly IPrimeNumberRepository primeNumberRepository;

        public PrimeNumberController(
            IPrimeNumberIndexSearchService primeNumberIndesearchService, 
            IPrimeNumberRepository primeNumberRepository)
        {
            this.primeNumberIndexSearchService = primeNumberIndesearchService;
            this.primeNumberRepository = primeNumberRepository;
        }

        // GET: api/PrimeNumber/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            long primeNumber = this.primeNumberIndexSearchService.GetPrimeNumberByIndex(id);
            return primeNumber.ToString();
        }
    }
}
