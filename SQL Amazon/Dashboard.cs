using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SQL_Amazon
{
    public partial class Dashboard : Form
    {
        private readonly Nile _nile;
        private readonly string _username;

        public Dashboard(Nile nile, string username)
        {
            InitializeComponent();

            _nile = nile;
            _username = username;
        }
    }
}
