   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	   D @ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:ViewModel;assembly=ViewModel	ViewModel 5   	       View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:View     5   	   :vms*clr-namespace:ViewModel;assembly=ViewModel     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Title$  
MainWindow��5	   	   $	��500��6   $
��1000��6)      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � DataContext 5        ViewModel.BookViewModel  5   
   6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��5* �6   6,   .+�5   
   �� -   5        $��stpInput��5      $��20,20,20,10q�6%   .+�5      �� $
��Bold"�6   ID:6/   �� 5      -   5        $��txtID��5      {�.  ��65   �� *SelectedItem.id+ �� ElementName$ lvBook�� �� Mode$ OneWay=�6y   �� 5!      $
��Bold"�6   Name:61   �� 5"      -   5        $��txtName��5"      ��6%   �� *SelectedItem.name+$ lvBook��$ OneWay=�6k   �� 5$      $
��Bold"�6   	Category:65   �� 5%      -   5        $��txtCategory��5%      ��6)   �� *SelectedItem.category+$ lvBook��$ OneWay=�6s   �� 5'      $
��Bold"�6   	Amount:63   �� 5(      -   5        $��	txtAmount��5(      ��6'   �� *SelectedItem.amount+$ lvBook��$ OneWay=�6o   �� 5*      $
��Bold"�6   Price:62   �� 5+      -   5        $��txtPrice��5+      ��6&   �� *SelectedItem.price+$ lvBook��$ OneWay=�6m   �� 5-      $
��Bold"�6   Size:61   �� 5.      -   5        $��txtSize��5.      ��6%   �� *SelectedItem.size+$ lvBook��$ OneWay=�6k   �� 50      $
��Bold"�6   	Author:63   �� 51      -   5        $��	txtAuthor��51      ��6'   �� *SelectedItem.author+$ lvBook��$ OneWay=�6o   �� 53      $
��Bold"�6   Publication Date:6=   �� 54      -	   5        $��txtPublicationDate��54      ��60   �� *SelectedItem.publicationdate+$ lvBook��$ OneWay=�6�   �� 56      $
��Bold"�6   Publishing Company:6?   �� 57      -
   5        $��txtPublishCompany��57      ��6/   �� *SelectedItem.publishcompany+$ lvBook��$ OneWay=�6   �� 59       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5:      ��   MaterialDesignRaisedButton#��[ 5;      $��70��5<      $��
0,10,10,10q�6(   ��5=      �� *
AddCommand+��5>      �� *
Children+$ stpInput��.��6Y   ADD5@      �� 5A      #��[ 5B      $	��100��5C      $��
0,10,10,10q�6)   ��5D      �� *DeleteCommand+��5E      �� *SelectedItem+$ lvBook��.��6[   DELETE5G      �� 5H      #��[ 5I      $	��100��5J      $��
0,10,10,10q�6)   ��5K      �� *UpdateCommand+��5L      �� *
Children+$ stpInput��.��6Y   UPDATE5N      5O      5Q      � 5T   
   $��1��6   .+�5U      �� .��5V      �� -   5        $��lvBook��5W      ��5X      �� *
listBook+ �� View 5Y      �� 5Z      .P�5[      �� $��#��5]      	 �� DisplayMemberBinding	 5\      �� *id+5]      �� 5^      $
��Name��5`      	 5_      �� *name+5`      �� 5a      $��Category��5c      	 5b      �� *
category+5c      �� 5d      $��Amount��5f      	 5e      �� *amount+5f      �� 5g      $��Price��5i      	 5h      �� *price+5i      �� 5j      $
��Size��5l      	 5k      �� *size+5l      �� 5m      $��Author��5o      	 5n      �� *author+5o      �� 5p      $��Publication Date��5r      	 5q      �� *publicationdate+5r      �� 5s      $��Publish Company��5u      	 5t      �� *publishcompany+5u      5w      5y      5z      5{      5|      5}      