using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace UserManagementSystem.Models
{
    // The [Index] attribute for columns should be placed on the class in EF Core 
    // to configure the database index.
    [Index(nameof(Email), IsUnique = true)]
    [Table("tbl_credencial")]
    public class Credential
    {
        [Key]
        public UInt64 Id { get; set; } = 0;

        public const String SALT = "1FnM6_";

        [Required] // Added [Required] back based on common usage for email
        [StringLength(250)]
        public String? Email { get; set; }

        private String? _password;

        [Required]
        [StringLength(64)]
        public String? Password
        {
            get
            {
                return _password;
            }
            set
            {
                // The setter calculates the hash using the provided value and salt.
                _password = ComputeSHA256(value, SALT);
            }
        }

        public Boolean Manager { get; set; } = false;

        [Required]
        public User? User { get; set; }

        public DateTime? LastAccess { get; set; }

        #region Hashing
        // ... (Hashing methods remain the same) ...
        public static string ComputeSHA256(string input)
        {
            return ComputeSHA256(input, null);
        }

        public static string ComputeSHA256(string? input, string? salt)
        {
            string hash = string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Ensure the salt is prepended even if it's null (it will be an empty string).
                string inputWithSalt = (salt ?? string.Empty) + input;

                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(inputWithSalt));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion

        public override String ToString()
        {
            return Id
                + ", User: " + User?.Id
                + ", " + Email
                + ", " + (Manager ? "Admin User" : "Regular User");
        }
    }
}