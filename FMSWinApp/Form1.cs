using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWinApp
{
    public partial class Form1 : Form
    {
        private readonly ICategoryService _categoryService;
        public Form1(ICategoryService categoryService):this()
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
