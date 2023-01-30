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
//Meili Zheng;
//Lecture Example - List<T>
//01/30/2023;


namespace Lecture_Example___ListT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> namesList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void DisplayFromList()
        {
            rtbdisplay1.Text = "";
            for (int i = 0; i < namesList.Count; i++)
            {
                FormatString(i);
            }           
        }

        public void FormatString(int i)
        {
            rtbdisplay1.Text += $"{i}  {namesList[i]} \n";
        }

        private void bntAdd_Click(object sender, RoutedEventArgs e)
        {                           
            string addtolist = txtAdd.Text;
            namesList.Add(addtolist);            
            DisplayFromList();            
        }

        private void bntDisplay_Click(object sender, RoutedEventArgs e)
        {
            int number = 0;
            string inputIndex = txtDisplaybyindex.Text;
            bool inputindex = int.TryParse(inputIndex, out number);
            if (inputindex)
            {
                int inputnumber = int.Parse(txtDisplaybyindex.Text);

                for (int i = 0; i < namesList.Count; i++)
                {
                    if (i == inputnumber)
                    {
                        rtbdisplay1.Text = i + "  " + namesList[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("Invaid information");
            }            
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {          
            
                int number = 0;
                string inputIndex = txtRemove.Text;
                bool inputindex = int.TryParse(inputIndex, out number);
            if (inputindex)
            {
                int removeIndex = int.Parse(txtRemove.Text);

                for (int i = 0; i < namesList.Count; i++)
                {
                    if (i == removeIndex)
                    {
                        namesList.RemoveAt(i);
                        DisplayFromList();
                    }
                }
            }              
            else
            {
               MessageBox.Show("Invaid information");
            }                         
        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            string removeItem = txtRemoveItem.Text;
            for (int i = 0; i < namesList.Count; i++)
            {
                if (removeItem == namesList[i])
                {
                    namesList.RemoveAt(i);
                    DisplayFromList();
                }
            }
        }

        private void btnRemoveRange_Click(object sender, RoutedEventArgs e)
        {
            int remoVevalue1 = int.Parse(txtRemovevalue1.Text);
            int removeValue2 = int.Parse(txtRemovevalue2.Text);
            for (int i = 0; i < namesList.Count; i++)
            {                
                if (i >= remoVevalue1 && i <= removeValue2)
                {
                    namesList.RemoveAt(i); ;
                    DisplayFromList();
                }                                 
            }     
          }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbdisplay1.Text = "";
        }
    }
}
