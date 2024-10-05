using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Voucher
    {
        public string codigoVoucher {  get; set; }
        public int idCliente {  get; set; }
        public SqlDateTime fechaCanje {  get; set; }
        public int idArticulo {  get; set; }

    }
}
