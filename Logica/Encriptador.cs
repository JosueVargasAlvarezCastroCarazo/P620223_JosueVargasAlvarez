using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P620223_JosueVargasAlvarez
{
    public class Encriptador
    {
        //Esta clase contiene los métodos necesarios para encriptar
        //no solo contraseñas sino cualquier dato importante
        //TODO: utilizar estas funciona para encriptar la cadena de conexión 

        string LlavePersonalizada = "Progra5/kajhsdkjh672716762";

        public string DesEncriptarPassword(string Pass)
        {
            String R = string.Empty;

            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    Byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(LlavePersonalizada));

                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;

                    Byte[] data = Convert.FromBase64String(Pass);

                    R = Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));

                }
            }

            return R;

        }

        public string EncriptarPassword(string Pass)
        {
            String R = string.Empty;

            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    Byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(LlavePersonalizada));

                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;

                    Byte[] data = Encoding.UTF8.GetBytes(Pass);

                    R = Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));

                }
            }

            return R;

        }

        public string EncriptarEnUnSentido(string Entrada)
        {

            if (String.IsNullOrEmpty(Entrada))
            {
                return Entrada;
            }

            string PorEncriptar = EncriptarPassword(Entrada);

            PorEncriptar += "PalabraClave";

            SHA512CryptoServiceProvider ProveedorCrypto = new SHA512CryptoServiceProvider();

            //Descompone la cadenaDeEntrada en Bytes
            byte[] BytesDeEntrada = Encoding.UTF8.GetBytes(PorEncriptar);

            //Usando los bytes de la cadena de entrada crea el Hash
            byte[] BytesConHash = ProveedorCrypto.ComputeHash(BytesDeEntrada);

            StringBuilder Resultado = new StringBuilder();

            //el for recorre cada byte del Hash y lo agrega a una cadena (stringbuilder)
            for (int i = 0; i < BytesConHash.Length; i++)
                Resultado.Append(BytesConHash[i].ToString("x2").ToLower());
            // el x2 lo que hace es poner los caracteres hexadecimales con cierto formato.

            return Resultado.ToString();

        }


    }
}
