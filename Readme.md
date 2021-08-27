<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638252/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1624)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/B138492/Form1.cs) (VB: [Form1.vb](./VB/B138492/Form1.vb))
<!-- default file list end -->
# How to show context menu for the focused TreeList node using a shortcut


<p>The easiest way to properly handle shortcuts is to utilize the BarManager. Simply create a hidden BarButtonItem, and assign a shortcut to it. Within the BarButtonitem.ItemClick, obtain bounds of the focused node to calculate the location and show the PopupMenu.</p>

<br/>


