using API.Dtos;
using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class AutomovilController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AutomovilController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }


    [HttpPost("AddAutomovil")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Add(AutomovilDto automovild)
    {
        Automovil auto = _mapper.Map<Automovil>(automovild);

        if (auto == null)
        {
            return BadRequest();
        }

        _unitOfWork.Automoviles.Add(auto);
        int num = await _unitOfWork.SaveChanges();

        if(num == 0)
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(Add), new {id = auto.ID_Automovil},auto);
    }
}