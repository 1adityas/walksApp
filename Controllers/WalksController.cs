using application2.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace application2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalksController : ControllerBase
    {
        private readonly IWalksRepository walksRepository;
        private readonly IMapper mapper;

        public WalksController(IWalksRepository walksRepository, IMapper mapper)
        {
            this.walksRepository = walksRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Models.DTO.AddWalkRequest addWalkRequest)
        {
            // Validate the request
            if (addWalkRequest == null)
            {
                return BadRequest("Invalid walk data.");
            }
            // Map the DTO to the domain model
            var walk = mapper.Map<Models.Domain.Walk>(addWalkRequest);

            // Add the walk to the database
            await walksRepository.CreateAsync(walk);
            // Map the added walk back to the DTO


            return Ok(walk);


        }
    }
}
