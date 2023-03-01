using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankAccounts.Class.Enum;

namespace bankAccounts.Class
{
    public class Client
    {
        public string Name { get; private set; }
        public DateTime Birth { get; private set; }
        public string Profession { get; private set; }
        public MaritalStatusEnum MaritalStatus { get; private set; }
        public TypePerson TypePerson { get; private set; }

        public Client() { }
        public Client(string name, DateTime birth, string profession, 
            MaritalStatusEnum maritalStatus, TypePerson typePerson)
        {
            Name = name;
            Birth = birth;
            Profession = profession;
            MaritalStatus = maritalStatus;
            TypePerson = typePerson;
        }
    }
}
