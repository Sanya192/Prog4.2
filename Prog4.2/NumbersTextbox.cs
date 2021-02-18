using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Prog4._2 {
    public class NumbersTextbox : TextBox {
        private static readonly Regex regex = new Regex("^[0-9,-]+$");

        /// <summary>
        /// If the text is other than what Regex is allows then the event won't proceed.
        /// </summary>
        /// <param name="e">The input arguments.</param>
        protected override void OnPreviewTextInput(TextCompositionEventArgs e) {
            if (!regex.IsMatch(e.Text))
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }
    }
}
