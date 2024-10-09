using Docker.API.Data;
using Docker.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Docker.API.Controllers;
[ApiController]
[Route("/")]
public class WeatherForecastController : ControllerBase
{
	protected readonly AppDbContext _context;

	public WeatherForecastController(AppDbContext context)
	{
		_context = context;
	}

	[HttpPost]
	[HttpPost]
	public async Task<IActionResult> Post([FromBody] Users request)
	{
		_context.Users.Add(request);
		await _context.SaveChangesAsync();
		return Ok(request);
	}


	[HttpGet]
	public async Task<IActionResult> Get()
	{
		var users = await _context.Users.AsNoTracking().ToListAsync();
		return Ok(users);
	}
}
