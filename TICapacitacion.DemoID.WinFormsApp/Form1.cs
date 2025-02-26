using TICapacitacion.DemoID.Biblioteca;

namespace TICapacitacion.DemoID.WinFormsApp
{
    public partial class Form1 : Form
    {
        TextBox Messages;

        public Form1(IDelegateWriter writer)
        {
            InitializeComponent();
            Messages = new TextBox
            {
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Multiline = true,
            };
            Controls.Add(Messages);
            writer.Delegate = AddMessage;
        }

        void AddMessage(string message)
        {
            if (message != null)
            {
                Messages.Invoke(() => Messages.Text += message + Environment.NewLine);
            }
        }
    }
}
