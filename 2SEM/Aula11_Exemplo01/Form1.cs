using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtEvento.Text != string.Empty)
                {
                    mskData.Focus();
                }
            }
        }

        private void mskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Convert.ToDateTime(mskData.Text);
                    listBox1.Items.Add(txtEvento.Text);
                    listBox2.Items.Add(mskData.Text);
                    txtEvento.Clear();
                    mskData.Clear();
                    txtEvento.Focus();

                } catch (Exception ex)
                {
                    MessageBox.Show("Data inválida!");
                    //MessageBox.Show(ex.ToString());
                    mskData.Focus();
                }
                
            }
            
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            }
            else if (listBox3.SelectedIndex == 1)
            {
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            }
            else if (listBox3.SelectedIndex == 2)
            {
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            } else
            {
                MessageBox.Show("Selecione um candidato, seu burro !");
            }
            listBox3.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void btnLimparDatas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnApagarEvento_Click(object sender, EventArgs e)
        {
            int itemSelecionado = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(itemSelecionado);
                listBox2.Items.RemoveAt(itemSelecionado);
            } else
            {
                MessageBox.Show("Selecione um item para excluir !");
            }
            
        }
    }
}
