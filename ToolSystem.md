# Introduction #

Each tool in the `PdfOverlay` is coded in a separate class deriving `OverlayTool`. It interfaces to the `PdfOverlay` control through the `OverlayInterface` interface.
Mouse events the tool needs to handle are redirected to the tool object by `PdfOverlay`.
For more details, see the description in the source file.

# Recipe to write a new tool #

To add a new (Overlay-) tool to TikzEdt, the following steps have to be performed:
  1. Create a tool class deriving `OverlayTool`.
  1. Code what you want it to do.
  1. Add a member variable for the new tool to `PdfOverlay`.
  1. Add an item to the enum `PdfOverlay.ToolType`, and update the property getter of `PdfOverlay.CurrentTool`.
  1. Set (toolmembervariable).overlay in the constructor of `PdfOverlay`.