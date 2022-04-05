using gregslist_sharp.models;

namespace gregslist_sharp.DB;

public static class FakeDb
{
  public static List<Car> Cars { get; set; } = new List<Car>() {
    new Car("Honda", "Accord", 1997, "Green"),
    new Car("Ford", "F-150", 2005, "Black"),
    new Car("Jeep", "Cherokee", 2010, "Red"),
    new Car("Toyota", "Solara", 2001, "Silver")
  };
}
