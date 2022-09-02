namespace FuckingChess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeGame();
            CreateCells();

        }

        private void InitializeGame()
        {
            Figure f = new Figure();
            King king = new King();
            if(king is Figure)
            {
                MessageBox.Show("yeah");
            }
            string s = "A";
            int X = (((int)YCellPositions.A));
            MessageBox.Show(X.ToString());
        }
        private void CreateCells()
        {
            int currentCellX=10;
            int currentCellY=10;
            Button [,] cells = new Button [2, 2]; 
            for(int i=0;i<2;i++)
            {
                for(int j =0;j<2;j++)
                {
                    cells[i,j] = new Button ();
                }
            }


            ///////////
            ///
            for (int i = 0; i < 8; i++)//создаем и заполням карту кнопками
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j] = new Button();

                    Button butt = new Button();//создаем новую кнопку
                    butt.Size = new Size(50, 50);//задаем размер 50*50
                    butt.Location = new Point(j * 50, i * 50);//с помощью i и j задаем позиции наших кнопок

                    switch (map[i, j] / 10)//вырезка из спрайта нужной фигуры
                    {
                        case 1:
                            Image part = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);//вырезаем белых 
                            butt.BackgroundImage = part;//в кнопку запихиваем картинку
                            break;
                        case 2:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);//вырезаем негров
                            butt.BackgroundImage = part1;//в кнопку запихиваем картинку
                            break;
                    }
                    butt.BackColor = Color.White;//делаем белый фон каждой кнопке
                    butt.Click += new EventHandler(OnFigurePress);//привязываем к каждой кнопке обработчик на клик
                    this.Controls.Add(butt);

                    butts[i, j] = butt;//записываем текущую кнопку которую мы создали
                }
            }
        }



    }


    }
}