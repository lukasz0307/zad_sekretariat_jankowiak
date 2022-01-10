using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace sekretariat
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		int licznik_ucz = 0;
		int licznik_naucz = 0;
		int licznik_pracownika = 0;
		int licznik_zdj_ucz = 0;
		int licznik_zdj_naucz = 0;
		String grupa_ucznia;
		String plec_ucznia;
		String plec_nauczyciela;
		String plec_pracownika;

		String imie_ucznia1;
		String imie_ucznia2;
		String imie_ucznia3;
		String imie_ucznia4;
		String imie_ucznia5;
		String imie_ucznia6;
		String imie_ucznia7;
		String imie_ucznia8;

		String imie_nauczyciela1;
		String imie_nauczyciela2;
		String imie_nauczyciela3;
		String imie_nauczyciela4;
		String imie_nauczyciela5;
		String imie_nauczyciela7;
		String imie_nauczyciela8;
		String imie_nauczyciela6;

		String imie_pracownika1;
		String imie_pracownika2;
		String imie_pracownika3;
		String imie_pracownika4;
		String imie_pracownika5;
		String imie_pracownika6;
		String imie_pracownika7;
		String imie_pracownika8;

		Boolean co_wyszuk1;
		Boolean co_wyszuk2;
		Boolean co_wyszuk3;
		public MainWindow()
        {
            InitializeComponent();
			
		}

		private void zapisz_ucznia_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (licznik_ucz == 1)
            {
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_ucz1.Text + "|"+drugie_imie_ucz1.Text+"|"+nazwisko_ucz1.Text+"|"
						+panienskie_nazwisko_ucz1.Text+"|"+imiona_rodzicow_ucz1.Text+"|"+data_ur_ucz1.Text+"|"+pesel_ucz1.Text+"|"+plec_ucz1.Text+
						"|"+klasa_ucz1.Text+"|"+grupa_ucz1);
			}
			else if (licznik_ucz == 2)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|" 
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text + 
						"|" + plec_ucznia + "|" + klasa_ucz1.Text + "|" + grupa_ucz1 
						+ "\n"+ imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2);
			}
			else if (licznik_ucz == 3)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucznia + "|" + klasa_ucz1.Text + "|" + grupa_ucz1
						+ "\n" + imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2
						+ "\n" + imie_ucz3.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3);
			}
			else if (licznik_ucz == 4)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucznia + "|" + klasa_ucz1.Text + "|" + grupa_ucz1
						+ "\n" + imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2
						+ "\n" + imie_ucz3.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3
						+ "\n" + imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4);
			}
			else if (licznik_ucz == 5)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucznia + "|" + klasa_ucz1.Text + "|" + grupa_ucz1
						+ "\n" + imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2
						+ "\n" + imie_ucz3.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3
						+ "\n" + imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4
						+ "\n" + imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5);
			}

		}
		private void zapisz_naucz_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (licznik_naucz == 1)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text+"|"+klasy_nauczane_naucz1.Text+"|"+data_zatr_naucz1);
			}
			else if (licznik_naucz == 2)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1
						+"\n"+ imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2
						);
			}
			else if (licznik_naucz == 3)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1
						+ "\n" + imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2
						+ "\n" + imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3);
			}
			else if (licznik_naucz == 4)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1
						+ "\n" + imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2
						+ "\n" + imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3
						+ "\n" + imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4);
			}
			else if (licznik_naucz == 5)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1
						+ "\n" + imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2
						+ "\n" + imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3
						+ "\n" + imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4
						+ "\n" + imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5);
			}

		}
		private void zapisz_prac_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (licznik_pracownika == 1)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1);
			}
			else if (licznik_pracownika == 2)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1+
						"\n"+ imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_naucz2.Text );
			}
			else if (licznik_pracownika == 3)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1 +
						"\n" + imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_naucz2.Text+
						"\n" + imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_naucz3.Text);
			}
			else if (licznik_pracownika == 4)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1 +
						"\n" + imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_naucz2.Text +
						"\n" + imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_naucz3.Text+
						"\n" + imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_naucz4.Text);
			}
			else if (licznik_pracownika == 5)
			{
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1 +
						"\n" + imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_naucz2.Text +
						"\n" + imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_naucz3.Text +
						"\n" + imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_naucz4.Text+
						"\n" + imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_naucz5.Text);
			}

		}

		private void zdj_naucz(object sender, RoutedEventArgs e)
		{
			licznik_naucz++;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == true)
			{
				Uri fileUri = new Uri(openFileDialog.FileName);
                if (licznik_zdj_naucz == 1)
                {
					zdj_naucz_1.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 2)
				{
					zdj_naucz_2.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 3)
				{
					zdj_naucz_3.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 4)
				{
					zdj_naucz_4.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 5)
				{
					zdj_naucz_5.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 6)
				{
					zdj_naucz_6.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 7)
				{
					zdj_naucz_7.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_naucz == 8)
				{
					zdj_naucz_8.Source = new BitmapImage(fileUri);
				}

			}
		}
		
			private void zdj_ucznia(object sender, RoutedEventArgs e)
		{
			licznik_zdj_ucz++;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			if (openFileDialog1.ShowDialog() == true)
			{
				Uri fileUri = new Uri(openFileDialog1.FileName);
				if (licznik_zdj_ucz == 1)
				{
					zdj_ucznia_1.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 2)
				{
					zdj_ucznia_2.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 3)
				{
					zdj_ucznia_3.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 4)
				{
					zdj_ucznia_4.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 5)
				{
					zdj_ucznia_5.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 6)
				{
					zdj_ucznia_6.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 7)
				{
					zdj_ucznia_7.Source = new BitmapImage(fileUri);
				}
				if (licznik_zdj_ucz == 8)
				{
					zdj_ucznia_8.Source = new BitmapImage(fileUri);
				}

			}
		}

		


		private void zakoncz_Click(object sender, RoutedEventArgs e)
		{
			
		}
		private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor0.Text = "";
		}
		private void dodaj_ucznia_Click(object sender, RoutedEventArgs e)
		{

			licznik_ucz++;
			
			Boolean jaka_plec_ucznia1 = (bool)meszczyzna_ucz.IsChecked;
			Boolean jaka_plec_ucznia2 = (bool)kobieta_ucz.IsChecked;
			if (jaka_plec_ucznia1 == true)
			{
				 plec_ucznia = "Mężczyzna";
				
			}
			else if (jaka_plec_ucznia2 == true)
			{
				 plec_ucznia = "Kobieta";
			}
			Boolean ktora_grupa_ucznia1 = (bool)gr1.IsChecked;
			Boolean ktora_grupa_ucznia2 = (bool)gr2.IsChecked;
			if (ktora_grupa_ucznia1 == true)
			{
				 grupa_ucznia = "Grupa 1";
			}
			else if (ktora_grupa_ucznia2 == true)
			{ 
				 grupa_ucznia = "Grupa 2";
			}
			
			String imie_ucznia = imie_ucz.Text;
			String nazwisko_ucznia = nazwisko_ucz.Text;
			String drugie_imie_ucznia = drugie_imie_ucz.Text;
			String data_urodzenia_ucznia = data_ur_ucz.Text;
			String pesel_ucznia = pesel_ucz.Text;
			String nazwisko_panienskie_ucznia = nazwisko_panienskie_ucz.Text;
			String imiona_rodzicow_ucznia = imiona_rodzicow_ucz.Text;
			String klasa_ucznia = klasa_ucz.Text;

           
            if (licznik_ucz == 1)
            {
				id_ucz1.Text = licznik_ucz+".";
				imie_ucznia1 = imie_ucz.Text;
				imie_ucz1.Text = imie_ucznia; 
				drugie_imie_ucz1.Text = drugie_imie_ucznia;
				nazwisko_ucz1.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz1.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz1.Text = imiona_rodzicow_ucznia;
				data_ur_ucz1.Text = data_urodzenia_ucznia;
				pesel_ucz1.Text = pesel_ucznia;
				klasa_ucz1.Text = klasa_ucznia;
				grupa_ucz1.Text = grupa_ucznia;
				plec_ucz1.Text = plec_ucznia;
			}
			 if (licznik_ucz == 2)
            {
				id_ucz2.Text = licznik_ucz + ".";
				imie_ucznia2 = imie_ucz.Text;
				imie_ucz2.Text = imie_ucznia; 
				drugie_imie_ucz2.Text = drugie_imie_ucznia;
				nazwisko_ucz2.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz2.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz2.Text = imiona_rodzicow_ucznia;
				data_ur_ucz2.Text = data_urodzenia_ucznia;
				pesel_ucz2.Text = pesel_ucznia;
				klasa_ucz2.Text = klasa_ucznia;
				grupa_ucz2.Text = grupa_ucznia;
				plec_ucz2.Text = plec_ucznia;
			}
			 if (licznik_ucz == 3)
			{
				id_ucz3.Text = licznik_ucz + ".";
				imie_ucznia3 = imie_ucz.Text;
				imie_ucz3.Text =  imie_ucznia; 
				drugie_imie_ucz3.Text = drugie_imie_ucznia;
				nazwisko_ucz3.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz3.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz3.Text = imiona_rodzicow_ucznia;
				data_ur_ucz3.Text = data_urodzenia_ucznia;
				pesel_ucz3.Text = pesel_ucznia;
				klasa_ucz3.Text = klasa_ucznia;
				grupa_ucz3.Text = grupa_ucznia;
				plec_ucz3.Text = plec_ucznia;
			}
			 if (licznik_ucz == 4)
			{
				id_ucz4.Text = licznik_ucz + ".";
				imie_ucznia4 = imie_ucz.Text;
				imie_ucz4.Text =  imie_ucznia; 
				drugie_imie_ucz4.Text = drugie_imie_ucznia;
				nazwisko_ucz4.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz4.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz4.Text = imiona_rodzicow_ucznia;
				data_ur_ucz4.Text = data_urodzenia_ucznia;
				pesel_ucz4.Text = pesel_ucznia;
				klasa_ucz4.Text = klasa_ucznia;
				grupa_ucz4.Text = grupa_ucznia;
				plec_ucz4.Text = plec_ucznia;
			}
			 if (licznik_ucz == 5)
			{
				id_ucz5.Text = licznik_ucz + ".";
				imie_ucznia5 = imie_ucz.Text;
				imie_ucz5.Text = imie_ucznia;
				drugie_imie_ucz5.Text = drugie_imie_ucznia;
				nazwisko_ucz5.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz5.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz5.Text = imiona_rodzicow_ucznia;
				data_ur_ucz5.Text = data_urodzenia_ucznia;
				pesel_ucz5.Text = pesel_ucznia;
				klasa_ucz5.Text = klasa_ucznia;
				grupa_ucz5.Text = grupa_ucznia;
				plec_ucz5.Text = plec_ucznia;
			}
			if (licznik_ucz == 6)
			{
				id_ucz6.Text = licznik_ucz + ".";
				imie_ucznia6 = imie_ucz.Text;
				imie_ucz6.Text =  imie_ucznia;
				drugie_imie_ucz6.Text = drugie_imie_ucznia;
				nazwisko_ucz6.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz6.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz6.Text = imiona_rodzicow_ucznia;
				data_ur_ucz6.Text = data_urodzenia_ucznia;
				pesel_ucz6.Text = pesel_ucznia;
				klasa_ucz6.Text = klasa_ucznia;
				grupa_ucz6.Text = grupa_ucznia;
				plec_ucz6.Text = plec_ucznia;
			}
			if (licznik_ucz == 7)
			{
				id_ucz7.Text = licznik_ucz + ".";
				imie_ucznia7 = imie_ucz.Text;
				imie_ucz7.Text =  imie_ucznia;
				drugie_imie_ucz7.Text = drugie_imie_ucznia;
				nazwisko_ucz7.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz7.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz7.Text = imiona_rodzicow_ucznia;
				data_ur_ucz7.Text = data_urodzenia_ucznia;
				pesel_ucz7.Text = pesel_ucznia;
				klasa_ucz7.Text = klasa_ucznia;
				grupa_ucz7.Text = grupa_ucznia;
				plec_ucz7.Text = plec_ucznia;
			}
			if (licznik_ucz == 8)
			{
				id_ucz8.Text = licznik_ucz + ".";
				imie_ucznia8 = imie_ucz.Text;
				imie_ucz8.Text =  imie_ucznia;
				drugie_imie_ucz8.Text = drugie_imie_ucznia;
				nazwisko_ucz8.Text = nazwisko_ucznia;
				panienskie_nazwisko_ucz8.Text = nazwisko_panienskie_ucznia;
				imiona_rodzicow_ucz8.Text = imiona_rodzicow_ucznia;
				data_ur_ucz8.Text = data_urodzenia_ucznia;
				pesel_ucz8.Text = pesel_ucznia;
				klasa_ucz8.Text = klasa_ucznia;
				grupa_ucz8.Text = grupa_ucznia;
				plec_ucz8.Text = plec_ucznia;
			}


			MessageBox.Show("Dodano ucznia");
		}
		private void wyczysc_ucz_Click(object sender, RoutedEventArgs e)
		{
			imie_ucz.Text = "";
			nazwisko_ucz.Text = "";
			nazwisko_panienskie_ucz.Text = "";
			drugie_imie_ucz.Text = "";
			data_ur_ucz.Text = "";
			pesel_ucz.Text = "";
			imiona_rodzicow_ucz.Text = "";
			klasa_ucz.Text = "";
			//
		

		}
		private void TypeNumericValidation(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		private void PasteNumericValidation(object sender, DataObjectPastingEventArgs e)
		{
			if (e.DataObject.GetDataPresent(typeof(String)))
			{
				String input = (String)e.DataObject.GetData(typeof(String));
				if (new Regex("[^0-9]+").IsMatch(input))
				{
					e.CancelCommand();
				}
			}
			else e.CancelCommand();
		}

		private void usun_ucznia_Click(object sender, RoutedEventArgs e)
		{
			//int id_ucznia = (int)id_usuwanego.Text;

			if (id_usuwanego.Text=="")
            {
				MessageBox.Show("Podaj id");
            }
            else
            {
                if (id_usuwanego.Text == "1")
                {
					id_ucz1.Text = "";
					imie_ucz1.Text = "";
					drugie_imie_ucz1.Text = "";
					nazwisko_ucz1.Text = "";
					panienskie_nazwisko_ucz1.Text = "";
					imiona_rodzicow_ucz1.Text = "";
					data_ur_ucz1.Text = "";
					pesel_ucz1.Text = "";
					klasa_ucz1.Text = "";
					grupa_ucz1.Text = "";
					plec_ucz1.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "2")
				{
					id_ucz2.Text = "";
					imie_ucz2.Text = "";
					drugie_imie_ucz2.Text = "";
					nazwisko_ucz2.Text = "";
					panienskie_nazwisko_ucz2.Text = "";
					imiona_rodzicow_ucz2.Text = "";
					data_ur_ucz2.Text = "";
					pesel_ucz2.Text = "";
					klasa_ucz2.Text = "";
					grupa_ucz2.Text = "";
					plec_ucz2.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "3")
				{
					id_ucz3.Text = "";
					imie_ucz3.Text = "";
					drugie_imie_ucz3.Text = "";
					nazwisko_ucz3.Text = "";
					panienskie_nazwisko_ucz3.Text = "";
					imiona_rodzicow_ucz3.Text = "";
					data_ur_ucz3.Text = "";
					pesel_ucz3.Text = "";
					klasa_ucz3.Text = "";
					grupa_ucz3.Text = "";
					plec_ucz3.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "4")
				{
					id_ucz4.Text = "";
					imie_ucz4.Text = "";
					drugie_imie_ucz4.Text = "";
					nazwisko_ucz4.Text = "";
					panienskie_nazwisko_ucz4.Text = "";
					imiona_rodzicow_ucz4.Text = "";
					data_ur_ucz4.Text = "";
					pesel_ucz4.Text = "";
					klasa_ucz4.Text = "";
					grupa_ucz4.Text = "";
					plec_ucz4.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "5")
				{
					id_ucz5.Text = "";
					imie_ucz5.Text = "";
					drugie_imie_ucz5.Text = "";
					nazwisko_ucz5.Text = "";
					panienskie_nazwisko_ucz5.Text = "";
					imiona_rodzicow_ucz5.Text = "";
					data_ur_ucz5.Text = "";
					pesel_ucz5.Text = "";
					klasa_ucz5.Text = "";
					grupa_ucz5.Text = "";
					plec_ucz5.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "6")
				{
					id_ucz6.Text ="";
					imie_ucz6.Text = "";
					drugie_imie_ucz6.Text = "";
					nazwisko_ucz6.Text = "";
					panienskie_nazwisko_ucz6.Text = "";
					imiona_rodzicow_ucz6.Text = "";
					data_ur_ucz6.Text = "";
					pesel_ucz6.Text = "";
					klasa_ucz6.Text = "";
					grupa_ucz6.Text = "";
					plec_ucz6.Text = "";
					licznik_ucz--;
				}
				else if (id_usuwanego.Text == "7")
				{
					id_ucz7.Text = "";
					imie_ucz7.Text = "";
					drugie_imie_ucz7.Text = "";
					nazwisko_ucz7.Text = "";
					panienskie_nazwisko_ucz7.Text = "";
					imiona_rodzicow_ucz7.Text = "";
					data_ur_ucz7.Text = "";
					pesel_ucz7.Text = "";
					klasa_ucz7.Text = "";
					grupa_ucz7.Text = "";
					plec_ucz7.Text = "";
					licznik_ucz--;
				}
			}
		}
			private void wyczysc_prac_Click(object sender, RoutedEventArgs e)
		{
			
			imie_prac.Text = "";
			drugie_imie_prac.Text = "";
			nazwisko_prac1.Text = "";
			nazwisko_panienskie_prac.Text = "";
			imiona_rodzicow_prac1.Text = "";
			data_ur_prac.Text = "";
			pesel_prac.Text = "";
			etat_prac.Text = "";
			stanowisko_prac.Text = "";
			data_zatr_prac.Text = "";
			
			
		}
		private void dodaj_prac_Click(object sender, RoutedEventArgs e)
		{
			licznik_pracownika++;

			Boolean jaka_plec_pracownika1 = (bool)meszczyzna_prac.IsChecked;
			Boolean jaka_plec_pracownika2 = (bool)kobieta_prac.IsChecked;
			if (jaka_plec_pracownika1 == true)
			{
				plec_pracownika = "Mężczyzna";

			}
			else if (jaka_plec_pracownika2 == true)
			{
				plec_pracownika = "Kobieta";
			}


			String imie_pracownika = imie_prac.Text;
			String nazwisko_pracownika = nazwisko_prac.Text;
			String drugie_imie_pracownika = drugie_imie_prac.Text;
			String data_urodzenia_pracownika = data_ur_prac.Text;
			String pesel_pracownika = pesel_prac.Text;
			String nazwisko_panienskie_pracownika = nazwisko_panienskie_prac.Text;
			String imiona_rodzicow_pracownika = imiona_rodzicow_prac.Text;
			String etat_pracownika = etat_prac.Text;
			String opis_stanowiska = stanowisko_prac.Text;
			String data_zatr_pracownika = data_zatr_prac.Text;

			if (licznik_pracownika == 1)
			{
				id_prac1.Text = licznik_pracownika + ".";
				imie_pracownika1 = imie_prac.Text;
				imie_prac1.Text =  imie_pracownika;
				drugie_imie_prac1.Text = drugie_imie_pracownika;
				nazwisko_prac1.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac1.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac1.Text = imiona_rodzicow_pracownika;
				data_ur_prac1.Text = data_urodzenia_pracownika;
				pesel_prac1.Text = pesel_pracownika;
				plec_prac1.Text = plec_pracownika;
				etat_prac1.Text = etat_pracownika;
				stanowisk_prac1.Text = opis_stanowiska;
				data_zatr_prac1.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 2)
			{
				id_prac2.Text = licznik_pracownika + ".";
				imie_pracownika2 = imie_prac.Text;
				imie_prac2.Text =  imie_pracownika;
				drugie_imie_prac2.Text = drugie_imie_pracownika;
				nazwisko_prac2.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac2.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac2.Text = imiona_rodzicow_pracownika;
				data_ur_prac2.Text = data_urodzenia_pracownika;
				pesel_prac2.Text = pesel_pracownika;
				plec_prac2.Text = plec_pracownika;
				etat_prac2.Text = etat_pracownika;
				stanowisk_prac2.Text = opis_stanowiska;
				data_zatr_prac2.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 3)
			{
				id_prac3.Text = licznik_pracownika + ".";
				imie_pracownika3 = imie_prac.Text;
				imie_prac3.Text = imie_pracownika;
				drugie_imie_prac3.Text = drugie_imie_pracownika;
				nazwisko_prac3.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac3.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac3.Text = imiona_rodzicow_pracownika;
				data_ur_prac3.Text = data_urodzenia_pracownika;
				pesel_prac3.Text = pesel_pracownika;
				plec_prac3.Text = plec_pracownika;
				etat_prac3.Text = etat_pracownika;
				stanowisk_prac3.Text = opis_stanowiska;
				data_zatr_prac3.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 4)
			{
				id_prac4.Text = licznik_pracownika + ".";
				imie_pracownika4 = imie_prac.Text;
				imie_prac4.Text =  imie_pracownika;
				drugie_imie_prac4.Text = drugie_imie_pracownika;
				nazwisko_prac4.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac4.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac4.Text = imiona_rodzicow_pracownika;
				data_ur_prac4.Text = data_urodzenia_pracownika;
				pesel_prac4.Text = pesel_pracownika;
				plec_prac4.Text = plec_pracownika;
				etat_prac4.Text = etat_pracownika;
				stanowisk_prac4.Text = opis_stanowiska;
				data_zatr_prac4.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 5)
			{
				id_prac5.Text = licznik_pracownika + ".";
				imie_pracownika5 = imie_prac.Text;
				imie_prac5.Text = imie_pracownika;
				drugie_imie_prac5.Text = drugie_imie_pracownika;
				nazwisko_prac5.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac5.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac5.Text = imiona_rodzicow_pracownika;
				data_ur_prac5.Text = data_urodzenia_pracownika;
				pesel_prac5.Text = pesel_pracownika;
				plec_prac5.Text = plec_pracownika;
				etat_prac5.Text = etat_pracownika;
				stanowisk_prac5.Text = opis_stanowiska;
				data_zatr_prac5.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 6)
			{
				id_prac6.Text = licznik_pracownika + ".";
				imie_pracownika6 = imie_prac.Text;
				imie_prac6.Text = imie_pracownika;
				drugie_imie_prac6.Text = drugie_imie_pracownika;
				nazwisko_prac6.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac6.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac6.Text = imiona_rodzicow_pracownika;
				data_ur_prac6.Text = data_urodzenia_pracownika;
				pesel_prac6.Text = pesel_pracownika;
				plec_prac6.Text = plec_pracownika;
				etat_prac6.Text = etat_pracownika;
				stanowisk_prac6.Text = opis_stanowiska;
				data_zatr_prac6.Text = data_zatr_pracownika;

			}
			if (licznik_pracownika == 7)
			{
				id_prac7.Text = licznik_pracownika + ".";
				imie_pracownika7 = imie_prac.Text;
				imie_prac7.Text =  imie_pracownika;
				drugie_imie_prac7.Text = drugie_imie_pracownika;
				nazwisko_prac7.Text = nazwisko_pracownika;
				panienskie_nazwisko_prac7.Text = nazwisko_panienskie_pracownika;
				imiona_rodzicow_prac7.Text = imiona_rodzicow_pracownika;
				data_ur_prac7.Text = data_urodzenia_pracownika;
				pesel_prac7.Text = pesel_pracownika;
				plec_prac7.Text = plec_pracownika;
				etat_prac7.Text = etat_pracownika;
				stanowisk_prac7.Text = opis_stanowiska;
				data_zatr_prac7.Text = data_zatr_pracownika;

			}




			MessageBox.Show("Dodano pracownika");
		}
		private void usun_prac_Click(object sender, RoutedEventArgs e)
		{
			//int id_ucznia = (int)id_usuwanego.Text;

			if (id_usuwanego_prac.Text == "")
			{
				MessageBox.Show("Podaj id");
			}
			else
			{
				if (id_usuwanego_prac.Text == "1")
				{
					id_prac1.Text = "";
					imie_prac1.Text ="";
					drugie_imie_prac1.Text = "";
					nazwisko_prac1.Text = "";
					panienskie_nazwisko_prac1.Text = "";
					imiona_rodzicow_prac1.Text = "";
					data_ur_prac1.Text = "";
					pesel_prac1.Text = "";
					plec_prac1.Text = "";
					etat_prac1.Text = "";
					stanowisk_prac1.Text = "";
					data_zatr_prac1.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "2")
				{
					id_prac2.Text = "";
					imie_prac2.Text = "";
					drugie_imie_prac2.Text = "";
					nazwisko_prac2.Text = "";
					panienskie_nazwisko_prac2.Text = "";
					imiona_rodzicow_prac2.Text = "";
					data_ur_prac2.Text = "";
					pesel_prac2.Text = "";
					plec_prac2.Text = "";
					etat_prac2.Text = "";
					stanowisk_prac2.Text = "";
					data_zatr_prac2.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "3")
				{
					id_prac2.Text = "";
					imie_prac3.Text = "";
					drugie_imie_prac3.Text = "";
					nazwisko_prac3.Text = "";
					panienskie_nazwisko_prac3.Text = "";
					imiona_rodzicow_prac3.Text = "";
					data_ur_prac3.Text = "";
					pesel_prac3.Text = "";
					plec_prac3.Text = "";
					etat_prac3.Text = "";
					stanowisk_prac3.Text = "";
					data_zatr_prac3.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "4")
				{
					id_prac4.Text = "";
					imie_prac4.Text = "";
					drugie_imie_prac4.Text = "";
					nazwisko_prac4.Text = "";
					panienskie_nazwisko_prac4.Text = "";
					imiona_rodzicow_prac4.Text = "";
					data_ur_prac4.Text = "";
					pesel_prac4.Text = "";
					plec_prac4.Text = "";
					etat_prac4.Text = "";
					stanowisk_prac4.Text = "";
					data_zatr_prac4.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "5")
				{
					id_prac5.Text = "";
					imie_prac5.Text = "";
					drugie_imie_prac5.Text = "";
					nazwisko_prac5.Text = "";
					panienskie_nazwisko_prac5.Text = "";
					imiona_rodzicow_prac5.Text = "";
					data_ur_prac5.Text = "";
					pesel_prac5.Text = "";
					plec_prac5.Text = "";
					etat_prac5.Text = "";
					stanowisk_prac5.Text = "";
					data_zatr_prac5.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "6")
				{
					id_prac6.Text = "";
					imie_prac6.Text = "";
					drugie_imie_prac6.Text = "";
					nazwisko_prac6.Text = "";
					panienskie_nazwisko_prac6.Text = "";
					imiona_rodzicow_prac6.Text = "";
					data_ur_prac6.Text = "";
					pesel_prac6.Text = "";
					plec_prac6.Text = "";
					etat_prac6.Text = "";
					stanowisk_prac6.Text = "";
					data_zatr_prac6.Text = "";
					licznik_pracownika--;
				}
				else if (id_usuwanego_prac.Text == "7")
				{
					id_prac7.Text = "";
					imie_prac7.Text = "";
					drugie_imie_prac7.Text = "";
					nazwisko_prac7.Text = "";
					panienskie_nazwisko_prac7.Text = "";
					imiona_rodzicow_prac7.Text = "";
					data_ur_prac7.Text = "";
					pesel_prac7.Text = "";
					plec_prac7.Text = "";
					etat_prac7.Text = "";
					stanowisk_prac7.Text = "";
					data_zatr_prac7.Text = "";
					licznik_pracownika--;
				}
			}
		}


		private void wyczysc_naucz_Click(object sender, RoutedEventArgs e)
		{
			imie_prac.Text = "";
			drugie_imie_prac.Text = "";
			nazwisko_prac.Text = "";
			nazwisko_panienskie_prac.Text = "";
			imiona_rodzicow_prac.Text = "";
			data_ur_prac.Text = "";
			pesel_prac.Text = "";
			
			wychowawstwo_naucz.Text = "";
			
			data_zatr_naucz.Text = "";


		}
		private void dodaj_naucz_Click(object sender, RoutedEventArgs e)
		{
			licznik_naucz++;

			Boolean jaka_plec_nauczyciela1 = (bool)meszczyzna_naucz.IsChecked;
			Boolean jaka_plec_nauczyciela2 = (bool)kobieta_naucz.IsChecked;
			if (jaka_plec_nauczyciela1 == true)
			{
				plec_nauczyciela = "Mężczyzna";

			}
			else if (jaka_plec_nauczyciela2 == true)
			{
				plec_nauczyciela = "Kobieta";
			}
			

			String imie_nauczyciela = imie_naucz.Text;
			String nazwisko_nauczyciela = nazwisko_naucz.Text;
			String drugie_imie_nauczyciela = drugie_imie_naucz.Text;
			String data_urodzenia_nauczyciela = data_ur_naucz.Text;
			String pesel_nauczyciela = pesel_naucz.Text;
			String nazwisko_panienskie_nauczyciela = nazwisko_panienskie_naucz.Text;
			String imiona_rodzicow_nauczyciela = imiona_rodzicow_naucz.Text;
			
			String wychowawstwo_nauczyciela = wychowawstwo_naucz.Text;
			String przedmioty_nauczane = przedmioty_naucz.Text;
			String data_zatr_nauczyciela = data_zatr_naucz.Text;

			if (licznik_naucz == 1)
			{
				id_naucz1.Text = licznik_naucz + ".";
				imie_nauczyciela1 = imie_naucz.Text;
				imie_naucz1.Text = imie_nauczyciela;
				drugie_imie_naucz1.Text = drugie_imie_nauczyciela;
				nazwisko_naucz1.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz1.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz1.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz1.Text = data_urodzenia_nauczyciela;
				pesel_naucz1.Text = pesel_nauczyciela;
				plec_naucz1.Text = plec_nauczyciela;
				
				wychowawstwo_naucz1.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz1.Text = przedmioty_nauczane;
				data_zatr_naucz1.Text = data_zatr_nauczyciela;

			}
			if (licznik_naucz == 2)
			{
				id_naucz2.Text = licznik_naucz + ".";
				imie_nauczyciela2 = imie_naucz.Text;
				imie_naucz2.Text =   imie_nauczyciela;
				drugie_imie_naucz2.Text = drugie_imie_nauczyciela;
				nazwisko_naucz2.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz2.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz2.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz2.Text = data_urodzenia_nauczyciela;
				pesel_naucz2.Text = pesel_nauczyciela;
				plec_naucz2.Text = plec_nauczyciela;
				wychowawstwo_naucz2.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz2.Text = przedmioty_nauczane;
				data_zatr_naucz2.Text = data_zatr_nauczyciela;
		}
			if (licznik_naucz == 3)
			{
				id_naucz3.Text = licznik_naucz + ".";
				imie_nauczyciela3 = imie_naucz.Text;
				imie_naucz3.Text =imie_nauczyciela;
				drugie_imie_naucz3.Text = drugie_imie_nauczyciela;
				nazwisko_naucz3.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz3.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz3.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz3.Text = data_urodzenia_nauczyciela;
				pesel_naucz3.Text = pesel_nauczyciela;
				plec_naucz3.Text = plec_nauczyciela;
				wychowawstwo_naucz3.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz3.Text = przedmioty_nauczane;
				data_zatr_naucz3.Text = data_zatr_nauczyciela;
			}
			if (licznik_naucz == 4)
			{
				id_naucz4.Text = licznik_naucz + ".";
				imie_nauczyciela4 = imie_naucz.Text;
				imie_naucz4.Text = imie_nauczyciela;
				drugie_imie_naucz4.Text = drugie_imie_nauczyciela;
				nazwisko_naucz4.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz4.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz4.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz4.Text = data_urodzenia_nauczyciela;
				pesel_naucz4.Text = pesel_nauczyciela;
				plec_naucz4.Text = plec_nauczyciela;
				wychowawstwo_naucz4.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz4.Text = przedmioty_nauczane;
				data_zatr_naucz4.Text = data_zatr_nauczyciela;
			}
			if (licznik_naucz == 5)
			{
				id_naucz5.Text = licznik_naucz + ".";
				imie_nauczyciela5 = imie_naucz.Text;
				imie_naucz5.Text = imie_nauczyciela;
				drugie_imie_naucz5.Text = drugie_imie_nauczyciela;
				nazwisko_naucz5.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz5.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz5.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz5.Text = data_urodzenia_nauczyciela;
				pesel_naucz5.Text = pesel_nauczyciela;
				plec_naucz5.Text = plec_nauczyciela;
				wychowawstwo_naucz5.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz5.Text = przedmioty_nauczane;
				data_zatr_naucz5.Text = data_zatr_nauczyciela;
			}
			if (licznik_naucz == 6)
			{
				id_naucz6.Text = licznik_naucz + ".";
				imie_nauczyciela6 = imie_naucz.Text;
				imie_naucz6.Text =imie_nauczyciela;
				drugie_imie_naucz6.Text = drugie_imie_nauczyciela;
				nazwisko_naucz6.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz6.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz6.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz6.Text = data_urodzenia_nauczyciela;
				pesel_naucz6.Text = pesel_nauczyciela;
				plec_naucz6.Text = plec_nauczyciela;
				wychowawstwo_naucz6.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz6.Text = przedmioty_nauczane;
				data_zatr_naucz6.Text = data_zatr_nauczyciela;
			}
			if (licznik_naucz == 7)
			{
				id_naucz7.Text = licznik_naucz + ".";
				imie_nauczyciela7 = imie_naucz.Text;
				imie_naucz7.Text = imie_nauczyciela;
				drugie_imie_naucz7.Text = drugie_imie_nauczyciela;
				nazwisko_naucz7.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz7.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz7.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz7.Text = data_urodzenia_nauczyciela;
				pesel_naucz7.Text = pesel_nauczyciela;
				plec_naucz7.Text = plec_nauczyciela;
				wychowawstwo_naucz7.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz7.Text = przedmioty_nauczane;
				data_zatr_naucz7.Text = data_zatr_nauczyciela;
			}
			if (licznik_naucz == 8)
			{
				id_naucz8.Text = licznik_naucz + ".";
				imie_nauczyciela8 = imie_naucz.Text;
				imie_naucz8.Text = imie_nauczyciela;
				drugie_imie_naucz8.Text = drugie_imie_nauczyciela;
				nazwisko_naucz8.Text = nazwisko_nauczyciela;
				panienskie_nazwisko_naucz8.Text = nazwisko_panienskie_nauczyciela;
				imiona_rodzicow_naucz8.Text = imiona_rodzicow_nauczyciela;
				data_ur_naucz8.Text = data_urodzenia_nauczyciela;
				pesel_naucz8.Text = pesel_nauczyciela;
				plec_naucz8.Text = plec_nauczyciela;
				wychowawstwo_naucz8.Text = wychowawstwo_nauczyciela;
				przedm_nauczane_naucz8.Text = przedmioty_nauczane;
				data_zatr_naucz8.Text = data_zatr_nauczyciela;
			}



			MessageBox.Show("Dodano nauczyciela");
		}
		private void usun_naucz_Click(object sender, RoutedEventArgs e)
		{
			

			if (id_usuwanego_naucz.Text == "")
			{
				MessageBox.Show("Podaj id");
			}
			else
			{
				if (id_usuwanego_naucz.Text == "1")
				{
					id_naucz1.Text = "";
					imie_naucz1.Text = "";
					drugie_imie_naucz1.Text = "";
					nazwisko_naucz1.Text = "";
					panienskie_nazwisko_naucz1.Text = "";
					imiona_rodzicow_naucz1.Text = "";
					data_ur_naucz1.Text = "";
					pesel_naucz1.Text = "";
					plec_naucz1.Text = "";
					wychowawstwo_naucz1.Text = "";
					przedm_nauczane_naucz1.Text = "";
					data_zatr_naucz1.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "2")
				{
					id_naucz2.Text = "";
					imie_naucz2.Text = "";
					drugie_imie_naucz2.Text = "";
					nazwisko_naucz2.Text = "";
					panienskie_nazwisko_naucz2.Text = "";
					imiona_rodzicow_naucz2.Text = "";
					data_ur_naucz2.Text = "";
					pesel_naucz2.Text = "";
					plec_naucz2.Text = "";
					wychowawstwo_naucz2.Text = "";
					przedm_nauczane_naucz2.Text = "";
					data_zatr_naucz2.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "3")
				{
					id_naucz3.Text = "";
					imie_naucz3.Text = "";
					drugie_imie_naucz3.Text = "";
					nazwisko_naucz3.Text = "";
					panienskie_nazwisko_naucz3.Text = "";
					imiona_rodzicow_naucz3.Text = "";
					data_ur_naucz3.Text = "";
					pesel_naucz3.Text = "";
					plec_naucz3.Text = "";
					wychowawstwo_naucz3.Text = "";
					przedm_nauczane_naucz3.Text = "";
					data_zatr_naucz3.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "4")
				{
					id_naucz4.Text = "";
					imie_naucz4.Text = "";
					drugie_imie_naucz4.Text = "";
					nazwisko_naucz4.Text = "";
					panienskie_nazwisko_naucz4.Text = "";
					imiona_rodzicow_naucz4.Text = "";
					data_ur_naucz4.Text = "";
					pesel_naucz4.Text = "";
					plec_naucz4.Text = "";
					wychowawstwo_naucz4.Text = "";
					przedm_nauczane_naucz4.Text = "";
					data_zatr_naucz4.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "5")
				{
					id_naucz5.Text = "";
					imie_naucz5.Text = "";
					drugie_imie_naucz5.Text = "";
					nazwisko_naucz5.Text = "";
					panienskie_nazwisko_naucz5.Text = "";
					imiona_rodzicow_naucz5.Text = "";
					data_ur_naucz5.Text = "";
					pesel_naucz5.Text = "";
					plec_naucz5.Text = "";
					wychowawstwo_naucz5.Text = "";
					przedm_nauczane_naucz5.Text = "";
					data_zatr_naucz5.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "6")
				{
					id_naucz6.Text = "";
					imie_naucz6.Text = "";
					drugie_imie_naucz6.Text = "";
					nazwisko_naucz6.Text = "";
					panienskie_nazwisko_naucz6.Text = "";
					imiona_rodzicow_naucz6.Text = "";
					data_ur_naucz6.Text = "";
					pesel_naucz6.Text = "";
					plec_naucz6.Text = "";
					wychowawstwo_naucz6.Text = "";
					przedm_nauczane_naucz6.Text = "";
					data_zatr_naucz6.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "7")
				{
					id_naucz7.Text = "";
					imie_naucz7.Text = "";
					drugie_imie_naucz7.Text = "";
					nazwisko_naucz7.Text = "";
					panienskie_nazwisko_naucz7.Text = "";
					imiona_rodzicow_naucz7.Text = "";
					data_ur_naucz7.Text = "";
					pesel_naucz7.Text = "";
					plec_naucz7.Text = "";
					wychowawstwo_naucz7.Text = "";
					przedm_nauczane_naucz7.Text = "";
					data_zatr_naucz7.Text = "";
					licznik_naucz--;
				}
				else if (id_usuwanego_naucz.Text == "8")
				{
					id_naucz8.Text = "";
					imie_naucz8.Text = "";
					drugie_imie_naucz8.Text = "";
					nazwisko_naucz8.Text = "";
					panienskie_nazwisko_naucz8.Text = "";
					imiona_rodzicow_naucz8.Text = "";
					data_ur_naucz8.Text = "";
					pesel_naucz8.Text = "";
					plec_naucz8.Text = "";
					wychowawstwo_naucz8.Text = "";
					przedm_nauczane_naucz8.Text = "";
					data_zatr_naucz8.Text = "";
					licznik_naucz--;
				}
			}
		}
		
		private void szukaj(object sender, RoutedEventArgs e)
		{
			 co_wyszuk1 = (bool)uczen_szuk.IsChecked;
			 co_wyszuk2 = (bool)naucz_szuk.IsChecked;
			 co_wyszuk3 = (bool)prac_szuk.IsChecked;
			if (co_wyszuk1 == true)
			{
				lista_ucz.Visibility = Visibility.Visible;
				pole_szuk.Visibility = Visibility.Visible;

			}
			else if (co_wyszuk2 == true)
			{
				lista_naucz.Visibility = Visibility.Visible;
				pole_szuk.Visibility = Visibility.Visible;
			}
			else if (co_wyszuk3 == true)
			{
				lista_prac.Visibility = Visibility.Visible;
				pole_szuk.Visibility = Visibility.Visible;
			}
		}
		private void pokaz_raport(object sender, RoutedEventArgs e)
		{
			int newIndex = tabcontrol.SelectedIndex + 1;
			if (newIndex >= tabcontrol.Items.Count)
				newIndex = 0;
			tabcontrol.SelectedIndex = newIndex;
			raport1.Text = "";
			raport2.Text = "";
			raport3.Text = "";
			raport4.Text = "";
			raport5.Text = "";

			String klucz_wyszukiwania = pole_szuk.Text;
			Boolean imie_ucznia_szuk = szuk_imie_ucz.IsSelected;
			Boolean drugie_imie_ucznia_szuk = szuk_drugie_imie_ucz.IsSelected;
			Boolean nawisko_ucznia_szuk = szuk_nazwisko_ucz.IsSelected;
			Boolean nawisko_panienskie_ucznia_szuk = szuk_nazwisko_panienskie_ucz.IsSelected;
			Boolean imiona_rodz_ucznia_szuk = szuk_imiona_rodzicow_ucz.IsSelected;
			Boolean data_ur_ucznia_szuk = szuk_data_ur_ucz.IsSelected;
			Boolean pesel_ucznia_szuk = szuk_pesel_ucz.IsSelected;
			Boolean plec_ucznia_szuk = szuk_plec_ucz.IsSelected;
			Boolean klasa_ucznia_szuk = szuk_klasa_ucz.IsSelected;
			Boolean grupa_ucznia_szuk = szuk_grupa_ucz.IsSelected;

			Boolean imie_nauczyciela_szuk = szuk_imie_naucz.IsSelected;
			Boolean drugie_imie_nauczyciela_szuk = szuk_drugie_imie_naucz.IsSelected;
			Boolean nawisko_nauczyciela_szuk = szuk_nazwisko_naucz.IsSelected;
			Boolean nawisko_panienskie_nauczyciela_szuk = szuk_nazwisko_panienskie_naucz.IsSelected;
			Boolean imiona_rodz_nauczyciela_szuk = szuk_imiona_rodzicow_naucz.IsSelected;
			Boolean data_ur_nauczyciela_szuk = szuk_data_ur_naucz.IsSelected;
			Boolean pesel_nauczuciela_szuk = szuk_pesel_naucz.IsSelected;
			Boolean plec_nauczyciela_szuk = szuk_plec_naucz.IsSelected;
			Boolean wychowawstwo_nauczyciela_szuk = szuk_wychowawstwo_naucz.IsSelected;
			Boolean klasy_naczyciela_szuk = szuk_klasy_naucz.IsSelected;
			Boolean przedmioty_nauczane_szuk = szuk_przedmioty_naucz.IsSelected;
			Boolean data_zatr_nauczzyciela_szuk = szuk_data_zatr_naucz.IsSelected;


			Boolean imie_pracownika_szuk = szuk_imie_prac.IsSelected;
			Boolean drugie_imie_pracownika_szuk = szuk_drugie_imie_prac.IsSelected;
			Boolean nawisko_pracownika_szuk = szuk_nazwisko_prac.IsSelected;
			Boolean nawisko_panienskie_pracownika_szuk = szuk_nazwisko_panienskie_prac.IsSelected;
			Boolean imiona_rodz_pracownika_szuk = szuk_imiona_rodzicow_prac.IsSelected;
			Boolean pesel_pracownika_szuk = szuk_pesel_prac.IsSelected;
			Boolean data_ur_pracownika_szuk = szuk_data_ur_prac.IsSelected;
			Boolean plec_pracownika_szuk = szuk_plec_prac.IsSelected;
			Boolean stanowisko_pracownika_szuk = szuk_stanowisko_prac.IsSelected;
			Boolean etat_pracownika_szuk = szuk_etat_prac.IsSelected;
			Boolean data_zatr_pracownika_szuk = szuk_data_zatr_prac.IsSelected;

			if (co_wyszuk1 == true)
			{

				if (imie_ucznia_szuk == true)
				{
					if (imie_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (imie_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (imie_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (imie_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (imie_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (drugie_imie_ucznia_szuk == true)
				{
					if (drugie_imie_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (drugie_imie_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (drugie_imie_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (drugie_imie_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (drugie_imie_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (nawisko_ucznia_szuk == true)
				{
					if (nazwisko_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (nazwisko_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (nazwisko_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (nazwisko_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (nazwisko_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (nawisko_panienskie_ucznia_szuk == true)
				{
					if (panienskie_nazwisko_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (panienskie_nazwisko_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (panienskie_nazwisko_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (panienskie_nazwisko_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (panienskie_nazwisko_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (imiona_rodz_ucznia_szuk == true)
				{
					if (imiona_rodzicow_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (imiona_rodzicow_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (imiona_rodzicow_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (imiona_rodzicow_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (imiona_rodzicow_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}

				}
				else if (data_ur_ucznia_szuk == true)
				{
					if (data_ur_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (imiona_rodzicow_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (data_ur_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (data_ur_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (data_ur_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
					}
				else if (pesel_ucznia_szuk == true)
				{
					if (pesel_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (pesel_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (pesel_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (pesel_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (pesel_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
					}
				else if (plec_ucznia_szuk == true)
				{
					if (plec_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (plec_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (plec_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (plec_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (plec_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (klasa_ucznia_szuk == true)
				{
					if (klasa_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (klasa_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (klasa_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (klasa_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (klasa_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}
				else if (grupa_ucznia_szuk == true)
				{
					if (grupa_ucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_ucz1.Text + "|" + drugie_imie_ucz1.Text + "|" + nazwisko_ucz1.Text + "|"
						+ panienskie_nazwisko_ucz1.Text + "|" + imiona_rodzicow_ucz1.Text + "|" + data_ur_ucz1.Text + "|" + pesel_ucz1.Text +
						"|" + plec_ucz1.Text + "|" + klasa_ucz1.Text + "|" + grupa_ucz1.Text;
					}

					if (grupa_ucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_ucz2.Text + "|" + drugie_imie_ucz2.Text + "|" + nazwisko_ucz2.Text + "|"
						+ panienskie_nazwisko_ucz2.Text + "|" + imiona_rodzicow_ucz2.Text + "|" + data_ur_ucz2.Text + "|" + pesel_ucz2.Text +
						"|" + plec_ucz2.Text + "|" + klasa_ucz2.Text + "|" + grupa_ucz2.Text;

					}

					if (klasa_ucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_ucz1.Text + "|" + drugie_imie_ucz3.Text + "|" + nazwisko_ucz3.Text + "|"
						+ panienskie_nazwisko_ucz3.Text + "|" + imiona_rodzicow_ucz3.Text + "|" + data_ur_ucz3.Text + "|" + pesel_ucz3.Text +
						"|" + plec_ucz3.Text + "|" + klasa_ucz3.Text + "|" + grupa_ucz3.Text;
					}

					if (grupa_ucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_ucz4.Text + "|" + drugie_imie_ucz4.Text + "|" + nazwisko_ucz4.Text + "|"
						+ panienskie_nazwisko_ucz4.Text + "|" + imiona_rodzicow_ucz4.Text + "|" + data_ur_ucz4.Text + "|" + pesel_ucz4.Text +
						"|" + plec_ucz4.Text + "|" + klasa_ucz4.Text + "|" + grupa_ucz4.Text;
					}

					if (grupa_ucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_ucz5.Text + "|" + drugie_imie_ucz5.Text + "|" + nazwisko_ucz5.Text + "|"
						+ panienskie_nazwisko_ucz5.Text + "|" + imiona_rodzicow_ucz5.Text + "|" + data_ur_ucz5.Text + "|" + pesel_ucz5.Text +
						"|" + plec_ucz5.Text + "|" + klasa_ucz5.Text + "|" + grupa_ucz5.Text;
					}
				}

				{

                }
			}
			else if (co_wyszuk2==true)
            {
				/*
				 imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1
						+ "\n" + imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2
						+ "\n" + imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3
						+ "\n" + imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4
						+ "\n" + imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5
				 */
				if (imie_nauczyciela_szuk == true)
				{
					if (imie_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (imie_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (imie_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (imie_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (imie_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (drugie_imie_nauczyciela_szuk == true)
				{
					if (drugie_imie_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (drugie_imie_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (drugie_imie_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (drugie_imie_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (drugie_imie_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (nawisko_nauczyciela_szuk == true)
				{
					if (nazwisko_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (nazwisko_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (nazwisko_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (nazwisko_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (nazwisko_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (nawisko_panienskie_nauczyciela_szuk == true)
				{
					if (panienskie_nazwisko_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (panienskie_nazwisko_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (panienskie_nazwisko_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (panienskie_nazwisko_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (panienskie_nazwisko_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (imiona_rodz_nauczyciela_szuk == true)
				{
					if (imiona_rodzicow_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (imiona_rodzicow_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (imiona_rodzicow_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (imiona_rodzicow_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (imiona_rodzicow_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}

				}
				else if (data_ur_nauczyciela_szuk == true)
				{
					if (data_ur_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (data_ur_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (data_ur_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (data_ur_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (data_ur_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (pesel_nauczuciela_szuk == true)

				{
					if (pesel_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (pesel_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (pesel_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (pesel_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (pesel_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (plec_nauczyciela_szuk == true)
				{
					if (plec_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (plec_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (plec_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (plec_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (plec_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (wychowawstwo_nauczyciela_szuk == true)
				{
					if (wychowawstwo_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (wychowawstwo_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (wychowawstwo_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (wychowawstwo_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (wychowawstwo_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (przedmioty_nauczane_szuk == true)
				{
					if (przedm_nauczane_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (przedm_nauczane_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (przedm_nauczane_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (przedm_nauczane_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (przedm_nauczane_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (klasy_naczyciela_szuk == true)
				{
					if (klasy_nauczane_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (klasy_nauczane_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (klasy_nauczane_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (klasy_nauczane_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (klasy_nauczane_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				else if (data_zatr_nauczzyciela_szuk == true)
				{
					if (data_zatr_naucz1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_naucz1.Text + "|" + drugie_imie_naucz1.Text + "|" + nazwisko_naucz1.Text + "|"
						+ panienskie_nazwisko_naucz1.Text + "|" + imiona_rodzicow_naucz1.Text + "|" + data_ur_naucz1.Text + "|" + pesel_naucz1.Text + "|" + plec_naucz1.Text +
						"|" + wychowawstwo_naucz1.Text + "|" + przedm_nauczane_naucz1.Text + "|" + klasy_nauczane_naucz1.Text + "|" + data_zatr_naucz1;
					}

					if (data_zatr_naucz2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_naucz2.Text + "|" + drugie_imie_naucz2.Text + "|" + nazwisko_naucz2.Text + "|"
						+ panienskie_nazwisko_naucz2.Text + "|" + imiona_rodzicow_naucz2.Text + "|" + data_ur_naucz2.Text + "|" + pesel_naucz2.Text + "|" + plec_naucz2.Text +
						"|" + wychowawstwo_naucz2.Text + "|" + przedm_nauczane_naucz2.Text + "|" + klasy_nauczane_naucz2.Text + "|" + data_zatr_naucz2;

					}

					if (data_zatr_naucz3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_naucz3.Text + "|" + drugie_imie_naucz3.Text + "|" + nazwisko_naucz3.Text + "|"
						+ panienskie_nazwisko_naucz3.Text + "|" + imiona_rodzicow_naucz3.Text + "|" + data_ur_naucz3.Text + "|" + pesel_naucz3.Text + "|" + plec_naucz3.Text +
						"|" + wychowawstwo_naucz3.Text + "|" + przedm_nauczane_naucz3.Text + "|" + klasy_nauczane_naucz3.Text + "|" + data_zatr_naucz3;
					}

					if (data_zatr_naucz4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_naucz4.Text + "|" + drugie_imie_naucz4.Text + "|" + nazwisko_naucz4.Text + "|"
						+ panienskie_nazwisko_naucz4.Text + "|" + imiona_rodzicow_naucz4.Text + "|" + data_ur_naucz4.Text + "|" + pesel_naucz4.Text + "|" + plec_naucz4.Text +
						"|" + wychowawstwo_naucz4.Text + "|" + przedm_nauczane_naucz4.Text + "|" + klasy_nauczane_naucz4.Text + "|" + data_zatr_naucz4;
					}

					if (data_zatr_naucz5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_naucz5.Text + "|" + drugie_imie_naucz5.Text + "|" + nazwisko_naucz5.Text + "|"
						+ panienskie_nazwisko_naucz5.Text + "|" + imiona_rodzicow_naucz5.Text + "|" + data_ur_naucz5.Text + "|" + pesel_naucz5.Text + "|" + plec_naucz5.Text +
						"|" + wychowawstwo_naucz5.Text + "|" + przedm_nauczane_naucz5.Text + "|" + klasy_nauczane_naucz5.Text + "|" + data_zatr_naucz5;
					}
				}
				
			}
			else if (co_wyszuk3 == true)
            {
				/*
				 * Boolean imie_pracownika_szuk = szuk_imie_prac.IsSelected;
			Boolean drugie_imie_pracownika_szuk = szuk_drugie_imie_prac.IsSelected;
			Boolean nawisko_pracownika_szuk = szuk_nazwisko_prac.IsSelected;
			Boolean nawisko_panienskie_pracownika_szuk = szuk_nazwisko_panienskie_prac.IsSelected;
			Boolean imiona_rodz_pracownika_szuk = szuk_imiona_rodzicow_prac.IsSelected;
			Boolean pesel_pracownika_szuk = szuk_pesel_prac.IsSelected;
			Boolean data_ur_pracownika_szuk = szuk_data_ur_prac.IsSelected;
			Boolean plec_pracownika_szuk = szuk_plec_prac.IsSelected;
			Boolean stanowisko_pracownika_szuk = szuk_stanowisko_prac.IsSelected;
			Boolean etat_pracownika_szuk = szuk_etat_prac.IsSelected;
			Boolean data_zatr_pracownika_szuk = szuk_data_zatr_prac.IsSelected;

				imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_naucz1 +
						"\n" + imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_naucz2.Text +
						"\n" + imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_naucz3.Text +
						"\n" + imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_naucz4.Text+
						"\n" + imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_naucz5.Text
				 */
				if (imie_pracownika_szuk == true)
				{
					if (imie_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (imie_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (imie_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (imie_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (imie_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (drugie_imie_pracownika_szuk == true)
				{
					if (drugie_imie_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (drugie_imie_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (drugie_imie_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (drugie_imie_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (drugie_imie_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
							+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
							"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (nawisko_pracownika_szuk == true)
				{
					if (nazwisko_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (nazwisko_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (nazwisko_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (nazwisko_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (nazwisko_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (nawisko_panienskie_pracownika_szuk == true)
				{
					if (panienskie_nazwisko_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (panienskie_nazwisko_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (panienskie_nazwisko_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (panienskie_nazwisko_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (panienskie_nazwisko_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (imiona_rodz_pracownika_szuk == true)
				{
					if (imiona_rodzicow_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (imiona_rodzicow_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (imiona_rodzicow_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (imiona_rodzicow_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (imiona_rodzicow_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}

				}
				else if (data_ur_pracownika_szuk == true)
				{
					if (data_ur_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (data_ur_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (data_ur_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (data_ur_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (data_ur_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (pesel_pracownika_szuk == true)

				{
					if (pesel_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (pesel_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (pesel_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (pesel_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (pesel_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (plec_pracownika_szuk == true)
				{
					if (plec_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (plec_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (plec_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (plec_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (plec_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						   + panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						   "|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (stanowisko_pracownika_szuk == true)
				{
					if (stanowisk_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (stanowisk_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (stanowisk_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (stanowisk_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (stanowisk_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (etat_pracownika_szuk == true)
				{
					if (etat_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (etat_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (etat_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (etat_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (etat_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				else if (data_zatr_pracownika_szuk == true)
				{
					if (data_zatr_prac1.Text == klucz_wyszukiwania)
					{
						raport1.Text = imie_prac1.Text + "|" + drugie_imie_prac1.Text + "|" + nazwisko_prac1.Text + "|"
						+ panienskie_nazwisko_prac1.Text + "|" + imiona_rodzicow_prac1.Text + "|" + data_ur_prac1.Text + "|" + pesel_prac1.Text + "|" + plec_prac1.Text +
						"|" + etat_prac1.Text + "|" + stanowisk_prac1.Text + "|" + data_zatr_prac1.Text;
					}

					if (data_zatr_prac2.Text == klucz_wyszukiwania)
					{
						raport2.Text = imie_prac2.Text + "|" + drugie_imie_prac2.Text + "|" + nazwisko_prac2.Text + "|"
						+ panienskie_nazwisko_prac2.Text + "|" + imiona_rodzicow_prac2.Text + "|" + data_ur_prac2.Text + "|" + pesel_prac2.Text + "|" + plec_prac2.Text +
						"|" + etat_prac2.Text + "|" + stanowisk_prac2.Text + "|" + data_zatr_prac2.Text;

					}

					if (data_zatr_prac3.Text == klucz_wyszukiwania)
					{
						raport3.Text = imie_prac3.Text + "|" + drugie_imie_prac3.Text + "|" + nazwisko_prac3.Text + "|"
						+ panienskie_nazwisko_prac3.Text + "|" + imiona_rodzicow_prac3.Text + "|" + data_ur_prac3.Text + "|" + pesel_prac3.Text + "|" + plec_prac3.Text +
						"|" + etat_prac3.Text + "|" + stanowisk_prac3.Text + "|" + data_zatr_prac3.Text;
					}

					if (data_zatr_prac4.Text == klucz_wyszukiwania)
					{
						raport4.Text = imie_prac4.Text + "|" + drugie_imie_prac4.Text + "|" + nazwisko_prac4.Text + "|"
						+ panienskie_nazwisko_prac4.Text + "|" + imiona_rodzicow_prac4.Text + "|" + data_ur_prac4.Text + "|" + pesel_prac4.Text + "|" + plec_prac4.Text +
						"|" + etat_prac4.Text + "|" + stanowisk_prac4.Text + "|" + data_zatr_prac4.Text;
					}

					if (data_zatr_prac5.Text == klucz_wyszukiwania)
					{
						raport5.Text = imie_prac5.Text + "|" + drugie_imie_prac5.Text + "|" + nazwisko_prac5.Text + "|"
						+ panienskie_nazwisko_prac5.Text + "|" + imiona_rodzicow_prac5.Text + "|" + data_ur_prac5.Text + "|" + pesel_prac5.Text + "|" + plec_prac5.Text +
						"|" + etat_prac5.Text + "|" + stanowisk_prac5.Text + "|" + data_zatr_prac5.Text;
					}
				}
				

				}




			}
		private void zapisz_raport(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			
				if (saveFileDialog.ShowDialog() == true)
					File.WriteAllText(saveFileDialog.FileName, raport1.Text+"\n"+raport2.Text + "\n" + raport3.Text + "\n" + raport4.Text
						 + "\n" + raport5.Text);
		}
		private void wczytaj_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog theDialog = new OpenFileDialog();
			theDialog.Title = "Open Text File";
			theDialog.Filter = "TXT files|*.txt";
			theDialog.InitialDirectory = @"C:\";
			if (theDialog.ShowDialog() == true)
			{
				try
				{
					string[] allLines = File.ReadAllLines(theDialog.FileName);
					wczytaj_text.Text = "";
					for (int i = 0; i < allLines.Length; i++)
					{
						string currentLine = allLines[i];
						wczytaj_text.AppendText(currentLine + Environment.NewLine);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		}
}
