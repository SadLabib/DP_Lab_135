using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Encryption
    {
        private IEncryptionMethod EncryMethod;

        public void SetEncryptionMethod(IEncryptionMethod encryptionMethod) 
        { 
            EncryMethod = encryptionMethod;
        }

        public String Encrypt(String input)
        {
            return EncryMethod.encrypt(input);
        }

        public String Decrypt(String encryptedString)
        {
            return EncryMethod.decrypt(encryptedString);
        }
    }
}
