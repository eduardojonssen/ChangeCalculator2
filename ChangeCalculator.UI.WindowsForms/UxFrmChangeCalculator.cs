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

namespace ChangeCalculator.UI.WindowsForms {
    public partial class UxFrmChangeCalculator : Form {
        public UxFrmChangeCalculator() {

            InitializeComponent();
        }

        private void UxBtnCalculate_Click(object sender, EventArgs e) {
            try {
                IChangeCalculator calculatorChange = new ChangeCalculatorManager();

                long totalPaidAmountCents;
                long totalPaymentAmountCents;

                if (long.TryParse(UxTxtTotalPaid.Text, out totalPaidAmountCents) == false) {
                    throw new ApplicationException(string.Format("Total Paid is inválid"));
                }

                if (long.TryParse(UxTxtTotalPayment.Text, out totalPaymentAmountCents) == false) {
                    throw new ApplicationException(string.Format("Total Payment is inválid"));
                }

                BindingSource source = new BindingSource();
                CalculatorChangeRequest calculatorChangeRequest = new CalculatorChangeRequest() {
                    SalePrice = totalPaymentAmountCents,
                    ValuePayment = totalPaidAmountCents
                };

                CalculatorChangeResponse calculatorChangeResponse =
                    calculatorChange.Calculator(calculatorChangeRequest);

                UxTxtCoins.Text = string.Empty;
                UxTxtAmount.Text = string.Empty;

                if (calculatorChangeResponse.Success) {
                    IEnumerable<string> change =
                        calculatorChangeResponse
                                    .ChangeCollection
                                    .Select(x => string.Format("{0} - {1} - {2}", x.Value, x.Quantity, x.Type));

                    UxTxtCoins.Text = string.Join(Environment.NewLine, change);
                    UxTxtAmount.Text = calculatorChangeResponse.ChangeAmount.ToString();
                }
                else {
                    StringBuilder error = new StringBuilder();
                    foreach (Report item in calculatorChangeResponse.ReportCollection) {

                        error.AppendLine(item.Field).AppendLine();

                        error.AppendFormat("\t{0}", item.Message)
                                 .AppendLine();
                    }

                    UxTxtCoins.Text = error.ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
