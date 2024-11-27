using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.model
{
    internal class Заказ
    {
        public int Id_Заказ { get; set; }
        public string Дата_Заказа { get; set; }
        public string Дата_Доставки { get; set; }
        public int Id_Клиент { get; set; }
    }
}
