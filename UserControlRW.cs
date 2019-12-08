using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class UserControlRW : UserControl
    {
        public UserControlRW()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kmprw` (`mesplan`, `status`, `date_zajavki`, `client`, `station`, `code`, `product1`, `zakaz`, `time_zakr`, `id_doc`, `product2`, `poddony`, `vagon`, `plomb`, `brutto`, `netto`, `wagon_weight`, `nty`, `podacha`, `wed`, `sklad`) VALUES ('1309900992', 'на согласовании ГУ-11', '2019-12-01', 'ООО \"Терра Трейд Тернополь\"', '\" 360004 (Тернополь)(УЗ)  \"', '5865', 'Блоки стеновые (крытый)           625*300*200-2,5-1к - 26 под(1,494)        625*200*249-2,5-1к - 26 под(1,743)                            термоупаковка                              Контроль ОТК кр', 'КМУТ-001919', '2019-12-09 15:30:00', '87545456', 'Блоки стеновые (крытый)           625*300*200-2,5-1к - 26 под(1,494)        625*200*249-2,5-1к - 26 под(1,743)                            термоупаковка                              Контроль ОТК кр', '52', '24257658', 'КМП А372', '56.71', '54.91', '67', 'Гл.11', '2019-12-08 20:20:00', '1', 'ЭЦ 25465462');", db.getConnection());
        }
    }
}
