namespace IntegrationTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void buttonInput_Click(object sender, EventArgs e)
        {
            
            
        }
        static bool IsPowerOfFive(int num)
        {
            // Проверяем, что число больше 0 и является степенью пятерки
            while (num > 0 && num % 5 == 0)
            {
                num /= 5;
            }
            // Если число после всех делений стало равным 1, то оно является степенью пятерки
            return num == 1;
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try { 
            int[] sequence = textBoxInput.Text.Split(", ").Select(x => int.Parse(x)).ToArray();
            
            foreach (int i in sequence)
            {
                if (i == 9) { MessageBox.Show("Ого! Вы попали в день рождения разработчика!"); }
                if (i < 1 || i > 999)
                {
                    MessageBox.Show("Вы вышли за диапозон!");
                    Application.Exit();
                }
            }
            int count = 0;
            foreach (int num in sequence)
            {
                if (IsPowerOfFive(num))
                {
                    count++;
                }
            }
            MessageBox.Show($"В вашей последовательности {count} чисел, являющихся степенями 5!") ; //
            }
            catch { MessageBox.Show("Вы неправильно ввели данные!"); }
        }
       
    }
}
