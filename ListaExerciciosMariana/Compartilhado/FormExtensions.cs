namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public static class FormExtensions
    {
        public static void ConfigurarDialog(this Form form)
        {
            form.ShowIcon = false;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ShowInTaskbar = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in form.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += (sender, e) =>
                    {
                        button.BackColor = Color.FromArgb(94, 134, 177);
                        button.ForeColor = Color.Snow;
                        //button.ForeColor = Color.Snow;
                        //SystemColors.GradientInactiveCaption;
                    };

                    button.MouseLeave += (sender, e) =>
                    {
                        button.BackColor = Color.LightSteelBlue;
                        button.ForeColor = Color.Black;
                    };
                }
            }
        }
    }
}
