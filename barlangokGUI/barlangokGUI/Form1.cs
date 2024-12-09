namespace barlangokGUI
{
    public partial class Form1 : Form
    {
        private List<Barlang> barlangok = [];
        private Barlang? talalat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using StreamReader reader = new("../../../src/barlangok.txt");
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                barlangok.Add(new Barlang(reader.ReadLine()!));
            }
        }

        private void bt_keres_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tx_azon.Text, out int azon))
            {
                MessageBox.Show("A megadott azonosító nem egy szám!");
                return;
            }

            Barlang barlang = barlangok.Find(b => b.Azon == azon)!;
            if (barlang == null)
            {
                DefaultUI();
                MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!");
            }
            else
            {
                tx_hossz.Text = barlang.Hossz.ToString();
                tx_melyseg.Text = barlang.Melyseg.ToString();
                lb_nev.Text = $"Barlang neve: {barlang.Nev}";
                bt_mentes.Enabled = true;
                talalat = barlang;
            }
        }

        private void bt_mentes_Click(object sender, EventArgs e)
        {
            if (talalat == null) { return; }

            if (!int.TryParse(tx_hossz.Text, out int hossz))
            {
                MessageBox.Show("A megadott hossz nem egy szám!");
                return;
            }
            else if (talalat.Hossz > hossz)
            {
                MessageBox.Show("A hossz nem lehet kisebb a korábbi értéknél!");
                return;
            }

            if (!int.TryParse(tx_melyseg.Text, out int melyseg))
            {
                MessageBox.Show("A megadott melység nem egy szám!");
                return;
            }
            else if (talalat.Melyseg > melyseg)
            {
                MessageBox.Show("A melység nem lehet kisebb a korábbi értéknél!");
                return;
            }

            talalat.Hossz = hossz;
            talalat.Melyseg = melyseg;


            using StreamWriter writer = new("../../../src/barlangok.txt");
            writer.WriteLine("azon;nev;hossz;melyseg;telepules;vedettseg");
            foreach (Barlang barlang in barlangok)
            {
                writer.WriteLine($"{barlang.Azon};{barlang.Nev};{barlang.Hossz};{barlang.Melyseg};{barlang.Telepules};{barlang.Vedettseg}");
            }

            DefaultUI();
        }

        void DefaultUI()
        {
            tx_azon.Text = "";
            tx_hossz.Text = "";
            tx_melyseg.Text = "";
            lb_nev.Text = "Barlang neve:";
            bt_mentes.Enabled = false;
            talalat = null;
        }
    }
}
