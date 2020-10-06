// ##########################################
// Solution: Outlook Mail Sorter
// Project: Outlook File Email
// File: ThisAddIn.cs
// 
// Last User: Chris Hildebran
// Last Edit: 2019-02-03 2:26 PM
// ##########################################

using Office = Microsoft.Office.Core;

namespace Outlook_File_Email
{
        using System;

        public partial class ThisAddIn
        {
                #region Methods

                /// <summary>
                ///         Required method for Designer support - do not modify
                ///         the contents of this method with the code editor.
                /// </summary>
                private void InternalStartup()
                {
                        Startup += new EventHandler(ThisAddIn_Startup);
                        Shutdown += new EventHandler(ThisAddIn_Shutdown);
                }




                private void ThisAddIn_Shutdown(object sender, EventArgs e)
                {
                        // Note: Outlook no longer raises this event. If you have code that 
                        //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
                }




                private void ThisAddIn_Startup(object sender, EventArgs e)
                {
                }

                #endregion
        }
}