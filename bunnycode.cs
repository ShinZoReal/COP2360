using System;

public class Bunny
{
  public string Name;
  public bool LikesCarrots;
  public bool LikesHumans;
  
  public Bunny () {}
  public Bunny (string n) { Name = n; }
}

public class Program
{
    public static void Main()
    {
        Bunny a = new Bunny("Chonk")
        {
            LikesCarrots = true,
            LikesHumans = true
        };

        Bunny b = new Bunny("Hazel")
        {
            LikesCarrots = false,
            LikesHumans = false
        };

        Console.WriteLine($"{a.Name} - Likes Carrots: {a.LikesCarrots}, Likes Humans: {a.LikesHumans}");
        Console.WriteLine($"{b.Name} - Likes Carrots: {b.LikesCarrots}, Likes Humans: {b.LikesHumans}");
    }
}
