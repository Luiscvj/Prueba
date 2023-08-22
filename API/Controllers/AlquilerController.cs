using API.Dtos;
using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class AlquilerController :BaseApiController
{
    protected readonly IUnitOfWork _unitOfWork;
    private readonly IMapper mapper;

    public AlquilerController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        this.mapper = mapper;
    }


[HttpPost("AddAlquiler")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Add(AlquilerDto entityd)
    {   
        Alquiler alquiler =  mapper.Map<Alquiler>(entityd);
        if(alquiler == null)
        {
            return BadRequest();
        }
        
        _unitOfWork.Alquileres.Add(alquiler);
       int num =await  _unitOfWork.SaveChanges();

       if(num == 0)
       {
            return BadRequest();
       }

       return CreatedAtAction(nameof(Add),new {id = alquiler.ID_Alquiler},alquiler);

    }
}