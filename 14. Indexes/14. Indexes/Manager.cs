using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Indexes
{
    class Manager
    {
        string name;
        string email;
        string phone;
        
        public string this[string props]
        {
            get
            {
                switch (props)
                {
                    case "name": return this.name;
                    case "email": return this.email;
                    case "phone": return this.phone;
                    default: return null;
                }
            }
            set
            {
                switch (props)
                {
                    case "name":
                        this.name = value;
                        break;
                    case "email":
                        this.email = value;
                        break;
                    case "phone":
                        this.phone = value;
                        break;
                }
            }
        }
    }
}
