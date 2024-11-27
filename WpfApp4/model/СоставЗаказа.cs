using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.model
{
    internal class СоставЗаказа
    {
        public int Id_СоставЗаказа { get; set; }
        public int Id_Заказ { get; set; }
        public int Id_Товар { get; set; }
        public int КоличествоТовара { get; set; }
    }
}
