using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryAguirreIE
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            LlenarTreeView();
            this.treeView1.NodeMouseClick +=
            new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }
        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                treeView1.Nodes.Add(nodoMadre);
            }
        }
        private void ObtenerCarpetas(DirectoryInfo[] subDirs,
             TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //recursiva - se llama a si mismo para
                //buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        void treeView1_NodeMouseClick(object sender,
    TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void Proveedores_Load(object sender, EventArgs e)
        {
          
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio volver = new frmInicio();
            volver.Show();
        }
        String[] SepararDatos;
        String LeerLinea;
        string nombreArchivo;
        public void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            string ruta = info.FullName;
            nombreArchivo = listView1.SelectedItems[0].Text;
            StreamReader Leer = new StreamReader(ruta+ "\\" + nombreArchivo);
            clsGrabarArchivo.RutaFull = ruta + "\\"+ nombreArchivo;
            CargarProveedores.RutaFull =  ruta+ "\\" + nombreArchivo;
            frmMostrarGrilla.RutaFull = ruta + "\\" + nombreArchivo; 

            LeerLinea = Leer.ReadLine();
            SepararDatos = LeerLinea.Split(';');

            //llamar a la grilla del formulario
            frmMostrarGrilla ventanaGrilla = new frmMostrarGrilla();
            ventanaGrilla.Show();
            for (int indice = 0; indice < SepararDatos.Length; indice++)
            {
                //usar la grilla para cargar
                ventanaGrilla.GrillaMostrar.Rows.Add(SepararDatos[indice], SepararDatos[indice]); 

            }
            while (Leer.EndOfStream == false)
            {
                LeerLinea = Leer.ReadLine() ;
                SepararDatos = LeerLinea.Split(';');
                ventanaGrilla.GrillaMostrar.Rows.Add(SepararDatos);
            }
            Leer.Close();
            
        }
    }
}

