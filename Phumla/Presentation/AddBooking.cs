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
    public partial class AddBooking : Form
    {
        private RoomDB rooms;
        public AddBooking()
        {
            rooms = new RoomDB();
            InitializeComponent();
        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtGuestID.Clear();
            txtHotelID.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAvailability_Click(object sender, EventArgs e)
        {

            Collection<Room> availablerooms = new Collection<Room>();
            
        }

        private void btnGoBackToAddGuest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reservation will be unsaved.", "Go back to Home Page?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }
    }
}
