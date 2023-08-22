using API.Dtos;
using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class SucursalController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public SucursalController(IUnitOfWork unitOfWork, IMapper   mapper)
    {
        _unitOfWork = unitOfWork;
        this._mapper = mapper;
    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Add(SucursalDto entity)
    {

        Sucursal sucursal = _mapper.Map<Sucursal>(entity);
        if(sucursal == null)
        {
            return BadRequest();
        }

        _unitOfWork.Sucursales.Add(sucursal);
    int num = await _unitOfWork.SaveChanges();

    if(num == 0)
    {
        return BadRequest();
    }
    
    return CreatedAtAction(nameof(Add), new {id = sucursal.ID_Sucursal},sucursal);

    }
    [HttpPost("AddRangeSucuursal")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]


    public async  Task<ActionResult> AddRange(SucursalDto[] entities)
    {
        Sucursal[] suc = _mapper.Map<Sucursal[]>(entities);

        if (suc.Length == 0 )
        {
            return  BadRequest();
        }


        _unitOfWork.Sucursales.AddRange(suc);
        int num = await _unitOfWork.SaveChanges();


        if(num == 0)
        {
            return BadRequest();
        }

        foreach(var entity in suc )
        {
            CreatedAtAction(nameof(AddRange),new {id = entity.ID_Sucursal},entity);
        }

        return Ok();

    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]


    public async Task<ActionResult<SucursalDto>> GetById(int id)
    {   
        int numericValue;
        if(! int.TryParse(id.ToString(), out numericValue))
        {
            return BadRequest("El id dado no es valido, verifique que exista o que sea entero");
        }

        var sucursal = await _unitOfWork.Sucursales.GetById(id);
       SucursalDto suc   =_mapper.Map<SucursalDto>(sucursal);

        return suc;
    }
    [HttpGet("GetAllSucursales")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<SucursalDto>> GetAll()
    {
         IEnumerable<Sucursal> suc  = await _unitOfWork.Sucursales.GetAll();
        return _mapper.Map<SucursalDto[]>(suc);
         
    }

    [HttpDelete("RemoveSucursal{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Delete(int id)
    {
         Sucursal suc = await _unitOfWork.Sucursales.GetById(id);
          _unitOfWork.Sucursales.Remove(suc);
          int num = await _unitOfWork.SaveChanges();

          if (num == 0 )
          {
            return BadRequest();
          }

          return NoContent();
    }

    [HttpPut("PutSucursal{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<SucursalDto>> Update(int id, [FromBody]SucursalDto sucursal)
    {       
            Sucursal  suc = _mapper.Map<Sucursal>(sucursal); 
         _unitOfWork.Sucursales.Update(suc);
         int num = await _unitOfWork.SaveChanges();

         if(num == 0 )
         {
            return BadRequest();
         }
         return sucursal ;
    }


    



}