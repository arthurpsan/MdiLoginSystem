using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdiLoginSystem
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

        private String? _email;
        public String? Email
        {
            get => _email;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Email));

                if (value.Length >= 150 || value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Email must contain between 1 and 150 characters.");
                }

                _email = value;
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
