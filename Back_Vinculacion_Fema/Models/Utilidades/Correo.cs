using System.Net;
using System.Net.Mail;

class Correo
{
    static string GenerarContraseña()
    {
        Random random = new Random();

        // Primer caracter: letra mayúscula
        char primerCaracter = (char)random.Next('A', 'Z' + 1);

        // Caracteres 2 a 5: letras aleatorias
        char[] letrasAleatorias = new char[4];
        for (int i = 0; i < letrasAleatorias.Length; i++)
        {
            letrasAleatorias[i] = (char)random.Next('A', 'Z' + 1);
        }

        // Último caracter: número
        int ultimoCaracter = random.Next(0, 10);

        // Combinar todos los caracteres
        string contraseña = string.Format("{0}{1}{2}{3}{4}{5}",
                                         primerCaracter,
                                         letrasAleatorias[0],
                                         letrasAleatorias[1],
                                         letrasAleatorias[2],
                                         letrasAleatorias[3],
                                         ultimoCaracter);
            
        return contraseña;
    }

    public static void  sendEmail()
    {
    
        using SmtpClient email = new SmtpClient
        {
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            EnableSsl = true,
            Host = "smtp.gmail.com",
            Port = 587,
            Credentials = new NetworkCredential(GetUserName(), GetPassword())
        };
        //Invocacion del metodo generador de clave
        String nuevaClave = GenerarContraseña();
        string subject = "Recuperación de contraseña";
        string body = "Has solicitado la recuperación de tu contraseña para el acceso a la aplicación FEMA<b>" +
            "Tu nueva contraseña es: " + nuevaClave;

        try
        {
            email.Send(GetUserName(), ToAddress(), subject, body);
        }
        catch(SmtpException e)
        {
            Console.WriteLine(e);
        }
        //ENVIAR post a la BD 
    }

    private static String GetUserName()
    {
        return "luisperezfema@gmail.com";
    }

    private static String GetPassword()
    {
        return "Sergiodefjam18";
    }

    private static String ToAddress() //PARAMETRO CORREO DEL USUARIO
    {
        return "sergiorobles951@gmail.com";
    }
}