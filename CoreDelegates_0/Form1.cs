namespace CoreDelegates_0
{
    public partial class Form1 : Form
    {
        //Action, Predicate,Func

        Action actDelegate;

        Action<string> actDelegate2;




        delegate void MyDelegate();


        Predicate<string> preDelegate;

        Func<string, bool> funcDelegate;

        


        MyDelegate md1;
        //TestDelegate td1;
        //IslemYap iy1;


        //delegate void TestDelegate(string item);


        //delegate int IslemYap(int sayi1, int sayi2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            md1 = FormaYazdir;
            //md1 = new MyDelegate(FormaYazdir);
            //md1 += RenkDegistir;
            //md1 += Selamla;

            //td1 = new TestDelegate(IsmeGoreSelamla);

            //iy1 = new IslemYap(Topla);
            //actDelegate = Selamla;
            //actDelegate2 = IsmeGoreSelamla;

            //actDelegate = () =>
            //{
            //    MessageBox.Show("Selamla");
            //};

            //actDelegate2 = x =>
            //{

            //    MessageBox.Show($"Hosgeldin {x}");
            //};
            List<string> sehirler = new List<string>
            {
                "Paris","Istanbul","Londra"
            };

            //preDelegate = SehriBul;

            funcDelegate = SehriBul;

            //Text = sehirler.Find(preDelegate);

            List<string> bulunanSehirler = sehirler.Where(funcDelegate).ToList();




        }

        public void Selamla()
        {
            MessageBox.Show("Hello World");
        }

        public void FormaYazdir()
        {
            Text = "Hello World";
        }

        public void RenkDegistir()
        {
            BackColor = Color.Red;
        }


        public void IsmeGoreSelamla(string item)
        {
            MessageBox.Show($"Hosgeldin {item}");
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            //md1.Invoke();

            //td1.Invoke("Ahmet");

            //Text = iy1.Invoke(3, 3).ToString();
            //actDelegate2.Invoke("Ahmet");
        }


        public int Topla(int x, int y)
        {
            return x + y;
        }


        public bool SehriBul(string deger)
        {
            return deger == "Paris";
        }
    }
}
