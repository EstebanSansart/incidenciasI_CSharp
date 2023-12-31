using System.ComponentModel.DataAnnotations;

namespace ApiIncidenciasI.Dtos;
public class UserDataDto
{
    public string Mensaje { get; set; }
    public bool EstaAutenticado { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    //public List<string> Roles { get; set; }
    public string Token { get; set; }
}