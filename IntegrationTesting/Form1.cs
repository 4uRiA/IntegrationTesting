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
            // ���������, ��� ����� ������ 0 � �������� �������� �������
            while (num > 0 && num % 5 == 0)
            {
                num /= 5;
            }
            // ���� ����� ����� ���� ������� ����� ������ 1, �� ��� �������� �������� �������
            return num == 1;
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try { 
            int[] sequence = textBoxInput.Text.Split(", ").Select(x => int.Parse(x)).ToArray();
            
            foreach (int i in sequence)
            {
                if (i == 9) { MessageBox.Show("���! �� ������ � ���� �������� ������������!"); }
                if (i < 1 || i > 999)
                {
                    MessageBox.Show("�� ����� �� ��������!");
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
            MessageBox.Show($"� ����� ������������������ {count} �����, ���������� ��������� 5!") ; //
            }
            catch { MessageBox.Show("�� ����������� ����� ������!"); }
        }
       
    }
}
