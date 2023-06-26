internal class Program
{
    private static void Main(string[] args)
    {
        var controller = new UserController();
        controller.Start(); // Inicia el controlador, que a su vez inicia la interacción con el usuario
    }
}