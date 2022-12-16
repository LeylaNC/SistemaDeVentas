using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIProductosVentas;
using System.Text.Json;

namespace CapaVisual
{
    public partial class ProductosUsuario : Form
    {

        public ProductosUsuario()
        {
            InitializeComponent();
        }

        private void ProductosUsuario_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }


        private void CargarTabla ()
        {
            DataTable tablaProductos = new DataTable();

            ProductosVentas productosVentas = new ProductosVentas();
            string jProductos = productosVentas.CargarTablaProductos();


            //string jProductos = "[{\"IdProducto\": 101,\"Nombre\":\"IT\" }, 
            //{\"IdProducto\": 102,\"Nombre\":\"Accounts\" }]";



            //private static ArrayList ListID = new ArrayList();
            //private static ArrayList ListFirstname = new ArrayList();
            //private static ArrayList ListLastname = new ArrayList();
            //private static ArrayList ListTelephone = new ArrayList();
            //private static ArrayList ListAddress = new ArrayList();

            //IList<T> ListaProductos = JsonSerializer.Deserialize<IList<>>(jProductos);

            //foreach (var dept in deptList)
            //{
            //Console.WriteLine("Department Id is: {0}", dept.DeptId);
            //Console.WriteLine("Department Name is: {0}", dept.DepartmentName);
            //}
            ActualizarDataGrid();

            //CargarTabla(productos);

        }

        private void ActualizarDataGrid()
        {

            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);




            DataGridViewProductos.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(DataGridViewProductos);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListFirstname[i];
                newRow.Cells[2].Value = ListLastname[i];
                newRow.Cells[3].Value = ListTelephone[i];
                newRow.Cells[4].Value = ListAddress[i];
                DataGridViewProductos.Rows.Add(newRow);
            }
        }


        private void BtnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar seleccion probablemente
                ComprarUsuario comprar = new ComprarUsuario();
                comprar.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
