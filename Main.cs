/*************************************************************************/
/*                               Main.cs                                 */
/*************************************************************************/
/*                       This file is part of:                           */
/*                           EmptyRecycleBin                             */
/*                      https://godotengine.org                          */
/*************************************************************************/
/*                                                                       */
/*              Copyright (c) 2021-2022 Andrew Poženel                   */
/*                                                                       */
/* Permission is hereby granted, free of charge, to any person obtaining */
/* a copy of this software and associated documentation files (the       */
/* "Software"), to deal in the Software without restriction, including   */
/* without limitation the rights to use, copy, modify, merge, publish,   */
/* distribute, sublicense, and/or sell copies of the Software, and to    */
/* permit persons to whom the Software is furnished to do so, subject to */
/* the following conditions:                                             */
/*                                                                       */
/* The above copyright notice and this permission notice shall be        */
/* included in all copies or substantial portions of the Software.       */
/*                                                                       */
/* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,       */
/* EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF    */
/* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.*/
/* IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY  */
/* CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,  */
/* TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE     */
/* SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                */
/*************************************************************************/

// Andrew Poženel AKA SloDevTeam

using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Net;

namespace EmptyRecycleBin {
  public partial class MAIN: Form

  {

    enum RecycleFlags: int {
      SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
        SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
        SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
    }

    [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
    static extern uint SHEmptyRecycleBin(IntPtr hwnd, string ? pszRootPath, RecycleFlags dwFlags);

    public MAIN() {
      InitializeComponent();
    }

    private void DoExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void DoEmpty_Click(object sender, EventArgs e) {

      DialogResult result;
      result = MessageBox.Show("Are you sure you want to delete all the items in recycle bin", "Clear recycle bin", MessageBoxButtons.YesNo);

      // If accepted, continue with the cleaning
      if (result == DialogResult.Yes) {
        try {
          // Execute the method with the required parameters
          uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
          MessageBox.Show("The recycle bin has been succesfully emptied !", "Empty recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
          // Handle exceptions
          MessageBox.Show("The recycle bin couldn't be emptied" + ex.Message, "Empty recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

      }

    }

    private void MAIN_Load(object sender, EventArgs e) {

    }

    private void LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

      try {
        VisitLink();
      } catch (Exception ex) {
        MessageBox.Show("Unable to open link that was clicked!");
      }

    }

    private void VisitLink() {

      System.Diagnostics.Process.Start("https://slo-dev-team.000webhostapp.com/");
      LINK.LinkVisited = true;

      //ProcessStartInfo sInfo = new ProcessStartInfo("https://slo-dev-team.000webhostapp.com/");
      //Process.Start(sInfo);
    }

  }
}