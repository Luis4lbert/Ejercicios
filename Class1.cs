using System;

public class Password 
{
    int Longitud = 0; 
    int Longitud_def = 8;
    string contraseña;
	
    
    public int getlongitud(){
        return Longitud; 

    }

    public void setlongitud(int Longitud){
        this.Longitud=Longitud;

    }

    public string contraseña()
    {
        return contraseña;
    }

    string generarpass()
    {
        string pass="";

        for (int i=0; i<Longitud; i++)
        {
            int eleccion =((int)Math.Floor(Math.random()*3+1));

            if (eleccion == 1)
            {
                char minusculas = (char)((int)Math.Floor(Math.random() * (123 - 97) + 97));
                pass += minusculas;
            }
            else
                { if(eleccion == 2){
                    char mayusculas = (char)((int)Math.Floor(Math.random() * (91 - 65)+ 65));
                    pass += mayusculas;
                }
            else
            {
                char numeros = (char)((int)Math.Floor(Math.random() * (55 - 48) + 48));
                pass += numeros;

            }
                    
            }


        }
        return pass;
    }

    public boolean esfuerte()
    {
        int cuentanumeros =0;
        int cuentamayusculas = 0;
        int cuentaminusculas = 0;

        for (int i = 0; i < contraseña.leng(); i++)
        {
            if(contraseña.charArt(i)>=97 && contraseña.charArt(i)<=122){
                cuentaminusculas += 1;
            }
            else
            {
                if (contraseña.charArt(i) >= 65 && contraseña.charart(i) < 90)
                {
                    cuentamayusculas += 1;
                }
                else
                {
                    cuentanumeros += 1;
                }
            }
        }

        if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
             
       

    }
         public Password(){
             this(longitud_def);
         }

         public Password(int longitud)
         {
             this.longitud = longitud;
             contraseña = generarpass();
         }

         static void Main(string[] args)
         {
             Console.Write("Introduce el Tamaño del arreglo: ");
             String tam_array = Console.ReadLine();
             int tamanio = Int32.Parse(tam_array);

             Console.Write("Introduce la longitud del password");
             String lon_pass = Console.ReadLine();
             int longitud = Int32.Parse(lon_pass);

             Password lista_pass = new Password[tamanio];
             Boolean fortaleza_pass = new Boolean[tamanio];

             for (int i = 0; i < lista_pass.length; i++)
             {
                 lista_pass[i] = new Password(longitud);
                 fortaleza_pass[i] = lista_pass[i].esFuerte();
                 Console.Write("");
             }

         }
	
}
