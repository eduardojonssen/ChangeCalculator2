using ChangeCalculator.Core;
using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator.UI.WindowsForms
{
    public partial class UxFrmChangeCalculator : Form
    {
        readonly IChangeCalculator calculatorChange;

        public UxFrmChangeCalculator()
        {
            calculatorChange = new ChangeCalculatorManager();
            InitializeComponent();
        }

        private void UxBtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                long totalPaidAmountCents;
                long totalPaymentAmountCents;

                if (long.TryParse(UxTxtTotalPaid.Text, out totalPaidAmountCents) == false)
                {
                    throw new ApplicationException(string.Format("Total Paid is inválid"));
                }

                if (long.TryParse(UxTxtTotalPayment.Text, out totalPaymentAmountCents) == false)
                {
                    throw new ApplicationException(string.Format("Total Payment is inválid"));
                }

                BindingSource source = new BindingSource();
                CalculatorChangeRequest calculatorChangeRequest = new CalculatorChangeRequest()
                {
                    SalePrice = totalPaymentAmountCents,
                    ValuePayment = totalPaidAmountCents
                };

                CalculatorChangeResponse calculatorChangeResponse =
                    calculatorChange.Calculator(calculatorChangeRequest);

                UxTxbCoins.Text = string.Empty;
                if (calculatorChangeResponse.Success)
                {
                    IEnumerable<string> change =
                        calculatorChangeResponse
                                    .ChangeCollection
                                    .Select(x => string.Format("{0} - {1}", x.Coin, x.Quantity));

                    UxTxbCoins.Text = string.Join(Environment.NewLine, change);
                    UxTxtAmount.Text = calculatorChangeResponse.ChangeAmount.ToString();
                }
                else
                {
                    StringBuilder error = new StringBuilder();
                    foreach (MessageRequest message in calculatorChangeResponse.MessageCollection)
                    {
                        if (string.IsNullOrEmpty(message.Field) == true)
                        {
                            error.AppendLine(message.Field).AppendLine();
                        }

                        foreach (var item in message.MessageCollection)
                        {
                            error.AppendFormat("\t{0}", item)
                                 .AppendLine();
                        }
                    }

                    UxTxbCoins.Text = error.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
