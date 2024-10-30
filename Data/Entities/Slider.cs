using System.ComponentModel.DataAnnotations;

public class Slider
{
    [Key]
    public int Id { get; set; }
    public string nameslider{ get; set; }
    public bool active { get; set; }

}