using System.Collections.ObjectModel;

namespace Domain.Entities;

public class AssingnmentList : DadosPadrao
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    
    public virtual User user { get; set; }
    public virtual Collection<Assignment> Assignments { get; set; }
}