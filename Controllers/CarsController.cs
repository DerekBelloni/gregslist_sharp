using Microsoft.AspNetCore.Mvc;
using gregslist_sharp.models;
using gregslist_sharp.Services;

namespace gregslist_sharp.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _cs;

  public CarsController(CarsService cs)
  {
    _cs = cs;
  }

  [HttpGet]
  public ActionResult<List<Car>> Get()
  {
    try
    {
      List<Car> cars = _cs.GetAll();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Car> GetById(string id)
  {
    try
    {
      Car car = _cs.GetById(id);
      return car;
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Car> Create([FromBody] Car newCar)
  {
    try
    {
      Car car = _cs.Create(newCar);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Car> Update(string id, [FromBody] Car updates)
  {
    try
    {
      updates.Id = id;
      Car updated = _cs.Update(updates);
      return Ok(updated);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]

  public ActionResult<Car> Delete(string id)
  {
    try
    {
      _cs.Delete(id);
      return Ok("Deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}