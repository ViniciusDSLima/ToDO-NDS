using System.Collections.ObjectModel;

namespace Domain.Entities;

public class User : DadosPadrao
{
    public int Id { get; set; }
    public string Nome { get; set; }    
    public string Email { get; set; }    
    public string Password { get; set; }


    public virtual Collection<Assignment> Assignments { get; set; } = new();
    public virtual Collection<AssingnmentList> AssignmentLists { get; set; } = new();
}