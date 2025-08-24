using Bll;
using DTO;

namespace Tanach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //json-���� �
        private void button1_Click(object sender, EventArgs e)
        {
            ParashahService.makeJsonFile();
        }

        //����� ����
        private void button2_Click(object sender, EventArgs e)
        {
            List<Place> places = ParashahService.FindWord(FindWord.Text);
            var x = places.Select(p => new { p.Parashah, p.Perek, Pasook = p.Pasook.Number, p.Pasook.Text }).ToList();
            dataGridView1.DataSource = x;
            count.Text = "��\"�: " + x.Count();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = ParashahService.getPsookim();
        }

     
    }
}
