using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class Herramientas
    {
        public bool ValidarUrl(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // Solo revisamos los headers para ver si es una imagen y no descargamos todo el contenido.

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Validar si la respuesta es válida (200 OK) y si es un tipo de imagen
                    if (response.StatusCode == HttpStatusCode.OK &&
                        response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
