using EuroMilApp.Domain;
using System.Linq;
using System.Text;

namespace EuroMilApp
{
    public partial class BetScreen : Form
    {
        private readonly BetService betService;

        public BetScreen(BetService betService)
        {
            InitializeComponent();

            InitializeValues();

            this.betService = betService;
        }

        private void InitializeValues()
        {
            foreach (var control in numbersGroupBox.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    for (int i = 1; i <= 50; i++)
                    {
                        comboBox.Items.Add(i.ToString("00"));
                    }
                }
            }

            foreach (var control in starsGroupBox.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        comboBox.Items.Add(i.ToString("00"));
                    }
                }
            }
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var betResult = await betService.Bet(accountCombobox.Text, GetKey());

                MessageBoxIcon icon = MessageBoxIcon.Information;
                if (!betResult.Success)
                {
                    icon = MessageBoxIcon.Error;
                }

                MessageBox.Show(betResult.Message, "Resultado do Registo", MessageBoxButtons.OK, icon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao enviar aposta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetKey()
        {
            ValidateInputs();

            StringBuilder stringBuilder = new StringBuilder();

            GetValues(stringBuilder, numbersGroupBox);
            stringBuilder.Append(' ');
            GetValues(stringBuilder, starsGroupBox);

            return stringBuilder.ToString().Trim();
        }

        private void GetValues(StringBuilder stringBuilder, GroupBox groupBox)
        {
            stringBuilder.Append(string.Join(" ", groupBox.Controls
                                                    .OfType<ComboBox>()
                                                    .OrderBy(u => u.Name)
                                                    .Select(comboBox => comboBox.Text)));
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(accountCombobox.Text.Trim()))
            {
                throw new Exception("Por favor selecione a conta antes de enviar a aposta.");
            }

            ValidateInputs(numbersGroupBox, "Números não podem ter valores iguais. Por favor selecione valores distintos antes de enviar a aposta.");
            ValidateInputs(starsGroupBox, "Estrelas não podem ter valores iguais. Por favor selecione valores distintos antes de enviar a aposta.");
        }

        private void ValidateInputs(GroupBox groupBox, string errorMessage)
        {
            foreach (var comboBox in groupBox.Controls.OfType<ComboBox>())
            {
                if (comboBox?.SelectedIndex == -1)
                {
                    throw new Exception("Por favor selecione todos os valores corretamente antes de enviar a aposta.");
                }

                ValidateInputValues(comboBox, groupBox, errorMessage);
            }
        }

        private void ValidateInputValues(ComboBox comparableComboBox, GroupBox groupBox, string errorMessage)
        {
            foreach (ComboBox comboBox in groupBox.Controls.OfType<ComboBox>())
            {
                if (comparableComboBox == comboBox) continue;

                if (comparableComboBox.Text == comboBox.Text)
                {
                    throw new Exception(errorMessage);
                }
            }
        }
    }
}
