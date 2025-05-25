using application2.Models.Domain;
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
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            // Get all walks from the repository
            var walks = await walksRepository.GetAllAsync();
            // Map the domain models to DTOs
            var walkDTOs = mapper.Map<List<Models.Domain.Walk>>(walks);
            return Ok(walkDTOs);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            // Get the walk by ID from the repository
            var walk = await walksRepository.GetById(id);
            if (walk == null)
            {
                return NotFound();
            }
            // Map the domain model to a DTO
            var walkDTO = mapper.Map<Walk>(walk);
            return Ok(walkDTO);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] Models.DTO.UpdateWalkReqestDto updateWalkReqestDto)
        {
            // Validate the request
            if (updateWalkReqestDto == null)
            {
                return BadRequest("Invalid walk data.");
            }

            // Map the DTO to the domain model
            var Domainwalk = mapper.Map<Models.Domain.Walk>(updateWalkReqestDto);
            // Update the walk in the repository
            var updatedWalk = await walksRepository.UpdateAsync(id, Domainwalk);
            if (updatedWalk == null)
            {
                return NotFound();
            }
            // Map the updated walk back to a DTO
            var walkDTO = mapper.Map<Models.DTO.WalkDto>(updatedWalk);
            return Ok(walkDTO);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Delete the walk from the repository
            var deletedWalk = await walksRepository.DeleteAsync(id);
            if (deletedWalk == null)
            {
                return NotFound();
            }
            // Return a success response
            return Ok(deletedWalk);
        }
    }
}
