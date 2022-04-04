using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_7
{
    public partial class FormQuizPanda : Form
    {
        //char[] huruf;
        public FormQuizPanda()
        {
            InitializeComponent();
        }


        //char cekHuruf;
        public void buttonKonversi_Click(object sender, EventArgs e)
        {
            //char[] koleksiHuruf = { 'A', 'B', 'C', 'D', 'E', 'F', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; 
            
            
            string input = textBoxInputKal.Text.ToUpper();
            labelOutput.Text = "";
            foreach (var huruf in input)
            {
                
                string inputMenjadi = textBoxInputMenjadi.Text;
                string inputHur = textBoxInputHur.Text;

                foreach (var hurufInput in inputHur)
                {
                    int IndexHurufInput = Convert.ToInt32(hurufInput); //CARI VALUE
                    foreach (var hurufMenjadi in inputMenjadi)
                    {
                        int indexHurufMenjadi = Convert.ToInt32(hurufMenjadi);

                        int selisih = indexHurufMenjadi - IndexHurufInput;
                        string output = Convert.ToChar(Convert.ToInt32(huruf) + selisih).ToString();


                        if (Convert.ToInt32(huruf) == 32) //input.Contains(" "))
                        {
                            labelOutput.Text += " "; //input += input.Replace(' '.ToString(), " ");
                        }

                        else if (Convert.ToInt32(huruf) + selisih < 65)
                        {
                            
                            //int valueHuruf = Convert.ToInt32(huruf) + 26 + selisih;
                            //valueHuruf = valueHuruf + 26 + selisih;
                            labelOutput.Text += Convert.ToChar(Convert.ToInt32(huruf) + 26 + selisih);
                            
                        }
                        else if (Convert.ToInt32(huruf) + selisih > 90)
                        {
                            
                            //int valueHuruf = Convert.ToInt32(huruf);
                            //valueHuruf = valueHuruf - 26 + selisih;
                            labelOutput.Text += Convert.ToChar(Convert.ToInt32(huruf) - 26 + selisih);
                            
                        }
                        else
                        {
                            
                            labelOutput.Text += Convert.ToChar(Convert.ToInt32(huruf) + selisih);
                            
                        }



                        //MessageBox.Show(IndexHurufInput.ToString()); //97
                        //MessageBox.Show(indexHurufMenjadi.ToString()); //122
                    }

                }
                /*for (int i = 0; i <input.Length; i++)
                {
                    foreach (var hurufInput in inputHur)
                    {
                        int IndexHurufInput = Convert.ToInt16(hurufInput); //CARI VALUE
                        foreach (var hurufMenjadi in inputMenjadi)
                        {
                            int indexHurufMenjadi = Convert.ToInt16(hurufMenjadi);

                            int selisih = indexHurufMenjadi - IndexHurufInput;
                            string output = Convert.ToChar(Convert.ToInt32(huruf) + selisih).ToString();
                            labelOutput.Text = output;
                        }

                    }
                    
                }
                */
                /*foreach (var hurufInput in inputHur)
                {
                    int IndexHurufInput = Convert.ToInt16(hurufInput); //CARI VALUE
                    foreach (var hurufMenjadi in inputMenjadi)
                    {
                        int indexHurufMenjadi = Convert.ToInt16(hurufMenjadi);
                        
                        int selisih = indexHurufMenjadi - IndexHurufInput;
                        string output = Convert.ToChar(Convert.ToInt32(huruf) + selisih).ToString();
                        labelOutput.Text = output;
                    }
                    
                } */
                
                
                
                
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            char huruf1 = 'a';
            char huruf2 = 'd';
            int selisih = huruf2 - huruf1;
            MessageBox.Show(selisih.ToString());
            */
        }

        /*
        string input = textBoxInputKal.Text;
            
            foreach (var huruf in input)
            {
                
                string inputMenjadi = textBoxInputMenjadi.Text;
        string inputHur = textBoxInputHur.Text;
                //for(int i = 0; i <input.Length; i++)
                foreach (var hurufInput in inputHur)
                {
                    int IndexHurufInput = Convert.ToInt16(hurufInput); //CARI VALUE
                    foreach (var hurufMenjadi in inputMenjadi)
                    {
                        int indexHurufMenjadi = Convert.ToInt16(hurufMenjadi);

        int selisih = indexHurufMenjadi - IndexHurufInput;
        string output = Convert.ToChar(Convert.ToInt32(huruf) + selisih).ToString();
        labelOutput.Text = output;
                    }

}
                
                
                
                
            }


        //if (cekHuruf.ToString().Contains(textBoxInputKal.Text))
       

    //textBoxInputKal.Text;

    /*
    if (textBoxInputHur.Text.Contains(textBoxInputKal.Text)) ;
    {
        if (textBoxInputHur.Text = 'a')
            textBoxInputKal.Text = textBoxInputKal.Text.StartsWith('a');
    }
    */

    //huruf = labelInputKalimat.Text.ToCharArray();


    //koleksiHuruf = ['A', 'B', 'C', 'D', 'E', 'F', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];



    //labelOutput.Text = input;


    //string inputMenjadi = textBoxInputMenjadi.Text;

    //string inputHur = Convert.ToInt16(textBoxInputHur.Text).ToString();
    //string inputMenjadi = Convert.ToInt16(textBoxInputMenjadi).ToString();
    //MessageBox.Show(inputHur.ToString());
    /*
    string inputHur = textBoxInputHur.Text;
    foreach (var huruf in inputHur)
    {
        Convert.ToInt16(huruf).ToString(); //CARI VALUE
    //MessageBox.Show(Convert.ToChar(Convert.ToInt16(huruf) + selisih).ToString());
    }
    string inputMenjadi = textBoxInputMenjadi.Text;
    foreach (var huruf in inputMenjadi)
    {
        Convert.ToInt16(huruf).ToString();
    }
    */



    //string inputHur = Convert.ToInt16(textBoxInputHur.Text).ToString();
    //string inputMenjadi = Convert.ToInt16(textBoxInputMenjadi).ToString();
    //MessageBox.Show(inputHur.ToString());
    //MessageBox.Show(inputHur.ToString());
    //MessageBox.Show(Convert.ToInt16(huruf).ToString()); //CARI VALUE

    //int selisih = inputMenjadi - inputHur;
    //int selisih = (Convert.ToInt32(inputMenjadi)) - (Convert.ToInt32(inputHur));
    //Convert.ToChar(Convert.ToInt32(kata) + selisih).ToString();
        //MessageBox.Show(Convert.ToChar(Convert.ToInt16(huruf) + selisih).ToString());
    }
}
