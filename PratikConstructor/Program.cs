using PratikConstructor;

Bebek bebek1 = new Bebek();
Console.WriteLine($"Bebeğin adı {bebek1.name}, Bebeğin soyadı {bebek1.surname}, Bebeğin doğum tarihi {bebek1.birthDate}");

//parametre gönderiliyor
Bebek bebek2 = new Bebek("Rick","Grimes");
Console.WriteLine($"Bebeğin adı {bebek2.name}, Bebeğin soyadı {bebek2.surname}, Bebeğin doğum tarihi {bebek2.birthDate}");