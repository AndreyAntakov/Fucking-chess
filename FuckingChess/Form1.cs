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

        Button[,] cells = new Button[8, 8];
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
            for(int i=0;i<8;i++)
            {
                for(int j =0;j<8;j++)
                {
                    cells[i,j] = new Button ();
                    cells[i, j].Size = new Size(50, 50);
                    cells[i,j].Location = new Point((j*50)+currentCellX,(i*50)+currentCellY);
                    currentCellX += 5;
                    cells[i,j].Click+= new EventHandler(OnCellClick);
                    this.Controls.Add(cells[i, j]);
                }
                currentCellY += 5;
                currentCellX = 10;
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {

        }
        
    }


}