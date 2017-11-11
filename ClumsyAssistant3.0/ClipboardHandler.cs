using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClumsyAssistant3._0
{
    class ClipboardHandler
    {
        public String SwapClipboardHText(String replacementText = null)
        {
            String clipBoardMsg;

            if (replacementText != null)
            {
                Clipboard.SetText(replacementText);
                return replacementText;
            }

            clipBoardMsg = Clipboard.GetText();
            return clipBoardMsg;
        }

    }
}