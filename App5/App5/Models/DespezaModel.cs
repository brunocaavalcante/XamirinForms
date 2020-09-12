using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Models
{
    public class DespezaModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int NaturezaId { get; set; }
        public int StatusId { get; set; }
        public Guid UserId { get; set; }
        public decimal Valor { get; set; }
    }
}
