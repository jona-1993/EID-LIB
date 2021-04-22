using System;
using System.Text;
using EIDLib;

namespace TestEID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test de lecture de données

            ReadData data = new ReadData();

            //data.GetAndTestIdFile();

            var test = data.GetDateOfBirth();


            var test2 = data.GetSurname();


            // Test de signature électronique

            /*Integrity integrity = new Integrity();
            Sign signer = new Sign();

            string ASigner = "Hello World";

            var signed = signer.DoSign(Encoding.ASCII.GetBytes(ASigner), "Signature");

            var verif = integrity.Verify(Encoding.ASCII.GetBytes(ASigner), signed, data.GetCertificateSignatureFile());*/

            Console.ReadLine();
        }
    }
}
