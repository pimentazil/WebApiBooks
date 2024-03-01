using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBooks.Repository.Models
{
    public class TabLivro
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public decimal preco { get; set; }
        public DateTime dataLancamento { get; set; }
    }
}
