
using Constructor_Inheritance_Classwork;
using System;
using System.Data;

//Person person = new()
//{
//    id = 1,
//    fullName = "Fatime  ",
//    age = 22,
//    position = "Student"
//};


//Person person = new(1, "Hacixan Hacixanov", 22, "Student");

//Console.WriteLine(person.fullName);


//Person person1 = new Person("Azerbaycan");

//Person person1 = new Person("Azerbaycan", "Turkiye");

//Person person1 = new()
//{
//    id = 1,
//    fullName = "Ilqar Shiriyev",
//    age = 26
//};

//Person person2 = new()
//{
//    id = 2,
//    fullName = "Reshad Agayev",
//    age = 26
//};

//Person person3 = new()
//{
//    id = 3,
//    fullName = "Nurlan Umudov",
//    age = 26
//};

//Person person4 = new()
//{
//    id = 4,
//    fullName = "Elmir Qafarzade",
//    age = 26
//};


//Person[] people = { person1, person2, person3, person4 };

//Person FindPersonById(Person[] people, int id)
//{
//    Person person = people.FirstOrDefault(m => m.id == id);
//    return person;
//}


//Person result = FindPersonById(people, 1);

//Person result = FindPersonById(people, 100);
//Console.WriteLine(result);

//Person[] GetAllPerson(Person[] datas)
//{
//    return datas;
//}


//var allPeople = GetAllPerson(people);

//string response = $"Id: {result.id} Fullname: {result.fullName} Age: {result.age}";

//Console.WriteLine(response); 

//var result1 = result != null ? response : "notfound";

//var result2 = result != null ? $"Id: {result.id} Fullname: {result.fullName} Age: {result.age}" : "notfound";

//Console.WriteLine(result2);

//if (result != null)
//{

//    Console.WriteLine(response);
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}

//if (result != null)
//{
//    string response = $"Id: {result.id} Fullname: {result.fullName} Age: {result.age}";

//    Console.WriteLine(response);
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}

//ShowPersonById(result);

//ShowAllPeople(allPeople);


Person[] GetAllPerson()
{
    Person person1 = new()
    {
        id = 1,
        fullName = "Behruz Shiriyev",
        age = 26
    };

    Person person2 = new()
    {
        id = 2,
        fullName = "Behruz Agayev",
        age = 26
    };

    Person person3 = new()
    {
        id = 3,
        fullName = "Nurlan Umudov",
        age = 26
    };

    Person person4 = new()
    {
        id = 4,
        fullName = "Behruz Agayev",
        age = 26
    };


    Person[] people = { person1, person2, person3, person4 };

    return people;
}

void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id: {item.id} Fullname: {item.fullName} Age: {item.age}";
        Console.WriteLine(response);
    }
}


//ShowAllPeople(GetAllPerson());

//var result = GetAllPerson();

//ShowAllPeople(result);


Person FindPersonById(Person[] people, int id)
{
    return people.FirstOrDefault(m => m.id == id);
}

void ShowPerson(Person person)
{
    if (person != null)
    {
        string response = $"Id: {person.id} Fullname: {person.fullName} Age: {person.age}";

        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data notfound");
    }
}

//var result = FindPersonById(GetAllPerson(), 1);

//ShowPerson(FindPersonById(GetAllPerson(),2));


Person[] GetPeopleByName(Person[] people, string name)
{
    return people.Where(m => m.fullName == name).ToArray();
}

void ShowPeopleByName(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id: {item.id} Fullname: {item.fullName} Age: {item.age}";
        Console.WriteLine(response);
    }
}

//ShowPeopleByName(GetPeopleByName(GetAllPerson(), "Behruz Agayev"));














//Animal animal = new();

//animal.id = 5;
//animal.name = "Qartal";

//Console.WriteLine(animal.name);


//Bird bird = new()
//{
//    id = 1,
//    name = "Qaranqush",
//    age = 10
//};

//Console.WriteLine(bird.name);

//bird.Sound();


//Fish fish = new();

//Animal animal = new Animal("salam");
