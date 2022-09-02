using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTakToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int row = 3;
        private readonly int column = 3;
        private char who_now = 'X';
        private bool end = false;
        private ImageType[,] board = new ImageType[3, 3];
        public MainWindow()
        {
            InitializeComponent();
            SetupGrid();
            SetupBoard();
        }
        public void SetupBoard()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    board[i, j] = ImageType.Empty;
        }
        public void SetupGrid()
        {
            GameGrid.Rows = row;
            GameGrid.Columns = column;

            for (int r = 0; r < row; ++r)
                for (int c = 0; c < column; ++c)
                {
                    Image image = new()
                    {
                        Source = Images.Empty
                    };
                 

                    GameGrid.Children.Add(image);
                }
        }
        public void PrintGrid()
        {
            GameGrid.Children.Clear();
            for (int r = 0; r < row; ++r)
                for (int c = 0; c < column; ++c)
                {
                    Image image = new();
                    if (board[r, c] == ImageType.Empty)
                        image.Source = Images.Empty;
                    else if (board[r, c] == ImageType.O)
                        image.Source = Images.O;
                    else if (board[r, c] == ImageType.X)
                        image.Source = Images.X;
                    GameGrid.Children.Add(image);
                }
        }
        

        private void On_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void RB_Click(object sender, RoutedEventArgs e)
        {
            Image image = new();
            if (board[2, 2] != ImageType.Empty)
                return;
            if (who_now == 'X')
            {
                board[2, 2] = ImageType.X;
                image.Source = Images.X;
            }
            else if(who_now == 'O')
            {
                board[2, 2] = ImageType.O;
                image.Source = Images.O;

            }
        }

        private ImageType WhoWin()
        {
            for (int i = 0; i < row; ++i)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
                return board[2, 0];
            return ImageType.Empty;
        }

        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            if (end)
                return;
            Image image = new();
            Point p = e.GetPosition(GameGrid);
            if (p.X < 150 && p.Y < 150)
            {
                if (board[0, 0] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[0, 0] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[0, 0] = ImageType.O;
                }
            }
            else if (p.X < 300 && p.Y < 150)
            {
                if (board[0, 1] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[0, 1] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[0, 1] = ImageType.O;
                }
            }
            else if (p.X < 450 && p.Y < 150)
            {
                if (board[0, 2] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[0, 2] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[0, 2] = ImageType.O;
                }
            }
            else if (p.X < 150 && p.Y < 300)
            {
                if (board[1, 0] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[1, 0] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[1, 0] = ImageType.O;
                }
            }
            else if (p.X < 300 && p.Y < 300)
            {
                if (board[1, 1] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[1, 1] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[1, 1] = ImageType.O;
                }
            }
            else if (p.X < 450 && p.Y < 300)
            {
                if (board[1, 2] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[1, 2] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[1, 2] = ImageType.O;
                }
            }
            else if (p.X < 150 && p.Y < 450)
            {
                if (board[2, 0] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[2, 0] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[2, 0] = ImageType.O;
                }
            }
            else if (p.X < 300 && p.Y < 450)
            {
                if (board[2, 1] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[2, 1] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[2, 1] = ImageType.O;
                }
            }
            else if (p.X < 450 && p.Y < 450)
            {
                if (board[2, 2] != ImageType.Empty)
                    return;
                if (who_now == 'X')
                {
                    board[2, 2] = ImageType.X;
                    who_now = 'O';
                }
                else if (who_now == 'O')
                {
                    who_now = 'X';
                    board[2, 2] = ImageType.O;
                }
            }
            PrintGrid();
            if (WhoWin() != ImageType.Empty)
                end = true;


        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            end = false;
            SetupBoard();
            PrintGrid();
        }
    }
}
