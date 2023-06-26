class UserModel
{
    private string name="";
    private int age;
    public string Name // Propiedad para almacenar el nombre del usuario
    { 
        set{name=value;}
        get{return name;}
    } 
    public int Age // Propiedad para almacenar la edad del usuario
    { 
        set{age=value;}
        get{return age;}
    } 
}
