   M S B A M L   `   `   `  ����L  HDataGatheringTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DataGatheringToolDataGatheringTool  5   	   $    DataGatheringTool.GatheredData   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DataGatheringTool     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ GatheredData��5	   	   $	��290��6   $	��520��6+   .��5
      � $��5q�6   .+�5   
   �� -   5         ��Name$	 URL��5      $��Center=�6!   $	��Top=�6>   $��20��6V   $	��280��6b   $��0,0,0,0q�6n    �� TextAlignment$ Center=�6   $	��URL��6�   �� 5   
   $��
0,-205,0,0q�6   �� 5   
   -   5        $ 	UnderText��5      $	��245��6'   $
��Left=�63   $ Center=�6N   $��0,20,0,0q�6e   Under6~   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Under��5         AutoGenerateColumns$ False��6:   $	��245��6V   $
��Left=�6b   $	��180��6}   $��	0,025,0,0q�6�   ��6"   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        UnderID��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 5   6      Header$ ID��6A   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6M   �� *id+  5      -   5        	UnderName��$	 125 5   8   $
 Name��6D   	 6R   �� *name+  5      -   5        UnderAge��$ 35 5   7   $	 Age��6B   	 6O   �� *age+  5      -   5        	UnderTemp��$
 Auto 5   8   
   CanUserResize$
 False��6E   $
 Temp��6[   	 6i   �� *temperature+5      �� 5   
   -   5        $ OverText��5      $	��245��6&   $��Right=�62   $ Center=�6N   $��0,20,0,0q�6e   Over6}     5   
   -	   5        $
 Over��5      $ False��69   $	��245��6U   $��Right=�6a   $	��180��6}   $��0,25,0,0q�6�   ��6!   ��  5        5      -
   5        
OverID��$ 40 5   5   $ ID��6@   	 6L   �� *id+  5      -   5        OverName��$	 125 5   7   $
 Name��6C   	 6Q   �� *name+  5      -   5        OverAge��$ 35 5   6   $	 Age��6A   	 6N   �� *age+  5      -   5        OverTemp��$
 Auto 5   7   $
 False��6D   $
 Temp��6Z   	 6h   �� *temperature+5      �� 5!   
   -   5         ��Name$ FileName��5!      $
��Left=�6$   $��Bottom=�6?   $	��400��6Z   $��20��6f   6t   �� 5"   
   -   5         ��Name$ 
SaveButton��5"      $��Right=�66   $��Bottom=�6R   $	��100��6m   $��20��6y   .��6�   Save6�   5$      5&      