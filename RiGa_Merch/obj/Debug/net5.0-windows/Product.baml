   M S B A M L   `   `   `  ????E  ARiGa_Merch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RiGa_Merch
RiGa_Merch  5   	       RiGa_Merch.Product   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RiGa_Merch     5   	     ? Title$3  -Rhino Games Merchandise System v1.0 - Product??5   	   $	??616??6?   $	??946??6L    ? 
ResizeMode$ NoResize=?6X    ? WindowStartupLocation$ CenterScreen=?6n    ? Icon$ /RiGa_Icon.png??5	   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??75 ?6   ?? 5      $	??450 ?6   ?? 5      $??75 ?6   .+?5   
   ? $??1??6    ? ColumnDefinitions 5      ?? 5      ?? 5      $	??100 ?6#   .+?5      ?? $??5,5,10,5q?6   
???   ?$	??1.5q?6;   ._?5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
ProductTBL??5   O   $??10q?6   
???   ?$??1q?6;   6c   5      ? 5      $??1??6    5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5       ?? -   5         ??Name$ 
AddItemBTN??5    B   ???#33415c
???????$??15q?6V   $??Add Item??6b   6u   ?? 5!      -   5        $ 	UpdateBTN??5!   B   ???#33415c
???????$??1??6U   $??15q?6b   $??Update??6n   6   ?? 5"      -   5        $ 	DeleteBTN??5"   B   ???#33415c
???????$??2??6U   $??15q?6b   $??Delete??6n   6   ?? 5#      -   5        $ 
RealoadBTN??5#   B   ???#33415c
???????$??Reload??6V   $??15q?6g   $??3??6s   6?   5$      5%      ? 5&   
   $??0??6    5'      ?? 5(      $	??100 ?6#   ?? 5)      $	??100 ?6#   ?? 5*      $	??100 ?6#   ?? 5+      $	??100 ?6#   ?? 5,      $	??416 ?6#   ?? 5-      $	??130 ?6#   .+?51      ?? -   5        $ 
ProductBTN??51   E   $??0??6   $??5q?6%   ???#0466C8$??Product??6Y   
???????6~   ?? 52      -   5        $ OrderBTN??52   E   $??1??6   $??5q?6%   ???#0353A4$??Orders??6W   
???????6{   ?? 53      -   5        $ CustomerBTN??53   E   $??2??6   $??5q?6%   ???#023E7D$??Customer??6Z   
???????6?   ?? 54      -	   5        $ CategoryBTN??54   E   $??3??6   $??5q?6%   ???#002855$??Category??6Z   
???????6?   ?? 55      $??/Merch_Logo.png??6   $??6??6-   58      ?? 5:   
   ???#0466C8$??1q?6&   $??Center=?6:   $??Center=?6U   $	??700??6r   
???   ?$??66??6?   $??2??6?   $??20q?6?   ._?5;      ?? $??Products??6   $??Center=?6(   $??Center=?6C   $
??20pt(?6`   
???????6p   5<      5>      5?      