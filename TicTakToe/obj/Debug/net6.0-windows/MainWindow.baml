   M S B A M L   `   `   `  ????D  @TicTakToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTakToe	TicTakToe  5   	       TicTakToe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTakToe     5   	   -   5          ? Title$  	TikTakToe??5   	   $	??600??6   $	??800??6(    ? WindowStartupLocation$ CenterScreen=?5	   	      BackgroundColor#??[  5
   	     	FontColor#??[ 5   	   .??5      ?  ? ColumnDefinitions 5   
    ? RowDefinitions 5   
   .+?5   
   ?? $??Center=?6   $??67??61   $??0,0,0,0q?6=   $
??Wrap=?5      $??	TicTacToe??6(   $	??Top=?5      $	??160??6,   $??36(?68   ?? 5   
   -   5         ??Name$ 
GridBorder??5        
LinesColor#??[ 5      $??Center=?5      $??Center=?5      $??0,50,0,0q?5      $??2q?5       J? SnapsToDevicePixels$
 True??5        ?? EdgeMode$ Aliased=?5!      ._?5#      A? -   5         A?Name$ GameGrid??5#      $	??450??5$      $	??450??5%        
BoardColor#??[ 5&      $
 True??5'       ?? BitmapScalingMode$ HighQuality=?5(      5*      5,      ?? 5-   
   -   5        $??Reset??5-      $
??Left=?6!   $??23??6<   $??
56,244,0,0q?6H   $	??Top=?6\   $??56??6t   ???	#FF7542425.      53      54      