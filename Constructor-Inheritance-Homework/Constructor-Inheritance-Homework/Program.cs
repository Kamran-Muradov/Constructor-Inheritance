
using Constructor_Inheritance_Homework;

CustomMath customMath = new();

//1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.

//var result = customMath.SumOfOddNumsInArray(new int[] {1,2,3,4,5});

//Console.WriteLine(result);



//2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.

//var result = customMath.FindEvenOrOddNum(5);

//Console.WriteLine(result);



//3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

//var result = customMath.SquareOfSumOfEvenNums(new int[] { 1, 2, 3, 4, 5, 6 });

//Console.WriteLine(result);



//4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

//var result = customMath.ProductInInterval(5);

//Console.WriteLine(result);










//Employee adinda class yaradin, Class-in id, name, surname, address, email, age fieldleri olacaq.
//Proqram.cs - de ashagidaki methodlari yazin. 



Employee employee1 = new()
{
    id = 1,
    name = "Kamran",
    surname = "Muradov",
    age = 24,
    email = "kamranmuradov5@gmail.com",
    address = "Sumqayit"
};

Employee employee2 = new()
{
    id = 2,
    name = "Kamran2",
    surname = "Muradov2",
    age = 27,
    email = "test@gmail.com2",
    address = "Sumqayit2"
};

Employee employee3 = new()
{
    id = 3,
    name = "Kamran3",
    surname = "Muradov3",
    age = 46,
    email = "test@gmail.com3",
    address = "Sumqayit3"
};

Employee employee4 = new()
{
    id = 4,
    name = "Kamran4",
    surname = "Muradov4",
    age = 57,
    email = "test@gmail.com4",
    address = "Sumqayit4"
};

Employee[] employees = { employee1, employee2, employee3, employee4 };


//1) Yashi methoda parametr kimi gelen yashdan boyuk olan employee - lerin  siyahisini qaytaran method.

Employee[] GetAllOlderEmployees(Employee[] datas, int age)
{
    return datas.Where(m => m.age > age).ToArray();
}

//var result = GetAllOlderEmployees(employees, 30);

//foreach (var item in result)
//{
//    Console.WriteLine($" Id: {item.id} Name: {item.name} Surname: {item.surname} Age: {item.age} Email: {item.email} Address: {item.address}");
//}



// 2) Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.

int CountOfEmployeesInAgeInterval(Employee[] datas)
{
    return datas.Count(m => m.age >= 20 && m.age <= 30);
}

var result = CountOfEmployeesInAgeInterval(employees);

Console.WriteLine(result);



//3) Butun Emloyeelerin yashlarinin cemini qaytaran method.

int SumOfEmployeeAges(Employee[] datas)
{
    return datas.Sum(m => m.age);
}

//var result = SumOfEmployeeAges(employees);

//Console.WriteLine(result);



// 4) Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

Employee[] GetAllEmployessWithSameStartingEmail(Employee[] datas, string word)
{
    return datas.Where(m => m.email.StartsWith(word)).ToArray();
}

//var result = GetAllEmployessWithSameStartingEmail(employees, "test");

//foreach (var item in result)
//{
//    Console.WriteLine($" Id: {item.id} Name: {item.name} Surname: {item.surname} Age: {item.age} Email: {item.email} Address: {item.address}");
//}