using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Docker.API.Models;

public class Users
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	[JsonIgnore]
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
}
