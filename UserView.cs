class UserView
{
     public void DisplayUser(UserModel user)
    {
        Console.WriteLine("User Information:");
        Console.WriteLine($"Name: {user.Name}"); // Muestra el nombre del usuario
        Console.WriteLine($"Age: {user.Age}"); // Muestra la edad del usuario
    }

    public UserModel CreateUser()
    {
        Console.WriteLine("Enter user details:");
        Console.Write("Name: ");
        var name = Console.ReadLine(); // Lee el nombre ingresado por el usuario
        Console.Write("Age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age)) // Lee la edad ingresada por el usuario, valida que sea un número válido
        {
            Console.WriteLine("Invalid age. Please enter a valid number.");
        }

       return new UserModel
{
    Name = name ?? string.Empty, // Si name es null, asigna una cadena vacía
    Age = age
};
    }
}