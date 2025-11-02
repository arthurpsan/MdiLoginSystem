using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    public class User
    {
        public Int64 Id { get; set; }

        [Required]
        private String? _name;
        public String? Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNull(nameof(value), "Username cannot be null or empty.");

                if (value.Length >= 80)
                {
                    throw new ArgumentOutOfRangeException("Name cannot contain more than 80 characters.");
                }

                _name = value;
            }
        }

        private String? _nickname;
        public String? Nickname
        {
            get => _nickname;
            set
            {
                ArgumentNullException.ThrowIfNull(nameof(value), "Nickname cannot be null or empty.");

                if (value.Length >= 20)
                {
                    throw new ArgumentOutOfRangeException("Nickname cannot contain more than 20 characters.");
                }
                _nickname = value;
            }
        }

        private String? _email;
        public String Email
        {
            get => _email;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value, nameof(Email));

                if (value.Length >= 80)
                {
                    throw new ArgumentOutOfRangeException("Email cannot contain more than 80 characters. ");
                }
            }
        }

        private UInt64? _phoneNumber;
        public UInt64? PhoneNumber
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
