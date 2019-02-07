using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HullSpeedGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sailboat mySailboat;
        public MainWindow()
        {
            InitializeComponent();
            mySailboat = new Sailboat();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLenght.Text) || tbxLenght.Text.All(char.IsNumber) == false)
            {
                MessageBox.Show("Insert the lenght of the ship");
            }
            else
            {
                tbxHullSpeed.Text = mySailboat.Hullspeed().ToString();
            }
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) & Keyboard.IsKeyDown(Key.L))
            {
                this.FontSize = this.FontSize + 2;
            }
            else if (Keyboard.IsKeyDown(Key.LeftCtrl) & Keyboard.IsKeyDown(Key.S))
            {
                this.FontSize = this.FontSize - 2;
            }
        }

        private void TbxName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            mySailboat.Name = tbxName.Text;
        }

        private void TbxLenght_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxLenght.Text.All(char.IsNumber) == false)
            {
                mySailboat.Length = Convert.ToDouble(tbxLenght.Text);
            }
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text) == false)
            {
                MessageBox.Show("The name of the ship is " + mySailboat.Name);
            }
        }
    }
}
