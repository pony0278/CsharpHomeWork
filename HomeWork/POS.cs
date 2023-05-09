using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class POS : Form
    {


        public POS()
        {
            InitializeComponent();
        }

        private int beerCount = 0;
        private int wineCount = 0;
        private int wiskyCount = 0;
        private int tequliaCount = 0;
        private int totalPrice = 0;


        private void beer_btn_Click(object sender, EventArgs e)
        {
            beerCount++;
            totalPrice += 120;
            updateOrderMessage();
            ShowTotalPrice();
        }

        private void tequlia_btn_Click(object sender, EventArgs e)
        {

            tequliaCount++;
            totalPrice += 180;
            updateOrderMessage();
            ShowTotalPrice();
        }

        private void ShowTotalPrice()
        {
            totalPrice_txt.Text = "總金額：" + totalPrice.ToString() + "元"; 
        }

        private void updateOrderMessage()
        {
            string orderMessage = "";
            if (beerCount > 0)
            {
                int beerPrice = beerCount * 120;
                orderMessage += "已選擇 beer * " + beerCount + " 共 " + beerPrice + " 元\n";
            }
            if (wineCount > 0)
            {
                int winePrice = wineCount * 320;
                orderMessage += "已選擇 wine * " + wineCount + " 共 " + winePrice + " 元\n";
            }
            if (tequliaCount > 0)
            {
                int tequliaPrice = tequliaCount * 180;
                orderMessage += "已選擇 tequlia * " + tequliaCount + " 共 " + tequliaPrice + " 元\n";
            }
            if (wiskyCount > 0)
            {
                int wiskyPrice = wiskyCount * 380;
                orderMessage += "已選擇 wisky * " + wiskyCount + " 共 " + wiskyPrice + " 元\n";
            }
            if (totalPrice == 0)
            {
                orderMessageLabel.Text = "尚未點餐";
            }
            else
            {
                orderMessageLabel.Text = orderMessage.Trim();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            orderMessageLabel.Text = "";
            totalPrice_txt.Text = "";
            beerCount = 0;
            wineCount = 0;
            wiskyCount = 0;
            tequliaCount = 0;
            totalPrice = 0;
        }

        private void creditCard_btn_Click(object sender, EventArgs e)
        {
            int discount = totalPrice * 9 / 10;
            MessageBox.Show("總共：" + totalPrice.ToString() + "元\n" + "折扣後" + discount +"元" );
        }

        private void winsky_btn_Click(object sender, EventArgs e)
        {
            wiskyCount++;
            totalPrice += 350;
            updateOrderMessage();
            ShowTotalPrice();
        }

        private void wine_btn_Click(object sender, EventArgs e)
        {
            wineCount++;
            totalPrice += 320;
            updateOrderMessage();
            ShowTotalPrice();
        }

        private void Cash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共：" + totalPrice.ToString() + "元");
        }
    } 
}
