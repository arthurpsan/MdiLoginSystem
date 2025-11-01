using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore; // Needed for [Index] when used on a class

namespace MdiLoginSystem
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
        public Int64 Id { get; set; } = 0;

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

        public bool Manager { get; set; }
        
        [Required]
        public User? User { get; set; }

        public DateTime LastSession { get; set; }

        #region Hashing
        // ... (Hashing methods remain the same) ...
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Ensure the salt is prepended even if it's null (it will be an empty string).
                string inputWithSalt = (salt ?? String.Empty) + input;

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
                + ", " + Email
                + ", " + Password
                + ", " + (Manager ? "Administrador" : "Usuário comum")
                + ", Usuário: " + User?.Id;
        }
    }
}