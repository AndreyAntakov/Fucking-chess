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
            for (int i = 0; i < 8; i++)//������� � �������� ����� ��������
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j] = new Button();

                    Button butt = new Button();//������� ����� ������
                    butt.Size = new Size(50, 50);//������ ������ 50*50
                    butt.Location = new Point(j * 50, i * 50);//� ������� i � j ������ ������� ����� ������

                    switch (map[i, j] / 10)//������� �� ������� ������ ������
                    {
                        case 1:
                            Image part = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);//�������� ����� 
                            butt.BackgroundImage = part;//� ������ ���������� ��������
                            break;
                        case 2:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);//�������� ������
                            butt.BackgroundImage = part1;//� ������ ���������� ��������
                            break;
                    }
                    butt.BackColor = Color.White;//������ ����� ��� ������ ������
                    butt.Click += new EventHandler(OnFigurePress);//����������� � ������ ������ ���������� �� ����
                    this.Controls.Add(butt);

                    butts[i, j] = butt;//���������� ������� ������ ������� �� �������
                }
            }
        }



    }


    }
}