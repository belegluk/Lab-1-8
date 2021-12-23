using System;
using System.IO;
using System.Security.Cryptography;

namespace Aes_Example
{
    class AesExample
    {
        public static void Main()
        {            
            byte[] original = File.ReadAllBytes(@"D:\kpi\navrotskyi\LAB_08_Olshewski\LAB_08_Olshewski\original");           
            //string FileName = "3DES_CText.enc";
            // Create a new instance of the Aes
            // class.  This generates a new key and initialization
            // vector (IV).
            using (Aes myAes = Aes.Create())
            {
                // Encrypt the string to an array of bytes.
                //byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
                byte[] encrypted = AESEncryptBytes(original, myAes.Key, myAes.IV);
                File.WriteAllBytes(@"D:\kpi\navrotskyi\LAB_08_Olshewski\LAB_08_Olshewski\encrypted", encrypted);

                // Decrypt the bytes to a string.
                //string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);
                byte[] roundtrip = AESDecryptBytes(encrypted, myAes.Key, myAes.IV);
                //Display the original data and the decrypted data.
                Console.WriteLine("AES");
                Console.WriteLine("Original:   {0}", Convert.ToBase64String(original));
                Console.WriteLine("encrypted:   {0}", Convert.ToBase64String(encrypted)); 
                Console.WriteLine("Round Trip: {0}", Convert.ToBase64String(roundtrip));
                //Console.ReadLine();
            }

            try
            {
                // Create a new TripleDES object to generate a key
                // and an initialization vector (IV).
                using (TripleDES TripleDESalg = TripleDES.Create())
                {
                    // Encrypt text to a file using the file name, key, and IV.
                    //EncryptTextToFile(original, FileName, TripleDESalg.Key, TripleDESalg.IV);
                    byte[] TDES_o = TDESEncryptBytes(original, TripleDESalg.Key, TripleDESalg.IV);
                    // Decrypt the text from a file using the file name, key, and IV.
                    byte[] TDES_d = TDESDecryptBytes(TDES_o, TripleDESalg.Key, TripleDESalg.IV);

                    // Display the decrypted string to the console.
                    Console.WriteLine("TripleDES");
                    Console.WriteLine("Original:   {0}", Convert.ToBase64String(original));
                    Console.WriteLine("encrypted:   {0}", Convert.ToBase64String(TDES_o));
                    Console.WriteLine("Round Trip: {0}", Convert.ToBase64String(TDES_d));
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);                            
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
        public static void EncryptTextToFile(String Data, String FileName, byte[] Key, byte[] IV)
        {
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                {

                    // Create a new TripleDES object.
                    using (TripleDES tripleDESalg = TripleDES.Create())
                    {

                        // Create a CryptoStream using the FileStream
                        // and the passed key and initialization vector (IV).
                        using (CryptoStream cStream = new CryptoStream(fStream,
                            tripleDESalg.CreateEncryptor(Key, IV),
                            CryptoStreamMode.Write))
                        {

                            // Create a StreamWriter using the CryptoStream.
                            using (StreamWriter sWriter = new StreamWriter(cStream))
                            {

                                // Write the data to the stream
                                // to encrypt it.
                                sWriter.WriteLine(Data);
                            }
                        }
                    }
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file access error occurred: {0}", e.Message);
            }
        }

        public static string DecryptTextFromFile(String FileName, byte[] Key, byte[] IV)
        {
            try
            {
                string retVal = "";
                // Create or open the specified file.
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                {

                    // Create a new TripleDES object.
                    using (TripleDES tripleDESalg = TripleDES.Create())
                    {

                        // Create a CryptoStream using the FileStream
                        // and the passed key and initialization vector (IV).
                        using (CryptoStream cStream = new CryptoStream(fStream, tripleDESalg.CreateDecryptor(Key, IV), CryptoStreamMode.Read))
                        {

                            // Create a StreamReader using the CryptoStream.
                            using (StreamReader sReader = new StreamReader(cStream))
                            {

                                // Read the data from the stream
                                // to decrypt it.
                                retVal = sReader.ReadLine();
                            }
                        }
                    }
                }
                // Return the string.
                return retVal;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file access error occurred: {0}", e.Message);
                return null;
            }
        }

        public static byte[] AESEncryptBytes(byte[] clearBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] encryptedBytes = null;

            // create a key from the password and salt, use 32K iterations – see note
            //var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            // create an AES object
            using (Aes aes = new AesManaged())
            {
                aes.Key = passBytes;
                aes.IV = saltBytes;
                //// set the key size to 256
                //aes.KeySize = 256;
                //aes.Key = key.GetBytes(aes.KeySize / 8);
                //aes.IV = key.GetBytes(aes.BlockSize / 8);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(),
          CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public static byte[] TDESEncryptBytes(byte[] clearBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] encryptedBytes = null;

            // create a key from the password and salt, use 32K iterations – see note
            //var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            // create an AES object
            using (TripleDES tripleDES = TripleDES.Create())
            {
                tripleDES.Key = passBytes;
                tripleDES.IV = saltBytes;
                //// set the key size to 256
                //aes.KeySize = 256;
                //aes.Key = key.GetBytes(aes.KeySize / 8);
                //aes.IV = key.GetBytes(aes.BlockSize / 8);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, tripleDES.CreateEncryptor(),
          CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public static byte[] AESDecryptBytes(byte[] cryptBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] clearBytes = null;

            // create a key from the password and salt, use 32K iterations
            //var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            using (Aes aes = new AesManaged())
            {
                aes.Key = passBytes;
                aes.IV = saltBytes;
                // set the key size to 256
                //aes.KeySize = 256;
                //aes.Key = key.GetBytes(aes.KeySize / 8);
                //aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cryptBytes, 0, cryptBytes.Length);
                        cs.Close();
                    }
                    clearBytes = ms.ToArray();
                }
            }
            return clearBytes;
        }

        public static byte[] TDESDecryptBytes(byte[] cryptBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] clearBytes = null;

            // create a key from the password and salt, use 32K iterations
            //var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            using (TripleDES tripleDES = TripleDES.Create())
            {
                tripleDES.Key = passBytes;
                tripleDES.IV = saltBytes;
                // set the key size to 256
                //aes.KeySize = 256;
                //aes.Key = key.GetBytes(aes.KeySize / 8);
                //aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, tripleDES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cryptBytes, 0, cryptBytes.Length);
                        cs.Close();
                    }
                    clearBytes = ms.ToArray();
                }
            }
            return clearBytes;
        }
    }
}