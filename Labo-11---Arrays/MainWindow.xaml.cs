using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_11___Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[6] { 100, 50, 20, 60, 90, 80 };
            //int[] numbers = new int[] { 100, 50, 20, 60, 90, 80 };
            //int[] numbers = { 100, 50, 20, 60, 90, 80 };

            StringBuilder sb = new StringBuilder();

            //Optie 1
            //foreach (int number in numbers)
            //{
            //    sb.AppendLine(number.ToString());
            //}

            //sb.AppendLine();

            //Optie 2


            
            int temp;
            int i;
            int j;

            for (i = 0; i < numbers.Length; i++)
            {

                for (j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }
                }
                //sb.AppendLine(numbers[i].ToString());
            }

            //outputTextBox.Text = sb.ToString();

            //outputTextBox.Text = $"Minimum: {min.ToString()} Maximum: {max.ToString()}";
            
            int[] result = ReturnSmallestAndBiggest(numbers);
            sb.AppendLine($"Het kleinste getal is {result[0]}");
            sb.AppendLine($"Het grootste getal is {result[1]}");
            outputTextBox.Text = sb.ToString();


        }

        private int[] ReturnSmallestAndBiggest(int[] numberArray)
        {
            int min = numberArray[0];
            int max = numberArray[0];



            for (int teller = 1; teller < numberArray.Length; teller++)
            {


                if (numberArray[teller] < min)
                {
                    min = numberArray[teller];
                }

                if (numberArray[teller] > max)
                {
                    max = numberArray[teller];
                }
            }

            return new int[2] { min, max };
        }
    }
}