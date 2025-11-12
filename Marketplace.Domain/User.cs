using System.ComponentModel.DataAnnotations;


public class User
{
    public User(string username, string password)
    {
        Username = username;
        Password = password;
        Balance = 0.0;
    }

    [Key]
    public int UserId { get; set; }
    public string Username { set; get; }
    public string Password { set; get; }
    public double Balance { set; get; }
    

    public List<Item> Items { get; set; } = new List<Item>();
    

}