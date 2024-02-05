namespace Obrazki
{
    public partial class Form1 : Form
    { PictureBox obraz;
        List <string>obrazki=new List<string>() { "1.jpg","2.jpg","3.jpg","4.jpg","5.jpg"};
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            this.AutoSize= true;
            Text = "Krajobrazy";
            obraz=new PictureBox();
            obraz.SizeMode = PictureBoxSizeMode.StretchImage;
            //obraz.SizeMode = PictureBoxSizeMode.AutoSize;
             Controls.Add(obraz);
            obraz.Width = 800;
            obraz.Height = 600;
            obraz.Location = new Point(this.Width/2-obraz.Width/2, this.Height / 2 - obraz.Height / 2);
            obraz.Image = new Bitmap("../../../krajobrazy/1.jpg");

            this.Resize += Centruj;
            obraz.Click+= ZmianaObrazka;

        }
        void Centruj(object? sender, EventArgs e)
        {
            obraz.Location = new Point(this.Width / 2 - obraz.Width / 2, this.Height / 2 - obraz.Height / 2);
        }

        void ZmianaObrazka(object? sender, EventArgs e)
        {   if(index <obrazki.Count)
            {
                index++;
                
               
            }
        if(index ==obrazki.Count)
            {
                index = 0;
            }
       
            obraz.Image = new Bitmap("../../../krajobrazy/" + obrazki[index]);
        }
    }
}