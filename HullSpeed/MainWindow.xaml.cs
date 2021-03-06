﻿using System;
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

namespace HullSpeed
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

        private void CalcButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LengthTextBox.Text) || LengthTextBox.Text.All(char.IsNumber)==false)
            {
                MessageBox.Show("Insert the lenght of the ship");
            }
            else
            {
                HullSpeedResultLabel.Content = mySailboat.Hullspeed();
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

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) == false)
            {
                MessageBox.Show("The name of the ship is " + mySailboat.Name);
            }
        }

        private void NameTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            mySailboat.Name = NameTextBox.Text;
        }

        private void LengthTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
                mySailboat.Length = double.Parse(LengthTextBox.Text);
        }
    }
}
