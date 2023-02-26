using LearningCSharp;

Person me = new Person();
me.FirstName = "Matt";
me.LastName = "Milner";
// Ankit add a line here  me.Status = "lol";

Console.WriteLine("Hello from, {0} {1}, to you!", 
    me.FirstName, me.LastName);