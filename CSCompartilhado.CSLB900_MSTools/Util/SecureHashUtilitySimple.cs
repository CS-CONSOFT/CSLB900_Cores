using System.Security.Cryptography;

namespace CSLB900.MSTools.Util
{
    public static class SecureHashUtilitySimple
    {
        public static string Hash(string value)
        {
            // Generate a salt
            byte[] bytesChave = new byte[16];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytesChave);
            }

            /**
             o salt serve para garantir que hashes de senhas iguais fiquem diferentes. 
             O PBKDF2 não armazena o salt junto do hash, ele apenas usa o salt para gerar o hash.
             */
            Rfc2898DeriveBytes hash = new(value, bytesChave, 10000, HashAlgorithmName.SHA256);
            byte[] bytesSenhaCriptografada = hash.GetBytes(20);

            // Combine salt and hash
            byte[] bytesSenhaCombinadaComHash = new byte[36];
            Array.Copy(bytesChave, 0, bytesSenhaCombinadaComHash, 0, 16);

            Array.Copy(bytesSenhaCriptografada, 0, bytesSenhaCombinadaComHash, 16, 20);

            // Convert to base64 string
            return Convert.ToBase64String(bytesSenhaCombinadaComHash);
        }

        public static bool VerifyEquality(string value, string storedHash)
        {
            byte[] senhaCriptografadaSalva = Convert.FromBase64String(storedHash);

            // Extrair a chave nos primeiros 16 bytes
            byte[] bytesChave = new byte[16];
            Array.Copy(senhaCriptografadaSalva, 0, bytesChave, 0, 16);

            // Criar hash da senha digitada usando o mesmo salt
            var hash = new Rfc2898DeriveBytes(value, bytesChave, 10000, HashAlgorithmName.SHA256);
            byte[] bytesSenhaCriptografadaEmExecucao = hash.GetBytes(20);

            // Comparar o hash gerado da senha com o armazenado
            for (int i = 0; i < 20; i++)
            {
                if (senhaCriptografadaSalva[i + 16] != bytesSenhaCriptografadaEmExecucao[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VerifyEqualityV2(this string senhaDigitada, string senhaDoBanco)
        {
            return VerifyEquality(senhaDigitada, senhaDoBanco);
        }
    }
}
