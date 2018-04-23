# How to show context menu for the focused TreeList node using a shortcut


<p>The easiest way to properly handle shortcuts is to utilize the BarManager. Simply create a hidden BarButtonItem, and assign a shortcut to it. Within the BarButtonitem.ItemClick, obtain bounds of the focused node to calculate the location and show the PopupMenu.</p>

<br/>


