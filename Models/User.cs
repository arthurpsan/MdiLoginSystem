using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class User
    {
        public long Id { get; set; }

        [Required]
        private string? _name;
        public string? Name
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

        private string? _nickname;
        public string? Nickname
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

        private string? _email;
        public string? Email
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

        private ulong? _phoneNumber;
        public ulong? PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value < 10000000000 || value > 99999999999)
                {
                    throw new ArgumentOutOfRangeException("Phone number must be a valid number.");
                }

                _phoneNumber = value;
            }
        }

        private Credential? _credential;
        public Credential? Credential
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
