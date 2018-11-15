<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/B138492/Form1.cs) (VB: [Form1.vb](./VB/B138492/Form1.vb))
<!-- default file list end -->
# How to show context menu for the focused TreeList node using a shortcut


<p>The easiest way to properly handle shortcuts is to utilize the BarManager. Simply create a hidden BarButtonItem, and assign a shortcut to it. Within the BarButtonitem.ItemClick, obtain bounds of the focused node to calculate the location and show the PopupMenu.</p>

<br/>


