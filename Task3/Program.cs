
var Post1 = new Post();
Post1.Title = "In behtarin ast";
Post1.Description = "Man kushish kardam";
Post1.Like();
Post1.Comments.Add("salom");


var Post2 = new Post();
Post2.Title = "In bad ast";
Post2.Description = "Man kushish nakardam";
Post2.Like();
Post2.Like();
Post2.Comments.Add("Behtarin");




var Post3 = new Post();
Post3.Title = "In behtarin nest";
Post3.Description = "Man kushish karda budam";
Post3.Like();
Post3.Like();
Post3.Like();
Post3.Comments.Add("Mo bo shumo hastem");



var Post4 = new Post();
Post4.Title = "In behtarin ast";
Post4.Description = "Man kushish kardam";
Post4.Like();
Post4.Like();
Post4.Like();
Post4.Like();
Post4.Comments.Add("Ofarin");



var Post5 = new Post();
Post5.Title = "In behtarin ast";
Post5.Description = "Man kushish kardam";
Post5.Like();
Post5.Like();
Post5.Like();
Post5.Like();
Post5.Like();
Post5.Comments.Add( "Ofarin");

var posts = new List<Post>();
posts.Add(Post1);
posts.Add(Post2);
posts.Add(Post3);
posts.Add(Post4);
posts.Add(Post5);

foreach (var item in posts)
{
    System.Console.WriteLine($"{item.Title}\n{item.Description}\nnumber of Likes: {item.LikeCount}");
    foreach (var item1 in item.Comments)
    {
        System.Console.WriteLine(item1);
    }
    System.Console.WriteLine("**********************************");
}





