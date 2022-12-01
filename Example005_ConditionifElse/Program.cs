 Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "рита")
 {
    Console.WriteLine("Привет, родная!");
 }
 else
 {
    Console.Write("Ну, заходи, ");
    Console.WriteLine(username);
 }