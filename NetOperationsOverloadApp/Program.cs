using NetOperationsOverloadApp;

Fraction f1 = new();
f1 = 12.5;
Console.WriteLine(f1);

Money m1 = new(25, 50);
f1 = (Fraction)m1;
Console.WriteLine(f1);

Group group = new Group(3);
group["Title"] = "PV211";
group[0] = new Student() { Name = "Bob", Age = 23 };
group[1] = new Student() { Name = "Joe", Age = 35 };
group[2] = new Student() { Name = "Tom", Age = 19 };

Student bob = group[0];
bob["Name"] = "Bobby";
bob["Email"] = "bob@gmail.com";
bob["Age"] = "25";


for(int i = 0; i < group.Count; i++)
    Console.WriteLine(group[i]);