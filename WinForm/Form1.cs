using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemonos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonService servicio = new PokemonService();
            listaPokemonos = servicio.listar();
            dgvPokeinfo.DataSource = listaPokemonos;
            dgvPokeinfo.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaPokemonos[0].UrlImagen);
        }

        private void dgvPokeinfo_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokeinfo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbxPokemon.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
