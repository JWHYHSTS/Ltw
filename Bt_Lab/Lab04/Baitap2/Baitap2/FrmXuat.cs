using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class FrmXuat : Form
    {
        const int KhoangCachLe = 10;
        const int KhoangCachButton = 10;
        const int Rong = 70;
        const int Cao = 70;
        public FrmXuat(int soDong = 1, int soCot = 1)
        {
            InitializeComponent();

            Button button;
            for(int i = 0; i < soDong; i++)
            {
                for(int j = 0; j < soCot; j++)
                {
                    button = new Button();
                    button.Left = KhoangCachLe + (KhoangCachButton + Rong) * j;
                    button.Top = KhoangCachLe + (KhoangCachButton + Cao) * i;
                    button.Width = Rong;
                    button.Height = Cao;
                    button.Text = $"({i},{j})";

                    // Gán sự kiện Click cho Button
                    button.Click += ClickButton;

                    // Thêm button vào Form
                    this.Controls.Add(button);

                    // Resize kích thước Form
                    this.ClientSize = new Size(KhoangCachLe + (KhoangCachButton + Rong) * soCot, KhoangCachLe + (KhoangCachButton + Cao) * soDong);
                }
            }
        }

        protected void ClickButton(object sender, EventArgs e) 
        {
            MessageBox.Show("Click lên Button: " + (sender as Button).Text);
        }
    }
}
