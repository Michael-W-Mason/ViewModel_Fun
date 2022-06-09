#pragma warning disable CS8618
namespace ViewModel_Fun.Models;
public class User{
    public string FirstName {get;set;}
    public string LastName {get;set;}

    public User(string first, string last){
        FirstName = first;
        LastName = last;
    }
}