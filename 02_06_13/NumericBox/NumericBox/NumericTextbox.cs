using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NumericBox
{
    class NumericTextbox : System.Windows.Forms.TextBox
    {

        private string _oldValue;


        

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            
            
            string newValue = this.Text;
            bool isOK = true;
            for (int i = 0; i < newValue.Length; i++)
            {
                switch (newValue[i])
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '0':
                        break;
                    default:
                        isOK = false;
                        break;
                }
            }

            if (isOK)
            {
                _oldValue = newValue;
            }
            else
            {
                this.Text = _oldValue;
                this.Select(_oldValue.Length, 0);
            }


        }


    }
}
