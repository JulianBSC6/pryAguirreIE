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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            TreeNode nodoMadre;
            DirectoryInfo info = new DirectoryInfo("C:\\Program Files");
            if (info.Exists==true)
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                
                treeView1.Nodes.Add(nodoMadre);
            }
        }
    }
}
