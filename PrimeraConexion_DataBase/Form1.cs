using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PrimeraConexion_DataBase
    
{
    
    public partial class Form1 : Form
    {
    //Agrego el atributo listaPokemon
        private List<Pokemon> listaPokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.Listar(); 
            dataGridViewPokemon.DataSource = listaPokemon;
            dataGridViewPokemon.Columns["UrlImagen"].Visible = false;
            //pictureBox1Pokemon.Load(listaPokemon[0].UrlImagen);//Le digo que cargue en el picture box la url
            //Saco la linea anterior xq en el selectionchanged que sigue ya cago directamente las imagenes

            //nueva Data grid view probando elementos
            ElementosNegocio elem = new ElementosNegocio();
            dataGridView1Elementos.DataSource = elem.listar();
            

        }

        //Para cambiar la imagen cuando cambio de fila en mi datagridview, vamos a utlizar la 
        //opcion SelectionChange del PictureBox
        private void dataGridViewPokemon_SelectionChanged(object sender, EventArgs e)
        {
              Pokemon seleccionado = (Pokemon)dataGridViewPokemon.CurrentRow.DataBoundItem;
            //pictureBox1Pokemon.Load(seleccionado.UrlImagen);
            cargarImagen(seleccionado.UrlImagen);
        }

        //En el caso anterior el codigo comentado , si no llegamos a tener imagen se romperia el programa. Para esto vamos a crear un metodo
        // en el cual vamos a manejar esa excepcion

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1Pokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBox1Pokemon.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }
    }
}
