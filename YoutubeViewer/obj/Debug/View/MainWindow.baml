   M S B A M L   `   `   `  ����H  DYoutubeViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:YoutubeViewerYoutubeViewer  5   	       YoutubeViewer.MainWindow   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:YoutubeViewer     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $
��1280��5      $	��720��6'   ���	#FF292929  � WindowStartupLocation$  CenterScreen=�6K    � 
ResizeMode$ CanMinimize=�6p   .��5
      � -   5         �Name$ mainGrid��5
       � ColumnDefinitions 5   
   �� 5      �� 5      $	��960 �6    � RowDefinitions 5   
   �� 5      �� 5      $	��540 �6   �� 5      $��20 �6   .+�5   
   � $��2��6   $��0��6(   $��Center=�65   $��Center=�6P   .+�5      �� $6��0/YoutubeViewer;component/Assets/Youtube-icon.png��6   $��50��6N   $��50��6Y   $��0,0,10,0q�6e   �� 5      
������� �� CornerRadius$ 5��6(   $	��700��69   ._�5      �� $��
30 5 30 10q�6   .+�5      �� -   5         ��Name$ 	searchURL��5       %  !MaterialDesignFloatingHintTextBox#��[  61   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Insert URL��6l   5      5      �� 5      -   5         ��Name$ searchButton��5      $��54��6+   .��5      (� $��48��6   $��48��6%   .��5      �� $��24��6   $��24��6(   .+�5      F� 
������������`�� ��- � $� `�� ��.c �.c � $� p�� P#� �� @V� Ѐ� ��t� ��� ���� ��� � �8��!���! �8р�� ��� р�� �t� �Ѐ� @V� Ӱ� P#� p��  $� `��  $� ���- `�� ��.c �.c �`�� ��- ��.c �.c �`�� @KL ���j @KL @KL ��j @KL `�� �@KL  � ��j ��� `�� ��� � � ��� ���  � ��� `�� Ӏ�� ��j  � @KL `�� @KL 	6,   5       5!      5"      5#      �� 5$   
   $��1��6   $��0��6"   $	��720��62   .+�5%      �� $��35��6   	 �� Padding$	 5q�6!   ���	#FF673AB7._�5&      �� $��Center=�6   
�������.��6F   	History6O   5'      �� 5(      -   5        
 ��Name$
 playList��5(      
�������$	��685��6;   5*      5+      �� 5-   
   $��1��6   $��1��6%   .+�5.      �� 
���   �$��1q�6)   $
��1280��6=   $	��720��6J   
���   �._�5/      (  "System.Windows.Controls.WebBrowser  -   5          Name$ mainBrowser��5/      50      52      �� 54   
   $��2��6   $��2��6)   ���	#FF673AB766   56      57      