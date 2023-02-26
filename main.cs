using LearningCSharp;

Person me = new Person();
me.FirstName = "Matt";
me.LastName = "Milner";

Console.WriteLine("Hello from, {0} {1}, to you!", 
    me.FirstName, me.LastName);