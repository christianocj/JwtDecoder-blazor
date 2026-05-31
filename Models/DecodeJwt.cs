namespace JwtDecoder.Models;

public class DecodedJwt
{
    public string Header { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
    public string Signature { get; set; } = string.Empty;
}

