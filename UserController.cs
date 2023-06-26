class UserController
{
    private UserModel? user; // Agregar el operador de anulabilidad "?" después de UserModel
    private UserView view;

    public UserController()
    {
        user = null;
        view = new UserView();
    }

    public void Start()
    {
        user = view.CreateUser(); // Crea un nuevo usuario solicitando los detalles a la vista
        view.DisplayUser(user); // Muestra la información del usuario en la vista
    }
}