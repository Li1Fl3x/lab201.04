using System.Windows;

namespace lab201._04
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnalyzeButtonClick(object sender, RoutedEventArgs e)
        {
            string inputString = inputTextBox.Text;
            int dotCount = CountOccurrences(inputString, '.');
            int commaCount = CountOccurrences(inputString, ',');

            resultTextBlock.Text = $"Количество точек: {dotCount}\nКоличество запятых: {commaCount}";
        }

        private int CountOccurrences(string input, char target)
        {
            int count = 0;
            foreach (char character in input)
            {
                if (character == target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

