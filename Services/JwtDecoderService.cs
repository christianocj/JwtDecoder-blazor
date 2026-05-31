using JwtDecoder.Models;
using System.Text;
using System.Text.Json;

namespace JwtDecoder.Services
{
    public class JwtDecoderService
    {
        public DecodedJwt Decode(string token)
        {
            var parts = token.Split('.');
            if (parts.Length != 3)
                throw new ArgumentException("Token JWT inválido (deve ter 3 partes)");

            var headerJson = DecodeBase64Url(parts[0]);
            var payloadJson = DecodeBase64Url(parts[1]);
            var signature = parts[2];  

            return new DecodedJwt
            {
                Header = FormatarJson(headerJson),
                Payload = FormatarJson(payloadJson),
                Signature = signature
            };
        }

        private string DecodeBase64Url(string base64Url)
        {
            string base64 = base64Url
                .Replace('-', '+')
                .Replace('_', '/');

            // Adição do padding se for necessário
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            byte[] bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(bytes);
        }

        private string FormatarJson(string json)
        {
            using var doc = JsonDocument.Parse(json);
            return JsonSerializer.Serialize(doc, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
