using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.model
{
    internal class Товар
    {
        public int Id_Товар { get; set; }
        public string Артикул { get; set; }
        public string Название { get; set; }
        public string Категория { get; set; }
        public string Бренд { get; set; }
        public string Животное { get; set; }
        public string Описание { get; set; }
        public string Состав { get; set; }
        public string Стоимость { get; set; }
    }
}
