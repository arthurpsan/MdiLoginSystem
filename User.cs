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
        public UInt64 Id { get; set; }

        [Required]
        private String? _name;

        public String? Name
        {
            get
            {
                return _name;
            }
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(value);

                if (value.Length > 45)
                {
                    throw new ArgumentException("Nome não pode ter mais que 45 caracteres");
                }
                _name = value;
            }
        }

        private String _phone;
        public String Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length > 11)
                {
                    throw new ArgumentException("Telefone Inválido");
                }
                _phone = value;
            }

        }

        private String _email;
        public String Email
        {
            get
            {
                return _email;
            }
            set
            {
                ArgumentNullException.ThrowIfNullOrEmpty(value);

                if (value.Length > 74)
                {
                    throw new ArgumentException("Email inválido");
                }
                _email = value;

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
