using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;

namespace API.Models
{
    public class Pessoa:IPessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }
        public char Gender { get; set; }

    }
}
