using AutomotrizApp.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizApp.dominio;
using ApiAutomotriz.Resultados;
using System;
using AutomotrizApp.Dominio;

namespace ApiAutomotriz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
        private IDataApi dataApi; //punto de acceso a la API

        private Resultado resultado;
        public VehiculoController()
        {
            dataApi = new DataApiImp();
            resultado = new Resultado();
        }

        [HttpGet("/Vehiculos")]
        public IActionResult GetVehiculos()
        {
            try
            {
                var listaVehiculos = dataApi.GetVehiculos();
                if (listaVehiculos != null)
                {
                    return Ok(listaVehiculos);
                }
                else
                {
                    resultado.SetError("Error al intentar consultar los Vehiculos");
                    resultado.StatusCode = 400;
                    return BadRequest(resultado);
                }
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }

        }

        [HttpGet("/Autopartes")]
        public IActionResult GetAutopartes()
        {
            try
            {
                var listaAutopartes = dataApi.GetAutoPartes();
                if (listaAutopartes != null)
                {
                    return Ok(listaAutopartes);
                }
                else
                {
                    resultado.SetError("Error al intentar consultar las Autopartes");
                    resultado.StatusCode = 400;
                    return BadRequest(resultado);
                }
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }

        }

       
        [HttpPost("/CrearVehiculo")]
        public IActionResult PostVehiculo(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo == null)
                {
                    return BadRequest("Ingresar Vehiculo");
                }

                return Ok(dataApi.PostVehiculo(vehiculo));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete("eliminarVehiculo")]
        public IActionResult DeleteVehiculo(int id)
        {
            try
            {
                if (id == 0)
                {
                    resultado.StatusCode = 400;
                    resultado.SetError("ID Vehiculo incorrecta");
                    return BadRequest(resultado);
                }
                else
                {
                    return Ok(dataApi.EliminarVehiculo(id));
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        //[HttpPost("UpdateVehiculo")]
        //public IActionResult EditarVehiculo(Vehiculo oVehiculo)
        //{
        //    try
        //    {
        //        if (oVehiculo != null)
        //        {
        //            return Ok(dataApi.EditarVehiculo(oVehiculo));
        //        }
        //        else
        //        {
        //            resultado.StatusCode = 400;
        //            resultado.Ok = false;
        //            resultado.SetError("Error al editar el Vehiculo");
        //            return BadRequest(resultado);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}

        [HttpPost("/ModificarVehiculo")]
        public IActionResult EditarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo != null)
                {
                    return Ok(dataApi.EditarVehiculo(vehiculo));
                }
                else
                {
                    resultado.StatusCode = 400;
                    resultado.Ok = false;
                    resultado.SetError("Error al editar el Vehiculo");
                    return BadRequest(resultado);
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpPost("/BajaVehiculo")]
        public IActionResult BajaVehiculo(int id)
        {
            try
            {
                if (id == 0)
                {
                    resultado.StatusCode = 400;
                    resultado.SetError("ID Vehiculo incorrecta");
                    return BadRequest(resultado);
                }
                else
                {

                    return Ok(dataApi.EliminarVehiculo(id));
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}