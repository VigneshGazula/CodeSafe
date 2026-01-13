using Microsoft.AspNetCore.DataProtection;
using ShareItems_WebApp.Services;

public class EncryptionService : IEncryptionService
{
    private readonly IDataProtector _protector;
    
    public EncryptionService(IDataProtectionProvider provider)
    {
        _protector = provider.CreateProtector("MyPurpose");
    }
    public string EncryptData(string plainText)
    {
        return _protector.Protect(plainText);
    }
    public string DecryptData(string encryptedData)
    {
        try
        {
            return _protector.Unprotect(encryptedData);
        }
        catch (Exception ex)
        {
            return $"Decryption failed: {ex.Message}";
        }
    }

    public byte[] EncryptData(byte[] plainData)
    {
        return _protector.Protect(plainData);
    }

    public byte[] DecryptData(byte[] encryptedData)
    {
        try
        {
            return _protector.Unprotect(encryptedData);
        }
        catch (Exception ex)
        {
            throw new Exception($"Decryption failed: {ex.Message}", ex);
        }
    }
}
