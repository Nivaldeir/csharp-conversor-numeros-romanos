using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorNumerosRomanos
{
    public partial class Form1 : Form
    {
        String nr = String.Empty;
        int digitoRomanoemconjunto = 0;
        int teste;
        public Form1()
        {
            InitializeComponent();
        }

        public string romana(double n)
        {
            nr = "";
            int unidades, centenas, dezenas, Unidade_unidade, Unidade_Dezenas, Unidade_Centenas, Unidade_Milhao; //criação das variaveis

            Unidade_Milhao = (int)(n / 1000000);
            n = n - Unidade_Milhao * 1000000;

            Unidade_Centenas = (int)(n / 100000);
            n = n - Unidade_Centenas * 100000;

            Unidade_Dezenas = (int)(n / 10000);
            n = n - Unidade_Dezenas * 10000;

            Unidade_unidade = (int)(n / 1000);
            n = n - Unidade_unidade * 1000;

            centenas = (int)(n / 100);
            n = n - centenas * 100; // calcular e tirar centenas do numero
            dezenas = (int)n / 10;

            n = n - dezenas * 10;//calcuar e tirar dezenas do numero
            unidades = Convert.ToInt32(n);//unidades

            switch (Unidade_Milhao)
            {
                case 1:
                    label6.Text = "_";
                    nr = "M";
                    break;
            } // Unidade de Milhao
            switch (Unidade_Centenas)
            {
                case 1:
                    label6.Text = label6.Text + "_";
                    nr = nr + "C";
                    break;
                case 2:
                    label6.Text = label6.Text + "__";
                    nr = nr + "CC";
                    break;
                case 3:
                    label6.Text = label6.Text + "___";
                    nr = nr + "CCC";
                    break;
                case 4:
                    label6.Text = label6.Text + "__";
                    nr = nr + "CD";
                    break;
                case 5:
                    label6.Text = label6.Text + "_";
                    nr = nr + "D";
                    break;
                case 6:
                    label6.Text = label6.Text + "__";
                    nr = nr + "DC";
                    break;
                case 7:
                    label6.Text = label6.Text + "___";
                    nr = nr + "DCC";
                    break;
                case 8:
                    label6.Text = label6.Text + "____";
                    nr = nr + "DCCC";
                    break;
                case 9:
                    label6.Text = label6.Text + "__";
                    nr = nr + "CM";
                    break;
            } // Centenas de milhar

            switch (Unidade_Dezenas)
            {
                case 1:
                    label6.Text = label6.Text + "_";
                    nr = nr + "X";
                    break;
                case 2:
                    label6.Text = label6.Text + "__";
                    nr = nr + "XX";
                    break;
                case 3:
                    label6.Text = label6.Text + "___";
                    nr = nr + "XXX";
                    break;
                case 4:
                    label6.Text = label6.Text + "__";
                    nr = nr + "XL";
                    break;
                case 5:
                    label6.Text = label6.Text + "_";
                    nr = nr + "L";
                    break;
                case 6:
                    label6.Text = label6.Text + "__";
                    nr = nr + "LX";
                    break;
                case 7:
                    label6.Text = label6.Text + "___";
                    nr = nr + "LXX";
                    break;
                case 8:
                    label6.Text = label6.Text + "____";
                    nr = nr + "LXXX";
                    break;
                case 9:
                    label6.Text = label6.Text + "__";
                    nr = nr + "XC";
                    break;
            } // Dezenas de milhar

            switch (Unidade_unidade)
            {
                case 1: nr = nr + "M"; break;
                case 2: nr = nr + "MM"; break;
                case 3: nr = nr + "MMM"; break;
                case 4:
                    label6.Text = label6.Text + "__";
                    nr = "IV";
                    break;
                case 5:
                    label6.Text = label6.Text + "_";
                    nr = nr + "V";
                    break;
                case 6:
                    label6.Text = label6.Text + "__";
                    nr = nr + "VI";
                    break;
                case 7:
                    label6.Text = label6.Text + "_";
                    nr = nr + "VII";
                    break;
                case 8:
                    label6.Text = label6.Text + "_";
                    nr = nr + "VIII";
                    break;
                case 9:
                    label6.Text = label6.Text + "_";
                    nr = nr + "IX";
                    break;
            } //Unidade_Dezenas de milhar

            switch (centenas)
            {
                case 1: nr = nr + "C"; break;
                case 2: nr = nr + "CC"; break;
                case 3: nr = nr + "CCC"; break;
                case 4: nr = nr + "CD"; break;
                case 5: nr = nr + "D"; break;
                case 6: nr = nr + "DC"; break;
                case 7: nr = nr + "DCC"; break;
                case 8: nr = nr + "DCCC"; break;
                case 9: nr = nr + "CM"; break;
                case 10: nr = nr + "M"; break;
                case 11: nr = nr + "MM"; break;
                case 12: nr = nr + "MMM"; break;
            } // Centena

            switch (dezenas)
            {
                case 1: nr = nr + "X"; break;
                case 2: nr = nr + "XX"; break;
                case 3: nr = nr + "XXX"; break;
                case 4: nr = nr + "XL"; break;
                case 5: nr = nr + "L"; break;
                case 6: nr = nr + "LX"; break;
                case 7: nr = nr + "LXX"; break;
                case 8: nr = nr + "LXXX"; break;
                case 9: nr = nr + "XC"; break;
            } // Dezenas

            switch (unidades)
            {
                case 1: nr = nr + "I"; break;
                case 2: nr = nr + "II"; break;
                case 3: nr = nr + "III"; break;
                case 4: nr = nr + "IV"; break;
                case 5: nr = nr + "V"; break;
                case 6: nr = nr + "VI"; break;
                case 7: nr = nr + "VII"; break;
                case 8: nr = nr + "VIII"; break;
                case 9: nr = nr + "IX"; break;
            } // Unidades

            return nr;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                romana(double.Parse(txtNumero.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Dados invalidos, por favor inserir apenas numeros");
                txtNumero.Clear();
                label5.Text = "";
                label6.Text = "";
            }
            label5.Text = nr.ToString();
        }

        public void verificarNumerosRomanos(string numeroRomano)
        {
            int soma = 0;
            if (guna2TextBox1.Text == "CCCC" || guna2TextBox1.Text == "MMMM" || guna2TextBox1.Text == "MMMMM")
            {
                MessageBox.Show("Numero romano invalido");
                return;
            }
            int NumeroRomanoTest = 0;
            for (int i = 0; i < numeroRomano.Length; i++)
            {
                switch (numeroRomano[i])
                {
                    case 'I':
                        NumeroRomanoTest += 1;
                        break;
                    case 'V':
                        NumeroRomanoTest += 5;
                        break;
                    case 'X':
                        NumeroRomanoTest += 10;
                        break;
                    case 'L':
                        NumeroRomanoTest += 50;
                        break;
                    case 'C':
                        NumeroRomanoTest += 100;
                        break;
                    case 'D':
                        NumeroRomanoTest += 500;
                        break;
                    case 'M':
                        NumeroRomanoTest += 1000;
                        break;
                }
                char dr = numeroRomano[i];
                char drSeguinte = i < numeroRomano.Length - 1 ? numeroRomano[i + 1] : ' ';

                if (dr == 'I' && drSeguinte == 'V')
                {
                    digitoRomanoemconjunto += -2;
                }

                if (dr == 'I' && drSeguinte == 'X')
                {
                    digitoRomanoemconjunto += -2;
                }

                if (dr == 'X' && drSeguinte == 'L')
                {
                    digitoRomanoemconjunto += -20;
                }

                if (dr == 'X' && drSeguinte == 'C')
                {
                    digitoRomanoemconjunto += -20;

                }

                if (dr == 'C' && drSeguinte == 'D')
                {
                    digitoRomanoemconjunto += -200;
                }

                if (dr == 'C' && drSeguinte == 'M')
                {
                    digitoRomanoemconjunto += -200;
                }
            }
            teste = NumeroRomanoTest;
            soma = NumeroRomanoTest + digitoRomanoemconjunto;
            label2.Text = soma.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           verificarNumerosRomanos(guna2TextBox1.Text.ToString());
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            label6.Text = "";
            label5.Text = "";
        }
    }
}
