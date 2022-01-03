using System;
using System.Collections.Generic;
using System.Linq;
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

namespace JogoDaVelha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Last = "O";
        private string Vencedor = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void clickBtn1(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = false;
            button1.Content = validaCaractere(button1.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn4(object sender, RoutedEventArgs e)
        {
            button4.IsEnabled = false;
            button4.Content = validaCaractere(button4.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn7(object sender, RoutedEventArgs e)
        {
            button7.IsEnabled = false;
            button7.Content = validaCaractere(button7.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn2(object sender, RoutedEventArgs e)
        {
            button2.IsEnabled = false;
            button2.Content = validaCaractere(button2.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn5(object sender, RoutedEventArgs e)
        {
            button5.IsEnabled = false;
            button5.Content = validaCaractere(button5.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn8(object sender, RoutedEventArgs e)
        {
            button8.IsEnabled = false;
            button8.Content = validaCaractere(button8.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn3(object sender, RoutedEventArgs e)
        {
            button3.IsEnabled = false;
            button3.Content = validaCaractere(button3.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn6(object sender, RoutedEventArgs e)
        {
            button6.IsEnabled = false;
            button6.Content = validaCaractere(button6.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void clickBtn9(object sender, RoutedEventArgs e)
        {
            button9.IsEnabled = false;
            button9.Content = validaCaractere(button9.Content.ToString());
            validaResultado(button1.Content.ToString(), button2.Content.ToString(), button3.Content.ToString(), button4.Content.ToString(), button5.Content.ToString(), button6.Content.ToString(), button7.Content.ToString(), button8.Content.ToString(), button9.Content.ToString());
            
        }

        private void validaResultado(string btn1, string btn2, string btn3, string btn4, string btn5, string btn6, string btn7, string btn8, string btn9)
        {

            if ((Vencedor != "Vencedor:X") && (Vencedor != "Vencedor:O"))
            {
                //valida as linhas
                if ((btn1 == btn2) && (btn2 == btn3) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn2.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if ((btn4 == btn5) && (btn5 == btn6) && !string.IsNullOrWhiteSpace(btn4))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if ((btn7 == btn8) && (btn8 == btn9) && !string.IsNullOrWhiteSpace(btn7))
                {
                    if (btn8.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                //valida as colunas
                else if ((btn1 == btn4) && (btn4 == btn7) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn4.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if ((btn2 == btn5) && (btn5 == btn8) && !string.IsNullOrWhiteSpace(btn2))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if ((btn3 == btn6) && (btn6 == btn9) && !string.IsNullOrWhiteSpace(btn3))
                {
                    if (btn6.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                //valida as diagonais
                else if ((btn1 == btn5) && (btn5 == btn9) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if ((btn3 == btn5) && (btn5 == btn7) && !string.IsNullOrWhiteSpace(btn3))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        MessageBox.Show($"Vencedor:{Last}\n O jogo será reiniciado!", "Fim de Jogo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        resetJogo();
                    }
                }
                else if (!string.IsNullOrWhiteSpace(btn1) && !string.IsNullOrWhiteSpace(btn2) && !string.IsNullOrWhiteSpace(btn3) && !string.IsNullOrWhiteSpace(btn4) &&
                    !string.IsNullOrWhiteSpace(btn5) && !string.IsNullOrWhiteSpace(btn6) && !string.IsNullOrWhiteSpace(btn7) && !string.IsNullOrWhiteSpace(btn8) &&
                    !string.IsNullOrWhiteSpace(btn9))
                {
                    Vencedor = "Deu velha!";
                    MessageBox.Show("Deu velha!");
                    resetJogo();
                }
            }
        }

        private string validaCaractere(string buttonPadrao)
        {
            if (Last == "X")
            {
                Last = "O";
                return buttonPadrao = "O";
            }
            else if (Last == "O")
            {
                Last = "X";
                return buttonPadrao = "X";
            }
            else 
            {
                Last = "X";
                return buttonPadrao = "X";
            }
        }

        private void resetJogo()
        {
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";

            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
        }
    }
}
