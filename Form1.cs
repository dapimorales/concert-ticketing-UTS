using concert_ticketing.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace concert_ticketing
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAccount = _serviceProvider.GetRequiredService<FormAccount>();

            // Gunakan FormClosing, bukan FormClosed
            formAccount.FormClosing += (s, args) =>
            {
                args.Cancel = true;   // cegah dispose
                formAccount.Hide();   // hanya sembunyikan
                this.Show();          // tampilkan form utama lagi
            };

            formAccount.Show();
            this.Hide();
        }

        private void concertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formConcerts = _serviceProvider.GetRequiredService<FormConcerts>();

            formConcerts.FormClosing += (s, args) =>
            {
                args.Cancel = true;
                formConcerts.Hide();
                this.Show();
            };

            formConcerts.Show();
            this.Hide();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTicket = _serviceProvider.GetRequiredService<FormTicket>();

            formTicket.FormClosing += (s, args) =>
            {
                args.Cancel = true;
                formTicket.Hide();
                this.Show();
            };

            formTicket.Show();
            this.Hide();
        }
    }
}
