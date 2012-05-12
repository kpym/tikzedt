/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;
using TikzEdt.Overlay;
using System.Windows.Forms;

namespace TikzEdt
{

    public enum OverlayToolType { move, addvert, addedge, addpath, smooth, bezier, rectangle, ellipse, grid, arc, arcedit } 

    /// <summary>
    /// This is the abstract base class of tools for the PdfOverlay.
    /// 
    /// A tool essentially has the following responsibilities:
    ///     1. Call overlay.BeginUpdate() and EndUpdate() before and after editing the Parsetree.
    ///     2. Not edit the parsetree when overlay.Allowediting false.
    ///     3. Clean up when deselected!
    ///     
    /// </summary>
    public class OverlayTool
    {       

        /// <summary>
        /// Access to the PdfOverlay. It will be set in the constructor.
        /// </summary>
        protected IOverlayInterface overlay;
        public OverlayTool(IOverlayInterface overlay)
        {
            this.overlay = overlay;
        }

        /// <summary>
        /// This method is called when the tool is selected by the user.
        /// For example, the cursor shape should be set here.
        /// </summary>
        public virtual void OnActivate() { }
        /// <summary>
        /// This is called when the tool is deselected.
        /// Todo: Clean up after yourself!
        /// </summary>
        public virtual void OnDeactivate() { }

        /// <summary>
        /// This is called by the overlay when the tool should update the raster, (usually because the UsePolar... setting has changed) 
        /// </summary>
        public virtual void UpdateRaster() { }        

        /// <summary>
        /// This method is called when the tool is active and the appropriate mouse event occurs.
        /// 
        /// </summary>
        /// <param name="item">The item at cursor position.</param>
        /// <param name="p">The cursor position, in BOTTOM LEFT CENTERED pixel coordinates.</param>
        /// <param name="e"></param>
        public virtual void OnLeftMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e) { }
        /// <summary>
        /// LeftMouseButtonUp event, forwarded from the overlay control.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        public virtual void OnLeftMouseButtonUp(Point p, TEMouseArgs e) { }
        /// <summary>
        /// Set e.Handled if you want to turn off the default handling... like opening the context menu etc.
        /// </summary>
        /// <param name="item">The item on which the event occurred.</param>   
        /// <param name="p">The cursor position, in BOTTOM LEFT CENTERED pixel coordinates.</param>
        ///        
        public virtual void OnRightMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e) { }
        /// <summary>
        /// "Raw" MouseButtonUp event, forwarded from the overlay control.
        /// </summary>
        public virtual void OnRightMouseButtonUp() { }
        /// <summary>
        /// MouseMove event, forwarded from the overlay control.
        /// </summary>
        /// <param name="p"></param>
        /// 
        public virtual void OnMouseMove(Point p, TEMouseArgs e) { }

        /// <summary>
        /// KeyDown event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyDown(TEKeyArgs e) { }
        /// <summary>
        /// KeyUp event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyUp(TEKeyArgs e) { }

    }

    public class TEMouseArgs
    {
        public bool LeftButtonPressed, RightButtonPressed, MiddleButtonPressed;
        public int ClickCount;
        public bool Handled = false;
    }

    public class TEKeyArgs
    {
        public bool Handled = false;
        public Keys KeyCode;
    }

    [Flags]
    public enum TEModifierKeys
    {
        None = 0x0,
        Shift = 0x1,
        Control = 0x2,
        Alt = 0x4,
    }

 

  



}
