namespace GestiónTareasPendientes
{
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
            }
            else {
                Console.WriteLine("Prueba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Remove(lstTareas.SelectedItem);
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
