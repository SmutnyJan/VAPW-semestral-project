﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Smutny_semestral_project
{
    public partial class VisualUpdateForm : Form
    {
        public bool IsEventBased { get { return EventBasedButton.Checked; } }

        public VisualUpdateForm()
        {
            InitializeComponent();
        }

    }
}
