using API.Dtos;
using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class Sucursal_AutomovilController :BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public Sucursal_AutomovilController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }
    [HttpPost("AddSucursalAutomovil")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Add(Sucursal_AutomovilDto entity)
    {
        Sucursal_Automovil suc_aut = _mapper.Map<Sucursal_Automovil>(entity);
        if (suc_aut == null)
        {
            return BadRequest();
        }

        _unitOfWork.Sucursal_Automoviles.Add(suc_aut);
        int num = await _unitOfWork.SaveChanges();

        if (num == 0)
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(Add), new {id = suc_aut.ID_Automovil,suc_aut.ID_Sucursal},suc_aut);

    }
}