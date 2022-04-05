using System.ComponentModel.DataAnnotations;

namespace gregslist_sharp.models
{
  public class Car
  {


    public string Id { get; set; }
    [Required]
    public string Make { get; set; }


    [Required]
    public string Model { get; set; }
    [Required]
    public int? Year { get; set; }
    [Required]
    public string Color { get; set; }


    public Car(string make, string model, int? year, string color)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Color = color;
    }



  }
}