using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LabirentOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            // FINISH alanımız.

            MessageBox.Show("Tebrikler, Kazandınız");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            // Bütün Label'ları tek bir çatı altında topladık, hepsine ayrı ayrı aynı event'i yazmadık. Buna 'Event Binding' diyoruz.
            //Event Binding: Birden fazla kontrolü tek bir event'e baglamak istiyorsanız önce ilgili kontrolleri secin ve onlar (sadece onlar) seciliyken properties ekranından event ikonuna gelin ve oradan istediginiz event'e cift tıklayın. Böylece acılacak event sizin sectiginiz kontrollerin hepsinin baglandıgı event olacaktır...Bu Event Binding işlemidir...

            MessageBox.Show("Yandınız");
        }
    }
}
