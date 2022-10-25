namespace PageContacts.Data;


public class ContactData
{
    private List<string> Nombre = new List<string>(){
        
    };

    private List<string> Correo = new List<string>(){
        
    };

    private List<string> Mensaje = new List<string>(){
        
    };
    
    

    public List<Contact> getContacts ()
    {
        List<Contact> ListContacts = new ();
        Random random = new Random();
        for(var i = 0; i < 3; i++) {
            Contact contacto = new Contact {
                    Nombre = this.Nombre[i],
                    Correo = this.Correo[i],
                    Telefono = random.Next(100),
                    Mensaje = this.Mensaje[i]
                    
            };
            ListContacts.Add(contacto);
        }

        return ListContacts;
    }
}