using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2V_Acid_2
{
    public partial class Wowzers : Form
    {
        public Wowzers()
        {
            InitializeComponent();

            //Setup the change event for all the controls.
            foreach(Control c in this.Controls)
                if (c.GetType() == typeof(TrackBar))
                    ((TrackBar) c).ValueChanged += setTrackValue;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c.GetType() == typeof(TrackBar))
                {
                    ((TrackBar) c).Value = Program.Random.Next(0, 255);
                }
        }

        private void loopRandomButton_Click(object sender, EventArgs e)
        {
            loopTimer.Enabled = !loopTimer.Enabled;
        }

        private void setTrackValue(object sender, EventArgs e)
        {
            var index = ((TrackBar) sender).TabIndex; //Ain't this just fucking cheeky.
            var value = (byte) ((double) ((TrackBar) sender).Value);
            setValue(index, value);
        }

        private void setValue(int index, byte value)
        {
            var address = 4621500 + index;
            Program.Memory.WriteByte(address, value, true);
        }

        private void loopTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c.GetType() == typeof(TrackBar))
                {
                    ((TrackBar)c).Value = Program.Random.Next(0, 255);
                }
        }
    }
}
