namespace Domain.Entities;

public class Assignment : DadosPadrao
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public int AssignmentListId { get; set; }
    public bool Conclued { get; set; }
    public DateTime? ConcluedAt { get; set; }
    public DateTime? DeadLine { get; set; }
    
    
    //Quando for concluido a Task:
    public void setConclued()
    {
        Conclued = true;
        ConcluedAt = DateTime.Now;
    }
}