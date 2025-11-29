using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class User
    {
        [Key]
        public UInt64 Id { get; set; }

        [Required]
        private String? _name;
        public String? Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Email));

                if (value.Length >= 80)
                {
                    throw new ArgumentOutOfRangeException("Name cannot contain more than 80 characters.");
                }

                _name = value;
            }
        }

        public virtual String Role
        {
            get
            {
                if (Credential?.Manager == true) return "Manager";
                if (this is Salesperson) return "Salesperson";
                if (this is Cashier) return "Cashier";
                return "Employee";
            }
        }

        private String? _nickname;
        public String? Nickname
        {
            get => _nickname;
            set
            {
                ArgumentNullException.ThrowIfNull(nameof(value), "Nickname cannot be null or empty.");

                if (value.Length <= 1 || value.Length >= 20)
                {
                    throw new ArgumentOutOfRangeException("Nickname cannot contain more than 20 characters.");
                }
                _nickname = value;
            }
        }

        private String? _email;
        public String? Email
        {
            get => _email;
            set
            {
                ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Email));

                if (value.Length >= 80)
                {
                    throw new ArgumentOutOfRangeException("Email cannot contain more than 80 characters. ");
                }

                _email = value;
            }
        }

        private UInt64? _phoneNumber;
        public UInt64? PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value < 1000000000000 || value > 9999999999999)
                {
                    throw new ArgumentOutOfRangeException("Phone number must be a valid number.");
                }

                _phoneNumber = value;
            }
        }

        private Credential _credential;
        public Credential Credential
        {
            get
            {
                return _credential;
            }
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                _credential = value;
            }
        }
    }
}
