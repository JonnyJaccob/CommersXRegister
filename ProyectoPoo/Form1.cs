﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Form1 : Form
    {
        Producto producto;
        Producto[] Arreglo; //= new Producto[20];
        Sorteador sorteo = new Sorteador();
        int c = 0; //int res=0;
        int cuento = 0;
        static string Echis = @"C:\Users\doloresmargarita\source\repos\ProyectoP\Informacion2.dat";
        ArchivoSecuencialSerializadoBinario<Producto> miArchivo;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void AccionHabilitar(object sender, MouseEventArgs e)
        {
            BoxCliente.Enabled = true;
        }

        private void HabilitarProducto(object sender, MouseEventArgs e)
        {
            BoxProducto.Enabled = true;
        }

        private void ckbPermitir_CheckedChanged(object sender, EventArgs e)
        {
            if (cuento == 0)
            {
                groupArchivo.Enabled = true;
                cuento++;
            }
            else if (cuento == 1)
            {
                groupArchivo.Enabled = false;
                cuento--;
            }
            else MessageBox.Show("Algo salio mal");

        }

        private void PermitirCambio(object sender, EventArgs e)
        {


        }

        private void Pulsar(object sender, MouseEventArgs e)
        {
            //if (ckbPermitir.Checked)
            //{
            //    groupArchivo.Enabled = true;
            //}
            //else groupArchivo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Agregar()
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                producto = new Producto();
                producto.Acarreo = double.Parse(txtCostoAcarreo.Text);
                producto.Descuento = double.Parse(txtDescuento.Text);
                producto.DireccionP = txtDireccionP.Text;
                producto.DireccionC = txtDireccion.Text;
                producto.EncargadoC = txtEncargadoC.Text;
                producto.EncargadoP = txtEncargado.Text;
                producto.Importe = double.Parse(txtImporte.Text);
                producto.IntervaloBono = double.Parse(txtBonoMensual.Text);
                producto.Marca = txtMarca.Text;
                producto.Nombre = txtNombreProd.Text;
                producto.NombreC = txtNombreC.Text;
                producto.NombreP = txtNombreP.Text;
                producto.FechaCapturacion = dtpFCaptura.Value;
                producto.FechaExpiracion = dtpExpiracion.Value;
                ListaEmpresas.Rows.Add(producto.NombreP, producto.DireccionP, producto.EncargadoP, producto.NombreC, producto.DireccionC, producto.EncargadoC,producto.FechaCapturacion ,producto.Nombre, producto.Marca, producto.FechaExpiracion, producto.Importe, producto.CalcularTotal());
                try
                {
                    //Arreglo[c] = producto;
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                c++;

            }
            catch (Exception l)
            {
                MessageBox.Show(l.Message);
                return;
            }
            try
            {
                miArchivo.AbrirModoEscritura();
                miArchivo.GrabarObjeto(producto);
                MessageBox.Show("Datos Almacenados correctamente");
                
                //MostrarDatos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                miArchivo.Cerrar();
            }
            MostrarDatos();  
        }
        public void MostrarDatos()
        {
            try
            {
                //miArchivo.AbrirModoLectura();
                //while (!miArchivo.FinArchivo)//despues de esto error
                //{
                //    producto = miArchivo.LeerObjetos();
                //    //Error en la lista
                //    ListaEmpresas.Rows.Add(producto.NombreP, producto.DireccionP, producto.EncargadoP, producto.NombreC, producto.DireccionC, producto.EncargadoC, producto.Nombre, producto.Marca, producto.FechaExpiracion, producto.Importe, producto.CalcularTotal());
                //}
                try
                {
                    //miArchivo = new ArchivoSecuencialSerializadoBinario<Producto>(Echis);
                    miArchivo.NombreArchivo = Echis;
                    miArchivo.AbrirModoLectura();
                    ListaEmpresas.Rows.Clear();
                    while (!miArchivo.FinArchivo)
                    {
                        producto = miArchivo.LeerObjetos();
                        //MessageBox.Show("Datos Almacenados correctamente");
                        
                        ListaEmpresas.Rows.Add(producto.NombreP, producto.DireccionP, producto.EncargadoP, producto.NombreC, producto.DireccionC, producto.EncargadoC,producto.FechaCapturacion, producto.Nombre, producto.Marca, producto.FechaExpiracion, producto.Importe, Math.Round(producto.CalcularTotal(),2));

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miArchivo.Cerrar();
            }
        }
        

        private void btnLlenarTexto_Click(object sender, EventArgs e)
        {
            txtCostoAcarreo.Text = "9.99";
            txtDescuento.Text = "0.05";
            txtDireccionP.Text = "Reforma";
            txtDireccion.Text = "Colombia av.";
            txtEncargadoC.Text = "Julio";
            txtEncargado.Text = "Antonio";
            txtImporte.Text = "100.00";
            txtBonoMensual.Text = "0.05";
            txtMarca.Text = "La Costeña";
            txtNombreProd.Text = "Art. de limpieza";
            txtNombreC.Text = "Walt Mart";
            txtNombreP.Text = "DesVenturas S.V.";
            BoxProducto.Enabled = true;
            BoxCliente.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                int CantidadE = ListaEmpresas.Rows.Count - 1;
                Arreglo = new Producto[CantidadE];
                for (int i = 0; i < CantidadE; i++)
                {
                    producto = new Producto();
                    producto.NombreP = ListaEmpresas[0, i].Value.ToString();
                    producto.DireccionP = ListaEmpresas[1, i].Value.ToString();
                    producto.EncargadoP = ListaEmpresas[2, i].Value.ToString();
                    producto.NombreC = ListaEmpresas[3, i].Value.ToString();
                    producto.DireccionC = ListaEmpresas[4, i].Value.ToString();
                    producto.EncargadoC = ListaEmpresas[5, i].Value.ToString();
                    producto.FechaCapturacion = (DateTime)ListaEmpresas[6, i].Value;
                    producto.Nombre = ListaEmpresas[7, i].Value.ToString();
                    producto.Marca = ListaEmpresas[8, i].Value.ToString();
                    producto.FechaExpiracion = (DateTime)ListaEmpresas[9, i].Value;
                    producto.Importe = (double)ListaEmpresas[10, i].Value;
                    producto.Total = (double)ListaEmpresas[11, i].Value;

                    Arreglo[i] = new Producto();
                    Arreglo[i] = producto;
                }
                if (rdbAscendente.Checked && rdbTotal.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Ascendente, producto.CompararPorTotal);
                    //MessageBox.Show("Odenado");
                }
                if (rdbAscendente.Checked && rdbFecha.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Ascendente, producto.CompararPorFecha);
                }
                if (rdbAscendente.Checked && rdbCliente.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Ascendente, producto.CompararPorNombreCliente);
                }
                if (rdbAscendente.Checked && rdbProveedor.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Ascendente, producto.CompararPorNombreProveedor);
                    //MessageBox.Show("Odenado");
                }
                if (rdbAscendente.Checked && rdbProducto.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Ascendente, producto.CompararPorNombreMercancia);
                }
                if (rdbDescendente.Checked && rdbTotal.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Descendente, producto.CompararPorTotal);
                }
                if (rdbDescendente.Checked && rdbFecha.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Descendente, producto.CompararPorFecha);
                }
                if (rdbDescendente.Checked && rdbCliente.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Descendente, producto.CompararPorNombreCliente);
                }
                if (rdbDescendente.Checked && rdbProveedor.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Descendente, producto.CompararPorNombreProveedor);
                }
                if (rdbDescendente.Checked && rdbProducto.Checked)
                {
                    sorteo.Ordenar(Arreglo, sorteo.Descendente, producto.CompararPorNombreMercancia);
                }
                ListaEmpresas.Rows.Clear();
                for (int i = 0; i < Arreglo.Length; i++)
                {
                    producto = Arreglo[i];
                    ListaEmpresas.Rows.Add(producto.NombreP, producto.DireccionP, producto.EncargadoP, producto.NombreC, producto.DireccionC, producto.EncargadoC, producto.FechaCapturacion, producto.Nombre, producto.Marca, producto.FechaExpiracion, producto.Importe, producto.CalcularTotal());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
           // OpenFileDialog saveFileDialog = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Echis = openFileDialog1.FileName;
                miArchivo = new ArchivoSecuencialSerializadoBinario<Producto>(Echis);
                //CambiarRuta();
                MessageBox.Show("Pulse actualizar lista si elegio el archivo correcto");
            }
           // MostrarDatos();
        }
        

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtCostoAcarreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //miArchivo = new ArchivoSecuencialSerializadoBinario<Producto>(Echis);
            //MostrarDatos();
        }
       

        private void btnAbrirCompartir_Click(object sender, EventArgs e)
        {
            Form2 miForma2 = new Form2();
            miForma2.Show();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Echis = saveFileDialog1.FileName;
               
            }
            MostrarDatos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            if(saver.ShowDialog()==DialogResult.OK)
            {
                Echis = saver.FileName;
                TextWriter archivo;
                archivo = new StreamWriter(Echis);
                archivo.Close();
            }
            MostrarDatos();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Echis = saveFileDialog1.FileName;
                miArchivo = new ArchivoSecuencialSerializadoBinario<Producto>(Echis);
                //CambiarRuta();
                MessageBox.Show("Ya puede introducir sus datos.\nPor favor, pulse insertar");
            }
        }
    }
}
