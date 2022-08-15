using SomeAnimals;
using System;

Animals[] arr = new Animals[5];

arr[0] = new Cat();
arr[0].name = "Sishko";
arr[0].age = 4;
arr[0].gender = "male";

arr[1] = new Dog();
arr[1].name = "Jonny";
arr[1].gender = "male";
arr[1].age = 5;

arr[2] = new Pigeon();
arr[2].age = 3;
arr[2].name = "Desi";
arr[2].gender = "female";

foreach(var item in arr)
{
    Console.WriteLine(item.gender + item.name + item.age);
    item.GetSound();
    }

