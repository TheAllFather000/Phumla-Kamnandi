using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla.Data;
using Phumla.Business;

namespace Phumla.Presentation
{
    public partial class CreateReservation : Form
    {
        private RoomDB rooms;
        public CreateReservation()
        {
            rooms = new RoomDB();
            InitializeComponent();
        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAvailability_Click(object sender, EventArgs e)
        {

            Collection<Room> availablerooms = new Collection<Room>();
            
        }
    }
}
