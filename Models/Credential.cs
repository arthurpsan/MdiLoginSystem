using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace UserManagementSystem.Models
{
    // The [Index] attribute for columns should be placed on the class in EF Core 
    // to configure the database index.
    [Index(nameof(Email), IsUnique = true)]
    [Table("tbl_credencial")]
    public class Credential
    {
        // Primary key equal to User's foreign key - One-To-One Relationship.
        // You cannot reference a non-static field like User.Id in a field initializer.
        // You must initialize Id to a default value (like 0) and configure the 
        // one-to-one relationship and foreign key mapping in your DbContext.
        public long Id { get; set; } = 0;

        public const string SALT = "1FnM6_";

        [Required] // Added [Required] back based on common usage for email
        [StringLength(250)]
        public string? Email { get; set; }

        private string? _password;

        [Required]
        [StringLength(64)]
        public string? Password
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

        public bool Manager { get; set; } = false;

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

        public override string ToString()
        {
            return Id
                + ", User: " + User?.Id
                + ", " + Email
                + ", " + (Manager ? "Admin User" : "Regular User");
        }
    }
}